using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.Text.Json.Serialization;
using System.Windows.Controls;

namespace Playnite;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class RequiresRestartAttribute : Attribute
{
}

public partial class DetailsVisibilitySettings : ObservableObject
{
    [ObservableProperty] private bool library = true;
    [ObservableProperty] private bool playTime = true;
    [ObservableProperty] private bool installSize = true;
    [ObservableProperty] private bool installDirectory = true;
    [ObservableProperty] private bool lastPlayed = false;
    [ObservableProperty] private bool added = false;
    [ObservableProperty] private bool recentActivity = true;
    [ObservableProperty] private bool completionStatus = false;
    [ObservableProperty] private bool icon = false;
    [ObservableProperty] private bool coverImage = true;
    [ObservableProperty] private bool backgroundImage = true;
    [ObservableProperty] private bool platform = true;
    [ObservableProperty] private bool genres = true;
    [ObservableProperty] private bool developers = true;
    [ObservableProperty] private bool publishers = true;
    [ObservableProperty] private bool releaseDate = true;
    [ObservableProperty] private bool categories = true;
    [ObservableProperty] private bool tags = true;
    [ObservableProperty] private bool links = true;
    [ObservableProperty] private bool description = true;
    [ObservableProperty] private bool ageRating = false;
    [ObservableProperty] private bool series = false;
    [ObservableProperty] private bool source = false;
    [ObservableProperty] private bool region = false;
    [ObservableProperty] private bool version = false;
    [ObservableProperty] private bool communityScore = false;
    [ObservableProperty] private bool criticScore = false;
    [ObservableProperty] private bool userScore = false;
    [ObservableProperty] private bool features = true;
    [ObservableProperty] private bool notes = true;
    [ObservableProperty] private bool name = true;
}

public class WindowPosition
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    public Point? Position { get; set; }
    public Point? Size { get; set; }
    public System.Windows.WindowState State { get; set; } = System.Windows.WindowState.Normal;
}

public partial class SearchWindowVisibilitySettings : ObservableObject
{
    [ObservableProperty] private bool gameIcon = true;
    [ObservableProperty] private bool libraryIcon = true;
    [ObservableProperty] private bool hiddenStatus = true;
    [ObservableProperty] private bool platform = true;
    [ObservableProperty] private bool playTime = true;
    [ObservableProperty] private bool completionStatus = true;
    [ObservableProperty] private bool releaseDate = false;
}

public partial class AutoClientShutdownSettings : ObservableObject
{
    [ObservableProperty] private uint graceTimeout = 60;
    [ObservableProperty] private uint minimalSessionTime = 120;
    [ObservableProperty] private bool shutdownClients = false;
    [ObservableProperty] private List<Guid> shutdownPlugins = new ();
}

public partial class DateFormattingOptions : ObservableObject
{
    [ObservableProperty] private string? format;
    [ObservableProperty] private bool pastWeekRelativeFormat;

    public DateFormattingOptions()
    {
    }

    public DateFormattingOptions(string format, bool pastWeekRelativeFormat)
    {
        Format = format;
        PastWeekRelativeFormat = pastWeekRelativeFormat;
    }
}

public partial class ReleaseDateFormattingOptions : DateFormattingOptions
{
    [ObservableProperty] private string? partialFormat = DateTimes.DefaultPartialReleaseDateTimeFormat;

    public ReleaseDateFormattingOptions() : base()
    {
    }

    public ReleaseDateFormattingOptions(string format, bool pastWeekRelativeFormat) : base(format, pastWeekRelativeFormat)
    {
    }

    public ReleaseDateFormattingOptions(string format, bool pastWeekRelativeFormat, string partialFormat) : base(format, pastWeekRelativeFormat)
    {
        PartialFormat = partialFormat;
    }
}

public partial class DevelExtensionSettings : ObservableObject
{
    [ObservableProperty] bool enabled = true;
    [ObservableProperty] string? path;
}

