namespace Playnite;

public enum AddonLoadError
{
    None,
    Uknown,
    SDKVersion
}

public class Addons
{
    public static readonly string[] BuiltinExtensionIds = new string[]
    {
        "AmazonLibrary_Builtin",
        "BattlenetLibrary_Builtin",
        "EpicGamesLibrary_Builtin",
        "GogLibrary_Builtin",
        "HumbleLibrary_Builtin",
        "IGDBMetadata_Builtin",
        "ItchioLibrary_Builtin",
        "OriginLibrary_Builtin",
        "SteamLibrary_Builtin",
        "UplayLibrary_Builtin",
        "XboxLibrary_Builtin"
    };

    public static readonly string[] BuiltinThemeIds = new string[]
    {
        "Playnite_builtin_DefaultFullscreen",
        "Playnite_builtin_DefaultDesktop",
    };
}

public class ThemeManifest
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Author { get; set; }
    public string? Version { get; set; }
    public List<Link>? Links { get; set; }
    public string? ThemeApiVersion { get; set; }
    public ApplicationMode Mode { get; set; }

    public override string? ToString()
    {
        return Name ?? base.ToString();
    }
}