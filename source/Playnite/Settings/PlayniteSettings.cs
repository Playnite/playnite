using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NLog;
using NLog.Config;
using NLog.Targets;
using System.Configuration;
using Playnite.Common;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using Newtonsoft.Json.Serialization;
using System.Runtime.Serialization;
using Playnite.Metadata;
using Playnite.SDK;
using Microsoft.Win32;
using Playnite.SDK.Models;
using System.Collections.ObjectModel;
using Playnite.SDK.Plugins;

namespace Playnite
{
    

    public class PlayniteSettings : ObservableObject
    {
        private static SDK.ILogger logger = SDK.LogManager.GetLogger();

        public int Version
        {
            get; set;
        } = 7;



      

        [JsonIgnore]
        public double GridItemHeight
        {
            get; private set;
        }

        private double gridItemWidth = ViewSettings.DefaultGridItemWidth;
        public double GridItemWidth
        {
            get
            {
                return gridItemWidth;
            }

            set
            {
                gridItemWidth = Math.Round(value);
                OnPropertyChanged();
                UpdateGridItemHeight();
            }
        }

        [JsonIgnore]
        public AspectRatio CoverAspectRatio => new AspectRatio(GridItemWidthRatio, GridItemHeightRatio);

        private int gridItemWidthRatio = 3;
        public int GridItemWidthRatio
        {
            get
            {
                return gridItemWidthRatio;
            }

            set
            {
                gridItemWidthRatio = value;
                OnPropertyChanged();
                UpdateGridItemHeight();
                OnPropertyChanged(nameof(CoverAspectRatio));
            }
        }

        private int gridItemHeightRatio = 4;
        public int GridItemHeightRatio
        {
            get
            {
                return gridItemHeightRatio;
            }

            set
            {
                gridItemHeightRatio = value;
                OnPropertyChanged();
                UpdateGridItemHeight();
                OnPropertyChanged(nameof(CoverAspectRatio));
            }
        }

        private Stretch coverArtStretch = Stretch.UniformToFill;
        public Stretch CoverArtStretch
        {
            get
            {
                return coverArtStretch;
            }

            set
            {
                coverArtStretch = value;
                OnPropertyChanged();
            }
        }

        private int gridItemSpacing = 8;
        public int GridItemSpacing
        {
            get
            {
                return gridItemSpacing;
            }

            set
            {
                gridItemSpacing = value;
                OnPropertyChanged();
                ItemSpacingMargin = GetItemSpacingMargin();
                OnPropertyChanged(nameof(ItemSpacingMargin));
            }
        }

        private int gridItemMargin = 2;
        public int GridItemMargin
        {
            get
            {
                return gridItemMargin;
            }

            set
            {
                gridItemMargin = value;
                OnPropertyChanged();
            }
        }

        private int fullscreenItemSpacing = 20;
        public int FullscreenItemSpacing
        {
            get
            {
                return fullscreenItemSpacing;
            }

            set
            {
                fullscreenItemSpacing = value;
                OnPropertyChanged();
                FullscreenItemSpacingMargin = GetFullscreenItemSpacingMargin();
                OnPropertyChanged(nameof(FullscreenItemSpacingMargin));
            }
        }

        [JsonIgnore]
        public Thickness ItemSpacingMargin
        {
            get; private set;
        }

        [JsonIgnore]
        public Thickness FullscreenItemSpacingMargin
        {
            get; private set;
        }

        

        private FilterSettings filterSettings = new FilterSettings();
        public FilterSettings FilterSettings
        {
            get
            {
                return filterSettings;
            }

            set
            {
                filterSettings = value;
            }
        }

        private ViewSettings desktopViewSettings = new ViewSettings();
        public ViewSettings ViewSettings
        {
            get
            {
                return desktopViewSettings;
            }

            set
            {
                desktopViewSettings = value;
            }
        }



        

        private AgeRatingOrg ageRatingOrgPriority = AgeRatingOrg.PEGI;
        public AgeRatingOrg AgeRatingOrgPriority
        {
            get => ageRatingOrgPriority;
            set
            {
                ageRatingOrgPriority = value;
                OnPropertyChanged();
            }
        }

        // See OnCreateAutomationPeer comment in WindowBase.cs for why this exists.
        private AccessibilityInterfaceOptions accessibilityInterface = AccessibilityInterfaceOptions.Auto;
        [RequiresRestart]
        public AccessibilityInterfaceOptions AccessibilityInterface { get => accessibilityInterface; set => SetValue(ref accessibilityInterface, value); }

