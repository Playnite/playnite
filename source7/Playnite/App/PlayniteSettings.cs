using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.IO;
using System.Text.Json.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Playnite;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class RequiresRestartAttribute : Attribute
{
}

public partial class ListViewColumnProperty : ObservableObject
{
    public GameField Field { get; set; }
    [ObservableProperty] private bool visible = false;
    [ObservableProperty] private double width = double.NaN;

    partial void OnWidthChanged(double value)
    {
        // Don't allow exteremly small size because it could lead to a user accidentely hiding the column by resizing: #2257
        if (value < 25)
        {
#pragma warning disable MVVMTK0034 // Direct field reference to [ObservableProperty] backing field
            width = 25;
#pragma warning restore MVVMTK0034 // Direct field reference to [ObservableProperty] backing field
        }
    }

    public ListViewColumnProperty()
    {
    }

    public ListViewColumnProperty(GameField field)
    {
        Field = field;
    }
}

public partial class ListViewColumnsProperties : ObservableObject
{
    // TODO: autogen
    [ObservableProperty] private ListViewColumnProperty icon = new(GameField.Icon);
    [ObservableProperty] private ListViewColumnProperty name = new(GameField.Name);
    [ObservableProperty] private ListViewColumnProperty platform = new(GameField.Platforms);
    [ObservableProperty] private ListViewColumnProperty developers = new(GameField.Developers);
    [ObservableProperty] private ListViewColumnProperty publishers = new(GameField.Publishers);
    [ObservableProperty] private ListViewColumnProperty releaseDate = new(GameField.ReleaseDate);
    [ObservableProperty] private ListViewColumnProperty genres = new(GameField.Genres);
    [ObservableProperty] private ListViewColumnProperty lastActivity = new(GameField.LastActivity);
    [ObservableProperty] private ListViewColumnProperty recentActivity = new(GameField.RecentActivity);
    [ObservableProperty] private ListViewColumnProperty isInstalled = new(GameField.IsInstalled);
    [ObservableProperty] private ListViewColumnProperty installDirectory = new(GameField.InstallDirectory);
    [ObservableProperty] private ListViewColumnProperty categories = new(GameField.Categories);
    [ObservableProperty] private ListViewColumnProperty playtime = new(GameField.Playtime);
    [ObservableProperty] private ListViewColumnProperty added = new(GameField.Added);
    [ObservableProperty] private ListViewColumnProperty modified = new(GameField.Modified);
    [ObservableProperty] private ListViewColumnProperty playCount = new(GameField.PlayCount);
    [ObservableProperty] private ListViewColumnProperty installSize = new(GameField.InstallSize);
    [ObservableProperty] private ListViewColumnProperty series = new(GameField.Series);
    [ObservableProperty] private ListViewColumnProperty version = new(GameField.Version);
    [ObservableProperty] private ListViewColumnProperty ageRating = new(GameField.AgeRatings);
    [ObservableProperty] private ListViewColumnProperty region = new(GameField.Regions);
    [ObservableProperty] private ListViewColumnProperty source = new(GameField.Source);
    [ObservableProperty] private ListViewColumnProperty completionStatus = new(GameField.CompletionStatus);
    [ObservableProperty] private ListViewColumnProperty userScore = new(GameField.UserScore);
    [ObservableProperty] private ListViewColumnProperty criticScore = new(GameField.CriticScore);
    [ObservableProperty] private ListViewColumnProperty communityScore = new(GameField.CommunityScore);
    [ObservableProperty] private ListViewColumnProperty tags = new(GameField.Tags);
    [ObservableProperty] private ListViewColumnProperty pluginId = new(GameField.PluginId);
    [ObservableProperty] private ListViewColumnProperty features = new(GameField.Features);
    [ObservableProperty] private ListViewColumnProperty roms = new(GameField.Roms);
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
    [Description(LocId.automatic)]     Auto,
    [Description(LocId.always_on)]     AlwaysOn,
    [Description(LocId.always_off)]    AlwaysOff
}

public enum GameSearchItemAction
{
    [Description(LocId.game_search_item_action_play)]      Play,
    [Description(LocId.game_search_item_action_switch_to)] SwitchTo,
    [Description(LocId.game_search_item_action_open_menu)] OpenMenu,
    [Description(LocId.game_search_item_action_edit)]      Edit,
    [Description(LocId.none)]                              None
}

