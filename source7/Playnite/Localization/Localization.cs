using Linguini.Bundle;
using Linguini.Bundle.Builder;
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

    public static string GetString(string id, params (string name, object value)[] args)
    {
        var newArgs = new Dictionary<string, IFluentType>();
        foreach (var (name, value) in args)
        {
            if (value is int intValue)
            {
                newArgs.Add(name, (FluentNumber)intValue);
            }
            else if (value is uint uintValue)
            {
                newArgs.Add(name, (FluentNumber)uintValue);
            }
            else if (value is long longValue)
            {
                newArgs.Add(name, (FluentNumber)longValue);
            }
            else if (value is ulong ulongValue)
            {
                newArgs.Add(name, (FluentNumber)ulongValue);
            }
            else if (value is float floatValue)
            {
                newArgs.Add(name, (FluentNumber)floatValue);
            }
            else if (value is double doubleValue)
            {
                newArgs.Add(name, (FluentNumber)doubleValue);
            }
            else if (value is string strValue)
            {
                newArgs.Add(name, (FluentString)strValue);
            }
            else
            {
                newArgs.Add(name, (FluentString)(value.ToString() ?? "uknown"));
            }
        }

        if (fluentBundle?.TryGetMessage(id, newArgs, out _, out var message) == true)
        {
            return message ?? id;
        }

        return id;
    }

    public static bool IsStringId(string id)
    {
        return LocId.StringIds.Contains(id);
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
        var langs = new List<PlayniteLanguage>();
        var coverage = new Dictionary<string, int>();
        if (File.Exists(PlaynitePaths.LocalizationsStatusFile))
        {
            coverage = Serialization.FromJsonFile<Dictionary<string, int>>(PlaynitePaths.LocalizationsStatusFile) ?? coverage;
            coverage.Add("en", 100);
        }

        foreach (var lngFile in Directory.GetFiles(PlaynitePaths.LocalizationsDir, "*.ftl"))
        {
            var fileCode = Path.GetFileNameWithoutExtension(lngFile);
            if (!coverage.TryGetValue(fileCode.Replace('_', '-'), out var lngCov))
            {
                coverage.TryGetValue(fileCode.Split('_')[0], out lngCov);
            }

            string? localeString = null;
            try
            {
                foreach (var line in File.ReadLines(lngFile, Encoding.UTF8))
                {
                    if (line.StartsWith("language-name", StringComparison.Ordinal))
                    {
                        localeString = line[(line.LastIndexOf('=') + 1)..].Trim();
                        break;
                    }
                }
            }
            catch (Exception e) when (!AppConfig.ThrowAllErrors)
            {
                logger.Error(e, $"Failed to parse localization file {lngFile}");
                continue;
            }

            langs.Add(new PlayniteLanguage(localeString ?? fileCode, fileCode, lngCov));
        }

        langs.Sort((x, y) => string.Compare(x.LocaleString, y.LocaleString, StringComparison.InvariantCulture));
        return langs;
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
