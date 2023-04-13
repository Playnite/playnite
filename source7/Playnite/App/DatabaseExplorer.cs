using System.ComponentModel;

namespace Playnite;

public enum ExplorerField
{
    [Description(LocId.settings_top_panel_filter_presets_item)] Presets,
    [Description(LocId.platforms_title)]                        Platform,
    [Description(LocId.game_provider_title)]                    Library,
    [Description(LocId.category_label)]                         Category,
    [Description(LocId.game_last_activity_title)]               LastActivity,
    [Description(LocId.recent_activity_label)]                  RecentActivity,
    [Description(LocId.genre_label)]                            Genre,
    [Description(LocId.game_release_year_title)]                ReleaseYear,
    [Description(LocId.developer_label)]                        Developer,
    [Description(LocId.publisher_label)]                        Publisher,
    [Description(LocId.tag_label)]                              Tag,
    [Description(LocId.series_label)]                           Series,
    [Description(LocId.age_rating_label)]                       AgeRating,
    [Description(LocId.region_label)]                           Region,
    [Description(LocId.source_label)]                           Source,
    [Description(LocId.time_played)]                            PlayTime,
    [Description(LocId.install_size_label)]                     InstallSize,
    [Description(LocId.completion_status)]                      CompletionStatus,
    [Description(LocId.user_score)]                             UserScore,
    [Description(LocId.critic_score)]                           CriticScore,
    [Description(LocId.community_score)]                        CommunityScore,
    [Description(LocId.date_added_label)]                       Added,
    [Description(LocId.date_modified_label)]                    Modified,
    [Description(LocId.feature_label)]                          Feature,
    [Description(LocId.game_name_title)]                        Name
}