public enum AfterLaunchOptions
{
    [Description(LocId.none)]      None,
    [Description(LocId.minimize)]  Minimize,
    [Description(LocId.close)]     Close
}

public enum AfterGameCloseOptions
{
    [Description(LocId.none)]            None,
    [Description(LocId.restore_window)]  Restore
}

public enum ApplicationView
{
    [Description(LocId.library)]     Library,
    [Description(LocId.statistics)]  Statistics
}

public enum ImageLoadScaling
{
    [Description(LocId.settings_image_scaling_quality)]     None,
    [Description(LocId.settings_image_scaling_balanced)]    BitmapDotNet,
    [Description(LocId.settings_image_scaling_alternative)] Custom
}

public enum TrayIconType
{
    Default,
    Bright,
    Dark
}

public enum DefaultIconSourceOptions
{
    [Description(LocId.game_provider_title)] Library,
    [Description(LocId.platform_title)]      Platform,
    [Description("Playnite")]                 General,
    [Description(LocId.none)]                None
}

public enum DefaultCoverSourceOptions
{
    [Description(LocId.platform_title)] Platform,
    [Description("Playnite")]            General,
    [Description(LocId.none)]           None
}

public enum DefaultBackgroundSourceOptions
{
    [Description(LocId.game_provider_title)] Library,
    [Description(LocId.platform_title)]      Platform,
    [Description(LocId.game_cover_title)]    Cover,
    [Description(LocId.none)]                None
}

public enum TextRenderingModeOptions
{
    [Description(LocId.settings_text_rendering_mode_option_auto)]       Auto,
    [Description(LocId.settings_text_rendering_mode_option_aliased)]    Aliased,
    [Description(LocId.settings_text_rendering_mode_option_grayscale)]  Grayscale,
    [Description(LocId.settings_text_rendering_mode_option_clear_type)] ClearType
}

public enum TextFormattingModeOptions
{
    [Description(LocId.settings_text_formatting_mode_option_ideal)]   Ideal,
    [Description(LocId.settings_text_formatting_mode_option_display)] Display
}

public enum UpdateCheckFrequency
{
    [Description(LocId.option_on_every_startup)] OnEveryStartup,
    [Description(LocId.option_once_a_day)]       OnceADay,
    [Description(LocId.option_once_a_week)]      OnceAWeek
}

public enum LibraryUpdateCheckFrequency
{
    [Description(LocId.option_only_manually)]    Manually,
    [Description(LocId.option_on_every_startup)] OnEveryStartup,
    [Description(LocId.option_once_a_day)]       OnceADay,
    [Description(LocId.option_once_a_week)]      OnceAWeek
}

public enum AutoBackupFrequency
{
    [Description(LocId.option_once_a_day)]  OnceADay,
    [Description(LocId.option_once_a_week)] OnceAWeek
}

public partial class FullscreenFilterSettings
{
}

public partial class FullscreenViewSettings : ObservableObject
{
    [ObservableProperty] private SortOrder sortingOrder = SortOrder.Name;
    [ObservableProperty] private SortOrderDirection sortingOrderDirection = SortOrderDirection.Ascending;
}

public partial class ViewSettings : ObservableObject
{
    [ObservableProperty] private SortOrder sortingOrder = SortOrder.Name;
    [ObservableProperty] private SortOrderDirection sortingOrderDirection = SortOrderDirection.Ascending;
    [ObservableProperty] private GroupableField groupingOrder = GroupableField.None;
    [ObservableProperty] private DesktopView gamesViewType = DesktopView.Details;
    [ObservableProperty] private ExplorerField selectedExplorerField = ExplorerField.Library;
    [ObservableProperty] private ListViewColumnsProperties listViewColumns = new();
    [ObservableProperty] private Dictionary<GroupableField, List<string>> collapsedGroups = new();
    [ObservableProperty] private List<GameField> listViewColumsOrder = new()
    {
        GameField.Icon,
        GameField.Name,
        GameField.ReleaseDate,
        GameField.Genres,
        GameField.LastActivity,
        GameField.Playtime,
        GameField.PluginId
    };

    public ViewSettings()
    {
        listViewColumns.Icon.Visible = true;
        listViewColumns.Name.Visible = true;
        listViewColumns.ReleaseDate.Visible = true;
        listViewColumns.Genres.Visible = true;
        listViewColumns.LastActivity.Visible = true;
        listViewColumns.Playtime.Visible = true;
        listViewColumns.PluginId.Visible = true;
    }