        private bool partialDescriptionLoading = true;
        public bool PartialDescriptionLoading { get => partialDescriptionLoading; set => SetValue(ref partialDescriptionLoading, value); }

        [JsonIgnore]
        public WindowPositions WindowPositions
        {
            get; private set;
        } = new WindowPositions();

        [JsonIgnore]
        public FullscreenSettings Fullscreen
        {
            get; private set;
        } = new FullscreenSettings();


        private SearchWindowVisibilitySettings searchWindowVisibility = new SearchWindowVisibilitySettings();
        public SearchWindowVisibilitySettings SearchWindowVisibility
        {
            get
            {
                return searchWindowVisibility;
            }

            set
            {
                searchWindowVisibility = value;
                OnPropertyChanged();
            }
        }

        public PlayniteSettings()
        {
            var gpus = Computer.GetGpuVendors();
            if (gpus.Contains(HwCompany.Intel) || gpus.Contains(HwCompany.VMware))
            {
                BackgroundImageAnimation = false;
            }

            InstallInstanceId = Guid.NewGuid().ToString();
            ItemSpacingMargin = GetItemSpacingMargin();
            FullscreenItemSpacingMargin = GetFullscreenItemSpacingMargin();
            UpdateGridItemHeight();
        }

        private static T LoadSettingFile<T>(string path) where T : class
        {
            try
            {
                if (File.Exists(path))
                {
                    return JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
                }
            }
            catch (Exception e) when (!PlayniteEnvironment.ThrowAllErrors)
            {
                logger.Error(e, $"Failed to load {path} setting file.");
            }

            return null;
        }

        private static void SaveSettingFile(object settings, string path)
        {
            FileSystem.WriteStringToFile(path, JsonConvert.SerializeObject(settings, Formatting.Indented));
        }

        public static PlayniteSettings GetDefaultSettings()
        {
            var settings = new PlayniteSettings();
            settings.ViewSettings.ListViewColumsOrder = new List<GameField>
                {
                    GameField.Icon,
                    GameField.Name,
                    GameField.ReleaseDate,
                    GameField.Genres,
                    GameField.LastActivity,
                    GameField.Playtime,
                    GameField.PluginId
                };

            var columns = new ListViewColumnsProperties();
            columns.Icon.Visible = true;
            columns.Name.Visible = true;
            columns.ReleaseDate.Visible = true;
            columns.Genres.Visible = true;
            columns.LastActivity.Visible = true;
            columns.Playtime.Visible = true;
            columns.PluginId.Visible = true;
            settings.ViewSettings.ListViewColumns = columns;
            settings.MetadataSettings = MetadataDownloaderSettings.GetDefaultSettings();
            return settings;
        }