public enum DesktopSettingsPage
{
    General = 0,
    AppearanceGeneral = 1,
    AppearanceAdvanced = 2,
    AppearanceDetailsView = 3,
    AppearanceGridView = 4,
    AppearanceLayout = 5,
    GeneralAdvanced = 6,
    Input = 7,
    Metadata = 9,
    Scripting = 11,
    ClientShutdown = 12,
    Performance = 13,
    ImportExlusionList = 14,
    Development = 19,
    AppearanceTopPanel = 20,
    Sorting = 21,
    Updates = 22,
    AppearanceListView = 23,
    Search = 24,
    Backup = 25
}

public enum AccessibilityInterfaceOptions
{
    [Description(Loc.automatic_id)]     Auto,
    [Description(Loc.always_on_id)]     AlwaysOn,
    [Description(Loc.always_off_id)]    AlwaysOff
}

public enum GameSearchItemAction
{
    [Description(Loc.game_search_item_action_play_id)]      Play,
    [Description(Loc.game_search_item_action_switch_to_id)] SwitchTo,
    [Description(Loc.game_search_item_action_open_menu_id)] OpenMenu,
    [Description(Loc.game_search_item_action_edit_id)]      Edit,
    [Description(Loc.none_id)]                              None
}

public enum AfterLaunchOptions
{
    [Description(Loc.none_id)]      None,
    [Description(Loc.minimize_id)]  Minimize,
    [Description(Loc.close_id)]     Close
}

public enum AfterGameCloseOptions
{
    [Description(Loc.none_id)]            None,
    [Description(Loc.restore_window_id)]  Restore
}

public enum ApplicationView
{
    [Description(Loc.library_id)]     Library,
    [Description(Loc.statistics_id)]  Statistics
}

public enum ImageLoadScaling
{
    [Description(Loc.settings_image_scaling_quality_id)]     None,
    [Description(Loc.settings_image_scaling_balanced_id)]    BitmapDotNet,
    [Description(Loc.settings_image_scaling_alternative_id)] Custom
}

public enum TrayIconType
{
    Default,
    Bright,
    Dark
}

public enum DefaultIconSourceOptions
{
    [Description(Loc.game_provider_title_id)] Library,
    [Description(Loc.platform_title_id)]      Platform,
    [Description("Playnite")]                 General,
    [Description(Loc.none_id)]                None
}

public enum DefaultCoverSourceOptions
{
    [Description(Loc.platform_title_id)] Platform,
    [Description("Playnite")]            General,
    [Description(Loc.none_id)]           None
}

public enum DefaultBackgroundSourceOptions
{
    [Description(Loc.game_provider_title_id)] Library,
    [Description(Loc.platform_title_id)]      Platform,
    [Description(Loc.game_cover_title_id)]    Cover,
    [Description(Loc.none_id)]                None
}

public enum TextRenderingModeOptions
{
    [Description(Loc.settings_text_rendering_mode_option_auto_id)]       Auto,
    [Description(Loc.settings_text_rendering_mode_option_aliased_id)]    Aliased,
    [Description(Loc.settings_text_rendering_mode_option_grayscale_id)]  Grayscale,
    [Description(Loc.settings_text_rendering_mode_option_clear_type_id)] ClearType
}

public enum TextFormattingModeOptions
{
    [Description(Loc.settings_text_formatting_mode_option_ideal_id)]   Ideal,
    [Description(Loc.settings_text_formatting_mode_option_display_id)] Display
}

public enum UpdateCheckFrequency
{
    [Description(Loc.option_on_every_startup_id)] OnEveryStartup,
    [Description(Loc.option_once_a_day_id)]       OnceADay,
    [Description(Loc.option_once_a_week_id)]      OnceAWeek
}

public enum LibraryUpdateCheckFrequency
{
    [Description(Loc.option_only_manually_id)]    Manually,
    [Description(Loc.option_on_every_startup_id)] OnEveryStartup,
    [Description(Loc.option_once_a_day_id)]       OnceADay,
    [Description(Loc.option_once_a_week_id)]      OnceAWeek
}