    public bool IsGroupCollapsed(GroupableField field, string groupName)
    {
        if (CollapsedGroups.ContainsKey(field) &&
            CollapsedGroups[field].ContainsString(groupName, StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }

        return false;
    }

    public void ExpandAllGroups(GroupableField field)
    {
        if (CollapsedGroups.Remove(field))
        {
            OnPropertyChanged(nameof(CollapsedGroups));
        }
    }

    public void CollapseGroups(GroupableField field, List<string> groupNames)
    {
        if (!CollapsedGroups.ContainsKey(field))
        {
            CollapsedGroups.Add(field, new List<string>());
        }

        foreach (var groupName in groupNames)
        {
            if (!CollapsedGroups[field].ContainsString(groupName, StringComparison.OrdinalIgnoreCase))
            {
                CollapsedGroups[field].Add(groupName);
            }
        }

        OnPropertyChanged(nameof(CollapsedGroups));
    }

    public void SetGroupCollapseState(GroupableField field, string groupName, bool collapsed)
    {
        if (collapsed)
        {
            if (!CollapsedGroups.ContainsKey(field))
            {
                CollapsedGroups.Add(field, new List<string>());
            }

            if (!CollapsedGroups[field].ContainsString(groupName, StringComparison.OrdinalIgnoreCase))
            {
                CollapsedGroups[field].Add(groupName);
                OnPropertyChanged(nameof(CollapsedGroups));
            }
        }
        else
        {
            if (CollapsedGroups.ContainsKey(field))
            {
                var existing = CollapsedGroups[field].FirstOrDefault(a => string.Equals(a, groupName, StringComparison.OrdinalIgnoreCase));
                if (existing != null)
                {
                    CollapsedGroups[field].Remove(existing);
                }

                if (CollapsedGroups[field].Count == 0)
                {
                    CollapsedGroups.Remove(field);
                }

                OnPropertyChanged(nameof(CollapsedGroups));
            }
        }
    }
}

public partial class FullscreenSettings : ObservableObject
{
    [ObservableProperty] private int monitor = Computer.GetGetPrimaryScreenIndex();
    [ObservableProperty] private int rows = 2;
    [ObservableProperty] private int columns = 4;
    [ObservableProperty] private bool horizontalLayout = false;
    [ObservableProperty] private bool showBattery = false;
    [ObservableProperty] private bool showClock = true;
    [ObservableProperty] private bool showBatteryPercentage = false;
    [ObservableProperty] private bool showGameTitles = false;
    [ObservableProperty] private bool darkenUninstalledGamesGrid = false;
    [ObservableProperty] private bool enableMainBackgroundImage = false;
    [ObservableProperty] private int mainBackgroundImageBlurAmount = 0;
    [ObservableProperty] private float mainBackgroundImageDarkAmount = 30;
    [ObservableProperty] private bool usePrimaryDisplay = false;
    [ObservableProperty] private Guid selectedFilterPreset;
    [ObservableProperty] private bool hideMouserCursor = false;
    [ObservableProperty] private bool minimizeAfterGameStartup = true;
    [ObservableProperty] private float interfaceVolume = 0.5f;
    [ObservableProperty] private float musicVolume = 0.3f;
    [ObservableProperty] private bool muteInBackground = true;
    [ObservableProperty] private bool primaryControllerOnly = true;
    [ObservableProperty] private bool guideButtonFocus = false;
    [ObservableProperty] private ImageLoadScaling imageScalerMode = ImageLoadScaling.BitmapDotNet;
    [ObservableProperty] private bool smoothScrolling = true;
    [ObservableProperty] private int fullscreenItemSpacing = 20;
    [ObservableProperty] private AspectRatio coverAspectRatio = new(3, 4);

    [ObservableProperty] private bool mainMenuShowRestart = true;
    [ObservableProperty] private bool mainMenuShowShutdown = true;
    [ObservableProperty] private bool mainMenuShowSuspend = true;
    [ObservableProperty] private bool mainMenuShowHibernate = true;
    [ObservableProperty] private bool mainMenuShowMinimize = true;

    [ObservableProperty][property: RequiresRestart] private double fontSize = 22;
    [ObservableProperty][property: RequiresRestart] private double fontSizeSmall = 18;
    [ObservableProperty][property: RequiresRestart] private bool asyncImageLoading = true;
    [ObservableProperty][property: RequiresRestart] private string theme = Themes.DefaultFullscreenThemeId;