        public static PlayniteSettings LoadSettings()
        {
            var settings = LoadSettingFile<PlayniteSettings>(PlaynitePaths.ConfigFilePath);
            if (settings == null)
            {
                logger.Warn("No existing settings found.");
                settings = LoadSettingFile<PlayniteSettings>(PlaynitePaths.BackupConfigFilePath);
                if (settings == null)
                {
                    logger.Warn("No settings backup found, creating default ones.");
                    settings = new PlayniteSettings();
                }
            }

            if (settings.ViewSettings.ListViewColumsOrder == null)
            {
                settings.ViewSettings.ListViewColumsOrder = new List<GameField>
                {
                    GameField.Icon,
                    GameField.Name,
                    GameField.ReleaseDate,
                    GameField.Genres,
                    GameField.LastActivity,
                    GameField.Playtime,
                    GameField.PluginId
                };
            }

            if (settings.ViewSettings.ListViewColumns == null)
            {
                var columns = new ListViewColumnsProperties();
                columns.Icon.Visible = true;
                columns.Name.Visible = true;
                columns.ReleaseDate.Visible = true;
                columns.Genres.Visible = true;
                columns.LastActivity.Visible = true;
                columns.Playtime.Visible = true;
                columns.PluginId.Visible = true;
                settings.ViewSettings.ListViewColumns = columns;
            }

            if (settings.MetadataSettings == null)
            {
                settings.MetadataSettings = MetadataDownloaderSettings.GetDefaultSettings();
            }

            if (settings.Version == 1)
            {
                settings.BackgroundImageBlurAmount = 17;
                settings.Version = 2;
            }

            if (settings.Version == 2)
            {
                settings.BackgroundImageBlurAmount = 60;
                settings.Version = 3;
            }

            if (settings.Version == 3)
            {
                settings.MetadataSettings.Feature = new MetadataFieldSettings(
                    true, new List<Guid> { Guid.Empty, BuiltinExtensions.GetIdFromExtension(BuiltinExtension.IgdbMetadata) });
                settings.Version = 4;
            }

            if (settings.Version == 4)
            {
                settings.MetadataSettings.AgeRating = new MetadataFieldSettings(
                    true, new List<Guid> { Guid.Empty, BuiltinExtensions.GetIdFromExtension(BuiltinExtension.IgdbMetadata) });
                settings.MetadataSettings.Series = new MetadataFieldSettings(
                    true, new List<Guid> { Guid.Empty, BuiltinExtensions.GetIdFromExtension(BuiltinExtension.IgdbMetadata) });
                settings.MetadataSettings.Platform = new MetadataFieldSettings(
                    true, new List<Guid> { Guid.Empty });
                settings.MetadataSettings.Region = new MetadataFieldSettings(
                    true, new List<Guid> { Guid.Empty });
                settings.Version = 5;
            }

            if (settings.Version == 5)
            {
                if (settings.DisabledPlugins.HasItems())
                {
                    // P9 saves disabled list based on add-on IDs, not directory names.
                    var idsMigration = new Dictionary<string, string>
                    {
                        { "AmazonGamesLibrary", "AmazonLibrary_Builtin" },
                        { "BattleNetLibrary", "BattlenetLibrary_Builtin" },
                        { "BethesdaLibrary", "BethesdaLibrary_Builtin" },
                        { "EpicLibrary", "EpicGamesLibrary_Builtin" },
                        { "GogLibrary", "GogLibrary_Builtin" },
                        { "HumbleLibrary", "HumbleLibrary_Builtin" },
                        { "IGDBMetadata", "IGDBMetadata_Builtin" },
                        { "ItchioLibrary", "ItchioLibrary_Builtin" },
                        { "LibraryExporter", "LibraryExporterPS_Builtin" },
                        { "OriginLibrary", "OriginLibrary_Builtin" },
                        { "PSNLibrary", "PlayStationLibrary_Builtin" },
                        { "SteamLibrary", "SteamLibrary_Builtin" },
                        { "TwitchLibrary", "TwitchLibrary_Builtin" },
                        { "UplayLibrary", "UplayLibrary_Builtin" },
                        { "XboxLibrary", "XboxLibrary_Builtin" }
                    };

                    for (int i = 0; i < settings.DisabledPlugins.Count; i++)
                    {
                        if (idsMigration.TryGetValue(settings.DisabledPlugins[i], out var newValue))
                        {
                            settings.DisabledPlugins[i] = newValue;
                        }
                    }
                }

                settings.ViewSettings.ListViewColumns.AgeRating.Field = GameField.AgeRatings;
                settings.ViewSettings.ListViewColumns.Platform.Field = GameField.Platforms;
                settings.ViewSettings.ListViewColumns.Series.Field = GameField.Series;
                settings.ViewSettings.ListViewColumns.Region.Field = GameField.Regions;
                settings.Version = 6;
            }

            if (settings.Version == 6)
            {
                var oldSettings = LoadSettingFile<Dictionary<string, object>>(PlaynitePaths.ConfigFilePath);
                if (oldSettings != null)
                {
                    if (oldSettings.TryGetValue("UpdateLibStartup", out var oldUpdateLibStartup) && (bool)oldUpdateLibStartup == false)
                    {
                        settings.CheckForLibraryUpdates = LibraryUpdateCheckFrequency.Manually;
                    }

                    if (oldSettings.TryGetValue("UpdateEmulatedLibStartup", out var oldUpdateEmulatedLibStartup) && (bool)oldUpdateEmulatedLibStartup == false)
                    {
                        settings.CheckForEmulatedLibraryUpdates = LibraryUpdateCheckFrequency.Manually;
                    }

                    if (oldSettings.TryGetValue("ForcePlayTimeSync", out var oldForcePlayTimeSync) && (bool)oldForcePlayTimeSync == true)
                    {
                        settings.PlaytimeImportMode = PlaytimeImportMode.Always;
                    }
                }

                settings.Version = 7;
            }

            settings.WindowPositions = LoadExternalConfig<WindowPositions>(PlaynitePaths.WindowPositionsPath, PlaynitePaths.BackupWindowPositionsPath);
            settings.Fullscreen = LoadExternalConfig<FullscreenSettings>(PlaynitePaths.FullscreenConfigFilePath, PlaynitePaths.BackupFullscreenConfigFilePath);
            settings.BackupSettings();
            return settings;
        }