public enum AutoBackupFrequency
{
    [Description(Loc.option_once_a_day_id)]  OnceADay,
    [Description(Loc.option_once_a_week_id)] OnceAWeek
}

public partial class PlayniteSettings : ObservableObject
{
    internal static readonly string[] DefaultSortingNameRemovedArticles = new string[] { "The", "A", "An" };

    [ObservableProperty] private DetailsVisibilitySettings detailsVisibility = new();
    //[ObservableProperty] private MetadataDownloaderSettings metadataSettings;

    [ObservableProperty] private DefaultIconSourceOptions defaultIconSource = DefaultIconSourceOptions.General;
    [ObservableProperty] private DefaultCoverSourceOptions defaultCoverSource = DefaultCoverSourceOptions.General;
    [ObservableProperty] private DefaultBackgroundSourceOptions defaultBackgroundSource = DefaultBackgroundSourceOptions.None;
    [ObservableProperty] private bool indentGameDetails = true;
    [ObservableProperty] private Dock gridViewDetailsPosition = Dock.Right;
    [ObservableProperty] private Dock filterPanelPosition = Dock.Right;
    [ObservableProperty] private Dock explorerPanelPosition = Dock.Left;
    [ObservableProperty] private Dock detailsListPosition = Dock.Left;
    [ObservableProperty] private bool explorerPanelVisible = false;
    [ObservableProperty] private double filterPanelWitdh = 240;
    [ObservableProperty] private double explorerPanelWitdh = 280;
    [ObservableProperty] private double grdiDetailsWitdh = 350;
    [ObservableProperty] private double detailsListWitdh = 350;
    [ObservableProperty] private double gameDetailsCoverHeight = 170;
    [ObservableProperty] private bool showPanelSeparators = true;
    [ObservableProperty] private bool showGridItemBackground = true;
    [ObservableProperty] private bool showNameEmptyCover = true;
    [ObservableProperty] private bool showNamesUnderCovers = false;
    [ObservableProperty] private bool showBackgroundImageOnWindow = true;
    [ObservableProperty] private bool highQualityBackgroundBlur = true;
    [ObservableProperty] private bool blurWindowBackgroundImage = true;
    [ObservableProperty] private double backgroundImageBlurAmount = 60;
    [ObservableProperty] private bool darkenWindowBackgroundImage = true;
    [ObservableProperty] private float backgroundImageDarkAmount = 0.7f;
    [ObservableProperty] private bool showBackImageOnGridView = false;
    [ObservableProperty] private bool showIconsOnList = true;
    [ObservableProperty] private bool showGroupCount = true;
    [ObservableProperty] private bool gridViewSideBarVisible = false;
    [ObservableProperty] private bool filterPanelVisible = false;
    [ObservableProperty] private Dock sidebarPosition = Dock.Left;
    [ObservableProperty] private double detailsViewListIconSize = 26;
    [ObservableProperty] private bool backgroundImageAnimation = true;
    [ObservableProperty] private bool darkenUninstalledGamesGrid = false;
    [ObservableProperty] private double gridViewScrollSensitivity = 1.5;
    [ObservableProperty] private long gridViewScrollSpeed = 250 * TimeSpan.TicksPerMillisecond;
    [ObservableProperty] private bool gridViewSmoothScrollEnabled = false;
    [ObservableProperty] private double detailsViewScrollSensitivity = 1.5;
    [ObservableProperty] private long detailsViewScrollSpeed = 250 * TimeSpan.TicksPerMillisecond;
    [ObservableProperty] private bool detailsViewSmoothScrollEnabled = false;
    [ObservableProperty] private double listViewScrollSensitivity = 1.5;
    [ObservableProperty] private long listViewScrollSpeed = 250 * TimeSpan.TicksPerMillisecond;
    [ObservableProperty] private bool listViewSmoothScrollEnabled = false;
    [ObservableProperty][property: RequiresRestart] private double fontSize = 14;
    [ObservableProperty][property: RequiresRestart] private double fontSizeSmall = 12;
    [ObservableProperty][property: RequiresRestart] private double fontSizeLarge = 15;
    [ObservableProperty][property: RequiresRestart] private double fontSizeLarger = 20;
    [ObservableProperty][property: RequiresRestart] private double fontSizeLargest = 29;
    [ObservableProperty][property: RequiresRestart] private DateFormattingOptions dateTimeFormatAdded = new(DateTimes.DefaultDateTimeFormat, false);
    [ObservableProperty][property: RequiresRestart] private DateFormattingOptions dateTimeFormatModified = new(DateTimes.DefaultDateTimeFormat, false);
    [ObservableProperty][property: RequiresRestart] private DateFormattingOptions dateTimeFormatRecentActivity = new(DateTimes.DefaultDateTimeFormat, true);
    [ObservableProperty][property: RequiresRestart] private ReleaseDateFormattingOptions dateTimeFormatReleaseDate = new(DateTimes.DefaultDateTimeFormat, false);
    [ObservableProperty][property: RequiresRestart] private DateFormattingOptions dateTimeFormatLastPlayed = new(DateTimes.DefaultDateTimeFormat, true);
    [ObservableProperty][property: RequiresRestart] private bool playtimeUseDaysFormat = false;
    [ObservableProperty][NotifyPropertyChangedFor(nameof(ShowMainMenuOnTopPanel))] private bool showSidebar = true;
    [ObservableProperty][NotifyPropertyChangedFor(nameof(CalculatedGameDetailsIndentation))] private int gameDetailsIndentation = 400;