    [ObservableProperty] private FullscreenFilterSettings filterSettings = new();
    [ObservableProperty] private FullscreenViewSettings viewSettings = new();

    [ObservableProperty][property: JsonIgnore] private bool isMusicMuted = false;
    [JsonIgnore] public Thickness FullscreenItemSpacingMargin { get; private set; }

    public FullscreenSettings()
    {
        OnFullscreenItemSpacingChanged(FullscreenItemSpacing);
    }

    partial void OnFullscreenItemSpacingChanged(int value)
    {
        double marginX = FullscreenItemSpacing / 2;
        double marginY = CoverAspectRatio.GetWidth(FullscreenItemSpacing) / 2;
        FullscreenItemSpacingMargin = new Thickness(marginY / 2, marginX / 2, marginY / 2, marginX / 2);
        OnPropertyChanged(nameof(FullscreenItemSpacingMargin));
    }
}

public partial class PlayniteSettings : ObservableObject
{
    private static readonly ILogger logger = LogManager.GetLogger();

    public const int SettingsModelVersion = 11;
    public const double MinGridItemWidth = 60;
    public const double DefaultGridItemWidth = 200;
    public const double MaxGridItemWidth = 700;
    internal static readonly string[] DefaultSortingNameRemovedArticles = new string[] { "The", "A", "An" };

    public int Version { get; set; } = SettingsModelVersion;

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
    [ObservableProperty] private bool partialDescriptionLoading = true;
    [ObservableProperty] private SearchWindowVisibilitySettings searchWindowVisibility = new();
    [ObservableProperty] private DetailsVisibilitySettings detailsVisibility = new();
    [ObservableProperty] private MetadataDownloaderSettings metadataSettings = MetadataDownloaderSettings.GetDefaultSettings();
    [ObservableProperty] private ViewSettings viewSettings = new();
    //[ObservableProperty] private FilterSettings filterSettings = new();
    [ObservableProperty] private AgeRatingOrg ageRatingOrgPriority = AgeRatingOrg.PEGI;

    [ObservableProperty] private UpdateCheckFrequency checkForProgramUpdates = UpdateCheckFrequency.OnEveryStartup;
    [ObservableProperty] private UpdateCheckFrequency checkForAddonUpdates = UpdateCheckFrequency.OnEveryStartup;
    [ObservableProperty] private LibraryUpdateCheckFrequency checkForLibraryUpdates = LibraryUpdateCheckFrequency.OnEveryStartup;
    [ObservableProperty] private LibraryUpdateCheckFrequency checkForEmulatedLibraryUpdates = LibraryUpdateCheckFrequency.OnEveryStartup;

    [ObservableProperty] private GameSearchItemAction primaryGameSearchItemAction = GameSearchItemAction.SwitchTo;
    [ObservableProperty] private GameSearchItemAction secondaryGameSearchItemAction = GameSearchItemAction.Play;
    [ObservableProperty] private bool globalSearchOpenWithLegacySearch = true;
    [ObservableProperty] private bool saveGlobalSearchFilterSettings = true;
    [ObservableProperty] private Dictionary<string, string> customSearchKeywrods = new();
    [ObservableProperty] private GameSearchFilterSettings gameSearchFilterSettings = new();
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
    [ObservableProperty][property: RequiresRestart] private AccessibilityInterfaceOptions accessibilityInterface = AccessibilityInterfaceOptions.Auto;

    public string? InstallInstanceId { get; set; }
    public DateTime LastProgramUpdateCheck { get; set; }
    public DateTime LastAddonUpdateCheck { get; set; }
    public DateTime LastLibraryUpdateCheck { get; set; }
    public DateTime LastEmuLibraryUpdateCheck { get; set; }
    public DateTime LastAutoBackup { get; set; }

    [JsonIgnore] public double CalculatedGameDetailsIndentation => IndentGameDetails ? GameDetailsIndentation : Double.NaN;
    [JsonIgnore] public bool ShowMainMenuOnTopPanel => !ShowSidebar;
    [JsonIgnore] public List<WindowPosition> WindowPositions { get; private set; } = new();
    [JsonIgnore] public FullscreenSettings Fullscreen { get; private set; } = new();
    [JsonIgnore] public AspectRatio CoverAspectRatio { get; private set; } = new(3, 4);
    [JsonIgnore] public Thickness GridItemSpacingMargin { get; private set; }
    [JsonIgnore] public double GridItemHeight { get; private set; }