        private static T LoadExternalConfig<T>(string origPath, string backupPath, bool generateDefault = true) where T : class, new()
        {
            var name = Path.GetFileName(origPath);
            var config = LoadSettingFile<T>(origPath);
            if (config == null)
            {
                logger.Warn($"No existing {name} settings found.");
                config = LoadSettingFile<T>(backupPath);
                if (config == null)
                {
                    logger.Warn($"No {name} settings backup found, creating default ones.");
                    if (generateDefault)
                    {
                        config = new T();
                    }
                }
            }

            return config;
        }

        public void SaveSettings()
        {
            try
            {
                FileSystem.CreateDirectory(PlaynitePaths.ConfigRootPath);
                SaveSettingFile(this, PlaynitePaths.ConfigFilePath);
                SaveSettingFile(WindowPositions, PlaynitePaths.WindowPositionsPath);
                SaveSettingFile(Fullscreen, PlaynitePaths.FullscreenConfigFilePath);
            }
            catch (Exception e) when (!PlayniteEnvironment.ThrowAllErrors)
            {
                logger.Error(e, "Failed to save application settings.");
            }
        }

        public void BackupSettings()
        {
            try
            {
                FileSystem.CreateDirectory(PlaynitePaths.ConfigRootPath);
                SaveSettingFile(this, PlaynitePaths.BackupConfigFilePath);
                SaveSettingFile(WindowPositions, PlaynitePaths.BackupWindowPositionsPath);
                SaveSettingFile(Fullscreen, PlaynitePaths.BackupFullscreenConfigFilePath);
            }
            catch (Exception e) when (!PlayniteEnvironment.ThrowAllErrors)
            {
                logger.Error(e, "Failed to backup application settings.");
            }
        }

        public static void ConfigureLogger()
        {
            var config = new LoggingConfiguration();
            config.DefaultCultureInfo = new System.Globalization.CultureInfo("en-US");
#if DEBUG
            var consoleTarget = new ColoredConsoleTarget()
            {
                Layout = @"${level:uppercase=true:padding=-5}|${logger}:${message}${onexception:${newline}${exception}}"
            };

            config.AddTarget("console", consoleTarget);

            var rule1 = new LoggingRule("*", LogLevel.Trace, consoleTarget);
            config.LoggingRules.Add(rule1);
#endif
            var coreFileTarget = new FileTarget()
            {
                FileName = Path.Combine(PlaynitePaths.ConfigRootPath, "playnite.log"),
                Layout = "${date:format=dd-MM HH\\:mm\\:ss.fff}|${level:uppercase=true:padding=-5}|${logger}:${message}${onexception:${newline}${exception:format=toString}}",
                KeepFileOpen = false,
                ArchiveFileName = Path.Combine(PlaynitePaths.ConfigRootPath, "playnite.{#####}.log"),
                ArchiveAboveSize = 4096000,
                ArchiveNumbering = ArchiveNumberingMode.Sequence,
                MaxArchiveFiles = 2,
                Encoding = Encoding.UTF8
            };

            var extensionFileTarget = new FileTarget()
            {
                FileName = Path.Combine(PlaynitePaths.ConfigRootPath, "extensions.log"),
                Layout = "${date:format=dd-MM HH\\:mm\\:ss.fff}|${level:uppercase=true:padding=-5}|${logger}:${message}${onexception:${newline}${exception:format=toString}}",
                KeepFileOpen = false,
                ArchiveFileName = Path.Combine(PlaynitePaths.ConfigRootPath, "extensions.{#####}.log"),
                ArchiveAboveSize = 4096000,
                ArchiveNumbering = ArchiveNumberingMode.Sequence,
                MaxArchiveFiles = 2,
                Encoding = Encoding.UTF8
            };

            var allRule = new LoggingRule("*", LogLevel.Trace, coreFileTarget);
            allRule.Filters.Add(new NLog.Filters.ConditionBasedFilter()
            {
                Condition = "contains('${logger}', '#')",
                Action = NLog.Filters.FilterResult.Ignore
            });

            config.LoggingRules.Add(allRule);
            config.LoggingRules.Add(new LoggingRule("*#*", LogLevel.Trace, extensionFileTarget));

            NLog.LogManager.Configuration = config;
            SDK.LogManager.Init(new NLogLogProvider());
            logger = SDK.LogManager.GetLogger();
        }

        public static string GetAppConfigValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static bool GetAppConfigBoolValue(string key)
        {
            if (bool.TryParse(ConfigurationManager.AppSettings[key], out var result))
            {
                return result;
            }
            else
            {
                return false;
            }
        }

        public static void MigrateSettingsConfig()
        {
        }