    [ObservableProperty] private bool startInFullscreen = false;
    [ObservableProperty] private bool downloadMetadataOnImport = true;
    [ObservableProperty] private bool firstTimeWizardComplete;
    [ObservableProperty] private bool minimizeToTray = false;
    [ObservableProperty] private bool closeToTray = true;
    [ObservableProperty] private AfterLaunchOptions afterLaunch = AfterLaunchOptions.Minimize;
    [ObservableProperty] private AfterGameCloseOptions afterGameClose = AfterGameCloseOptions.Restore;
    [ObservableProperty] private bool startMinimized = false;
    [ObservableProperty] private bool startOnBoot = false;
    [ObservableProperty] private bool startOnBootClosedToTray = false;
    [ObservableProperty] private bool showImagePerformanceWarning = true;
    [ObservableProperty] private bool usedFieldsOnlyOnFilterLists = true;
    [ObservableProperty] private bool showHiddenInQuickLaunch = true;
    [ObservableProperty] private int quickLaunchItems = 10;
    [ObservableProperty] private string? directoryOpenCommand;
    [ObservableProperty] private bool fuzzyMatchingInNameFilter = true;
    [ObservableProperty] private bool traceLogEnabled = false;
    [ObservableProperty] private List<DevelExtensionSettings> develExtenions = new ();
    [ObservableProperty] private Guid selectedFilterPreset;
    [ObservableProperty] private bool addonsPerfNoticeShown = false;
    [ObservableProperty] private ImageLoadScaling imageScalerMode = ImageLoadScaling.BitmapDotNet;
    [ObservableProperty] private bool gameSortingNameAutofill = true;
    [ObservableProperty] private List<string> gameSortingNameRemovedArticles = DefaultSortingNameRemovedArticles.ToList();
    [ObservableProperty] private bool showNahimicServiceWarning = true;
    [ObservableProperty] private bool showElevatedRightsWarning = true;
    [ObservableProperty] private bool installSizeScanUseSizeOnDisk = true;
    [ObservableProperty] private bool scanLibInstallSizeOnLibUpdate = true;
    [ObservableProperty] private bool updateNotificationOnPatchesOnly = false;
    [ObservableProperty] private string webImageSarchIconTerm = "{Name} icon";
    [ObservableProperty] private string webImageSarchCoverTerm = "{Name} cover";
    [ObservableProperty] private string webImageSarchBackgroundTerm = "{Name} wallpaper";