    [ObservableProperty] private Stretch coverArtStretch = Stretch.UniformToFill;
    [ObservableProperty] private double gridItemWidth = DefaultGridItemWidth;
    [ObservableProperty] private int gridItemWidthRatio = 3;
    [ObservableProperty] private int gridItemHeightRatio = 4;
    [ObservableProperty] private int gridItemSpacing = 8;
    [ObservableProperty] private int gridItemMargin = 2;

    partial void OnGridItemWidthChanged(double value)
    {
        UpdateGridItemHeight();
    }

    partial void OnGridItemWidthRatioChanged(int value)
    {
        UpdateGridItemHeight();
        CoverAspectRatio = new AspectRatio(GridItemWidthRatio, GridItemHeightRatio);
        OnPropertyChanged(nameof(CoverAspectRatio));
        Fullscreen.CoverAspectRatio = CoverAspectRatio;
    }

    partial void OnGridItemHeightRatioChanged(int value)
    {
        UpdateGridItemHeight();
        CoverAspectRatio = new AspectRatio(GridItemWidthRatio, GridItemHeightRatio);
        OnPropertyChanged(nameof(CoverAspectRatio));
        Fullscreen.CoverAspectRatio = CoverAspectRatio;
    }

    partial void OnGridItemSpacingChanged(int value)
    {
        GridItemSpacingMargin = GetItemSpacingMargin();
        OnPropertyChanged(nameof(GridItemSpacingMargin));
    }

    private Thickness GetItemSpacingMargin()
    {
        return new Thickness(GridItemSpacing / 2, GridItemSpacing / 2, GridItemSpacing / 2, GridItemSpacing / 2); ;
    }

    private void UpdateGridItemHeight()
    {
        if (GridItemWidth != 0)
        {
            GridItemHeight = Math.Round(GridItemWidth * ((double)GridItemHeightRatio / GridItemWidthRatio));
        }
        else
        {
            GridItemHeight = 0;
        }

        OnPropertyChanged(nameof(GridItemHeight));
    }

    public bool ShouldCheckProgramUpdatePeriodic()
    {
        return CheckForProgramUpdates switch
        {
            UpdateCheckFrequency.OnceADay => DateTimes.Now.Date != LastProgramUpdateCheck.Date,
            UpdateCheckFrequency.OnceAWeek => (DateTimes.Now - LastProgramUpdateCheck).TotalDays > 6,
            _ => false,
        };
    }

    public bool ShouldCheckAddonUpdatePeriodic()
    {
        return CheckForAddonUpdates switch
        {
            UpdateCheckFrequency.OnceADay => DateTimes.Now.Date != LastAddonUpdateCheck.Date,
            UpdateCheckFrequency.OnceAWeek => (DateTimes.Now - LastAddonUpdateCheck).TotalDays > 6,
            _ => false,
        };
    }

    public bool ShouldCheckProgramUpdateStartup()
    {
        return CheckForProgramUpdates switch
        {
            UpdateCheckFrequency.OnceADay => DateTimes.Now.Date != LastProgramUpdateCheck.Date,
            UpdateCheckFrequency.OnceAWeek => (DateTimes.Now - LastProgramUpdateCheck).TotalDays > 6,
            _ => true,
        };
    }

    public bool ShouldCheckAddonUpdateStartup()
    {
        return CheckForAddonUpdates switch
        {
            UpdateCheckFrequency.OnceADay => DateTimes.Now.Date != LastAddonUpdateCheck.Date,
            UpdateCheckFrequency.OnceAWeek => (DateTimes.Now - LastAddonUpdateCheck).TotalDays > 6,
            _ => true,
        };
    }

    public bool ShouldCheckLibraryOnStartup()
    {
        return CheckForLibraryUpdates switch
        {
            LibraryUpdateCheckFrequency.OnceADay => DateTimes.Now.Date != LastLibraryUpdateCheck.Date,
            LibraryUpdateCheckFrequency.OnceAWeek => (DateTimes.Now - LastLibraryUpdateCheck).TotalDays > 6,
            LibraryUpdateCheckFrequency.Manually => false,
            _ => true,
        };
    }

