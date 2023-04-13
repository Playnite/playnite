namespace Playnite;

public static partial class Loc
{

    public static string language_name()
    {
        return GetString("language-name");
    }
    public static string language_settings_label()
    {
        return GetString("language-settings-label");
    }
    public static string exit_app_label()
    {
        return GetString("exit-app-label");
    }
    public static string filter_active_label()
    {
        return GetString("filter-active-label");
    }
    public static string filter_inactive_label()
    {
        return GetString("filter-inactive-label");
    }
    public static string additional_filters()
    {
        return GetString("additional-filters");
    }
    public static string filters()
    {
        return GetString("filters");
    }
    public static string filter()
    {
        return GetString("filter");
    }
    public static string invalid_data_title()
    {
        return GetString("invalid-data-title");
    }
    public static string save_changes_ask_title()
    {
        return GetString("save-changes-ask-title");
    }
    public static string about_home_page_link()
    {
        return GetString("about-home-page-link");
    }
    public static string about_source_link()
    {
        return GetString("about-source-link");
    }
    public static string about_create_diag_button()
    {
        return GetString("about-create-diag-button");
    }
    public static string about_send_diag_button()
    {
        return GetString("about-send-diag-button");
    }
    public static string about_window_title()
    {
        return GetString("about-window-title");
    }
    public static string about_author()
    {
        return GetString("about-author");
    }
    public static string category_window_title()
    {
        return GetString("category-window-title");
    }
    public static string category_set_button()
    {
        return GetString("category-set-button");
    }
    public static string category_add_cat_button()
    {
        return GetString("category-add-cat-button");
    }
    public static string category_tooltip()
    {
        return GetString("category-tooltip");
    }
    public static string no_category()
    {
        return GetString("no-category");
    }
    public static string no_platform()
    {
        return GetString("no-platform");
    }
    public static string crash_window_title()
    {
        return GetString("crash-window-title");
    }
    public static string crash_description()
    {
        return GetString("crash-description");
    }
    public static string ext_crash_description(object name)
    {
        return GetString("ext-crash-description", ("name", name));
    }
    public static string ext_crash_description_fs(object name)
    {
        return GetString("ext-crash-description-fs", ("name", name));
    }
    public static string ext_crash_description_unknown()
    {
        return GetString("ext-crash-description-unknown");
    }
    public static string crash_description_fullscreen()
    {
        return GetString("crash-description-fullscreen");
    }
    public static string crash_disable_extension()
    {
        return GetString("crash-disable-extension");
    }
    public static string crash_save_log()
    {
        return GetString("crash-save-log");
    }
    public static string crash_send_diag()
    {
        return GetString("crash-send-diag");
    }
    public static string crash_report_issue()
    {
        return GetString("crash-report-issue");
    }
    public static string crash_restart_playnite()
    {
        return GetString("crash-restart-playnite");
    }
    public static string crash_restart_safe()
    {
        return GetString("crash-restart-safe");
    }
    public static string crash_restart_safe_tooltip()
    {
        return GetString("crash-restart-safe-tooltip");
    }
    public static string crash_close_playnite()
    {
        return GetString("crash-close-playnite");
    }
    public static string crash_user_actions_description()
    {
        return GetString("crash-user-actions-description");
    }
    public static string library_manager()
    {
        return GetString("library-manager");
    }
    public static string game_remove_ask_title()
    {
        return GetString("game-remove-ask-title");
    }
    public static string game_remove_running_error()
    {
        return GetString("game-remove-running-error");
    }
    public static string game_uninstall_running_error()
    {
        return GetString("game-uninstall-running-error");
    }
    public static string game_remove_ask_message(object gameName)
    {
        return GetString("game-remove-ask-message", ("gameName", gameName));
    }
    public static string games_remove_ask_message(object gameCount)
    {
        return GetString("games-remove-ask-message", ("gameCount", gameCount));
    }
    public static string game_remove_ask_message_ignore_option(object gameName)
    {
        return GetString("game-remove-ask-message-ignore-option", ("gameName", gameName));
    }
    public static string games_remove_ask_message_ignore_option(object gameCount)
    {
        return GetString("games-remove-ask-message-ignore-option", ("gameCount", gameCount));
    }
    public static string remove_unused_fields_ask_message(object entryCount)
    {
        return GetString("remove-unused-fields-ask-message", ("entryCount", entryCount));
    }
    public static string remove_unused_fields_no_unused_message()
    {
        return GetString("remove-unused-fields-no-unused-message");
    }
    public static string remove_ask_add_to_exclusion_list_yes_response()
    {
        return GetString("remove-ask-add-to-exclusion-list-yes-response");
    }
    public static string game_edit_change_notif()
    {
        return GetString("game-edit-change-notif");
    }
    public static string db_upgrade_progress()
    {
        return GetString("db-upgrade-progress");
    }
    public static string db_upgrade_fail()
    {
        return GetString("db-upgrade-fail");
    }
    public static string db_upgrade_empty_space_fail(object megaBytes)
    {
        return GetString("db-upgrade-empty-space-fail", ("megaBytes", megaBytes));
    }
    public static string game_error()
    {
        return GetString("game-error");
    }
    public static string game_start_error_no_game(object gameId)
    {
        return GetString("game-start-error-no-game", ("gameId", gameId));
    }
    public static string game_start_error()
    {
        return GetString("game-start-error");
    }
    public static string game_start_action_error()
    {
        return GetString("game-start-action-error");
    }
    public static string game_open_location_error()
    {
        return GetString("game-open-location-error");
    }
    public static string calculate_game_size_error()
    {
        return GetString("calculate-game-size-error");
    }
    public static string calculate_game_size_error_caption()
    {
        return GetString("calculate-game-size-error-caption");
    }
    public static string calculate_games_size_error_message(object errorCount)
    {
        return GetString("calculate-games-size-error-message", ("errorCount", errorCount));
    }
    public static string game_shortcut_error()
    {
        return GetString("game-shortcut-error");
    }
    public static string manual_open_error()
    {
        return GetString("manual-open-error");
    }
    public static string game_install_error()
    {
        return GetString("game-install-error");
    }
    public static string game_uninstall_error()
    {
        return GetString("game-uninstall-error");
    }
    public static string error_no_play_action()
    {
        return GetString("error-no-play-action");
    }
    public static string error_no_install_action()
    {
        return GetString("error-no-install-action");
    }
    public static string error_library_plugin_not_found()
    {
        return GetString("error-library-plugin-not-found");
    }
    public static string error_no_metadata_downloader()
    {
        return GetString("error-no-metadata-downloader");
    }
    public static string error_no_game_selected()
    {
        return GetString("error-no-game-selected");
    }
    public static string error_game_script_action()
    {
        return GetString("error-game-script-action");
    }
    public static string error_application_script()
    {
        return GetString("error-application-script");
    }
    public static string error_global_script_action()
    {
        return GetString("error-global-script-action");
    }
    public static string error_emulator_script_action()
    {
        return GetString("error-emulator-script-action");
    }
    public static string error_play_script_action()
    {
        return GetString("error-play-script-action");
    }
    public static string error_power_shell_not_installed()
    {
        return GetString("error-power-shell-not-installed");
    }
    public static string error_startup_no_controller()
    {
        return GetString("error-startup-no-controller");
    }
    public static string enabled_title()
    {
        return GetString("enabled-title");
    }
    public static string remove_title()
    {
        return GetString("remove-title");
    }
    public static string remove_unused_title()
    {
        return GetString("remove-unused-title");
    }
    public static string rename_title()
    {
        return GetString("rename-title");
    }
    public static string copy_title()
    {
        return GetString("copy-title");
    }
    public static string add_title()
    {
        return GetString("add-title");
    }
    public static string default_icon_title()
    {
        return GetString("default-icon-title");
    }
    public static string default_cover_title()
    {
        return GetString("default-cover-title");
    }
    public static string default_background_title()
    {
        return GetString("default-background-title");
    }
    public static string finish_label()
    {
        return GetString("finish-label");
    }
    public static string next_label()
    {
        return GetString("next-label");
    }
    public static string back_label()
    {
        return GetString("back-label");
    }
    public static string done_cap_label()
    {
        return GetString("done-cap-label");
    }
    public static string back_cap_label()
    {
        return GetString("back-cap-label");
    }
    public static string clear_cap_label()
    {
        return GetString("clear-cap-label");
    }
    public static string clear_label()
    {
        return GetString("clear-label");
    }
    public static string dismiss()
    {
        return GetString("dismiss");
    }
    public static string dismiss_all()
    {
        return GetString("dismiss-all");
    }
    public static string import_label()
    {
        return GetString("import-label");
    }
    public static string name_label()
    {
        return GetString("name-label");
    }
    public static string author_label()
    {
        return GetString("author-label");
    }
    public static string module_label()
    {
        return GetString("module-label");
    }
    public static string series_label()
    {
        return GetString("series-label");
    }
    public static string version_label()
    {
        return GetString("version-label");
    }
    public static string last_played_label()
    {
        return GetString("last-played-label");
    }
    public static string most_played_label()
    {
        return GetString("most-played-label");
    }
    public static string play_count_label()
    {
        return GetString("play-count-label");
    }
    public static string install_size_label()
    {
        return GetString("install-size-label");
    }
    public static string folder_label()
    {
        return GetString("folder-label");
    }
    public static string notes_label()
    {
        return GetString("notes-label");
    }
    public static string added_label()
    {
        return GetString("added-label");
    }
    public static string date_added_label()
    {
        return GetString("date-added-label");
    }
    public static string modified_label()
    {
        return GetString("modified-label");
    }
    public static string date_modified_label()
    {
        return GetString("date-modified-label");
    }
    public static string website_label()
    {
        return GetString("website-label");
    }
    public static string path_label()
    {
        return GetString("path-label");
    }
    public static string ok_label()
    {
        return GetString("ok-label");
    }
    public static string save_label()
    {
        return GetString("save-label");
    }
    public static string close_label()
    {
        return GetString("close-label");
    }
    public static string cancel_label()
    {
        return GetString("cancel-label");
    }
    public static string confirm_label()
    {
        return GetString("confirm-label");
    }
    public static string reset_label()
    {
        return GetString("reset-label");
    }
    public static string yes_label()
    {
        return GetString("yes-label");
    }
    public static string no_label()
    {
        return GetString("no-label");
    }
    public static string welcome_label()
    {
        return GetString("welcome-label");
    }
    public static string local_user_label()
    {
        return GetString("local-user-label");
    }
    public static string general_label()
    {
        return GetString("general-label");
    }
    public static string media_label()
    {
        return GetString("media-label");
    }
    public static string links_label()
    {
        return GetString("links-label");
    }
    public static string installation_label()
    {
        return GetString("installation-label");
    }
    public static string actions_label()
    {
        return GetString("actions-label");
    }
    public static string downloading_label()
    {
        return GetString("downloading-label");
    }
    public static string downloading_media_label()
    {
        return GetString("downloading-media-label");
    }
    public static string loading_label()
    {
        return GetString("loading-label");
    }
    public static string type_label()
    {
        return GetString("type-label");
    }
    public static string profile_label()
    {
        return GetString("profile-label");
    }
    public static string profiles_label()
    {
        return GetString("profiles-label");
    }
    public static string remove_label()
    {
        return GetString("remove-label");
    }
    public static string download_label()
    {
        return GetString("download-label");
    }
    public static string search_label()
    {
        return GetString("search-label");
    }
    public static string search_resolution_label()
    {
        return GetString("search-resolution-label");
    }
    public static string search_resolution_any_label()
    {
        return GetString("search-resolution-any-label");
    }
    public static string zoom_label()
    {
        return GetString("zoom-label");
    }
    public static string list_view_label()
    {
        return GetString("list-view-label");
    }
    public static string covers_label()
    {
        return GetString("covers-label");
    }
    public static string grid_view_label()
    {
        return GetString("grid-view-label");
    }
    public static string details_view_label()
    {
        return GetString("details-view-label");
    }
    public static string custom_label()
    {
        return GetString("custom-label");
    }
    public static string url_label()
    {
        return GetString("url-label");
    }
    public static string patrons_label()
    {
        return GetString("patrons-label");
    }
    public static string license_label()
    {
        return GetString("license-label");
    }
    public static string contributors_label()
    {
        return GetString("contributors-label");
    }
    public static string closing_playnite()
    {
        return GetString("closing-playnite");
    }
    public static string today()
    {
        return GetString("today");
    }
    public static string yesterday()
    {
        return GetString("yesterday");
    }
    public static string monday()
    {
        return GetString("monday");
    }
    public static string tuesday()
    {
        return GetString("tuesday");
    }
    public static string wednesday()
    {
        return GetString("wednesday");
    }
    public static string thursday()
    {
        return GetString("thursday");
    }
    public static string friday()
    {
        return GetString("friday");
    }
    public static string saturday()
    {
        return GetString("saturday");
    }
    public static string sunday()
    {
        return GetString("sunday");
    }
    public static string past_week()
    {
        return GetString("past-week");
    }
    public static string past_month()
    {
        return GetString("past-month");
    }
    public static string past_year()
    {
        return GetString("past-year");
    }
    public static string more_then_year()
    {
        return GetString("more-then-year");
    }
    public static string size_zero_to100_mb()
    {
        return GetString("size-zero-to100-mb");
    }
    public static string size100_mb_to1_gb()
    {
        return GetString("size100-mb-to1-gb");
    }
    public static string size1_gb_to5_gb()
    {
        return GetString("size1-gb-to5-gb");
    }
    public static string size5_gb_to10_gb()
    {
        return GetString("size5-gb-to10-gb");
    }
    public static string size10_gb_to20_gb()
    {
        return GetString("size10-gb-to20-gb");
    }
    public static string size20_gb_to40_gb()
    {
        return GetString("size20-gb-to40-gb");
    }
    public static string size40_gb_to100_gb()
    {
        return GetString("size40-gb-to100-gb");
    }
    public static string size_more_than100_gb()
    {
        return GetString("size-more-than100-gb");
    }
    public static string import_completed()
    {
        return GetString("import-completed");
    }
    public static string all_games()
    {
        return GetString("all-games");
    }
    public static string game_id()
    {
        return GetString("game-id");
    }
    public static string database_id()
    {
        return GetString("database-id");
    }
    public static string presets()
    {
        return GetString("presets");
    }
    public static string column()
    {
        return GetString("column");
    }
    public static string columns()
    {
        return GetString("columns");
    }
    public static string row()
    {
        return GetString("row");
    }
    public static string rows()
    {
        return GetString("rows");
    }
    public static string exec_icon_missing_play_action()
    {
        return GetString("exec-icon-missing-play-action");
    }
    public static string meta_skip_non_empty()
    {
        return GetString("meta-skip-non-empty");
    }
    public static string meta_skip_non_empty_tooltip()
    {
        return GetString("meta-skip-non-empty-tooltip");
    }
    public static string meta_games_source_intro()
    {
        return GetString("meta-games-source-intro");
    }
    public static string meta_games_source_description()
    {
        return GetString("meta-games-source-description");
    }
    public static string meta_game_source_all()
    {
        return GetString("meta-game-source-all");
    }
    public static string meta_game_source_filtered()
    {
        return GetString("meta-game-source-filtered");
    }
    public static string meta_game_source_selected()
    {
        return GetString("meta-game-source-selected");
    }
    public static string meta_source_store()
    {
        return GetString("meta-source-store");
    }
    public static string meta_source_igdb()
    {
        return GetString("meta-source-igdb");
    }
    public static string meta_description_fields()
    {
        return GetString("meta-description-fields");
    }
    public static string meta_igdb_contrib_notif()
    {
        return GetString("meta-igdb-contrib-notif");
    }
    public static string progress_metadata()
    {
        return GetString("progress-metadata");
    }
    public static string progress_installed_games()
    {
        return GetString("progress-installed-games");
    }
    public static string progress_importing_games(object libraryName)
    {
        return GetString("progress-importing-games", ("libraryName", libraryName));
    }
    public static string progress_importing_emulated_games(object scannerName)
    {
        return GetString("progress-importing-emulated-games", ("scannerName", scannerName));
    }
    public static string progress_library_games()
    {
        return GetString("progress-library-games");
    }
    public static string progress_scanning_games_install_size()
    {
        return GetString("progress-scanning-games-install-size");
    }
    public static string progress_scanning_imported_games_install_size()
    {
        return GetString("progress-scanning-imported-games-install-size");
    }
    public static string progress_lib_import_finish()
    {
        return GetString("progress-lib-import-finish");
    }
    public static string progress_releasing_resources()
    {
        return GetString("progress-releasing-resources");
    }
    public static string menu_configuration_title()
    {
        return GetString("menu-configuration-title");
    }
    public static string menu_playnite_settings_title()
    {
        return GetString("menu-playnite-settings-title");
    }
    public static string menu_platform_emulator_settings_title()
    {
        return GetString("menu-platform-emulator-settings-title");
    }
    public static string menu_configure_emulators_menu_title()
    {
        return GetString("menu-configure-emulators-menu-title");
    }
    public static string menu_library_manager_title()
    {
        return GetString("menu-library-manager-title");
    }
    public static string menu_tools()
    {
        return GetString("menu-tools");
    }
    public static string menu_download_metadata()
    {
        return GetString("menu-download-metadata");
    }
    public static string menu_software_tools()
    {
        return GetString("menu-software-tools");
    }
    public static string menu_configure_integrations()
    {
        return GetString("menu-configure-integrations");
    }
    public static string menu_open_client()
    {
        return GetString("menu-open-client");
    }
    public static string menu_clients()
    {
        return GetString("menu-clients");
    }
    public static string menu_reload_library()
    {
        return GetString("menu-reload-library");
    }
    public static string menu_cancel_library_update()
    {
        return GetString("menu-cancel-library-update");
    }
    public static string menu_update_emulated_dirs()
    {
        return GetString("menu-update-emulated-dirs");
    }
    public static string menu_add_game()
    {
        return GetString("menu-add-game");
    }
    public static string menu_add_game_manual()
    {
        return GetString("menu-add-game-manual");
    }
    public static string menu_add_game_installed()
    {
        return GetString("menu-add-game-installed");
    }
    public static string menu_add_game_emulated()
    {
        return GetString("menu-add-game-emulated");
    }
    public static string menu_add_windows_store()
    {
        return GetString("menu-add-windows-store");
    }
    public static string menu_about()
    {
        return GetString("menu-about");
    }
    public static string menu_issues()
    {
        return GetString("menu-issues");
    }
    public static string menu_open_fullscreen()
    {
        return GetString("menu-open-fullscreen");
    }
    public static string menu_links_title()
    {
        return GetString("menu-links-title");
    }
    public static string menu_help_title()
    {
        return GetString("menu-help-title");
    }
    public static string menu_patreon_support()
    {
        return GetString("menu-patreon-support");
    }
    public static string sdk_documentation()
    {
        return GetString("sdk-documentation");
    }
    public static string menu_restart_system()
    {
        return GetString("menu-restart-system");
    }
    public static string menu_shutdown_system()
    {
        return GetString("menu-shutdown-system");
    }
    public static string menu_suspend_system()
    {
        return GetString("menu-suspend-system");
    }
    public static string menu_hibernate_system()
    {
        return GetString("menu-hibernate-system");
    }
    public static string menu_select_random_game()
    {
        return GetString("menu-select-random-game");
    }
    public static string settings_details_panel_items()
    {
        return GetString("settings-details-panel-items");
    }
    public static string settings_grid_item_spacing()
    {
        return GetString("settings-grid-item-spacing");
    }
    public static string settings_grid_item_draw_background()
    {
        return GetString("settings-grid-item-draw-background");
    }
    public static string settings_grid_item_cover_margin()
    {
        return GetString("settings-grid-item-cover-margin");
    }
    public static string settings_default_icon_source()
    {
        return GetString("settings-default-icon-source");
    }
    public static string settings_default_cover_source()
    {
        return GetString("settings-default-cover-source");
    }
    public static string settings_default_background_source()
    {
        return GetString("settings-default-background-source");
    }
    public static string settings_indent_game_details()
    {
        return GetString("settings-indent-game-details");
    }
    public static string settings_grid_view_details_position()
    {
        return GetString("settings-grid-view-details-position");
    }
    public static string settings_details_game_list_position()
    {
        return GetString("settings-details-game-list-position");
    }
    public static string settings_draw_panel_separators()
    {
        return GetString("settings-draw-panel-separators");
    }
    public static string settings_game_details_cover_height()
    {
        return GetString("settings-game-details-cover-height");
    }
    public static string settings_game_details_list_icon_size()
    {
        return GetString("settings-game-details-list-icon-size");
    }
    public static string settings_interface_font()
    {
        return GetString("settings-interface-font");
    }
    public static string settings_interface_mono_font()
    {
        return GetString("settings-interface-mono-font");
    }
    public static string settings_filter_panel_position()
    {
        return GetString("settings-filter-panel-position");
    }
    public static string settings_explorer_panel_position()
    {
        return GetString("settings-explorer-panel-position");
    }
    public static string settings_cover_art_rendering_label()
    {
        return GetString("settings-cover-art-rendering-label");
    }
    public static string settings_target_aspect_ratio_label()
    {
        return GetString("settings-target-aspect-ratio-label");
    }
    public static string settings_grid_tile_layout_fsnote()
    {
        return GetString("settings-grid-tile-layout-fsnote");
    }
    public static string settings_stretch_mode_label()
    {
        return GetString("settings-stretch-mode-label");
    }
    public static string settings_covert_aspect_dvd()
    {
        return GetString("settings-covert-aspect-dvd");
    }
    public static string settings_covert_aspect_epic_games_store()
    {
        return GetString("settings-covert-aspect-epic-games-store");
    }
    public static string settings_covert_aspect_gog_galaxy2()
    {
        return GetString("settings-covert-aspect-gog-galaxy2");
    }
    public static string settings_covert_aspect_igdb()
    {
        return GetString("settings-covert-aspect-igdb");
    }
    public static string settings_covert_aspect_square()
    {
        return GetString("settings-covert-aspect-square");
    }
    public static string settings_covert_aspect_steam()
    {
        return GetString("settings-covert-aspect-steam");
    }
    public static string settings_covert_aspect_steam_vertical()
    {
        return GetString("settings-covert-aspect-steam-vertical");
    }
    public static string settings_covert_aspect_twitch()
    {
        return GetString("settings-covert-aspect-twitch");
    }
    public static string settings_restart_notification()
    {
        return GetString("settings-restart-notification");
    }
    public static string settings_label()
    {
        return GetString("settings-label");
    }
    public static string settings_general_label()
    {
        return GetString("settings-general-label");
    }
    public static string settings_top_panel_label()
    {
        return GetString("settings-top-panel-label");
    }
    public static string settings_appearance_label()
    {
        return GetString("settings-appearance-label");
    }
    public static string settings_game_details_label()
    {
        return GetString("settings-game-details-label");
    }
    public static string settings_layout_label()
    {
        return GetString("settings-layout-label");
    }
    public static string settings_advanced_label()
    {
        return GetString("settings-advanced-label");
    }
    public static string settings_fullscreen_label()
    {
        return GetString("settings-fullscreen-label");
    }
    public static string settings_input_label()
    {
        return GetString("settings-input-label");
    }
    public static string settings_performance_label()
    {
        return GetString("settings-performance-label");
    }
    public static string settings_metadata_label()
    {
        return GetString("settings-metadata-label");
    }
    public static string settings_updating()
    {
        return GetString("settings-updating");
    }
    public static string settings_search()
    {
        return GetString("settings-search");
    }
    public static string settings_backup()
    {
        return GetString("settings-backup");
    }
    public static string menu_backup_data()
    {
        return GetString("menu-backup-data");
    }
    public static string menu_restore_backup()
    {
        return GetString("menu-restore-backup");
    }
    public static string settings_import_label()
    {
        return GetString("settings-import-label");
    }
    public static string settings_invalid_db_location()
    {
        return GetString("settings-invalid-db-location");
    }
    public static string settings_invalid_account_name()
    {
        return GetString("settings-invalid-account-name");
    }
    public static string settings_download_metadata_on_import()
    {
        return GetString("settings-download-metadata-on-import");
    }
    public static string settings_start_minimized()
    {
        return GetString("settings-start-minimized");
    }
    public static string settings_start_on_boot()
    {
        return GetString("settings-start-on-boot");
    }
    public static string settings_start_on_boot_closed_to_tray()
    {
        return GetString("settings-start-on-boot-closed-to-tray");
    }
    public static string settings_start_on_boot_registration_error()
    {
        return GetString("settings-start-on-boot-registration-error");
    }
    public static string settings_start_in_fullscreen()
    {
        return GetString("settings-start-in-fullscreen");
    }
    public static string settings_async_image_loading()
    {
        return GetString("settings-async-image-loading");
    }
    public static string settings_async_image_loading_tooltip()
    {
        return GetString("settings-async-image-loading-tooltip");
    }
    public static string settings_show_name_empty_cover()
    {
        return GetString("settings-show-name-empty-cover");
    }
    public static string settings_show_names_under_cover()
    {
        return GetString("settings-show-names-under-cover");
    }
    public static string settings_darken_uninstalled_grid_covers()
    {
        return GetString("settings-darken-uninstalled-grid-covers");
    }
    public static string settings_show_icon_list()
    {
        return GetString("settings-show-icon-list");
    }
    public static string settings_show_group_count()
    {
        return GetString("settings-show-group-count");
    }
    public static string settings_used_fields_only_on_filter_lists()
    {
        return GetString("settings-used-fields-only-on-filter-lists");
    }
    public static string settings_disable_acceleration()
    {
        return GetString("settings-disable-acceleration");
    }
    public static string settings_disable_acceleration_tooltip()
    {
        return GetString("settings-disable-acceleration-tooltip");
    }
    public static string settings_hidden_in_quick_launch()
    {
        return GetString("settings-hidden-in-quick-launch");
    }
    public static string settings_hidden_in_quick_launch_tooltip()
    {
        return GetString("settings-hidden-in-quick-launch-tooltip");
    }
    public static string settings_quick_launch_items()
    {
        return GetString("settings-quick-launch-items");
    }
    public static string settings_show_background_window_image()
    {
        return GetString("settings-show-background-window-image");
    }
    public static string settings_blur_window_background_image()
    {
        return GetString("settings-blur-window-background-image");
    }
    public static string settings_blur_high_quality()
    {
        return GetString("settings-blur-high-quality");
    }
    public static string settings_darken_window_background_image()
    {
        return GetString("settings-darken-window-background-image");
    }
    public static string settings_show_back_image_on_grid_view()
    {
        return GetString("settings-show-back-image-on-grid-view");
    }
    public static string settings_skin()
    {
        return GetString("settings-skin");
    }
    public static string settings_skin_color()
    {
        return GetString("settings-skin-color");
    }
    public static string settings_skin_fullscreen()
    {
        return GetString("settings-skin-fullscreen");
    }
    public static string settings_skin_color_fullscreen()
    {
        return GetString("settings-skin-color-fullscreen");
    }
    public static string settings_db_location()
    {
        return GetString("settings-db-location");
    }
    public static string settings_login_status()
    {
        return GetString("settings-login-status");
    }
    public static string settings_window_title()
    {
        return GetString("settings-window-title");
    }
    public static string settings_clear_web_cache()
    {
        return GetString("settings-clear-web-cache");
    }
    public static string settings_clear_web_cache_tooltip()
    {
        return GetString("settings-clear-web-cache-tooltip");
    }
    public static string settings_show_tray()
    {
        return GetString("settings-show-tray");
    }
    public static string settings_minimize_to_tray()
    {
        return GetString("settings-minimize-to-tray");
    }
    public static string settings_close_to_tray()
    {
        return GetString("settings-close-to-tray");
    }
    public static string settings_after_game_start()
    {
        return GetString("settings-after-game-start");
    }
    public static string settings_after_game_close()
    {
        return GetString("settings-after-game-close");
    }
    public static string settings_playtime_use_days_format_label()
    {
        return GetString("settings-playtime-use-days-format-label");
    }
    public static string settings_dates_formats_label()
    {
        return GetString("settings-dates-formats-label");
    }
    public static string settings_clear_cache_warn()
    {
        return GetString("settings-clear-cache-warn");
    }
    public static string settings_clear_cache_title()
    {
        return GetString("settings-clear-cache-title");
    }
    public static string settings_skin_change_restart()
    {
        return GetString("settings-skin-change-restart");
    }
    public static string settings_get_themes()
    {
        return GetString("settings-get-themes");
    }
    public static string settings_create_themes()
    {
        return GetString("settings-create-themes");
    }
    public static string settings_get_extensions()
    {
        return GetString("settings-get-extensions");
    }
    public static string settings_create_extensions()
    {
        return GetString("settings-create-extensions");
    }
    public static string settings_create_localization()
    {
        return GetString("settings-create-localization");
    }
    public static string settings_restart_ask_message()
    {
        return GetString("settings-restart-ask-message");
    }
    public static string settings_restart_title()
    {
        return GetString("settings-restart-title");
    }
    public static string settings_db_path_notification()
    {
        return GetString("settings-db-path-notification");
    }
    public static string settings_close_playtime_notif()
    {
        return GetString("settings-close-playtime-notif");
    }
    public static string settings_fullscreen_rows()
    {
        return GetString("settings-fullscreen-rows");
    }
    public static string settings_fullscreen_columns()
    {
        return GetString("settings-fullscreen-columns");
    }
    public static string settings_fullscreen_row_details()
    {
        return GetString("settings-fullscreen-row-details");
    }
    public static string settings_fullscreen_background_on_main_screen()
    {
        return GetString("settings-fullscreen-background-on-main-screen");
    }
    public static string background_image_screen_option_tooltip()
    {
        return GetString("background-image-screen-option-tooltip");
    }
    public static string settings_playtime_import_mode()
    {
        return GetString("settings-playtime-import-mode");
    }
    public static string settings_playtime_import_mode_tooltip()
    {
        return GetString("settings-playtime-import-mode-tooltip");
    }
    public static string settings_playtime_import_mode_always()
    {
        return GetString("settings-playtime-import-mode-always");
    }
    public static string settings_playtime_import_mode_new_imports_only()
    {
        return GetString("settings-playtime-import-mode-new-imports-only");
    }
    public static string settings_playtime_import_mode_never()
    {
        return GetString("settings-playtime-import-mode-never");
    }
    public static string settings_xinput_in_desktop_mode()
    {
        return GetString("settings-xinput-in-desktop-mode");
    }
    public static string settings_xinput_guide_opens_fullscreen()
    {
        return GetString("settings-xinput-guide-opens-fullscreen");
    }
    public static string settings_default_metadata_description()
    {
        return GetString("settings-default-metadata-description");
    }
    public static string settings_target_display()
    {
        return GetString("settings-target-display");
    }
    public static string settings_always_use_primary_display()
    {
        return GetString("settings-always-use-primary-display");
    }
    public static string settings_fullscreen_show_game_titles()
    {
        return GetString("settings-fullscreen-show-game-titles");
    }
    public static string settings_show_battery_status()
    {
        return GetString("settings-show-battery-status");
    }
    public static string settings_show_battery_percentage()
    {
        return GetString("settings-show-battery-percentage");
    }
    public static string settings_show_clock()
    {
        return GetString("settings-show-clock");
    }
    public static string settings_hide_mouse_cursor()
    {
        return GetString("settings-hide-mouse-cursor");
    }
    public static string settings_fullscreen_quick_filter_installed()
    {
        return GetString("settings-fullscreen-quick-filter-installed");
    }
    public static string settings_fullscreen_button_prompts()
    {
        return GetString("settings-fullscreen-button-prompts");
    }
    public static string settings_fullscreen_layout()
    {
        return GetString("settings-fullscreen-layout");
    }
    public static string settings_fullscreen_horizontal_scrolling()
    {
        return GetString("settings-fullscreen-horizontal-scrolling");
    }
    public static string settings_select_child_section()
    {
        return GetString("settings-select-child-section");
    }
    public static string settings_no_settings_available()
    {
        return GetString("settings-no-settings-available");
    }
    public static string settings_error_loading_settings()
    {
        return GetString("settings-error-loading-settings");
    }
    public static string settings_scripting_notice()
    {
        return GetString("settings-scripting-notice");
    }
    public static string settings_background_image_animation()
    {
        return GetString("settings-background-image-animation");
    }
    public static string settings_font_sizes()
    {
        return GetString("settings-font-sizes");
    }
    public static string settings_text_rendering_mode_option_auto()
    {
        return GetString("settings-text-rendering-mode-option-auto");
    }
    public static string settings_text_rendering_mode_option_aliased()
    {
        return GetString("settings-text-rendering-mode-option-aliased");
    }
    public static string settings_text_rendering_mode_option_grayscale()
    {
        return GetString("settings-text-rendering-mode-option-grayscale");
    }
    public static string settings_text_rendering_mode_option_clear_type()
    {
        return GetString("settings-text-rendering-mode-option-clear-type");
    }
    public static string settings_text_formatting_mode_option_ideal()
    {
        return GetString("settings-text-formatting-mode-option-ideal");
    }
    public static string settings_text_formatting_mode_option_display()
    {
        return GetString("settings-text-formatting-mode-option-display");
    }
    public static string settings_text_formatting_mode()
    {
        return GetString("settings-text-formatting-mode");
    }
    public static string settings_text_rendering_mode()
    {
        return GetString("settings-text-rendering-mode");
    }
    public static string settings_text_rendering_notice()
    {
        return GetString("settings-text-rendering-notice");
    }
    public static string settings_immediate_background_download()
    {
        return GetString("settings-immediate-background-download");
    }
    public static string settings_immediate_background_download_tooltip()
    {
        return GetString("settings-immediate-background-download-tooltip");
    }
    public static string settings_auto_close_launcher_option()
    {
        return GetString("settings-auto-close-launcher-option");
    }
    public static string settings_auto_close_grace_period()
    {
        return GetString("settings-auto-close-grace-period");
    }
    public static string settings_auto_close_minimal_session_time()
    {
        return GetString("settings-auto-close-minimal-session-time");
    }
    public static string settings_auto_close_specific_clients()
    {
        return GetString("settings-auto-close-specific-clients");
    }
    public static string settings_auto_close_section()
    {
        return GetString("settings-auto-close-section");
    }
    public static string settings_import_exclusion_list()
    {
        return GetString("settings-import-exclusion-list");
    }
    public static string settings_show_media_size_warning()
    {
        return GetString("settings-show-media-size-warning");
    }
    public static string open_directory_command()
    {
        return GetString("open-directory-command");
    }
    public static string settings_preferred_age_rating_org()
    {
        return GetString("settings-preferred-age-rating-org");
    }
    public static string settings_scan_lib_install_size_on_lib_update()
    {
        return GetString("settings-scan-lib-install-size-on-lib-update");
    }
    public static string settings_scan_lib_install_size_on_lib_update_tooltip()
    {
        return GetString("settings-scan-lib-install-size-on-lib-update-tooltip");
    }
    public static string stretch_none()
    {
        return GetString("stretch-none");
    }
    public static string stretch_fill()
    {
        return GetString("stretch-fill");
    }
    public static string stretch_uniform()
    {
        return GetString("stretch-uniform");
    }
    public static string stretch_uniform_to_fill()
    {
        return GetString("stretch-uniform-to-fill");
    }
    public static string dock_left()
    {
        return GetString("dock-left");
    }
    public static string dock_right()
    {
        return GetString("dock-right");
    }
    public static string dock_top()
    {
        return GetString("dock-top");
    }
    public static string dock_bottom()
    {
        return GetString("dock-bottom");
    }
    public static string import_error()
    {
        return GetString("import-error");
    }
    public static string login_required()
    {
        return GetString("login-required");
    }
    public static string login_failed()
    {
        return GetString("login-failed");
    }
    public static string settings_alt_web_view_rendering()
    {
        return GetString("settings-alt-web-view-rendering");
    }
    public static string settings_alt_web_view_rendering_tooltip()
    {
        return GetString("settings-alt-web-view-rendering-tooltip");
    }
    public static string settings_partial_description_loading()
    {
        return GetString("settings-partial-description-loading");
    }
    public static string settings_partial_description_loading_tooltip()
    {
        return GetString("settings-partial-description-loading-tooltip");
    }
    public static string meta_import_window_title()
    {
        return GetString("meta-import-window-title");
    }
    public static string download_meta_button()
    {
        return GetString("download-meta-button");
    }
    public static string save_default_tooltip()
    {
        return GetString("save-default-tooltip");
    }
    public static string emu_wizard_window_title()
    {
        return GetString("emu-wizard-window-title");
    }
    public static string emu_wizard_intro()
    {
        return GetString("emu-wizard-intro");
    }
    public static string emu_wizard_notice()
    {
        return GetString("emu-wizard-notice");
    }
    public static string emu_download_description()
    {
        return GetString("emu-download-description");
    }
    public static string emu_wizard_emu_import_intro()
    {
        return GetString("emu-wizard-emu-import-intro");
    }
    public static string emu_wizard_game_import_intro()
    {
        return GetString("emu-wizard-game-import-intro");
    }
    public static string emu_wizard_no_emulator_warning()
    {
        return GetString("emu-wizard-no-emulator-warning");
    }
    public static string emu_wizard_no_emulator_for_games_warning()
    {
        return GetString("emu-wizard-no-emulator-for-games-warning");
    }
    public static string emu_wizard_button_scan_games()
    {
        return GetString("emu-wizard-button-scan-games");
    }
    public static string emu_wizard_button_select_files()
    {
        return GetString("emu-wizard-button-select-files");
    }
    public static string emu_wizard_button_scan_emulator()
    {
        return GetString("emu-wizard-button-scan-emulator");
    }
    public static string emu_wizard_button_configure_emulator()
    {
        return GetString("emu-wizard-button-configure-emulator");
    }
    public static string emu_wizard_scanning()
    {
        return GetString("emu-wizard-scanning");
    }
    public static string emu_wizard_scanning_specific(object path)
    {
        return GetString("emu-wizard-scanning-specific", ("path", path));
    }
    public static string first_window_title()
    {
        return GetString("first-window-title");
    }
    public static string first_intro()
    {
        return GetString("first-intro");
    }
    public static string first_external_title()
    {
        return GetString("first-external-title");
    }
    public static string first_import_introduction()
    {
        return GetString("first-import-introduction");
    }
    public static string first_config_finished_title()
    {
        return GetString("first-config-finished-title");
    }
    public static string first_config_finished_text()
    {
        return GetString("first-config-finished-text");
    }
    public static string first_plugin_download_error()
    {
        return GetString("first-plugin-download-error");
    }
    public static string first_downloading_addon(object integrationName)
    {
        return GetString("first-downloading-addon", ("integrationName", integrationName));
    }
    public static string default_addon_list_download()
    {
        return GetString("default-addon-list-download");
    }
    public static string default_addon_list_download_error()
    {
        return GetString("default-addon-list-download-error");
    }
    public static string platforms_window_title()
    {
        return GetString("platforms-window-title");
    }
    public static string emulators_window_title()
    {
        return GetString("emulators-window-title");
    }
    public static string platforms_title()
    {
        return GetString("platforms-title");
    }
    public static string platform_title()
    {
        return GetString("platform-title");
    }
    public static string emulators_title()
    {
        return GetString("emulators-title");
    }
    public static string emulator_title()
    {
        return GetString("emulator-title");
    }
    public static string add_platform_title()
    {
        return GetString("add-platform-title");
    }
    public static string select_icon_title()
    {
        return GetString("select-icon-title");
    }
    public static string select_cover_title()
    {
        return GetString("select-cover-title");
    }
    public static string select_image_title()
    {
        return GetString("select-image-title");
    }
    public static string select_item_title()
    {
        return GetString("select-item-title");
    }
    public static string select_background_title()
    {
        return GetString("select-background-title");
    }
    public static string select_file_title()
    {
        return GetString("select-file-title");
    }
    public static string select_url_title()
    {
        return GetString("select-url-title");
    }
    public static string add_emulator_title()
    {
        return GetString("add-emulator-title");
    }
    public static string supported_platforms_title()
    {
        return GetString("supported-platforms-title");
    }
    public static string confirm_unsaved_platforms_title()
    {
        return GetString("confirm-unsaved-platforms-title");
    }
    public static string confirm_unsaved_emulators_title()
    {
        return GetString("confirm-unsaved-emulators-title");
    }
    public static string executable_title()
    {
        return GetString("executable-title");
    }
    public static string arguments_title()
    {
        return GetString("arguments-title");
    }
    public static string working_dir_title()
    {
        return GetString("working-dir-title");
    }
    public static string supported_files_title()
    {
        return GetString("supported-files-title");
    }
    public static string import_emulators_button()
    {
        return GetString("import-emulators-button");
    }
    public static string download_emulators_button()
    {
        return GetString("download-emulators-button");
    }
    public static string emu_load_args_preset_tooltip()
    {
        return GetString("emu-load-args-preset-tooltip");
    }
    public static string emu_removal_confirmation(object emulatorName, object gameCount)
    {
        return GetString("emu-removal-confirmation", ("emulatorName", emulatorName), ("gameCount", gameCount));
    }
    public static string platform_removal_confirmation(object platformName, object gamesCount, object emulatorsCount)
    {
        return GetString("platform-removal-confirmation", ("platformName", platformName), ("gamesCount", gamesCount), ("emulatorsCount", emulatorsCount));
    }
    public static string emulator_settings_help()
    {
        return GetString("emulator-settings-help");
    }
    public static string menu_sort_by_title()
    {
        return GetString("menu-sort-by-title");
    }
    public static string menu_sort_by_direction()
    {
        return GetString("menu-sort-by-direction");
    }
    public static string menu_group_by_title()
    {
        return GetString("menu-group-by-title");
    }
    public static string menu_sort_ascending()
    {
        return GetString("menu-sort-ascending");
    }
    public static string menu_sort_descending()
    {
        return GetString("menu-sort-descending");
    }
    public static string menu_group_no_group()
    {
        return GetString("menu-group-no-group");
    }
    public static string menu_group_provider()
    {
        return GetString("menu-group-provider");
    }
    public static string menu_group_category()
    {
        return GetString("menu-group-category");
    }
    public static string menu_group_platform()
    {
        return GetString("menu-group-platform");
    }
    public static string view_type()
    {
        return GetString("view-type");
    }
    public static string menu_view()
    {
        return GetString("menu-view");
    }
    public static string menu_view_explorer_panel()
    {
        return GetString("menu-view-explorer-panel");
    }
    public static string menu_view_filter_panel()
    {
        return GetString("menu-view-filter-panel");
    }
    public static string game_icon_title()
    {
        return GetString("game-icon-title");
    }
    public static string library_icon_title()
    {
        return GetString("library-icon-title");
    }
    public static string game_cover_image_title()
    {
        return GetString("game-cover-image-title");
    }
    public static string game_background_title()
    {
        return GetString("game-background-title");
    }
    public static string game_sorting_name_title()
    {
        return GetString("game-sorting-name-title");
    }
    public static string game_provider_title()
    {
        return GetString("game-provider-title");
    }
    public static string game_manual_title()
    {
        return GetString("game-manual-title");
    }
    public static string game_name_title()
    {
        return GetString("game-name-title");
    }
    public static string install_drive_title()
    {
        return GetString("install-drive-title");
    }
    public static string game_account_name_title()
    {
        return GetString("game-account-name-title");
    }
    public static string game_platform_title()
    {
        return GetString("game-platform-title");
    }
    public static string game_categories_title()
    {
        return GetString("game-categories-title");
    }
    public static string game_genres_title()
    {
        return GetString("game-genres-title");
    }
    public static string game_release_date_title()
    {
        return GetString("game-release-date-title");
    }
    public static string game_release_year_title()
    {
        return GetString("game-release-year-title");
    }
    public static string game_developers_title()
    {
        return GetString("game-developers-title");
    }
    public static string game_tags_title()
    {
        return GetString("game-tags-title");
    }
    public static string game_publishers_title()
    {
        return GetString("game-publishers-title");
    }
    public static string game_installation_status()
    {
        return GetString("game-installation-status");
    }
    public static string use_filter_style_and_title()
    {
        return GetString("use-filter-style-and-title");
    }
    public static string use_filter_style_and_tooltip()
    {
        return GetString("use-filter-style-and-tooltip");
    }
    public static string game_is_installed_title()
    {
        return GetString("game-is-installed-title");
    }
    public static string game_is_game_installed_title()
    {
        return GetString("game-is-game-installed-title");
    }
    public static string game_is_un_installed_title()
    {
        return GetString("game-is-un-installed-title");
    }
    public static string game_hidden_title()
    {
        return GetString("game-hidden-title");
    }
    public static string game_favorite_title()
    {
        return GetString("game-favorite-title");
    }
    public static string game_hdr_title()
    {
        return GetString("game-hdr-title");
    }
    public static string game_hdr_tooltip()
    {
        return GetString("game-hdr-tooltip");
    }
    public static string game_hdr_not_supported_tooltip()
    {
        return GetString("game-hdr-not-supported-tooltip");
    }
    public static string game_last_activity_title()
    {
        return GetString("game-last-activity-title");
    }
    public static string game_category_title()
    {
        return GetString("game-category-title");
    }
    public static string game_description_title()
    {
        return GetString("game-description-title");
    }
    public static string game_install_dir_title()
    {
        return GetString("game-install-dir-title");
    }
    public static string game_cover_title()
    {
        return GetString("game-cover-title");
    }
    public static string game_links_title()
    {
        return GetString("game-links-title");
    }
    public static string game_rom_title()
    {
        return GetString("game-rom-title");
    }
    public static string genre_label()
    {
        return GetString("genre-label");
    }
    public static string genres_label()
    {
        return GetString("genres-label");
    }
    public static string company_label()
    {
        return GetString("company-label");
    }
    public static string companies_label()
    {
        return GetString("companies-label");
    }
    public static string developer_label()
    {
        return GetString("developer-label");
    }
    public static string developers_label()
    {
        return GetString("developers-label");
    }
    public static string publisher_label()
    {
        return GetString("publisher-label");
    }
    public static string publishers_label()
    {
        return GetString("publishers-label");
    }
    public static string category_label()
    {
        return GetString("category-label");
    }
    public static string categories_label()
    {
        return GetString("categories-label");
    }
    public static string tag_label()
    {
        return GetString("tag-label");
    }
    public static string tags_label()
    {
        return GetString("tags-label");
    }
    public static string feature_label()
    {
        return GetString("feature-label");
    }
    public static string features_label()
    {
        return GetString("features-label");
    }
    public static string age_rating_label()
    {
        return GetString("age-rating-label");
    }
    public static string age_ratings_label()
    {
        return GetString("age-ratings-label");
    }
    public static string region_label()
    {
        return GetString("region-label");
    }
    public static string regions_label()
    {
        return GetString("regions-label");
    }
    public static string source_label()
    {
        return GetString("source-label");
    }
    public static string sources_label()
    {
        return GetString("sources-label");
    }
    public static string recent_activity_label()
    {
        return GetString("recent-activity-label");
    }
    public static string database_error_title()
    {
        return GetString("database-error-title");
    }
    public static string database_open_error()
    {
        return GetString("database-open-error");
    }
    public static string database_not_opened_error()
    {
        return GetString("database-not-opened-error");
    }
    public static string database_open_access_error(object path)
    {
        return GetString("database-open-access-error", ("path", path));
    }
    public static string diag_package_creation_error()
    {
        return GetString("diag-package-creation-error");
    }
    public static string diag_package_upload_error()
    {
        return GetString("diag-package-upload-error");
    }
    public static string diag_package_sent_success()
    {
        return GetString("diag-package-sent-success");
    }
    public static string diag_package_creation_success()
    {
        return GetString("diag-package-creation-success");
    }
    public static string library_import_error(object libraryName)
    {
        return GetString("library-import-error", ("libraryName", libraryName));
    }
    public static string library_import_emulated_error(object scannerName)
    {
        return GetString("library-import-emulated-error", ("scannerName", scannerName));
    }
    public static string scan_emulator_games_empty_profile_error()
    {
        return GetString("scan-emulator-games-empty-profile-error");
    }
    public static string start_generic_error()
    {
        return GetString("start-generic-error");
    }
    public static string url_format_error()
    {
        return GetString("url-format-error");
    }
    public static string app_startup_error()
    {
        return GetString("app-startup-error");
    }
    public static string cef_sharp_init_error()
    {
        return GetString("cef-sharp-init-error");
    }
    public static string emulator_import_no_definitions_error()
    {
        return GetString("emulator-import-no-definitions-error");
    }
    public static string xinput_init_error_message()
    {
        return GetString("xinput-init-error-message");
    }
    public static string menu_action_exec_error()
    {
        return GetString("menu-action-exec-error");
    }
    public static string game_edit_window_title()
    {
        return GetString("game-edit-window-title");
    }
    public static string use_exe_icon()
    {
        return GetString("use-exe-icon");
    }
    public static string image_url()
    {
        return GetString("image-url");
    }
    public static string add_link_button()
    {
        return GetString("add-link-button");
    }
    public static string add_rom()
    {
        return GetString("add-rom");
    }
    public static string save_changes()
    {
        return GetString("save-changes");
    }
    public static string game_edit_change_save_tooltip()
    {
        return GetString("game-edit-change-save-tooltip");
    }
    public static string add_action()
    {
        return GetString("add-action");
    }
    public static string delete_action()
    {
        return GetString("delete-action");
    }
    public static string remove_play_action()
    {
        return GetString("remove-play-action");
    }
    public static string add_games()
    {
        return GetString("add-games");
    }
    public static string scan_folder()
    {
        return GetString("scan-folder");
    }
    public static string detect_installed()
    {
        return GetString("detect-installed");
    }
    public static string browse()
    {
        return GetString("browse");
    }
    public static string open_playnite()
    {
        return GetString("open-playnite");
    }
    public static string profile_settings()
    {
        return GetString("profile-settings");
    }
    public static string empty_game_name_error()
    {
        return GetString("empty-game-name-error");
    }
    public static string empty_tracking_folder_error()
    {
        return GetString("empty-tracking-folder-error");
    }
    public static string empty_game_name_meta_search_error()
    {
        return GetString("empty-game-name-meta-search-error");
    }
    public static string invalid_game_data()
    {
        return GetString("invalid-game-data");
    }
    public static string url_input_info()
    {
        return GetString("url-input-info");
    }
    public static string url_input_info_title()
    {
        return GetString("url-input-info-title");
    }
    public static string metadata_download_error()
    {
        return GetString("metadata-download-error");
    }
    public static string download_error()
    {
        return GetString("download-error");
    }
    public static string clear_filters()
    {
        return GetString("clear-filters");
    }
    public static string private_account()
    {
        return GetString("private-account");
    }
    public static string public_account()
    {
        return GetString("public-account");
    }
    public static string api_key()
    {
        return GetString("api-key");
    }
    public static string startup_error()
    {
        return GetString("startup-error");
    }
    public static string skin_error()
    {
        return GetString("skin-error");
    }
    public static string clear_all()
    {
        return GetString("clear-all");
    }
    public static string setup_running()
    {
        return GetString("setup-running");
    }
    public static string uninstalling()
    {
        return GetString("uninstalling");
    }
    public static string game_launching()
    {
        return GetString("game-launching");
    }
    public static string game_running()
    {
        return GetString("game-running");
    }
    public static string invalid_url()
    {
        return GetString("invalid-url");
    }
    public static string do_nothing()
    {
        return GetString("do-nothing");
    }
    public static string minimize()
    {
        return GetString("minimize");
    }
    public static string restore_window()
    {
        return GetString("restore-window");
    }
    public static string close()
    {
        return GetString("close");
    }
    public static string change()
    {
        return GetString("change");
    }
    public static string advanced()
    {
        return GetString("advanced");
    }
    public static string never()
    {
        return GetString("never");
    }
    public static string completion_status()
    {
        return GetString("completion-status");
    }
    public static string completion_statuses()
    {
        return GetString("completion-statuses");
    }
    public static string user_score()
    {
        return GetString("user-score");
    }
    public static string critic_score()
    {
        return GetString("critic-score");
    }
    public static string community_score()
    {
        return GetString("community-score");
    }
    public static string game_scripts()
    {
        return GetString("game-scripts");
    }
    public static string application_scripts()
    {
        return GetString("application-scripts");
    }
    public static string scripts()
    {
        return GetString("scripts");
    }
    public static string plugins()
    {
        return GetString("plugins");
    }
    public static string metadata_providers()
    {
        return GetString("metadata-providers");
    }
    public static string extensions()
    {
        return GetString("extensions");
    }
    public static string extension_id()
    {
        return GetString("extension-id");
    }
    public static string reload_scripts()
    {
        return GetString("reload-scripts");
    }
    public static string start_interactive_power_shell()
    {
        return GetString("start-interactive-power-shell");
    }
    public static string reload_scripts_success()
    {
        return GetString("reload-scripts-success");
    }
    public static string no_games_found()
    {
        return GetString("no-games-found");
    }
    public static string no_items_found()
    {
        return GetString("no-items-found");
    }
    public static string back_to_desktop_mode()
    {
        return GetString("back-to-desktop-mode");
    }
    public static string exit_playnite()
    {
        return GetString("exit-playnite");
    }
    public static string libraries()
    {
        return GetString("libraries");
    }
    public static string update_all()
    {
        return GetString("update-all");
    }
    public static string extension_created_by()
    {
        return GetString("extension-created-by");
    }
    public static string extension_version()
    {
        return GetString("extension-version");
    }
    public static string extension_updated()
    {
        return GetString("extension-updated");
    }
    public static string extension_module()
    {
        return GetString("extension-module");
    }
    public static string library()
    {
        return GetString("library");
    }
    public static string statistics()
    {
        return GetString("statistics");
    }
    public static string all()
    {
        return GetString("all");
    }
    public static string none()
    {
        return GetString("none");
    }
    public static string notifications()
    {
        return GetString("notifications");
    }
    public static string width()
    {
        return GetString("width");
    }
    public static string height()
    {
        return GetString("height");
    }
    public static string size()
    {
        return GetString("size");
    }
    public static string font_small()
    {
        return GetString("font-small");
    }
    public static string font_normal()
    {
        return GetString("font-normal");
    }
    public static string font_large()
    {
        return GetString("font-large");
    }
    public static string font_larger()
    {
        return GetString("font-larger");
    }
    public static string font_largest()
    {
        return GetString("font-largest");
    }
    public static string default_label()
    {
        return GetString("default-label");
    }
    public static string select()
    {
        return GetString("select");
    }
    public static string select_all()
    {
        return GetString("select-all");
    }
    public static string deselect_all()
    {
        return GetString("deselect-all");
    }
    public static string first()
    {
        return GetString("first");
    }
    public static string random()
    {
        return GetString("random");
    }
    public static string user_select()
    {
        return GetString("user-select");
    }
    public static string load_more()
    {
        return GetString("load-more");
    }
    public static string transparent()
    {
        return GetString("transparent");
    }
    public static string collapse()
    {
        return GetString("collapse");
    }
    public static string expand()
    {
        return GetString("expand");
    }
    public static string collapse_all()
    {
        return GetString("collapse-all");
    }
    public static string expand_all()
    {
        return GetString("expand-all");
    }
    public static string other()
    {
        return GetString("other");
    }
    public static string themes()
    {
        return GetString("themes");
    }
    public static string emulator_arguments()
    {
        return GetString("emulator-arguments");
    }
    public static string builtin_arguments()
    {
        return GetString("builtin-arguments");
    }
    public static string custom_arguments()
    {
        return GetString("custom-arguments");
    }
    public static string additional_emulator_arguments()
    {
        return GetString("additional-emulator-arguments");
    }
    public static string override_emulator_arguments()
    {
        return GetString("override-emulator-arguments");
    }
    public static string is_play_action()
    {
        return GetString("is-play-action");
    }
    public static string metadata_diff_window_title()
    {
        return GetString("metadata-diff-window-title");
    }
    public static string game_import_window_title()
    {
        return GetString("game-import-window-title");
    }
    public static string meta_lookup_window_title()
    {
        return GetString("meta-lookup-window-title");
    }
    public static string updater_window_title()
    {
        return GetString("updater-window-title");
    }
    public static string updater_changes_info()
    {
        return GetString("updater-changes-info");
    }
    public static string updater_install_update()
    {
        return GetString("updater-install-update");
    }
    public static string check_for_updates()
    {
        return GetString("check-for-updates");
    }
    public static string update_error()
    {
        return GetString("update-error");
    }
    public static string update_check_fail_message()
    {
        return GetString("update-check-fail-message");
    }
    public static string update_no_new_update_message()
    {
        return GetString("update-no-new-update-message");
    }
    public static string general_update_fail_message()
    {
        return GetString("general-update-fail-message");
    }
    public static string update_progress_cancel_ask()
    {
        return GetString("update-progress-cancel-ask");
    }
    public static string background_progress_cancel_ask_exit()
    {
        return GetString("background-progress-cancel-ask-exit");
    }
    public static string background_progress_cancel_ask_switch_mode()
    {
        return GetString("background-progress-cancel-ask-switch-mode");
    }
    public static string update_is_available_notification_body()
    {
        return GetString("update-is-available-notification-body");
    }
    public static string theme_test_reload_list()
    {
        return GetString("theme-test-reload-list");
    }
    public static string theme_test_apply_skin()
    {
        return GetString("theme-test-apply-skin");
    }
    public static string theme_test_watch_changes()
    {
        return GetString("theme-test-watch-changes");
    }
    public static string theme_test_watch_changes_tooltip()
    {
        return GetString("theme-test-watch-changes-tooltip");
    }
    public static string script_runtime()
    {
        return GetString("script-runtime");
    }
    public static string pre_script_description()
    {
        return GetString("pre-script-description");
    }
    public static string post_script_description()
    {
        return GetString("post-script-description");
    }
    public static string game_started_script_description()
    {
        return GetString("game-started-script-description");
    }
    public static string app_script_startup_description()
    {
        return GetString("app-script-startup-description");
    }
    public static string app_script_shutdown_description()
    {
        return GetString("app-script-shutdown-description");
    }
    public static string script_type_starting()
    {
        return GetString("script-type-starting");
    }
    public static string script_type_started()
    {
        return GetString("script-type-started");
    }
    public static string script_type_exit()
    {
        return GetString("script-type-exit");
    }
    public static string execute_global_script()
    {
        return GetString("execute-global-script");
    }
    public static string stats_global()
    {
        return GetString("stats-global");
    }
    public static string stats_filtered()
    {
        return GetString("stats-filtered");
    }
    public static string metadata_diff_current()
    {
        return GetString("metadata-diff-current");
    }
    public static string metadata_diff_new()
    {
        return GetString("metadata-diff-new");
    }
    public static string test_script()
    {
        return GetString("test-script");
    }
    public static string only_items_selected_tooltip()
    {
        return GetString("only-items-selected-tooltip");
    }
    public static string save_as_default()
    {
        return GetString("save-as-default");
    }
    public static string favorite_game()
    {
        return GetString("favorite-game");
    }
    public static string remove_favorite_game()
    {
        return GetString("remove-favorite-game");
    }
    public static string hide_game()
    {
        return GetString("hide-game");
    }
    public static string un_hide_game()
    {
        return GetString("un-hide-game");
    }
    public static string enable_hdr()
    {
        return GetString("enable-hdr");
    }
    public static string disable_hdr()
    {
        return GetString("disable-hdr");
    }
    public static string edit_game()
    {
        return GetString("edit-game");
    }
    public static string calculate_install_size()
    {
        return GetString("calculate-install-size");
    }
    public static string calculate_games_all_install_size()
    {
        return GetString("calculate-games-all-install-size");
    }
    public static string calculate_games_missing_install_size()
    {
        return GetString("calculate-games-missing-install-size");
    }
    public static string install_size_menu_label()
    {
        return GetString("install-size-menu-label");
    }
    public static string set_game_category()
    {
        return GetString("set-game-category");
    }
    public static string set_completion_status()
    {
        return GetString("set-completion-status");
    }
    public static string remove_game()
    {
        return GetString("remove-game");
    }
    public static string play_game()
    {
        return GetString("play-game");
    }
    public static string install_game()
    {
        return GetString("install-game");
    }
    public static string game_options()
    {
        return GetString("game-options");
    }
    public static string game_details()
    {
        return GetString("game-details");
    }
    public static string uninstall_game()
    {
        return GetString("uninstall-game");
    }
    public static string open_game_location()
    {
        return GetString("open-game-location");
    }
    public static string create_desktop_shortcut()
    {
        return GetString("create-desktop-shortcut");
    }
    public static string open_game_manual()
    {
        return GetString("open-game-manual");
    }
    public static string more_action()
    {
        return GetString("more-action");
    }
    public static string play_action_use_plugin()
    {
        return GetString("play-action-use-plugin");
    }
    public static string play_action_use_plugin_tooltip()
    {
        return GetString("play-action-use-plugin-tooltip");
    }
    public static string meta_download_single_game_tip()
    {
        return GetString("meta-download-single-game-tip");
    }
    public static string progress_availability_message()
    {
        return GetString("progress-availability-message");
    }
    public static string description_html_support_tooltip()
    {
        return GetString("description-html-support-tooltip");
    }
    public static string description_playtime_seconds()
    {
        return GetString("description-playtime-seconds");
    }
    public static string description_size_bytes()
    {
        return GetString("description-size-bytes");
    }
    public static string release_date_tooltip()
    {
        return GetString("release-date-tooltip");
    }
    public static string description_score_values()
    {
        return GetString("description-score-values");
    }
    public static string patreon_develop_message()
    {
        return GetString("patreon-develop-message");
    }
    public static string about_contributors_message()
    {
        return GetString("about-contributors-message");
    }
    public static string cancel_monitoring_ask_title()
    {
        return GetString("cancel-monitoring-ask-title");
    }
    public static string cancel_monitoring_setup_ask()
    {
        return GetString("cancel-monitoring-setup-ask");
    }
    public static string cancel_monitoring_execution_ask()
    {
        return GetString("cancel-monitoring-execution-ask");
    }
    public static string time_played()
    {
        return GetString("time-played");
    }
    public static string last_played()
    {
        return GetString("last-played");
    }
    public static string played_days(object days, object hours, object minutes)
    {
        return GetString("played-days", ("days", days), ("hours", hours), ("minutes", minutes));
    }
    public static string played_hours(object hours, object minutes)
    {
        return GetString("played-hours", ("hours", hours), ("minutes", minutes));
    }
    public static string played_minutes(object minutes)
    {
        return GetString("played-minutes", ("minutes", minutes));
    }
    public static string played_seconds(object seconds)
    {
        return GetString("played-seconds", ("seconds", seconds));
    }
    public static string played_none()
    {
        return GetString("played-none");
    }
    public static string opening_desktop_mode_message()
    {
        return GetString("opening-desktop-mode-message");
    }
    public static string opening_fullscreen_mode_message()
    {
        return GetString("opening-fullscreen-mode-message");
    }
    public static string opening_database()
    {
        return GetString("opening-database");
    }
    public static string calculating_install_size_message()
    {
        return GetString("calculating-install-size-message");
    }
    public static string calculating_install_size_of_game_message(object gameName)
    {
        return GetString("calculating-install-size-of-game-message", ("gameName", gameName));
    }
    public static string script_install_fail()
    {
        return GetString("script-install-fail");
    }
    public static string script_install_success()
    {
        return GetString("script-install-success");
    }
    public static string install_script()
    {
        return GetString("install-script");
    }
    public static string script_error()
    {
        return GetString("script-error");
    }
    public static string script_execution_error()
    {
        return GetString("script-execution-error");
    }
    public static string open_metadata_folder()
    {
        return GetString("open-metadata-folder");
    }
    public static string install_size_calculate()
    {
        return GetString("install-size-calculate");
    }
    public static string install_size_calculate_edit_button_tooltip()
    {
        return GetString("install-size-calculate-edit-button-tooltip");
    }
    public static string client_not_installed_error(object clientName)
    {
        return GetString("client-not-installed-error", ("clientName", clientName));
    }
    public static string sign_in_external_notif(object clientName)
    {
        return GetString("sign-in-external-notif", ("clientName", clientName));
    }
    public static string sign_in_external_wait_message()
    {
        return GetString("sign-in-external-wait-message");
    }
    public static string install_dir_not_found_error()
    {
        return GetString("install-dir-not-found-error");
    }
    public static string invalid_game_action_settings()
    {
        return GetString("invalid-game-action-settings");
    }
    public static string trouble_shooting_account_link()
    {
        return GetString("trouble-shooting-account-link");
    }
    public static string trouble_shooting_issues()
    {
        return GetString("trouble-shooting-issues");
    }
    public static string rename_item()
    {
        return GetString("rename-item");
    }
    public static string add_new_item()
    {
        return GetString("add-new-item");
    }
    public static string enter_name()
    {
        return GetString("enter-name");
    }
    public static string enter_new_name()
    {
        return GetString("enter-new-name");
    }
    public static string playtime_less_then_an_hour()
    {
        return GetString("playtime-less-then-an-hour");
    }
    public static string playtime1to10()
    {
        return GetString("playtime1to10");
    }
    public static string playtime10to100()
    {
        return GetString("playtime10to100");
    }
    public static string playtime100to500()
    {
        return GetString("playtime100to500");
    }
    public static string playtime500to1000()
    {
        return GetString("playtime500to1000");
    }
    public static string playtime1000plus()
    {
        return GetString("playtime1000plus");
    }
    public static string ext_installation_restart_notif()
    {
        return GetString("ext-installation-restart-notif");
    }
    public static string general_extension_package_error()
    {
        return GetString("general-extension-package-error");
    }
    public static string general_theme_package_error()
    {
        return GetString("general-theme-package-error");
    }
    public static string specific_extension_load_error(object extensionName)
    {
        return GetString("specific-extension-load-error", ("extensionName", extensionName));
    }
    public static string specific_extension_load_sdk_error(object extensionName)
    {
        return GetString("specific-extension-load-sdk-error", ("extensionName", extensionName));
    }
    public static string specific_theme_load_error(object themeName)
    {
        return GetString("specific-theme-load-error", ("themeName", themeName));
    }
    public static string specific_theme_load_sdk_error(object themeName)
    {
        return GetString("specific-theme-load-sdk-error", ("themeName", themeName));
    }
    public static string general_extension_load_error()
    {
        return GetString("general-extension-load-error");
    }
    public static string general_theme_load_error()
    {
        return GetString("general-theme-load-error");
    }
    public static string general_extension_install_api_version_fails()
    {
        return GetString("general-extension-install-api-version-fails");
    }
    public static string general_extension_install_success()
    {
        return GetString("general-extension-install-success");
    }
    public static string general_extension_install_title()
    {
        return GetString("general-extension-install-title");
    }
    public static string extension_generic()
    {
        return GetString("extension-generic");
    }
    public static string addon_install_failed(object addonName)
    {
        return GetString("addon-install-failed", ("addonName", addonName));
    }
    public static string extension_install_fail()
    {
        return GetString("extension-install-fail");
    }
    public static string extension_install_prompt(object name, object author, object version)
    {
        return GetString("extension-install-prompt", ("name", name), ("author", author), ("version", version));
    }
    public static string extension_update_prompt(object name, object currentVersion, object newVersion)
    {
        return GetString("extension-update-prompt", ("name", name), ("currentVersion", currentVersion), ("newVersion", newVersion));
    }
    public static string theme_install_fail()
    {
        return GetString("theme-install-fail");
    }
    public static string theme_install_prompt(object name, object author, object version)
    {
        return GetString("theme-install-prompt", ("name", name), ("author", author), ("version", version));
    }
    public static string theme_update_prompt(object name, object currentVersion, object newVersion)
    {
        return GetString("theme-update-prompt", ("name", name), ("currentVersion", currentVersion), ("newVersion", newVersion));
    }
    public static string url_navigation_message(object pageUrl)
    {
        return GetString("url-navigation-message", ("pageUrl", pageUrl));
    }
    public static string game_image_size_warning(object iconPixels, object coverPixels, object backgroundPixels)
    {
        return GetString("game-image-size-warning", ("iconPixels", iconPixels), ("coverPixels", coverPixels), ("backgroundPixels", backgroundPixels));
    }
    public static string performance_warning_title()
    {
        return GetString("performance-warning-title");
    }
    public static string dont_show_again_title()
    {
        return GetString("dont-show-again-title");
    }
    public static string incompatible_drag_and_drop_extension_error(object extensionName)
    {
        return GetString("incompatible-drag-and-drop-extension-error", ("extensionName", extensionName));
    }
    public static string incompatible_drag_and_drop_extension_error_title()
    {
        return GetString("incompatible-drag-and-drop-extension-error-title");
    }
    public static string large_media_warning_tooltip()
    {
        return GetString("large-media-warning-tooltip");
    }
    public static string theme_uninstall_question()
    {
        return GetString("theme-uninstall-question");
    }
    public static string theme_built_in_uninstall_hint()
    {
        return GetString("theme-built-in-uninstall-hint");
    }
    public static string theme_unsupported()
    {
        return GetString("theme-unsupported");
    }
    public static string extension_uninstall_question()
    {
        return GetString("extension-uninstall-question");
    }
    public static string extension_built_in_uninstall_hint()
    {
        return GetString("extension-built-in-uninstall-hint");
    }
    public static string extension_unsupported()
    {
        return GetString("extension-unsupported");
    }
    public static string extension_install_dir()
    {
        return GetString("extension-install-dir");
    }
    public static string extension_data_dir()
    {
        return GetString("extension-data-dir");
    }
    public static string diag_generating()
    {
        return GetString("diag-generating");
    }
    public static string diag_uploading()
    {
        return GetString("diag-uploading");
    }
    public static string add_from_exe()
    {
        return GetString("add-from-exe");
    }
    public static string what_is_this()
    {
        return GetString("what-is-this");
    }
    public static string confirmation_ask_generic()
    {
        return GetString("confirmation-ask-generic");
    }
    public static string stats_total_play_time()
    {
        return GetString("stats-total-play-time");
    }
    public static string stats_average_play_time()
    {
        return GetString("stats-average-play-time");
    }
    public static string stats_top_play_time()
    {
        return GetString("stats-top-play-time");
    }
    public static string stats_total_install_size()
    {
        return GetString("stats-total-install-size");
    }
    public static string overview_label()
    {
        return GetString("overview-label");
    }
    public static string sidebar()
    {
        return GetString("sidebar");
    }
    public static string tools_show_on_sidebar()
    {
        return GetString("tools-show-on-sidebar");
    }
    public static string settings_reset()
    {
        return GetString("settings-reset");
    }
    public static string settings_default_reset_desc()
    {
        return GetString("settings-default-reset-desc");
    }
    public static string settings_for_developers()
    {
        return GetString("settings-for-developers");
    }
    public static string settings_external_extensions()
    {
        return GetString("settings-external-extensions");
    }
    public static string settings_new_external_extension_box()
    {
        return GetString("settings-new-external-extension-box");
    }
    public static string common_links_achievements()
    {
        return GetString("common-links-achievements");
    }
    public static string common_links_forum()
    {
        return GetString("common-links-forum");
    }
    public static string common_links_news()
    {
        return GetString("common-links-news");
    }
    public static string common_links_store_page()
    {
        return GetString("common-links-store-page");
    }
    public static string fullscreen_first_time_error()
    {
        return GetString("fullscreen-first-time-error");
    }
    public static string quick_filter_recently_played()
    {
        return GetString("quick-filter-recently-played");
    }
    public static string quick_filter_favorites()
    {
        return GetString("quick-filter-favorites");
    }
    public static string quick_filter_most_played()
    {
        return GetString("quick-filter-most-played");
    }
    public static string quick_filter_all_games()
    {
        return GetString("quick-filter-all-games");
    }
    public static string game_list_filtered()
    {
        return GetString("game-list-filtered");
    }
    public static string game_list_extra_filtered()
    {
        return GetString("game-list-extra-filtered");
    }
    public static string game_list_search_results()
    {
        return GetString("game-list-search-results");
    }
    public static string item_already_exists()
    {
        return GetString("item-already-exists");
    }
    public static string random_game_limit_to_filter()
    {
        return GetString("random-game-limit-to-filter");
    }
    public static string random_game_pick_another()
    {
        return GetString("random-game-pick-another");
    }
    public static string menu_addons()
    {
        return GetString("menu-addons");
    }
    public static string extensions_installed()
    {
        return GetString("extensions-installed");
    }
    public static string extensions_settings()
    {
        return GetString("extensions-settings");
    }
    public static string extensions_browse()
    {
        return GetString("extensions-browse");
    }
    public static string extensions_updates()
    {
        return GetString("extensions-updates");
    }
    public static string extensions_updates_count(object updatesCount)
    {
        return GetString("extensions-updates-count", ("updatesCount", updatesCount));
    }
    public static string addons_config_move_info()
    {
        return GetString("addons-config-move-info");
    }
    public static string libraries_config_window_description()
    {
        return GetString("libraries-config-window-description");
    }
    public static string addons_themes_desktop()
    {
        return GetString("addons-themes-desktop");
    }
    public static string addons_themes_fullscreen()
    {
        return GetString("addons-themes-fullscreen");
    }
    public static string addons_searching()
    {
        return GetString("addons-searching");
    }
    public static string addon_error_not_compatible()
    {
        return GetString("addon-error-not-compatible");
    }
    public static string addon_error_download_failed()
    {
        return GetString("addon-error-download-failed");
    }
    public static string addon_error_manifest_download_error()
    {
        return GetString("addon-error-manifest-download-error");
    }
    public static string addon_changes_restart()
    {
        return GetString("addon-changes-restart");
    }
    public static string addon_queued_for_install()
    {
        return GetString("addon-queued-for-install");
    }
    public static string addon_install()
    {
        return GetString("addon-install");
    }
    public static string addon_uninstall()
    {
        return GetString("addon-uninstall");
    }
    public static string addon_already_installed()
    {
        return GetString("addon-already-installed");
    }
    public static string addon_no_addons_available()
    {
        return GetString("addon-no-addons-available");
    }
    public static string addon_update_addons()
    {
        return GetString("addon-update-addons");
    }
    public static string addon_changelog_not_available()
    {
        return GetString("addon-changelog-not-available");
    }
    public static string addon_update_status_downloaded()
    {
        return GetString("addon-update-status-downloaded");
    }
    public static string addon_update_status_failed()
    {
        return GetString("addon-update-status-failed");
    }
    public static string addon_update_status_license_rejected()
    {
        return GetString("addon-update-status-license-rejected");
    }
    public static string addon_downloading_addon(object addonName)
    {
        return GetString("addon-downloading-addon", ("addonName", addonName));
    }
    public static string addon_looking_for_updates()
    {
        return GetString("addon-looking-for-updates");
    }
    public static string addon_updates_available()
    {
        return GetString("addon-updates-available");
    }
    public static string addon_select_to_update()
    {
        return GetString("addon-select-to-update");
    }
    public static string addon_dev_reference_loaded()
    {
        return GetString("addon-dev-reference-loaded");
    }
    public static string addon_license_window_title(object addonName)
    {
        return GetString("addon-license-window-title", ("addonName", addonName));
    }
    public static string license_accept()
    {
        return GetString("license-accept");
    }
    public static string license_decline()
    {
        return GetString("license-decline");
    }
    public static string include_plugin_game_actions()
    {
        return GetString("include-plugin-game-actions");
    }
    public static string select_action_title()
    {
        return GetString("select-action-title");
    }
    public static string action_tracking_mode()
    {
        return GetString("action-tracking-mode");
    }
    public static string action_tracking_path()
    {
        return GetString("action-tracking-path");
    }
    public static string game_action_type_link()
    {
        return GetString("game-action-type-link");
    }
    public static string game_action_type_file()
    {
        return GetString("game-action-type-file");
    }
    public static string game_action_type_emulator()
    {
        return GetString("game-action-type-emulator");
    }
    public static string game_action_type_script()
    {
        return GetString("game-action-type-script");
    }
    public static string action_tracking_mode_default()
    {
        return GetString("action-tracking-mode-default");
    }
    public static string action_tracking_mode_process()
    {
        return GetString("action-tracking-mode-process");
    }
    public static string action_tracking_mode_directory()
    {
        return GetString("action-tracking-mode-directory");
    }
    public static string action_tracking_original_process()
    {
        return GetString("action-tracking-original-process");
    }
    public static string devel_trace_log_enable()
    {
        return GetString("devel-trace-log-enable");
    }
    public static string multi_edit_overwrite_warning()
    {
        return GetString("multi-edit-overwrite-warning");
    }
    public static string grid_view_spacing_mode_none()
    {
        return GetString("grid-view-spacing-mode-none");
    }
    public static string grid_view_spacing_mode_uniform()
    {
        return GetString("grid-view-spacing-mode-uniform");
    }
    public static string grid_view_spacing_mode_between_items_only()
    {
        return GetString("grid-view-spacing-mode-between-items-only");
    }
    public static string grid_view_spacing_mode_start_and_end_only()
    {
        return GetString("grid-view-spacing-mode-start-and-end-only");
    }
    public static string scrolling_sensitivity()
    {
        return GetString("scrolling-sensitivity");
    }
    public static string smooth_scrolling()
    {
        return GetString("smooth-scrolling");
    }
    public static string smooth_scrolling_speed()
    {
        return GetString("smooth-scrolling-speed");
    }
    public static string ask_remove_item_title()
    {
        return GetString("ask-remove-item-title");
    }
    public static string ask_remove_item_message()
    {
        return GetString("ask-remove-item-message");
    }
    public static string settings_top_panel_items()
    {
        return GetString("settings-top-panel-items");
    }
    public static string settings_top_panel_general_view_item()
    {
        return GetString("settings-top-panel-general-view-item");
    }
    public static string settings_top_panel_grouping_item()
    {
        return GetString("settings-top-panel-grouping-item");
    }
    public static string settings_top_panel_sorting_item()
    {
        return GetString("settings-top-panel-sorting-item");
    }
    public static string settings_top_panel_filter_presets_item()
    {
        return GetString("settings-top-panel-filter-presets-item");
    }
    public static string top_panel_plugin_panel_position()
    {
        return GetString("top-panel-plugin-panel-position");
    }
    public static string top_panel_separator_width()
    {
        return GetString("top-panel-separator-width");
    }
    public static string top_panel_main_button_move()
    {
        return GetString("top-panel-main-button-move");
    }
    public static string top_panel_explorer_switch()
    {
        return GetString("top-panel-explorer-switch");
    }
    public static string top_panel_select_random_game_button()
    {
        return GetString("top-panel-select-random-game-button");
    }
    public static string top_panel_view_select_random_game_button()
    {
        return GetString("top-panel-view-select-random-game-button");
    }
    public static string top_panel_view_select_random_game_button_tooltip()
    {
        return GetString("top-panel-view-select-random-game-button-tooltip");
    }
    public static string filter_preset_save_view_options()
    {
        return GetString("filter-preset-save-view-options");
    }
    public static string filter_preset_show_on_fs_top_panel()
    {
        return GetString("filter-preset-show-on-fs-top-panel");
    }
    public static string in_past7_days()
    {
        return GetString("in-past7-days");
    }
    public static string in_past31_days()
    {
        return GetString("in-past31-days");
    }
    public static string in_past365_days()
    {
        return GetString("in-past365-days");
    }
    public static string more_than365_days_ago()
    {
        return GetString("more-than365-days-ago");
    }
    public static string configure()
    {
        return GetString("configure");
    }
    public static string filter_preset_save()
    {
        return GetString("filter-preset-save");
    }
    public static string settings_minimize_after_starting_game()
    {
        return GetString("settings-minimize-after-starting-game");
    }
    public static string settings_minimize_after_starting_game_description()
    {
        return GetString("settings-minimize-after-starting-game-description");
    }
    public static string settings_font_size()
    {
        return GetString("settings-font-size");
    }
    public static string settings_font_size_small()
    {
        return GetString("settings-font-size-small");
    }
    public static string settings_xinput_processing()
    {
        return GetString("settings-xinput-processing");
    }
    public static string settings_xinput_processing_description()
    {
        return GetString("settings-xinput-processing-description");
    }
    public static string settings_show_items_main_menu_header()
    {
        return GetString("settings-show-items-main-menu-header");
    }
    public static string settings_swap_main_view_xa_buttons()
    {
        return GetString("settings-swap-main-view-xa-buttons");
    }
    public static string settings_swap_main_view_xa_buttons_descriptions()
    {
        return GetString("settings-swap-main-view-xa-buttons-descriptions");
    }
    public static string settings_swap_confirm_cancel_buttons()
    {
        return GetString("settings-swap-confirm-cancel-buttons");
    }
    public static string settings_swap_confirm_cancel_buttons_descriptions()
    {
        return GetString("settings-swap-confirm-cancel-buttons-descriptions");
    }
    public static string settings_primary_controller_only()
    {
        return GetString("settings-primary-controller-only");
    }
    public static string settings_primary_controller_only_description()
    {
        return GetString("settings-primary-controller-only-description");
    }
    public static string settings_refocus_on_guid_button()
    {
        return GetString("settings-refocus-on-guid-button");
    }
    public static string settings_interface_volume()
    {
        return GetString("settings-interface-volume");
    }
    public static string settings_music_volume()
    {
        return GetString("settings-music-volume");
    }
    public static string settings_mute_background()
    {
        return GetString("settings-mute-background");
    }
    public static string error_audio_interface_init()
    {
        return GetString("error-audio-interface-init");
    }
    public static string settings_audio_output_api()
    {
        return GetString("settings-audio-output-api");
    }
    public static string settings_audio_output_api_description()
    {
        return GetString("settings-audio-output-api-description");
    }
    public static string settings_fs_section_general()
    {
        return GetString("settings-fs-section-general");
    }
    public static string settings_fs_section_visuals()
    {
        return GetString("settings-fs-section-visuals");
    }
    public static string settings_fs_section_audio()
    {
        return GetString("settings-fs-section-audio");
    }
    public static string settings_fs_section_layout()
    {
        return GetString("settings-fs-section-layout");
    }
    public static string settings_fs_section_menus()
    {
        return GetString("settings-fs-section-menus");
    }
    public static string settings_fs_section()
    {
        return GetString("settings-fs-section");
    }
    public static string game_is_starting(object gameName)
    {
        return GetString("game-is-starting", ("gameName", gameName));
    }
    public static string game_is_running(object gameName)
    {
        return GetString("game-is-running", ("gameName", gameName));
    }
    public static string text_input_capitalize()
    {
        return GetString("text-input-capitalize");
    }
    public static string text_input_space()
    {
        return GetString("text-input-space");
    }
    public static string settings_image_scaler_mode()
    {
        return GetString("settings-image-scaler-mode");
    }
    public static string settings_image_scaling_alternative()
    {
        return GetString("settings-image-scaling-alternative");
    }
    public static string settings_image_scaling_balanced()
    {
        return GetString("settings-image-scaling-balanced");
    }
    public static string settings_image_scaling_quality()
    {
        return GetString("settings-image-scaling-quality");
    }
    public static string settings_image_scaler_mode_tooltip()
    {
        return GetString("settings-image-scaler-mode-tooltip");
    }
    public static string select_file_tooltip()
    {
        return GetString("select-file-tooltip");
    }
    public static string select_directory_tooltip()
    {
        return GetString("select-directory-tooltip");
    }
    public static string startup_script()
    {
        return GetString("startup-script");
    }
    public static string addon_perf_notice()
    {
        return GetString("addon-perf-notice");
    }
    public static string game_action_select_on_start()
    {
        return GetString("game-action-select-on-start");
    }
    public static string emulator_select_on_start()
    {
        return GetString("emulator-select-on-start");
    }
    public static string emulator_built_in_profiles()
    {
        return GetString("emulator-built-in-profiles");
    }
    public static string emulator_built_in_profile()
    {
        return GetString("emulator-built-in-profile");
    }
    public static string emulator_custom_profiles()
    {
        return GetString("emulator-custom-profiles");
    }
    public static string emulator_custom_profile()
    {
        return GetString("emulator-custom-profile");
    }
    public static string emulator_function_handled_by_script()
    {
        return GetString("emulator-function-handled-by-script");
    }
    public static string emulator_spec()
    {
        return GetString("emulator-spec");
    }
    public static string platform_spec()
    {
        return GetString("platform-spec");
    }
    public static string region_spec()
    {
        return GetString("region-spec");
    }
    public static string emulator_pre_script_description()
    {
        return GetString("emulator-pre-script-description");
    }
    public static string emulator_post_script_description()
    {
        return GetString("emulator-post-script-description");
    }
    public static string emulator_started_script_description()
    {
        return GetString("emulator-started-script-description");
    }
    public static string error_emulator_executable_not_found()
    {
        return GetString("error-emulator-executable-not-found");
    }
    public static string error_emulator_specification_not_found()
    {
        return GetString("error-emulator-specification-not-found");
    }
    public static string error_emulator_startup_script_not_found()
    {
        return GetString("error-emulator-startup-script-not-found");
    }
    public static string split_emu_import_split_games()
    {
        return GetString("split-emu-import-split-games");
    }
    public static string split_emu_import_merge_games()
    {
        return GetString("split-emu-import-merge-games");
    }
    public static string emu_import_assign_platform()
    {
        return GetString("emu-import-assign-platform");
    }
    public static string emu_import_assign_region()
    {
        return GetString("emu-import-assign-region");
    }
    public static string emu_scan_directory()
    {
        return GetString("emu-scan-directory");
    }
    public static string emu_scan_configurations()
    {
        return GetString("emu-scan-configurations");
    }
    public static string emu_crc_exclude_file_types()
    {
        return GetString("emu-crc-exclude-file-types");
    }
    public static string emu_crc_exclude_file_types_tooltip()
    {
        return GetString("emu-crc-exclude-file-types-tooltip");
    }
    public static string emu_scan_emulator()
    {
        return GetString("emu-scan-emulator");
    }
    public static string scan_config_name_error()
    {
        return GetString("scan-config-name-error");
    }
    public static string scan_config_no_emulator_error()
    {
        return GetString("scan-config-no-emulator-error");
    }
    public static string scan_config_directory_error()
    {
        return GetString("scan-config-directory-error");
    }
    public static string scan_config_error()
    {
        return GetString("scan-config-error");
    }
    public static string emu_scan_include_global_update()
    {
        return GetString("emu-scan-include-global-update");
    }
    public static string emulator_scan_failed()
    {
        return GetString("emulator-scan-failed");
    }
    public static string emulated_game_scan_failed()
    {
        return GetString("emulated-game-scan-failed");
    }
    public static string emu_scan_hide_imported()
    {
        return GetString("emu-scan-hide-imported");
    }
    public static string emu_import_profiles_to_import_header()
    {
        return GetString("emu-import-profiles-to-import-header");
    }
    public static string emu_auto_scan_configurations()
    {
        return GetString("emu-auto-scan-configurations");
    }
    public static string emu_save_scan_config()
    {
        return GetString("emu-save-scan-config");
    }
    public static string emu_save_scan_config_tooltip()
    {
        return GetString("emu-save-scan-config-tooltip");
    }
    public static string emu_import_with_relative_paths()
    {
        return GetString("emu-import-with-relative-paths");
    }
    public static string emu_import_with_relative_paths_tooltip()
    {
        return GetString("emu-import-with-relative-paths-tooltip");
    }
    public static string emu_import_scan_subfolders()
    {
        return GetString("emu-import-scan-subfolders");
    }
    public static string emu_import_scan_inside_archives()
    {
        return GetString("emu-import-scan-inside-archives");
    }
    public static string emu_merge_related_files()
    {
        return GetString("emu-merge-related-files");
    }
    public static string emu_merge_related_files_tooltip()
    {
        return GetString("emu-merge-related-files-tooltip");
    }
    public static string emu_add_scanner()
    {
        return GetString("emu-add-scanner");
    }
    public static string emu_add_saved_scanner()
    {
        return GetString("emu-add-saved-scanner");
    }
    public static string start_scan()
    {
        return GetString("start-scan");
    }
    public static string emu_import_directory_config_desc()
    {
        return GetString("emu-import-directory-config-desc");
    }
    public static string completion_status_default_status_desc()
    {
        return GetString("completion-status-default-status-desc");
    }
    public static string completion_status_played_status_desc()
    {
        return GetString("completion-status-played-status-desc");
    }
    public static string power_shell_creation_error()
    {
        return GetString("power-shell-creation-error");
    }
    public static string filter_preset_name_conflict()
    {
        return GetString("filter-preset-name-conflict");
    }
    public static string sorting_name_autofill()
    {
        return GetString("sorting-name-autofill");
    }
    public static string sorting_name_autofill_tooltip()
    {
        return GetString("sorting-name-autofill-tooltip");
    }
    public static string sorting_name_removed_articles()
    {
        return GetString("sorting-name-removed-articles");
    }
    public static string sorting_name_removed_articles_tooltip()
    {
        return GetString("sorting-name-removed-articles-tooltip");
    }
    public static string sorting_name_autofill_button()
    {
        return GetString("sorting-name-autofill-button");
    }
    public static string settings_sorting_label()
    {
        return GetString("settings-sorting-label");
    }
    public static string sorting_name_autofill_progress()
    {
        return GetString("sorting-name-autofill-progress");
    }
    public static string nahimic_service_warning()
    {
        return GetString("nahimic-service-warning");
    }
    public static string elevated_process_warning()
    {
        return GetString("elevated-process-warning");
    }
    public static string elevated_process_warning_show_option()
    {
        return GetString("elevated-process-warning-show-option");
    }
    public static string install_size_scan_use_size_on_disk_option()
    {
        return GetString("install-size-scan-use-size-on-disk-option");
    }
    public static string install_size_scan_use_size_on_disk_option_tooltip()
    {
        return GetString("install-size-scan-use-size-on-disk-option-tooltip");
    }
    public static string warning_blacklisted_extensions(object addonNames)
    {
        return GetString("warning-blacklisted-extensions", ("addonNames", addonNames));
    }
    public static string emu_exclude_online_files()
    {
        return GetString("emu-exclude-online-files");
    }
    public static string emu_exclude_online_files_tooltip()
    {
        return GetString("emu-exclude-online-files-tooltip");
    }
    public static string emu_use_simplified_online_file_scan()
    {
        return GetString("emu-use-simplified-online-file-scan");
    }
    public static string emu_use_simplified_online_file_scan_tooltip()
    {
        return GetString("emu-use-simplified-online-file-scan-tooltip");
    }
    public static string metadata_set_all_fields_to_value()
    {
        return GetString("metadata-set-all-fields-to-value");
    }
    public static string override_install_state()
    {
        return GetString("override-install-state");
    }
    public static string override_install_state_tooltip()
    {
        return GetString("override-install-state-tooltip");
    }
    public static string option_only_manually()
    {
        return GetString("option-only-manually");
    }
    public static string option_once_a_day()
    {
        return GetString("option-once-a-day");
    }
    public static string option_once_a_week()
    {
        return GetString("option-once-a-week");
    }
    public static string option_on_every_startup()
    {
        return GetString("option-on-every-startup");
    }
    public static string check_program_updates()
    {
        return GetString("check-program-updates");
    }
    public static string check_addon_updates()
    {
        return GetString("check-addon-updates");
    }
    public static string check_library_updates()
    {
        return GetString("check-library-updates");
    }
    public static string check_emulated_library_updates()
    {
        return GetString("check-emulated-library-updates");
    }
    public static string stats_include_hidden()
    {
        return GetString("stats-include-hidden");
    }
    public static string menu_set_fields()
    {
        return GetString("menu-set-fields");
    }
    public static string item_selection_select_deselect_all()
    {
        return GetString("item-selection-select-deselect-all");
    }
    public static string open()
    {
        return GetString("open");
    }
    public static string activate()
    {
        return GetString("activate");
    }
    public static string assign()
    {
        return GetString("assign");
    }
    public static string default_search_description()
    {
        return GetString("default-search-description");
    }
    public static string default_search_hint()
    {
        return GetString("default-search-hint");
    }
    public static string search_filter_uninstalled()
    {
        return GetString("search-filter-uninstalled");
    }
    public static string search_filter_hidden()
    {
        return GetString("search-filter-hidden");
    }
    public static string search_filter_uninstalled_included()
    {
        return GetString("search-filter-uninstalled-included");
    }
    public static string search_filter_uninstalled_excluded()
    {
        return GetString("search-filter-uninstalled-excluded");
    }
    public static string search_filter_hidden_included()
    {
        return GetString("search-filter-hidden-included");
    }
    public static string search_filter_hidden_excluded()
    {
        return GetString("search-filter-hidden-excluded");
    }
    public static string game_search_item_action_play()
    {
        return GetString("game-search-item-action-play");
    }
    public static string game_search_item_action_switch_to()
    {
        return GetString("game-search-item-action-switch-to");
    }
    public static string game_search_item_action_open_menu()
    {
        return GetString("game-search-item-action-open-menu");
    }
    public static string game_search_item_action_edit()
    {
        return GetString("game-search-item-action-edit");
    }
    public static string open_search()
    {
        return GetString("open-search");
    }
    public static string top_panel_search_box()
    {
        return GetString("top-panel-search-box");
    }
    public static string top_panel_search_button()
    {
        return GetString("top-panel-search-button");
    }
    public static string search_settings_primary_action()
    {
        return GetString("search-settings-primary-action");
    }
    public static string search_settings_secondary_action()
    {
        return GetString("search-settings-secondary-action");
    }
    public static string search_settings_keyboard_open_search()
    {
        return GetString("search-settings-keyboard-open-search");
    }
    public static string search_settings_save_filter()
    {
        return GetString("search-settings-save-filter");
    }
    public static string search_settings_search_providers()
    {
        return GetString("search-settings-search-providers");
    }
    public static string search_settings_default_keyword()
    {
        return GetString("search-settings-default-keyword");
    }
    public static string search_settings_custom_keyword()
    {
        return GetString("search-settings-custom-keyword");
    }
    public static string search_settings_system_wide_shortcut()
    {
        return GetString("search-settings-system-wide-shortcut");
    }
    public static string search_title()
    {
        return GetString("search-title");
    }
    public static string extension_settings_menu()
    {
        return GetString("extension-settings-menu");
    }
    public static string exclusions()
    {
        return GetString("exclusions");
    }
    public static string emu_scanner_excluded_files()
    {
        return GetString("emu-scanner-excluded-files");
    }
    public static string emu_scanner_excluded_folders()
    {
        return GetString("emu-scanner-excluded-folders");
    }
    public static string emu_import_add_rom_exclusion_list()
    {
        return GetString("emu-import-add-rom-exclusion-list");
    }
    public static string emu_import_add_folder_exclusion_list()
    {
        return GetString("emu-import-add-folder-exclusion-list");
    }
    public static string emu_exclusion_no_config_error()
    {
        return GetString("emu-exclusion-no-config-error");
    }
    public static string emu_exclusion_added_message(object scannerName)
    {
        return GetString("emu-exclusion-added-message", ("scannerName", scannerName));
    }
    public static string emu_override_platform()
    {
        return GetString("emu-override-platform");
    }
    public static string emu_override_platform_tooltip()
    {
        return GetString("emu-override-platform-tooltip");
    }
    public static string search_include_commands_in_default()
    {
        return GetString("search-include-commands-in-default");
    }
    public static string search_include_commands_in_default_tooltip()
    {
        return GetString("search-include-commands-in-default-tooltip");
    }
    public static string name_filter_use_fuzzy_matching()
    {
        return GetString("name-filter-use-fuzzy-matching");
    }
    public static string name_filter_use_fuzzy_matching_tooltip()
    {
        return GetString("name-filter-use-fuzzy-matching-tooltip");
    }
    public static string search_view_game_field_options()
    {
        return GetString("search-view-game-field-options");
    }
    public static string hidden_status()
    {
        return GetString("hidden-status");
    }
    public static string backup_cancelled()
    {
        return GetString("backup-cancelled");
    }
    public static string backup_failed()
    {
        return GetString("backup-failed");
    }
    public static string backup_error_title()
    {
        return GetString("backup-error-title");
    }
    public static string backup_progress()
    {
        return GetString("backup-progress");
    }
    public static string backup_restore_progress()
    {
        return GetString("backup-restore-progress");
    }
    public static string backup_restore_failed()
    {
        return GetString("backup-restore-failed");
    }
    public static string backup_option_settings()
    {
        return GetString("backup-option-settings");
    }
    public static string backup_option_library()
    {
        return GetString("backup-option-library");
    }
    public static string backup_option_game_media()
    {
        return GetString("backup-option-game-media");
    }
    public static string backup_option_extensions()
    {
        return GetString("backup-option-extensions");
    }
    public static string backup_option_extensions_data()
    {
        return GetString("backup-option-extensions-data");
    }
    public static string backup_option_themes()
    {
        return GetString("backup-option-themes");
    }
    public static string backup_restore_message()
    {
        return GetString("backup-restore-message");
    }
    public static string backup_data_backup_message()
    {
        return GetString("backup-data-backup-message");
    }
    public static string settings_enable_automatic_backup()
    {
        return GetString("settings-enable-automatic-backup");
    }
    public static string settings_auto_backup_frequency()
    {
        return GetString("settings-auto-backup-frequency");
    }
    public static string settings_backup_folder()
    {
        return GetString("settings-backup-folder");
    }
    public static string settings_rotating_backups()
    {
        return GetString("settings-rotating-backups");
    }
    public static string settings_auto_backup_include_items()
    {
        return GetString("settings-auto-backup-include-items");
    }
    public static string settings_no_backup_dir_specified_error()
    {
        return GetString("settings-no-backup-dir-specified-error");
    }
    public static string update_notify_only_patches()
    {
        return GetString("update-notify-only-patches");
    }
    public static string update_notify_only_patches_tooltip()
    {
        return GetString("update-notify-only-patches-tooltip");
    }
    public static string settings_past_week_relative_format()
    {
        return GetString("settings-past-week-relative-format");
    }
    public static string settings_past_week_relative_format_tooltip()
    {
        return GetString("settings-past-week-relative-format-tooltip");
    }
    public static string settings_web_image_search()
    {
        return GetString("settings-web-image-search");
    }
    public static string settings_web_image_search_icon_term()
    {
        return GetString("settings-web-image-search-icon-term");
    }
    public static string settings_web_image_search_cover_term()
    {
        return GetString("settings-web-image-search-cover-term");
    }
    public static string settings_web_image_search_background()
    {
        return GetString("settings-web-image-search-background");
    }
    public static string settings_addon_information()
    {
        return GetString("settings-addon-information");
    }
    public static string no_metadata_source()
    {
        return GetString("no-metadata-source");
    }
    public static string scanner_config_play_action_settings()
    {
        return GetString("scanner-config-play-action-settings");
    }
    public static string scanner_config_play_action_settings_scanner()
    {
        return GetString("scanner-config-play-action-settings-scanner");
    }
    public static string scanner_config_play_action_settings_select_profile()
    {
        return GetString("scanner-config-play-action-settings-select-profile");
    }
    public static string scanner_config_play_action_settings_select_emulator()
    {
        return GetString("scanner-config-play-action-settings-select-emulator");
    }
    public static string automatic()
    {
        return GetString("automatic");
    }
    public static string always_on()
    {
        return GetString("always-on");
    }
    public static string always_off()
    {
        return GetString("always-off");
    }
    public static string settings_accessibility_interface()
    {
        return GetString("settings-accessibility-interface");
    }
    public static string application_menu()
    {
        return GetString("application-menu");
    }
    public static string game_menu()
    {
        return GetString("game-menu");
    }
    public static string program_folder()
    {
        return GetString("program-folder");
    }
    public static string user_data_folder()
    {
        return GetString("user-data-folder");
    }
    public static string db_corruption_crash_message()
    {
        return GetString("db-corruption-crash-message");
    }
}