    [ObservableProperty] private UpdateCheckFrequency checkForProgramUpdates = UpdateCheckFrequency.OnEveryStartup;
    [ObservableProperty] private UpdateCheckFrequency checkForAddonUpdates = UpdateCheckFrequency.OnEveryStartup;
    [ObservableProperty] private LibraryUpdateCheckFrequency checkForLibraryUpdates = LibraryUpdateCheckFrequency.OnEveryStartup;
    [ObservableProperty] private LibraryUpdateCheckFrequency checkForEmulatedLibraryUpdates = LibraryUpdateCheckFrequency.OnEveryStartup;

    [ObservableProperty] private GameSearchItemAction primaryGameSearchItemAction = GameSearchItemAction.SwitchTo;
    [ObservableProperty] private GameSearchItemAction secondaryGameSearchItemAction = GameSearchItemAction.Play;
    [ObservableProperty] private bool globalSearchOpenWithLegacySearch = true;
    [ObservableProperty] private bool saveGlobalSearchFilterSettings = true;
    [ObservableProperty] private Dictionary<string, string> customSearchKeywrods = new ();
    [ObservableProperty] private GameSearchFilterSettings gameSearchFilterSettings = new GameSearchFilterSettings();
    [ObservableProperty] private HotKey? systemSearchHotkey;
    [ObservableProperty] private bool includeCommandsInDefaultSearch = true;

    [ObservableProperty] private bool autoBackupEnabled = false;
    [ObservableProperty] private AutoBackupFrequency autoBackupFrequency = AutoBackupFrequency.OnceAWeek;
    [ObservableProperty] private string? autoBackupDir;
    [ObservableProperty] private int rotatingBackups;
    [ObservableProperty] private bool autoBackupIncludeLibFiles = true;
    [ObservableProperty] private bool autoBackupIncludeExtensionsData = true;
    [ObservableProperty] private bool autoBackupIncludeExtensions = false;
    [ObservableProperty] private bool autoBackupIncludeThemes = false;

    [ObservableProperty][property: RequiresRestart] private string? databasePath;
    [ObservableProperty][property: RequiresRestart] private bool disableHwAcceleration = false;
    [ObservableProperty][property: RequiresRestart] private bool asyncImageLoading = true;
    [ObservableProperty][property: RequiresRestart] private bool enableTray = true;
    [ObservableProperty][property: RequiresRestart] private string language = "en_US";
    [ObservableProperty][property: RequiresRestart] private string theme = Themes.DefaultDesktopThemeId;
    [ObservableProperty][property: RequiresRestart] private TrayIconType trayIcon = TrayIconType.Default;
    [ObservableProperty][property: RequiresRestart] private string fontFamilyName = "Trebuchet MS";
    [ObservableProperty][property: RequiresRestart] private string monospaceFontFamilyName = "Consolas";
    [ObservableProperty][property: RequiresRestart] private TextFormattingModeOptions textFormattingMode = TextFormattingModeOptions.Ideal;
    [ObservableProperty][property: RequiresRestart] private TextRenderingModeOptions textRenderingMode = TextRenderingModeOptions.Auto;

    [JsonIgnore] public double CalculatedGameDetailsIndentation => IndentGameDetails ? GameDetailsIndentation : Double.NaN;
    [JsonIgnore] public bool ShowMainMenuOnTopPanel => !ShowSidebar;

    public string? InstallInstanceId { get; set; }
    public DateTime LastProgramUpdateCheck { get; set; }
    public DateTime LastAddonUpdateCheck { get; set; }
    public DateTime LastLibraryUpdateCheck { get; set; }
    public DateTime LastEmuLibraryUpdateCheck { get; set; }
    public DateTime LastAutoBackup { get; set; }
}