using Linguini.Bundle.Builder;
using Linguini.Bundle.Resolver;
using Linguini.Shared.Types.Bundle;
using Linguini.Syntax.Ast;
using Linguini.Syntax.Parser;
using System.Text;

namespace FtlGenerator;

internal class Program
{
    static void Main(string[] args)
    {
        // We can't do this via source generators because for some stupid reason
        // they can only target netstandard 2.0 and not 2.1, which mean that we can't
        // use Linguini properly (targets 2.1 so VS fallsback to Framework version)
        // and then VS completely freaks out and starts throwing ton of warning in the IDE
        // related to CShrap analyzers, it fucks up everything :|

        string ftlPath = @"c:\Devel\Playnite\source7\Playnite\Localization\en_US.ftl";

        var parser = new LinguiniParser(File.ReadAllText(ftlPath));
        var ress = parser.Parse();

        // process errors

        var strings = new Dictionary<string, HashSet<string>>();

        foreach (var entry in ress.Entries)
        {
            if (entry is AstMessage message)
            {
                var vars = new HashSet<string>();
                void parsePattern(Pattern pattern)
                {
                    foreach (var element in pattern.Elements)
                    {
                        if (element is Placeable placeable)
                        {
                            if (placeable.Expression is VariableReference varRef)
                            {
                                vars.Add(varRef.Id.Name.ToString());
                            }
                            else if (placeable.Expression is SelectExpression selExp && selExp.Selector is VariableReference varRefExp)
                            {
                                vars.Add(varRefExp.Id.Name.ToString());
                                foreach (var variant in selExp.Variants)
                                {
                                    parsePattern(variant.Value);
                                }
                            }
                            else if (placeable.Expression is Pattern patternRef)
                            {
                                parsePattern(patternRef);
                            }
                            else if (placeable.Expression is Variant variant)
                            {
                                parsePattern(variant.Value);
                            }
                        }
                    }
                }

                parsePattern(message.Value!);
                strings.Add(message.Id.Name.ToString(), vars);
            }
        }

        var sb = new StringBuilder();
        sb.AppendLine($$"""
            using Linguini.Shared.Types.Bundle;
            namespace Playnite;

            public static partial class Loc
            {
                private static readonly HashSet<string> stringIds = new()
                {
                    {{string.Join(", \r\n        ", strings.Keys.Select(a => $"\"{a}\""))}}
                };
            """);

        sb.AppendLine();
        foreach (var str in strings.Keys)
        {
            sb.AppendLine($"    public const string {str.Replace('-', '_')}_id = \"{str}\";");
        }

        sb.AppendLine();
        foreach (var str in strings.Keys)
        {
            var vars = strings[str];
            if (vars?.Any() == true)
            {
                sb.AppendLine($$"""
                        public static string {{str.Replace('-', '_')}}({{string.Join(", ", vars.Select(a => $"object {a.Replace('-', '_')}"))}})
                        {
                            return GetString("{{str}}", {{string.Join(", ", vars.Select(a => $"(\"{a}\", {a.Replace('-', '_')})"))}});
                        }
                    """);
            }
            else
            {
                sb.AppendLine($$"""
                        public static string {{str.Replace('-', '_')}}()
                        {
                            return GetString("{{str}}");
                        }
                    """);
            }
        }

        sb.AppendLine("}");
        File.WriteAllText(@"c:\Devel\Playnite\source7\Playnite\Localization\Localization.generated.cs", sb.ToString());
    }
}