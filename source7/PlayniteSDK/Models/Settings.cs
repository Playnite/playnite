using System.ComponentModel;

namespace Playnite;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public enum AgeRatingOrg
{
    PEGI,
    ESRB,
    CERO,
    USK,
    GRAC,
    CLASSIND,
    ACB
}

public enum SortOrder : int
{
    [Description(LocId.game_name_title)]            Name = 0,
    [Description(LocId.platform_title)]             Platforms = 1,
    [Description(LocId.game_provider_title)]        Library = 2,
    [Description(LocId.category_label)]             Categories = 3,
    [Description(LocId.game_last_activity_title)]   LastActivity = 4,
    [Description(LocId.genre_label)]                Genres = 5,
    [Description(LocId.game_release_date_title)]    ReleaseDate = 6,
    [Description(LocId.developer_label)]            Developers = 7,
    [Description(LocId.publisher_label)]            Publishers = 8,
    [Description(LocId.tag_label)]                  Tags = 9,
    [Description(LocId.series_label)]               Series = 10,
    [Description(LocId.age_rating_label)]           AgeRatings = 11,
    [Description(LocId.version_label)]              Version = 12,
    [Description(LocId.region_label)]               Regions = 13,
    [Description(LocId.source_label)]               Source = 14,
    [Description(LocId.play_count_label)]           PlayCount = 15,
    [Description(LocId.time_played)]                Playtime = 16,
    [Description(LocId.completion_status)]          CompletionStatus = 17,
    [Description(LocId.user_score)]                 UserScore = 18,
    [Description(LocId.critic_score)]               CriticScore = 19,
    [Description(LocId.community_score)]            CommunityScore = 20,
    [Description(LocId.date_added_label)]           Added = 21,
    [Description(LocId.date_modified_label)]        Modified = 22,
    [Description(LocId.game_installation_status)]   IsInstalled = 23,
    [Description(LocId.game_hidden_title)]          Hidden = 24,
    [Description(LocId.game_favorite_title)]        Favorite = 25,
    [Description(LocId.game_install_dir_title)]     InstallDirectory = 26,
    [Description(LocId.feature_label)]              Features = 27,
    [Description(LocId.install_size_label)]         InstallSize = 28,
    [Description(LocId.recent_activity_label)]      RecentActivity = 29,
    [Description(LocId.game_rom_title)]             RomList = 30,
}

public enum SortOrderDirection : int
{
    [Description(LocId.menu_sort_ascending)]    Ascending = 0,
    [Description(LocId.menu_sort_descending)]   Descending = 1
}

public enum GroupableField : int
{
    [Description(LocId.menu_group_no_group)]        None = 0,
    [Description(LocId.platform_title)]             Platform = 1,
    [Description(LocId.game_provider_title)]        Library = 2,
    [Description(LocId.category_label)]             Category = 3,
    [Description(LocId.game_last_activity_title)]   LastActivity = 4,
    [Description(LocId.genre_label)]                Genre = 5,
    [Description(LocId.game_release_year_title)]    ReleaseYear = 6,
    [Description(LocId.developer_label)]            Developer = 7,
    [Description(LocId.publisher_label)]            Publisher = 8,
    [Description(LocId.tag_label)]                  Tag = 9,
    [Description(LocId.series_label)]               Series = 10,
    [Description(LocId.age_rating_label)]           AgeRating = 11,
    [Description(LocId.region_label)]               Region = 12,
    [Description(LocId.source_label)]               Source = 13,
    [Description(LocId.time_played)]                PlayTime = 14,
    [Description(LocId.completion_status)]          CompletionStatus = 15,
    [Description(LocId.user_score)]                 UserScore = 16,
    [Description(LocId.critic_score)]               CriticScore = 17,
    [Description(LocId.community_score)]            CommunityScore = 18,
    [Description(LocId.date_added_label)]           Added = 19,
    [Description(LocId.date_modified_label)]        Modified = 20,
    [Description(LocId.feature_label)]              Feature = 21,
    [Description(LocId.game_installation_status)]   InstallationStatus = 22,
    [Description(LocId.game_name_title)]            Name = 23,
    [Description(LocId.install_drive_title)]        InstallDrive = 24,
    [Description(LocId.install_size_label)]         InstallSize = 25,
    [Description(LocId.recent_activity_label)]      RecentActivity = 26
}

public enum DesktopView : int
{
    [Description(LocId.details_view_label)] Details = 0,
    [Description(LocId.grid_view_label)]    Grid = 1,
    [Description(LocId.list_view_label)]    List = 2
}

public enum ApplicationMode
{
    Desktop,
    Fullscreen
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