    public bool ShouldCheckEmuLibraryOnStartup()
    {
        return CheckForEmulatedLibraryUpdates switch
        {
            LibraryUpdateCheckFrequency.OnceADay => DateTimes.Now.Date != LastEmuLibraryUpdateCheck.Date,
            LibraryUpdateCheckFrequency.OnceAWeek => (DateTimes.Now - LastEmuLibraryUpdateCheck).TotalDays > 6,
            LibraryUpdateCheckFrequency.Manually => false,
            _ => true,
        };
    }

    public bool ShouldDataBackupOnStartup()
    {
        if (!AutoBackupEnabled)
        {
            return false;
        }

        return AutoBackupFrequency switch
        {
            AutoBackupFrequency.OnceADay => DateTimes.Now.Date != LastAutoBackup.Date,
            AutoBackupFrequency.OnceAWeek => (DateTimes.Now - LastAutoBackup).TotalDays > 6,
            _ => false,
        };
    }

    public PlayniteSettings()
    {
        var gpus = Computer.GetGpuVendors();
        if (gpus.Contains(HwCompany.Intel) || gpus.Contains(HwCompany.VMware))
        {
            BackgroundImageAnimation = false;
        }

        InstallInstanceId = Guid.NewGuid().ToString();
        OnGridItemWidthRatioChanged(GridItemWidthRatio);
        OnGridItemSpacingChanged(GridItemSpacing);
    }

    private static T? LoadSettingFile<T>(string path) where T : class
    {
        try
        {
            if (File.Exists(path))
            {
                return Serialization.FromJson<T>(File.ReadAllText(path));
            }
        }
        catch (Exception e) when (!AppConfig.ThrowAllErrors)
        {
            logger.Error(e, $"Failed to load {path} setting file.");
        }

        return null;
    }

    private static void SaveSettingFile(object settings, string path)
    {
        FileSystem.WriteStringToFile(path, Serialization.ToJson(settings, true));
    }

    public static PlayniteSettings LoadSettings()
    {
        var settings = LoadSettingFile<PlayniteSettings>(PlaynitePaths.ConfigFile);
        if (settings == null)
        {
            logger.Warn("No existing settings found.");
            settings = LoadSettingFile<PlayniteSettings>(PlaynitePaths.BackupConfigFile);
            if (settings == null)
            {
                logger.Warn("No settings backup found, creating default ones.");
                settings = new PlayniteSettings();
            }
        }

        if (settings.Version == 7)
        {
            // TODO: migration from P11
        }

        settings.Version = SettingsModelVersion;
        settings.WindowPositions = LoadExternalConfig<List<WindowPosition>>(PlaynitePaths.WindowPositionsFile, PlaynitePaths.BackupWindowPositionsFile);
        settings.Fullscreen = LoadExternalConfig<FullscreenSettings>(PlaynitePaths.FullscreenConfigFile, PlaynitePaths.BackupFullscreenConfigFile);
        settings.BackupSettings();
        return settings;
    }

    private static T LoadExternalConfig<T>(string origPath, string backupPath) where T : class, new()
    {
        var name = Path.GetFileName(origPath);
        var config = LoadSettingFile<T>(origPath);
        if (config is null)
        {
            logger.Warn($"No existing {name} settings found.");
            config = LoadSettingFile<T>(backupPath);
            if (config is null)
            {
                logger.Warn($"No {name} settings backup found, creating default ones.");
                config = new T();
            }
        }

        return config!;
    }

    public void SaveSettings()
    {
        try
        {
            FileSystem.CreateDirectory(PlaynitePaths.ConfigRootDir);
            SaveSettingFile(this, PlaynitePaths.ConfigFile);
            SaveSettingFile(WindowPositions, PlaynitePaths.WindowPositionsFile);
            SaveSettingFile(Fullscreen, PlaynitePaths.FullscreenConfigFile);
        }
        catch (Exception e) when (!AppConfig.ThrowAllErrors)
        {
            logger.Error(e, "Failed to save application settings.");
        }
    }

    public void BackupSettings()
    {
        try
        {
            FileSystem.CreateDirectory(PlaynitePaths.ConfigRootDir);
            SaveSettingFile(this, PlaynitePaths.BackupConfigFile);
            SaveSettingFile(WindowPositions, PlaynitePaths.BackupWindowPositionsFile);
            SaveSettingFile(Fullscreen, PlaynitePaths.BackupFullscreenConfigFile);
        }
        catch (Exception e) when (!AppConfig.ThrowAllErrors)
        {
            logger.Error(e, "Failed to backup application settings.");
        }
    }
}