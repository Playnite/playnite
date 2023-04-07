using Linguini.Bundle;
using Linguini.Bundle.Builder;
using Linguini.Bundle.Errors;
using Linguini.Shared.Types.Bundle;
using System.Globalization;
using System.IO;

namespace Playnite;

public class PlayniteLanguage
{
    public int TranslatedPercentage { get; set; } = -1;
    public string LocaleString { get; set; }
    public string Id { get; set; }
    public string DisplayString { get => ToString(); }

    public PlayniteLanguage(string localeString, string id, int translated)
    {
        LocaleString = localeString;
        Id = id;
        TranslatedPercentage = translated;
    }

    public override string ToString()
    {
        if (TranslatedPercentage == -1 || TranslatedPercentage == 100)
        {
            return LocaleString;
        }
        else
        {
            return $"{LocaleString}   ({Id}, {TranslatedPercentage}%)";
        }
    }
}

public static partial class Loc
{
    private static FluentBundle? fluentBundle;

    internal static void SetFtlBundle(FluentBundle bundle)
    {
        fluentBundle = bundle;
    }

    public static string GetString(string id)
    {
        if (fluentBundle?.TryGetMessage(id, null, out _, out var message) == true)
        {
            return message ?? id;
        }

        return id;
    }

    public static string GetString(string id, params (string name, IFluentType value)[] args)
    {
        var newArgs = new Dictionary<string, IFluentType>();
        foreach (var (name, value) in args)
        {
            newArgs.Add(name, value);
        }

        if (fluentBundle?.TryGetMessage(id, newArgs, out _, out var message) == true)
        {
            return message ?? id;
        }

        return id;
    }

    public static bool IsStringId(string id)
    {
        return stringIds.Contains(id);
    }

    public static FluentString ToFluentString(this string source)
    {
        return (FluentString)source;
    }

    public static FluentNumber ToFluentNumber(this int source)
    {
        return (FluentNumber)source;
    }

    public static FluentNumber ToFluentNumber(this uint source)
    {
        return (FluentNumber)source;
    }

    public static FluentNumber ToFluentNumber(this long source)
    {
        return (FluentNumber)source;
    }

    public static FluentNumber ToFluentNumber(this ulong source)
    {
        return (FluentNumber)source;
    }

    public static FluentNumber ToFluentNumber(this float source)
    {
        return (FluentNumber)source;
    }

    public static FluentNumber ToFluentNumber(this double source)
    {
        return (FluentNumber)source;
    }
}

public static class Localization
{
    private static readonly ILogger logger = LogManager.GetLogger();
    public const string DefaultLanguageId = "en_US";

    public static string? CurrentLanguage { get; private set; }
    public static CultureInfo ApplicationLanguageCultureInfo { get; private set; } = CultureInfo.CurrentCulture;
    public static bool IsRightToLeft { get => ApplicationLanguageCultureInfo.TextInfo.IsRightToLeft; }

    public static List<PlayniteLanguage> GetLanguageList()
    {
        var coverage = Serialization.FromJsonFile<Dictionary<string, int>>(PlaynitePaths.LocalizationsStatusFile);
        var langs = new List<PlayniteLanguage> { new PlayniteLanguage("English", DefaultLanguageId, 100) };

        if (!Directory.Exists(PlaynitePaths.LocalizationsDir))
        {
            return langs;
        }

        throw new NotImplementedException();

        //foreach (var file in Directory.GetFiles(PlaynitePaths.LocalizationsDir, "*.ftl"))
        //{
        //    if (!Regex.IsMatch(file, "[a-zA-Z]+_[a-zA-Z]+"))
        //    {
        //        continue;
        //    }

        //    var fileCode = Path.GetFileNameWithoutExtension(file);
        //    if (!coverage.TryGetValue(fileCode.Replace('_', '-'), out var lngCov))
        //    {
        //        coverage.TryGetValue(fileCode.Split('_')[0], out lngCov);
        //    }

        //    var langPath = Path.Combine(path, file);
        //    var localeString = "";
        //    try
        //    {
        //        foreach (var line in File.ReadLines(langPath, Encoding.UTF8))
        //        {
        //            var match = Regex.Match(line, @"LanguageName""\>(.+)\<");
        //            if (match.Success)
        //            {
        //                localeString = match.Groups[1].Value;
        //                break;
        //            }
        //        }
        //    }
        //    catch (Exception e) when (!PlayniteEnvironment.ThrowAllErrors)
        //    {
        //        logger.Error(e, $"Failed to parse localization file {file}");
        //        continue;
        //    }

        //    langs.Add(new PlayniteLanguage()
        //    {
        //        Id = Path.GetFileNameWithoutExtension(langPath),
        //        LocaleString = localeString,
        //        TranslatedPercentage = lngCov
        //    });
        //}

        //return langs.OrderBy(a => a.LocaleString).ToList();
    }

    public static void SetLanguage(string languageId, bool fallbackToDefault)
    {
        if (CurrentLanguage == languageId)
        {
            return;
        }

        logger.Info($"Loading language {languageId}.");
        try
        {
            var langFile = Path.Combine(PlaynitePaths.LocalizationsDir, languageId + ".ftl");
            if (!File.Exists(langFile))
            {
                throw new Exception($"Can't set language, language file missing.");
            }

            var cultInfo = new CultureInfo(languageId.Replace('_', '-'), false);
            (var bundle, var errors) = LinguiniBuilder.Builder().
                CultureInfo(cultInfo).
                AddResource(File.ReadAllText(langFile)).
                Build();

            if (errors.HasItems())
            {
                logger.Error("Error during ftl language file load:");
                errors.ForEach(a =>
                {
                    logger.Error(a.ToString());
                    logger.Error(a.GetSpan()?.ToString() ?? string.Empty);
                });

                throw new Exception($"Can't set language, ftl file has errors.");
            }

            Loc.SetFtlBundle(bundle);
            ApplicationLanguageCultureInfo = cultInfo;
            CurrentLanguage = languageId;
        }
        catch (Exception e) when (!AppConfig.ThrowAllErrors)
        {
            if (fallbackToDefault)
            {
                logger.Error(e, $"Failed to set language.");
                SetLanguage(DefaultLanguageId, false);
            }
        }
    }
}
