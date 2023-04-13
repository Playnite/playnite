using System.IO;

namespace Playnite;

public class Theme
{
    public ThemeManifest Manifest { get; }
    public bool IsBuiltInTheme { get; }
    public bool IsCustomTheme => !IsBuiltInTheme;
    public bool IsCompatible { get; }
    public string DirectoryPath { get; }
    public string DirectoryName { get; }
    public string Path { get; }

    public Theme(string manifestPath)
    {
        Manifest = Serialization.FromYaml<ThemeManifest>(File.ReadAllText(manifestPath));
        if (Manifest.Id.IsNullOrWhiteSpace())
        {
            throw new Exception("Addon ID is missing.");
        }

        if (Manifest.Name.IsNullOrWhiteSpace())
        {
            throw new Exception("Addon name is missing.");
        }

        if (Manifest.Version.IsNullOrWhiteSpace())
        {
            throw new Exception("Addon version is missing.");
        }

        if (Manifest.ThemeApiVersion.IsNullOrWhiteSpace())
        {
            throw new Exception("Addon ThemeApiVersion is missing.");
        }

        Path = manifestPath;
        DirectoryPath = System.IO.Path.GetDirectoryName(manifestPath)!;
        DirectoryName = System.IO.Path.GetFileName(DirectoryPath)!;
        IsBuiltInTheme = Addons.BuiltinThemeIds.Contains(Manifest.Id);
        var apiVesion = Manifest.Mode == ApplicationMode.Desktop ? Themes.DesktopApiVersion : Themes.FullscreenApiVersion;
        var themeVersion = new Version(Manifest.ThemeApiVersion);
        if (themeVersion.Major == apiVesion.Major && themeVersion <= apiVesion)
        {
            IsCompatible = true;
        }
    }

    public override string? ToString()
    {
        return Manifest.Name ?? Path;
    }
}

public class Themes
{
    private static readonly ILogger logger = LogManager.GetLogger();

    public const string DefaultDesktopThemeId = "Playnite_builtin_DefaultDesktop";
    public const string DefaultFullscreenThemeId = "Playnite_builtin_DefaultFullscreen";
    public const string DefaultThemeDirName = "Default";
    public static readonly Version DesktopApiVersion = new("2.5.0");
    public static readonly Version FullscreenApiVersion = new("2.5.0");

    public static Theme? CurrentTheme { get; private set; }
    public static Theme? DefaultTheme { get; private set; }

    public static Version GetApiVersion(ApplicationMode mode)
    {
        return mode == ApplicationMode.Desktop ? DesktopApiVersion : FullscreenApiVersion;
    }

    public static string GetThemeRootDirName(ApplicationMode mode)
    {
        return mode == ApplicationMode.Desktop ? "Desktop" : "Fullscreen";
    }

    public static void SetDefaultTheme(Theme theme)
    {
        DefaultTheme = theme;
    }

    public static List<Theme> GetAvailableThemes(ApplicationMode mode)
    {
        var modeDir = GetThemeRootDirName(mode);
        var themes = new List<Theme>();

        var userPath = Path.Combine(PlaynitePaths.ThemesUserDataDir, modeDir);
        if (!PlaynitePaths.IsPortable && Directory.Exists(userPath))
        {
            foreach (var dir in Directory.GetDirectories(userPath))
            {
                try
                {
                    var descriptorPath = Path.Combine(dir, PlaynitePaths.ThemeManifestFileName);
                    if (File.Exists(descriptorPath))
                    {
                        themes.Add(new Theme(descriptorPath));
                    }
                }
                catch (Exception e) when (!AppConfig.ThrowAllErrors)
                {
                    logger.Error(e, $"Failed to read theme data {dir}");
                }
            }
        }

        var programPath = Path.Combine(PlaynitePaths.ThemesProgramDir, modeDir);
        if (Directory.Exists(programPath))
        {
            foreach (var dir in Directory.GetDirectories(programPath))
            {
                try
                {
                    var descriptorPath = Path.Combine(dir, PlaynitePaths.ThemeManifestFileName);
                    if (File.Exists(descriptorPath))
                    {
                        var theme = new Theme(descriptorPath);
                        if (!themes.Any(a => a.Manifest.Id == theme.Manifest.Id))
                        {
                            themes.Add(theme);
                        }
                    }
                }
                catch (Exception e) when (!AppConfig.ThrowAllErrors)
                {
                    logger.Error(e, $"Failed to read theme data {dir}");
                }
            }
        }

        return themes;
    }
}