        private Thickness GetItemSpacingMargin()
        {
            return new Thickness(GridItemSpacing / 2, GridItemSpacing / 2, GridItemSpacing / 2, GridItemSpacing / 2);;
        }

        private Thickness GetFullscreenItemSpacingMargin()
        {
            double marginX = FullscreenItemSpacing / 2;
            double marginY = CoverAspectRatio.GetWidth(FullscreenItemSpacing) / 2;
            return new Thickness(marginY / 2, marginX / 2, marginY / 2, marginX / 2);
        }

        private void UpdateGridItemHeight()
        {
            if (GridItemWidth != 0)
            {
                GridItemHeight = Math.Round(GridItemWidth * ((double)gridItemHeightRatio / GridItemWidthRatio));
            }
            else
            {
                GridItemHeight = 0;
            }

            OnPropertyChanged(nameof(GridItemHeight));
        }

        public bool ShouldCheckProgramUpdatePeriodic()
        {
            switch (CheckForProgramUpdates)
            {
                case UpdateCheckFrequency.OnceADay:
                    return DateTimes.Now.Date != LastProgramUpdateCheck.Date;
                case UpdateCheckFrequency.OnceAWeek:
                    return (DateTimes.Now - LastProgramUpdateCheck).TotalDays > 6;
                case UpdateCheckFrequency.OnEveryStartup:
                default:
                    return false;
            }
        }

        public bool ShouldCheckAddonUpdatePeriodic()
        {
            switch (CheckForAddonUpdates)
            {
                case UpdateCheckFrequency.OnceADay:
                    return DateTimes.Now.Date != LastAddonUpdateCheck.Date;
                case UpdateCheckFrequency.OnceAWeek:
                    return (DateTimes.Now - LastAddonUpdateCheck).TotalDays > 6;
                case UpdateCheckFrequency.OnEveryStartup:
                default:
                    return false;
            }
        }

        public bool ShouldCheckProgramUpdateStartup()
        {
            switch (CheckForProgramUpdates)
            {
                case UpdateCheckFrequency.OnceADay:
                    return DateTimes.Now.Date != LastProgramUpdateCheck.Date;
                case UpdateCheckFrequency.OnceAWeek:
                    return (DateTimes.Now - LastProgramUpdateCheck).TotalDays > 6;
                case UpdateCheckFrequency.OnEveryStartup:
                default:
                    return true;
            }
        }

        public bool ShouldCheckAddonUpdateStartup()
        {
            switch (CheckForAddonUpdates)
            {
                case UpdateCheckFrequency.OnceADay:
                    return DateTimes.Now.Date != LastAddonUpdateCheck.Date;
                case UpdateCheckFrequency.OnceAWeek:
                    return (DateTimes.Now - LastAddonUpdateCheck).TotalDays > 6;
                case UpdateCheckFrequency.OnEveryStartup:
                default:
                    return true;
            }
        }

        public bool ShouldCheckLibraryOnStartup()
        {
            switch (CheckForLibraryUpdates)
            {
                case LibraryUpdateCheckFrequency.OnceADay:
                    return DateTimes.Now.Date != LastLibraryUpdateCheck.Date;
                case LibraryUpdateCheckFrequency.OnceAWeek:
                    return (DateTimes.Now - LastLibraryUpdateCheck).TotalDays > 6;
                case LibraryUpdateCheckFrequency.Manually:
                    return false;
                case LibraryUpdateCheckFrequency.OnEveryStartup:
                default:
                    return true;
            }
        }

        public bool ShouldCheckEmuLibraryOnStartup()
        {
            switch (CheckForEmulatedLibraryUpdates)
            {
                case LibraryUpdateCheckFrequency.OnceADay:
                    return DateTimes.Now.Date != LastEmuLibraryUpdateCheck.Date;
                case LibraryUpdateCheckFrequency.OnceAWeek:
                    return (DateTimes.Now - LastEmuLibraryUpdateCheck).TotalDays > 6;
                case LibraryUpdateCheckFrequency.Manually:
                    return false;
                case LibraryUpdateCheckFrequency.OnEveryStartup:
                default:
                    return true;
            }
        }

        public bool ShouldDataBackupOnStartup()
        {
            if (!AutoBackupEnabled)
            {
                return false;
            }

            switch (AutoBackupFrequency)
            {
                case AutoBackupFrequency.OnceADay:
                    return DateTimes.Now.Date != LastAutoBackup.Date;
                case AutoBackupFrequency.OnceAWeek:
                    return (DateTimes.Now - LastAutoBackup).TotalDays > 6;
                default:
                    return false;
            }
        }
    }
}
