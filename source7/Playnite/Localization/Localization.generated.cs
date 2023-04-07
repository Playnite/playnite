using Linguini.Shared.Types.Bundle;
namespace Playnite;

public static partial class Loc
{
    private static readonly HashSet<string> stringIds = new()
    {
        "language-name", 
        "language-settings-label", 
        "exit-app-label", 
        "filter-active-label", 
        "filter-inactive-label", 
        "aditional-filters", 
        "filters", 
        "filter", 
        "invalid-data-title", 
        "save-changes-ask-title", 
        "about-home-page-link", 
        "about-source-link", 
        "about-create-diag-button", 
        "about-send-diag-button", 
        "about-window-title", 
        "about-author", 
        "category-window-title", 
        "category-set-button", 
        "category-add-cat-button", 
        "category-tooltip", 
        "no-category", 
        "no-platform", 
        "crash-window-title", 
        "crash-description", 
        "ext-crash-description", 
        "ext-crash-description-fs", 
        "ext-crash-description-uknown", 
        "crash-description-fullscreen", 
        "crash-disable-extension", 
        "crash-save-log", 
        "crash-send-diag", 
        "crash-report-issue", 
        "crash-restart-playnite", 
        "crash-restart-safe", 
        "crash-restart-safe-tooltip", 
        "crash-close-playnite", 
        "crash-user-actions-description", 
        "library-manager", 
        "game-remove-ask-title", 
        "game-remove-running-error", 
        "game-uninstall-running-error", 
        "game-remove-ask-message", 
        "games-remove-ask-message", 
        "game-remove-ask-message-ignore-option", 
        "games-remove-ask-message-ignore-option", 
        "remove-unused-fields-ask-message", 
        "remove-unused-fields-no-unused-message", 
        "remove-ask-add-to-exlusion-list-yes-response", 
        "game-edit-change-notif", 
        "dbupgrade-progress", 
        "dbupgrade-fail", 
        "dbupgrade-empty-space-fail", 
        "game-error", 
        "game-start-error-no-game", 
        "game-start-error", 
        "game-start-action-error", 
        "game-open-location-error", 
        "calculate-game-size-error", 
        "calculate-game-size-error-caption", 
        "calculate-games-size-error-message", 
        "game-shortcut-error", 
        "manual-open-error", 
        "game-install-error", 
        "game-uninstall-error", 
        "error-no-play-action", 
        "error-no-install-action", 
        "error-library-plugin-not-found", 
        "error-no-metadata-downloader", 
        "error-no-game-selected", 
        "error-game-script-action", 
        "error-application-script", 
        "error-global-script-action", 
        "error-emulator-script-action", 
        "error-play-script-action", 
        "error-power-shell-not-installed", 
        "error-startup-no-controller", 
        "enabled-title", 
        "remove-title", 
        "remove-unused-title", 
        "rename-title", 
        "copy-title", 
        "add-title", 
        "default-icon-title", 
        "default-cover-title", 
        "default-background-title", 
        "finish-label", 
        "next-label", 
        "back-label", 
        "done-cap-label", 
        "back-cap-label", 
        "clear-cap-label", 
        "clear-label", 
        "dismiss", 
        "dismiss-all", 
        "import-label", 
        "name-label", 
        "author-label", 
        "module-label", 
        "series-label", 
        "version-label", 
        "last-played-label", 
        "most-played-label", 
        "play-count-label", 
        "install-size-label", 
        "folder-label", 
        "notes-label", 
        "added-label", 
        "date-added-label", 
        "modified-label", 
        "date-modified-label", 
        "website-label", 
        "path-label", 
        "oklabel", 
        "save-label", 
        "close-label", 
        "cancel-label", 
        "confirm-label", 
        "reset-label", 
        "yes-label", 
        "no-label", 
        "welcome-label", 
        "local-user-label", 
        "general-label", 
        "media-label", 
        "links-label", 
        "installation-label", 
        "actions-label", 
        "downloading-label", 
        "downloading-media-label", 
        "loading-label", 
        "type-label", 
        "profile-label", 
        "profiles-label", 
        "remove-label", 
        "download-label", 
        "search-label", 
        "search-resolution-label", 
        "search-resolution-any-label", 
        "zoom-label", 
        "list-view-label", 
        "covers-label", 
        "grid-view-label", 
        "details-view-label", 
        "custom-label", 
        "urllabel", 
        "patrons-label", 
        "license-label", 
        "contributors-label", 
        "closing-playnite", 
        "today", 
        "yesterday", 
        "monday", 
        "tuesday", 
        "wednesday", 
        "thursday", 
        "friday", 
        "saturday", 
        "sunday", 
        "past-week", 
        "past-month", 
        "past-year", 
        "more-then-year", 
        "size-zero-to100-mb", 
        "size100-mb-to1-gb", 
        "size1-gb-to5-gb", 
        "size5-gb-to10-gb", 
        "size10-gb-to20-gb", 
        "size20-gb-to40-gb", 
        "size40-gb-to100-gb", 
        "size-more-than100-gb", 
        "import-completed", 
        "all-games", 
        "game-id", 
        "database-id", 
        "presets", 
        "column", 
        "columns", 
        "row", 
        "rows", 
        "exec-icon-missing-play-action", 
        "meta-skip-non-empty", 
        "meta-skip-non-empty-tooltip", 
        "meta-games-source-intro", 
        "meta-games-source-description", 
        "meta-game-source-all", 
        "meta-game-source-filtered", 
        "meta-game-source-selected", 
        "meta-source-store", 
        "meta-source-igdb", 
        "meta-description-fields", 
        "meta-igdb-contrib-notif", 
        "progress-metadata", 
        "progress-installed-games", 
        "progress-importin-games", 
        "progress-importin-emulated-games", 
        "progress-library-games", 
        "progress-scanning-games-install-size", 
        "progress-scanning-imported-games-install-size", 
        "progress-lib-import-finish", 
        "progress-releasing-resources", 
        "menu-configuration-title", 
        "menu-playnite-settings-title", 
        "menu-platform-emulator-settings-title", 
        "menu-configure-emulators-menu-title", 
        "menu-library-manager-title", 
        "menu-tools", 
        "menu-download-metadata", 
        "menu-software-tools", 
        "menu-configure-integrations", 
        "menu-open-client", 
        "menu-clients", 
        "menu-reload-library", 
        "menu-cancel-library-update", 
        "menu-update-emulated-dirs", 
        "menu-add-game", 
        "menu-add-game-manual", 
        "menu-add-game-installed", 
        "menu-add-game-emulated", 
        "menu-add-windows-store", 
        "menu-about", 
        "menu-issues", 
        "menu-open-fullscreen", 
        "menu-links-title", 
        "menu-help-title", 
        "menu-patreon-support", 
        "sdkdocumentation", 
        "menu-restart-system", 
        "menu-shutdown-system", 
        "menu-suspend-system", 
        "menu-hibernate-system", 
        "menu-select-random-game", 
        "settings-details-panel-items", 
        "settings-grid-item-spacing", 
        "settings-grid-item-draw-background", 
        "settings-grid-item-cover-margin", 
        "settings-defaul-icon-source", 
        "settings-defaul-cover-source", 
        "settings-defaul-background-source", 
        "settings-indent-game-details", 
        "settings-grid-view-details-position", 
        "settings-details-game-list-position", 
        "settings-draw-panel-separators", 
        "settings-game-details-cover-height", 
        "settings-game-details-list-icon-size", 
        "settings-interface-font", 
        "settings-interface-mono-font", 
        "settings-filter-panel-position", 
        "settings-explorer-panel-position", 
        "settings-cover-art-rendering-label", 
        "settings-target-aspect-ratio-label", 
        "settings-grid-tile-layout-fsnote", 
        "settings-strech-mode-label", 
        "settings-covert-aspect-dvd", 
        "settings-covert-aspect-epic-games-store", 
        "settings-covert-aspect-gog-galaxy2", 
        "settings-covert-aspect-igdb", 
        "settings-covert-aspect-square", 
        "settings-covert-aspect-steam", 
        "settings-covert-aspect-steam-vertical", 
        "settings-covert-aspect-twitch", 
        "settings-restart-notification", 
        "settings-label", 
        "settings-general-label", 
        "settings-top-panel-label", 
        "settings-appearance-label", 
        "settings-game-details-label", 
        "settings-layout-label", 
        "settings-advanced-label", 
        "settings-fullscreen-label", 
        "settings-input-label", 
        "settings-performance-label", 
        "settings-metadata-label", 
        "settings-updating", 
        "settings-search", 
        "settings-backup", 
        "menu-backup-data", 
        "menu-restore-backup", 
        "settings-import-label", 
        "settings-invalid-dblocation", 
        "settings-invalid-account-name", 
        "settings-download-metadata-on-import", 
        "settings-start-minimized", 
        "settings-start-on-boot", 
        "settings-start-on-boot-closed-to-tray", 
        "settings-start-on-boot-registration-error", 
        "settings-start-in-fullscreen", 
        "settings-async-image-loading", 
        "settings-async-image-loading-tooltip", 
        "settings-show-name-empty-cover", 
        "settings-show-names-under-cover", 
        "settings-darken-uninstalled-grid-covers", 
        "settings-show-icon-list", 
        "settings-show-group-count", 
        "settings-used-fields-only-on-filter-lists", 
        "settings-disable-acceleration", 
        "settings-disable-acceleration-tooltip", 
        "settings-hidden-in-quick-launch", 
        "settings-hidden-in-quick-launch-tooltip", 
        "settings-quic-launch-items", 
        "settings-show-background-window-image", 
        "settings-blur-window-backgroun-image", 
        "settings-blur-high-quality", 
        "settings-darken-window-backghroun-image", 
        "settings-show-back-image-on-grid-view", 
        "settings-skin", 
        "settings-skin-color", 
        "settings-skin-fullscreen", 
        "settings-skin-color-fullscreen", 
        "settings-dblocation", 
        "settings-login-status", 
        "settings-window-title", 
        "settings-clear-web-cache", 
        "settings-clear-web-cache-tooltip", 
        "settings-show-tray", 
        "settings-minimize-to-tray", 
        "settings-close-to-tray", 
        "settings-after-game-start", 
        "settings-after-game-close", 
        "settings-playtime-use-days-format-label", 
        "settings-dates-formats-label", 
        "settings-clear-cache-warn", 
        "settings-clear-cache-title", 
        "settings-skin-change-restart", 
        "settings-get-themes", 
        "settings-create-themes", 
        "settings-get-extensions", 
        "settings-create-extensions", 
        "settings-create-localization", 
        "settings-restart-ask-message", 
        "settings-restart-title", 
        "settings-dbpath-notification", 
        "settings-close-playtime-notif", 
        "settings-fullscreen-rows", 
        "settings-fullscreen-columns", 
        "settings-fullscreen-row-details", 
        "settings-fullscreen-background-on-main-screen", 
        "background-image-screen-option-tooltip", 
        "settings-playtime-import-mode", 
        "settings-playtime-import-mode-tooltip", 
        "settings-playtime-import-mode-always", 
        "settings-playtime-import-mode-new-imports-only", 
        "settings-playtime-import-mode-never", 
        "settings-xinput-in-desktop-mode", 
        "settings-xinput-guide-opens-fullscreen", 
        "settings-default-metadata-description", 
        "settings-target-display", 
        "settings-always-use-primary-display", 
        "settings-fullscreen-show-game-titles", 
        "settings-show-battery-status", 
        "settings-show-battery-percentage", 
        "settings-show-clock", 
        "settings-hide-mouse-cursor", 
        "settings-fullscreen-quick-filter-installed", 
        "settings-fullscreen-button-prompts", 
        "settings-fullscreen-layout", 
        "settings-fullscreen-horizontal-scrolling", 
        "settings-select-child-section", 
        "settings-no-settings-available", 
        "settings-error-loading-settings", 
        "settings-scripting-notice", 
        "settings-background-image-animation", 
        "settings-font-sizes", 
        "settings-text-rendering-mode-option-auto", 
        "settings-text-rendering-mode-option-aliased", 
        "settings-text-rendering-mode-option-grayscale", 
        "settings-text-rendering-mode-option-clear-type", 
        "settings-text-formatting-mode-option-ideal", 
        "settings-text-formatting-mode-option-display", 
        "settings-text-formatting-mode", 
        "settings-text-rendering-mode", 
        "settings-text-rendering-notice", 
        "settings-immediate-background-download", 
        "settings-immediate-background-download-tooltip", 
        "settings-auto-close-launcher-option", 
        "settings-auto-close-grace-period", 
        "settings-auto-close-minimal-session-time", 
        "settings-auto-close-specific-clients", 
        "settings-auto-close-section", 
        "settings-import-exclusion-list", 
        "settings-show-media-size-warning", 
        "open-directory-command", 
        "settings-preferred-age-rating-org", 
        "settings-scan-lib-install-size-on-lib-update", 
        "settings-scan-lib-install-size-on-lib-update-tooltip", 
        "strech-none", 
        "strech-fill", 
        "strech-uniform", 
        "strech-uniform-to-fill", 
        "dock-left", 
        "dock-right", 
        "dock-top", 
        "dock-bottom", 
        "import-error", 
        "login-required", 
        "login-failed", 
        "settings-alt-web-view-rendering", 
        "settings-alt-web-view-rendering-tooltip", 
        "settings-partial-description-loading", 
        "settings-partial-description-loading-tooltip", 
        "meta-import-window-title", 
        "download-meta-button", 
        "save-default-tooltip", 
        "emu-wizard-window-title", 
        "emu-wizard-intro", 
        "emu-wizard-notice", 
        "emu-download-description", 
        "emu-wizard-emu-import-intro", 
        "emu-wizard-game-import-intro", 
        "emu-wizard-no-emulator-warning", 
        "emu-wizard-no-emulator-for-games-warning", 
        "emu-wizard-button-scan-games", 
        "emu-wizard-button-select-files", 
        "emu-wizard-button-scan-emulator", 
        "emu-wizard-button-configure-emulator", 
        "emu-wizard-scanning", 
        "emu-wizard-scanning-specific", 
        "first-window-title", 
        "first-intro", 
        "first-external-title", 
        "first-import-introduction", 
        "first-config-finished-title", 
        "first-config-finished-text", 
        "first-plugin-download-error", 
        "first-downloading-addon", 
        "default-addon-list-download", 
        "default-addon-list-download-error", 
        "platforms-window-title", 
        "emulators-window-title", 
        "platforms-title", 
        "platform-title", 
        "emulators-title", 
        "emulator-title", 
        "add-platform-title", 
        "select-icon-title", 
        "select-cover-title", 
        "select-image-title", 
        "select-item-title", 
        "select-background-title", 
        "select-file-title", 
        "select-url-title", 
        "add-emulator-title", 
        "supported-platforms-title", 
        "confirm-unsaved-platforms-title", 
        "confirm-unsaved-emulators-title", 
        "executable-title", 
        "arguments-title", 
        "working-dir-title", 
        "supported-files-title", 
        "import-emulators-button", 
        "download-emulators-button", 
        "emu-load-args-preset-tooltip", 
        "emu-removal-confirmation", 
        "platform-removal-confirmation", 
        "emulator-settings-help", 
        "menu-sort-by-title", 
        "menu-sort-by-direction", 
        "menu-group-by-title", 
        "menu-sort-ascending", 
        "menu-sort-descending", 
        "menu-group-dont", 
        "menu-group-provider", 
        "menu-group-category", 
        "menu-group-platform", 
        "view-type", 
        "menu-view", 
        "menu-view-explorer-panel", 
        "menu-view-filter-panel", 
        "game-icon-title", 
        "library-icon-title", 
        "game-cover-image-title", 
        "game-background-title", 
        "game-sorting-name-title", 
        "game-provider-title", 
        "game-manual-title", 
        "game-name-title", 
        "install-drive-title", 
        "game-account-name-title", 
        "game-platform-title", 
        "game-categories-title", 
        "game-genres-title", 
        "game-release-date-title", 
        "game-release-year-title", 
        "game-developers-title", 
        "game-tags-title", 
        "game-publishers-title", 
        "game-installation-status", 
        "use-filter-style-and-title", 
        "use-filter-style-and-tooltip", 
        "game-is-installed-title", 
        "game-is-game-installed-title", 
        "game-is-un-installed-title", 
        "game-hidden-title", 
        "game-favorite-title", 
        "game-hdr-title", 
        "game-hdr-tooltip", 
        "game-hdr-not-supported-tooltip", 
        "game-last-activity-title", 
        "game-category-title", 
        "game-description-title", 
        "game-install-dir-title", 
        "game-cover-title", 
        "game-links-title", 
        "game-romtitle", 
        "genre-label", 
        "genres-label", 
        "company-label", 
        "companies-label", 
        "developer-label", 
        "developers-label", 
        "publisher-label", 
        "publishers-label", 
        "category-label", 
        "categories-label", 
        "tag-label", 
        "tags-label", 
        "feature-label", 
        "features-label", 
        "age-rating-label", 
        "age-ratings-label", 
        "region-label", 
        "regions-label", 
        "source-label", 
        "sources-label", 
        "recent-activity-label", 
        "database-erro-title", 
        "database-open-error", 
        "database-not-opened-error", 
        "database-open-access-error", 
        "diag-package-creation-error", 
        "diag-package-upload-error", 
        "diag-package-sent-success", 
        "diag-package-creation-success", 
        "library-import-error", 
        "library-import-emulated-error", 
        "scan-emulator-games-empty-profile-error", 
        "start-generic-error", 
        "skin-apply-error", 
        "urlformat-error", 
        "app-startup-error", 
        "cef-sharp-init-error", 
        "emulator-import-no-definitions-error", 
        "xinput-init-error-message", 
        "menu-action-exec-error", 
        "game-edit-window-title", 
        "use-exe-icon", 
        "image-url", 
        "add-link-button", 
        "add-rom", 
        "save-changes", 
        "game-edit-change-save-tooltip", 
        "add-action", 
        "delete-action", 
        "remove-play-action", 
        "add-games", 
        "scan-folder", 
        "detect-installed", 
        "browse", 
        "open-playnite", 
        "profile-settings", 
        "empty-game-name-error", 
        "empty-tracking-folder-error", 
        "empty-game-name-meta-search-error", 
        "invalid-game-data", 
        "urlinput-info", 
        "urlinput-info-titile", 
        "metadata-download-error", 
        "download-error", 
        "clear-filters", 
        "private-account", 
        "public-account", 
        "apikey", 
        "startup-error", 
        "skin-error", 
        "clear-all", 
        "setup-running", 
        "uninstalling", 
        "game-launching", 
        "game-running", 
        "invalid-url", 
        "do-nothing", 
        "minimize", 
        "restore-window", 
        "close", 
        "change", 
        "advanced", 
        "never", 
        "completion-status", 
        "completion-statuses", 
        "user-score", 
        "critic-score", 
        "community-score", 
        "game-scripts", 
        "application-scripts", 
        "scripts", 
        "plugins", 
        "metadata-providers", 
        "extensions", 
        "extension-id", 
        "reload-scripts", 
        "start-interactive-power-shell", 
        "reload-scripts-success", 
        "no-games-found", 
        "no-items-found", 
        "back-to-desktop-mode", 
        "exit-playnite", 
        "libraries", 
        "update-all", 
        "extension-created-by", 
        "extension-version", 
        "extension-updated", 
        "extension-module", 
        "library", 
        "statistics", 
        "all", 
        "none", 
        "notifications", 
        "width", 
        "height", 
        "size", 
        "font-small", 
        "font-normal", 
        "font-large", 
        "font-larger", 
        "font-largest", 
        "default-label", 
        "select", 
        "select-all", 
        "deselect-all", 
        "first", 
        "random", 
        "user-select", 
        "load-more", 
        "transparent", 
        "collapse", 
        "expand", 
        "collapse-all", 
        "expand-all", 
        "other", 
        "themes", 
        "emulator-arguments", 
        "builtin-arguments", 
        "custom-arguments", 
        "additional-emulator-arguments", 
        "override-emulator-arguments", 
        "is-play-action", 
        "medata-diff-window-title", 
        "game-import-window-title", 
        "meta-lookup-window-title", 
        "updater-window-title", 
        "updater-changes-info", 
        "updater-install-update", 
        "check-for-updates", 
        "update-error", 
        "update-check-fail-message", 
        "update-no-new-update-message", 
        "general-update-fail-message", 
        "update-progress-cancel-ask", 
        "background-progress-cancel-ask-exit", 
        "background-progress-cancel-ask-switch-mode", 
        "update-is-available-notification-body", 
        "theme-test-reload-list", 
        "theme-test-apply-skin", 
        "theme-test-watch-changes", 
        "theme-test-watch-changes-tooltip", 
        "script-runtime", 
        "pre-script-description", 
        "post-script-description", 
        "game-started-script-description", 
        "app-script-startup-description", 
        "app-script-shutdown-description", 
        "script-type-starting", 
        "script-type-started", 
        "script-type-exit", 
        "execute-global-script", 
        "stats-global", 
        "stats-filtered", 
        "metadata-diff-current", 
        "metadata-diff-new", 
        "test-script", 
        "only-items-selected-tooltip", 
        "save-as-default", 
        "favorite-game", 
        "remove-favorite-game", 
        "hide-game", 
        "un-hide-game", 
        "enable-hdr", 
        "disable-hdr", 
        "edit-game", 
        "calculate-install-size", 
        "calculate-games-all-install-size", 
        "calculate-games-missing-install-size", 
        "install-size-menu-label", 
        "set-game-category", 
        "set-completion-status", 
        "remove-game", 
        "play-game", 
        "install-game", 
        "game-options", 
        "game-details", 
        "uninstall-game", 
        "open-game-location", 
        "create-desktop-shortcut", 
        "open-game-manual", 
        "more-action", 
        "play-action-use-plugin", 
        "play-action-use-plugin-tooltip", 
        "metadownload-no-results-message", 
        "metadownload-single-game-tip", 
        "progreess-availability-message", 
        "description-htmlsupport-tooltip", 
        "description-playtime-seconds", 
        "description-size-bytes", 
        "release-date-tooltip", 
        "description-score-values", 
        "patreon-develop-message", 
        "about-contributors-message", 
        "cancel-monitoring-ask-title", 
        "cancel-monitoring-setup-ask", 
        "cancel-monitoring-execution-ask", 
        "time-played", 
        "last-played", 
        "played-days", 
        "played-hours", 
        "played-minutes", 
        "played-seconds", 
        "played-none", 
        "opening-desktop-mode-message", 
        "opening-fullscreen-mode-message", 
        "opening-database", 
        "calculating-install-size-message", 
        "calculating-install-size-of-game-message", 
        "script-install-fail", 
        "script-install-success", 
        "install-script", 
        "script-error", 
        "script-execution-error", 
        "open-metadata-folder", 
        "install-size-calculate", 
        "install-size-calculate-edit-button-tooltip", 
        "client-not-installed-error", 
        "sign-in-external-notif", 
        "sign-in-external-wait-message", 
        "install-dir-not-found-error", 
        "invalid-game-action-settings", 
        "trouble-shooting-account-link", 
        "trouble-shooting-issues", 
        "rename-item", 
        "add-new-item", 
        "enter-name", 
        "enter-new-name", 
        "playtime-less-then-an-hour", 
        "playtime1to10", 
        "playtime10to100", 
        "playtime100to500", 
        "playtime500to1000", 
        "playtime1000plus", 
        "ext-installation-restart-notif", 
        "general-extension-package-error", 
        "general-theme-package-error", 
        "specific-extension-load-error", 
        "specific-extension-load-sdkerror", 
        "specific-theme-load-error", 
        "specific-theme-load-sdkerror", 
        "general-extension-load-error", 
        "general-theme-load-error", 
        "general-extension-install-api-version-fails", 
        "general-extension-install-success", 
        "general-extension-install-title", 
        "extension-generic", 
        "addon-install-faild", 
        "extension-install-fail", 
        "extension-install-prompt", 
        "extension-update-prompt", 
        "theme-install-fail", 
        "theme-install-prompt", 
        "theme-update-prompt", 
        "url-navigation-message", 
        "game-image-size-warning", 
        "performance-warning-title", 
        "dont-show-again-title", 
        "incompatible-drag-and-drop-extension-error", 
        "incompatible-drag-and-drop-extension-error-title", 
        "large-media-warning-tooltip", 
        "theme-uninstall-question", 
        "theme-built-in-uninstall-hint", 
        "theme-unsupported", 
        "extension-uninstall-question", 
        "extension-built-in-uninstall-hint", 
        "extension-unsupported", 
        "extension-install-dir", 
        "extension-data-dir", 
        "diag-generating", 
        "diag-uploading", 
        "add-from-exe", 
        "what-is-this", 
        "confirumation-ask-generic", 
        "stats-total-play-time", 
        "stats-avarage-play-time", 
        "stats-top-play-time", 
        "stats-total-install-size", 
        "overview-label", 
        "sidebar", 
        "tools-show-on-sidebar", 
        "settings-reset", 
        "settings-default-reset-desc", 
        "settings-for-developers", 
        "settings-external-extensions", 
        "settings-new-external-extension-box", 
        "common-links-achievements", 
        "common-links-forum", 
        "common-links-news", 
        "common-links-store-page", 
        "fullscreen-first-time-error", 
        "quick-filter-recently-played", 
        "quick-filter-favorites", 
        "quick-filter-most-played", 
        "quick-filter-all-games", 
        "game-list-filtered", 
        "game-list-extra-filtered", 
        "game-list-search-results", 
        "item-already-exists", 
        "random-game-limist-to-filter", 
        "random-game-pick-another", 
        "menu-addons", 
        "extensions-installed", 
        "extensions-settings", 
        "extensions-browse", 
        "extensions-updates", 
        "extensions-updates-count", 
        "addons-config-move-info", 
        "libraries-config-window-description", 
        "addons-themes-desktop", 
        "addons-themes-fullscren", 
        "addons-searching", 
        "addon-error-not-compatible", 
        "addon-error-download-failed", 
        "addon-error-manifest-download-error", 
        "addon-changes-restart", 
        "addon-queued-for-install", 
        "addon-install", 
        "addon-uninstall", 
        "addon-already-installed", 
        "addon-no-addons-available", 
        "addon-update-addons", 
        "addon-changelog-not-availavble", 
        "addon-update-status-downloaded", 
        "addon-update-status-failed", 
        "addon-update-status-license-rejected", 
        "addon-downloading-addon", 
        "addon-looking-for-updates", 
        "addon-updates-available", 
        "addon-select-to-update", 
        "addon-dev-reference-loaded", 
        "addon-license-window-title", 
        "license-accept", 
        "license-decline", 
        "include-plugin-game-actions", 
        "select-action-title", 
        "action-tracking-mode", 
        "action-tracking-path", 
        "game-action-type-link", 
        "game-action-type-file", 
        "game-action-type-emulator", 
        "game-action-type-script", 
        "action-tracking-mode-default", 
        "action-tracking-mode-process", 
        "action-tracking-mode-directory", 
        "action-tracking-original-process", 
        "devel-trace-log-enable", 
        "multi-edit-overwrite-warning", 
        "grid-view-spacing-mode-none", 
        "grid-view-spacing-mode-uniform", 
        "grid-view-spacing-mode-between-items-only", 
        "grid-view-spacing-mode-start-and-end-only", 
        "scrolling-sensitivity", 
        "smooth-scrolling", 
        "smooth-scrolling-speed", 
        "ask-remove-item-title", 
        "ask-remove-item-message", 
        "settings-top-panel-items", 
        "settings-top-panel-general-view-item", 
        "settings-top-panel-grouping-item", 
        "settings-top-panel-sorting-item", 
        "settings-top-panel-filter-presets-item", 
        "top-panel-plugin-panel-position", 
        "top-panel-separator-width", 
        "top-panel-main-button-move", 
        "top-panel-explorer-switch", 
        "top-panel-select-random-game-button", 
        "top-panel-view-select-random-game-button", 
        "top-panel-view-select-random-game-button-tooltip", 
        "filter-preset-save-view-options", 
        "filter-preset-show-on-fstop-panel", 
        "in-past7-days", 
        "in-past31-days", 
        "in-past365-days", 
        "more-than365-days-ago", 
        "configure", 
        "filter-preset-save", 
        "settings-minimize-after-starting-game", 
        "settings-minimize-after-starting-game-description", 
        "settings-font-size", 
        "settings-font-size-small", 
        "settings-xinput-processing", 
        "settings-xinput-processing-description", 
        "settings-show-items-main-menu-header", 
        "settings-swap-main-view-xabuttons", 
        "settings-swap-main-view-xabuttons-descriptions", 
        "settings-swap-confirm-cancel-buttons", 
        "settings-swap-confirm-cancel-buttons-descriptions", 
        "settings-primary-controller-only", 
        "settings-primary-controller-only-description", 
        "settings-refocus-on-guid-button", 
        "settings-interface-volume", 
        "settings-musi-volume", 
        "settings-mute-background", 
        "error-audio-interface-init", 
        "settings-audio-output-api", 
        "settings-audio-output-api-description", 
        "settings-fssection-general", 
        "settings-fssection-visuals", 
        "settings-fssection-audio", 
        "settings-fssection-layout", 
        "settings-fssection-menus", 
        "settings-fssection", 
        "game-is-starting", 
        "game-is-running", 
        "text-input-capitalize", 
        "text-input-space", 
        "settings-image-scaler-mode", 
        "settings-image-scaling-alternative", 
        "settings-image-scaling-balanced", 
        "settings-image-scaling-quality", 
        "settings-image-scaler-mode-tooltip", 
        "select-file-tooltip", 
        "select-directory-tooltip", 
        "startup-script", 
        "addon-perf-notice", 
        "game-action-select-on-start", 
        "emulator-select-on-start", 
        "emulator-built-in-profiles", 
        "emulator-built-in-profile", 
        "emulator-custom-profiles", 
        "emulator-custom-profile", 
        "emulator-function-handled-by-script", 
        "emulator-spec", 
        "platform-spec", 
        "region-spec", 
        "emulator-pre-script-description", 
        "emulator-post-script-description", 
        "emulator-started-script-description", 
        "error-emulator-executable-not-found", 
        "error-emulator-specification-not-found", 
        "error-emulator-startup-script-not-found", 
        "split-emu-import-split-games", 
        "split-emu-import-merge-games", 
        "emu-import-assign-platform", 
        "emu-import-assign-region", 
        "emu-scan-directory", 
        "emu-scan-configurations", 
        "emu-crc-exclude-file-types", 
        "emu-crc-exclude-file-types-tooltip", 
        "emu-scan-emulator", 
        "scan-config-name-error", 
        "scan-config-no-emulator-error", 
        "scan-config-directory-error", 
        "scan-config-error", 
        "emu-scan-include-global-update", 
        "emulator-scan-failed", 
        "emulated-game-scan-failed", 
        "emu-scan-hide-imported", 
        "emu-import-profiles-to-import-header", 
        "emu-auto-scan-configurations", 
        "emu-save-scan-config", 
        "emu-save-scan-config-tooltip", 
        "emu-import-with-relative-paths", 
        "emu-import-with-relative-paths-tooltip", 
        "emu-import-scan-subfolders", 
        "emu-import-scan-inside-archives", 
        "emu-merge-related-files", 
        "emu-merge-related-files-tooltip", 
        "emu-add-scanner", 
        "emu-add-saved-scanner", 
        "start-scan", 
        "emu-import-directory-config-desc", 
        "completion-status-default-status-desc", 
        "completion-status-played-status-desc", 
        "power-shell-creation-error", 
        "filter-preset-name-conflict", 
        "sorting-name-autofill", 
        "sorting-name-autofill-tooltip", 
        "sorting-name-removed-articles", 
        "sorting-name-removed-articles-tooltip", 
        "sorting-name-autofill-button", 
        "settings-sorting-label", 
        "sorting-name-autofill-progress", 
        "nahimic-service-warning", 
        "elevated-process-warning", 
        "elevated-process-warning-show-option", 
        "install-size-scan-use-size-on-disk-option", 
        "install-size-scan-use-size-on-disk-option-tooltip", 
        "warning-blacklisted-extensions", 
        "emu-exclude-online-files", 
        "emu-exclude-online-files-tooltip", 
        "emu-use-simplified-online-file-scan", 
        "emu-use-simplified-online-file-scan-tooltip", 
        "metadat-set-all-fields-to-value", 
        "override-install-state", 
        "override-install-state-tooltip", 
        "option-only-manually", 
        "option-once-aday", 
        "option-once-aweek", 
        "option-on-every-startup", 
        "check-program-updates", 
        "check-addon-updates", 
        "check-library-updates", 
        "check-emulated-library-updates", 
        "stats-include-hidden", 
        "menu-set-fields", 
        "item-selection-select-deselect-all", 
        "open", 
        "activate", 
        "assign", 
        "default-search-description", 
        "default-search-hint", 
        "search-filter-uninstalled", 
        "search-filter-hidden", 
        "search-filter-uninstalled-included", 
        "search-filter-uninstalled-excluded", 
        "search-filter-hidden-included", 
        "search-filter-hiddenalled-excluded", 
        "game-search-item-action-play", 
        "game-search-item-action-switch-to", 
        "game-search-item-action-open-menu", 
        "game-search-item-action-edit", 
        "open-search", 
        "top-panel-search-box", 
        "top-panel-search-button", 
        "search-settings-primary-action", 
        "search-settings-secondary-action", 
        "search-settings-keyboard-open-search", 
        "search-settings-save-filter", 
        "search-settings-search-providers", 
        "search-settings-default-keyword", 
        "search-settings-custom-keyword", 
        "search-settings-system-wide-shortcut", 
        "search-title", 
        "extension-settings-menu", 
        "exclusions", 
        "emu-scanner-excluded-files", 
        "emu-scanner-excluded-folders", 
        "emu-import-add-romexclusion-list", 
        "emu-import-add-folder-exclusion-list", 
        "emu-exclusion-no-config-error", 
        "emu-exclusion-added-message", 
        "emu-override-platform", 
        "emu-override-platform-tooltip", 
        "search-include-commands-in-default", 
        "search-include-commands-in-default-tooltip", 
        "name-filter-use-fuzzy-matching", 
        "name-filter-use-fuzzy-matching-tooltip", 
        "search-view-game-field-options", 
        "hidden-status", 
        "backup-cancelled", 
        "backup-failed", 
        "backup-error-title", 
        "backup-progress", 
        "backup-restore-progress", 
        "backup-restore-failed", 
        "backup-option-settings", 
        "backup-option-library", 
        "backup-option-game-media", 
        "backup-option-extensions", 
        "backup-option-extensions-data", 
        "backup-option-themes", 
        "backup-restore-message", 
        "backup-data-backup-message", 
        "settings-enable-automatic-backup", 
        "settings-auto-backup-frequency", 
        "settings-backup-folder", 
        "settings-rotating-backups", 
        "settings-auto-backup-include-items", 
        "settings-no-backup-dir-specified-error", 
        "update-notify-only-patches", 
        "update-notify-only-patches-toolip", 
        "settings-past-week-relative-format", 
        "settings-past-week-relative-format-tooltip", 
        "settings-web-image-search", 
        "settings-web-image-search-icon-term", 
        "settings-web-image-search-cover-term", 
        "settings-web-image-search-background", 
        "gettings-addon-information", 
        "no-metadata-source", 
        "scanner-config-play-action-settings", 
        "scanner-config-play-action-settings-scanner", 
        "scanner-config-play-action-settings-select-profile", 
        "scanner-config-play-action-settings-select-emulator", 
        "automatic", 
        "always-on", 
        "always-off", 
        "settings-accessibility-interface", 
        "application-menu", 
        "game-menu", 
        "program-folder", 
        "user-data-folder", 
        "dbcorruption-crash-message"
    };

    public const string language_name_id = "language-name";
    public const string language_settings_label_id = "language-settings-label";
    public const string exit_app_label_id = "exit-app-label";
    public const string filter_active_label_id = "filter-active-label";
    public const string filter_inactive_label_id = "filter-inactive-label";
    public const string aditional_filters_id = "aditional-filters";
    public const string filters_id = "filters";
    public const string filter_id = "filter";
    public const string invalid_data_title_id = "invalid-data-title";
    public const string save_changes_ask_title_id = "save-changes-ask-title";
    public const string about_home_page_link_id = "about-home-page-link";
    public const string about_source_link_id = "about-source-link";
    public const string about_create_diag_button_id = "about-create-diag-button";
    public const string about_send_diag_button_id = "about-send-diag-button";
    public const string about_window_title_id = "about-window-title";
    public const string about_author_id = "about-author";
    public const string category_window_title_id = "category-window-title";
    public const string category_set_button_id = "category-set-button";
    public const string category_add_cat_button_id = "category-add-cat-button";
    public const string category_tooltip_id = "category-tooltip";
    public const string no_category_id = "no-category";
    public const string no_platform_id = "no-platform";
    public const string crash_window_title_id = "crash-window-title";
    public const string crash_description_id = "crash-description";
    public const string ext_crash_description_id = "ext-crash-description";
    public const string ext_crash_description_fs_id = "ext-crash-description-fs";
    public const string ext_crash_description_uknown_id = "ext-crash-description-uknown";
    public const string crash_description_fullscreen_id = "crash-description-fullscreen";
    public const string crash_disable_extension_id = "crash-disable-extension";
    public const string crash_save_log_id = "crash-save-log";
    public const string crash_send_diag_id = "crash-send-diag";
    public const string crash_report_issue_id = "crash-report-issue";
    public const string crash_restart_playnite_id = "crash-restart-playnite";
    public const string crash_restart_safe_id = "crash-restart-safe";
    public const string crash_restart_safe_tooltip_id = "crash-restart-safe-tooltip";
    public const string crash_close_playnite_id = "crash-close-playnite";
    public const string crash_user_actions_description_id = "crash-user-actions-description";
    public const string library_manager_id = "library-manager";
    public const string game_remove_ask_title_id = "game-remove-ask-title";
    public const string game_remove_running_error_id = "game-remove-running-error";
    public const string game_uninstall_running_error_id = "game-uninstall-running-error";
    public const string game_remove_ask_message_id = "game-remove-ask-message";
    public const string games_remove_ask_message_id = "games-remove-ask-message";
    public const string game_remove_ask_message_ignore_option_id = "game-remove-ask-message-ignore-option";
    public const string games_remove_ask_message_ignore_option_id = "games-remove-ask-message-ignore-option";
    public const string remove_unused_fields_ask_message_id = "remove-unused-fields-ask-message";
    public const string remove_unused_fields_no_unused_message_id = "remove-unused-fields-no-unused-message";
    public const string remove_ask_add_to_exlusion_list_yes_response_id = "remove-ask-add-to-exlusion-list-yes-response";
    public const string game_edit_change_notif_id = "game-edit-change-notif";
    public const string dbupgrade_progress_id = "dbupgrade-progress";
    public const string dbupgrade_fail_id = "dbupgrade-fail";
    public const string dbupgrade_empty_space_fail_id = "dbupgrade-empty-space-fail";
    public const string game_error_id = "game-error";
    public const string game_start_error_no_game_id = "game-start-error-no-game";
    public const string game_start_error_id = "game-start-error";
    public const string game_start_action_error_id = "game-start-action-error";
    public const string game_open_location_error_id = "game-open-location-error";
    public const string calculate_game_size_error_id = "calculate-game-size-error";
    public const string calculate_game_size_error_caption_id = "calculate-game-size-error-caption";
    public const string calculate_games_size_error_message_id = "calculate-games-size-error-message";
    public const string game_shortcut_error_id = "game-shortcut-error";
    public const string manual_open_error_id = "manual-open-error";
    public const string game_install_error_id = "game-install-error";
    public const string game_uninstall_error_id = "game-uninstall-error";
    public const string error_no_play_action_id = "error-no-play-action";
    public const string error_no_install_action_id = "error-no-install-action";
    public const string error_library_plugin_not_found_id = "error-library-plugin-not-found";
    public const string error_no_metadata_downloader_id = "error-no-metadata-downloader";
    public const string error_no_game_selected_id = "error-no-game-selected";
    public const string error_game_script_action_id = "error-game-script-action";
    public const string error_application_script_id = "error-application-script";
    public const string error_global_script_action_id = "error-global-script-action";
    public const string error_emulator_script_action_id = "error-emulator-script-action";
    public const string error_play_script_action_id = "error-play-script-action";
    public const string error_power_shell_not_installed_id = "error-power-shell-not-installed";
    public const string error_startup_no_controller_id = "error-startup-no-controller";
    public const string enabled_title_id = "enabled-title";
    public const string remove_title_id = "remove-title";
    public const string remove_unused_title_id = "remove-unused-title";
    public const string rename_title_id = "rename-title";
    public const string copy_title_id = "copy-title";
    public const string add_title_id = "add-title";
    public const string default_icon_title_id = "default-icon-title";
    public const string default_cover_title_id = "default-cover-title";
    public const string default_background_title_id = "default-background-title";
    public const string finish_label_id = "finish-label";
    public const string next_label_id = "next-label";
    public const string back_label_id = "back-label";
    public const string done_cap_label_id = "done-cap-label";
    public const string back_cap_label_id = "back-cap-label";
    public const string clear_cap_label_id = "clear-cap-label";
    public const string clear_label_id = "clear-label";
    public const string dismiss_id = "dismiss";
    public const string dismiss_all_id = "dismiss-all";
    public const string import_label_id = "import-label";
    public const string name_label_id = "name-label";
    public const string author_label_id = "author-label";
    public const string module_label_id = "module-label";
    public const string series_label_id = "series-label";
    public const string version_label_id = "version-label";
    public const string last_played_label_id = "last-played-label";
    public const string most_played_label_id = "most-played-label";
    public const string play_count_label_id = "play-count-label";
    public const string install_size_label_id = "install-size-label";
    public const string folder_label_id = "folder-label";
    public const string notes_label_id = "notes-label";
    public const string added_label_id = "added-label";
    public const string date_added_label_id = "date-added-label";
    public const string modified_label_id = "modified-label";
    public const string date_modified_label_id = "date-modified-label";
    public const string website_label_id = "website-label";
    public const string path_label_id = "path-label";
    public const string oklabel_id = "oklabel";
    public const string save_label_id = "save-label";
    public const string close_label_id = "close-label";
    public const string cancel_label_id = "cancel-label";
    public const string confirm_label_id = "confirm-label";
    public const string reset_label_id = "reset-label";
    public const string yes_label_id = "yes-label";
    public const string no_label_id = "no-label";
    public const string welcome_label_id = "welcome-label";
    public const string local_user_label_id = "local-user-label";
    public const string general_label_id = "general-label";
    public const string media_label_id = "media-label";
    public const string links_label_id = "links-label";
    public const string installation_label_id = "installation-label";
    public const string actions_label_id = "actions-label";
    public const string downloading_label_id = "downloading-label";
    public const string downloading_media_label_id = "downloading-media-label";
    public const string loading_label_id = "loading-label";
    public const string type_label_id = "type-label";
    public const string profile_label_id = "profile-label";
    public const string profiles_label_id = "profiles-label";
    public const string remove_label_id = "remove-label";
    public const string download_label_id = "download-label";
    public const string search_label_id = "search-label";
    public const string search_resolution_label_id = "search-resolution-label";
    public const string search_resolution_any_label_id = "search-resolution-any-label";
    public const string zoom_label_id = "zoom-label";
    public const string list_view_label_id = "list-view-label";
    public const string covers_label_id = "covers-label";
    public const string grid_view_label_id = "grid-view-label";
    public const string details_view_label_id = "details-view-label";
    public const string custom_label_id = "custom-label";
    public const string urllabel_id = "urllabel";
    public const string patrons_label_id = "patrons-label";
    public const string license_label_id = "license-label";
    public const string contributors_label_id = "contributors-label";
    public const string closing_playnite_id = "closing-playnite";
    public const string today_id = "today";
    public const string yesterday_id = "yesterday";
    public const string monday_id = "monday";
    public const string tuesday_id = "tuesday";
    public const string wednesday_id = "wednesday";
    public const string thursday_id = "thursday";
    public const string friday_id = "friday";
    public const string saturday_id = "saturday";
    public const string sunday_id = "sunday";
    public const string past_week_id = "past-week";
    public const string past_month_id = "past-month";
    public const string past_year_id = "past-year";
    public const string more_then_year_id = "more-then-year";
    public const string size_zero_to100_mb_id = "size-zero-to100-mb";
    public const string size100_mb_to1_gb_id = "size100-mb-to1-gb";
    public const string size1_gb_to5_gb_id = "size1-gb-to5-gb";
    public const string size5_gb_to10_gb_id = "size5-gb-to10-gb";
    public const string size10_gb_to20_gb_id = "size10-gb-to20-gb";
    public const string size20_gb_to40_gb_id = "size20-gb-to40-gb";
    public const string size40_gb_to100_gb_id = "size40-gb-to100-gb";
    public const string size_more_than100_gb_id = "size-more-than100-gb";
    public const string import_completed_id = "import-completed";
    public const string all_games_id = "all-games";
    public const string game_id_id = "game-id";
    public const string database_id_id = "database-id";
    public const string presets_id = "presets";
    public const string column_id = "column";
    public const string columns_id = "columns";
    public const string row_id = "row";
    public const string rows_id = "rows";
    public const string exec_icon_missing_play_action_id = "exec-icon-missing-play-action";
    public const string meta_skip_non_empty_id = "meta-skip-non-empty";
    public const string meta_skip_non_empty_tooltip_id = "meta-skip-non-empty-tooltip";
    public const string meta_games_source_intro_id = "meta-games-source-intro";
    public const string meta_games_source_description_id = "meta-games-source-description";
    public const string meta_game_source_all_id = "meta-game-source-all";
    public const string meta_game_source_filtered_id = "meta-game-source-filtered";
    public const string meta_game_source_selected_id = "meta-game-source-selected";
    public const string meta_source_store_id = "meta-source-store";
    public const string meta_source_igdb_id = "meta-source-igdb";
    public const string meta_description_fields_id = "meta-description-fields";
    public const string meta_igdb_contrib_notif_id = "meta-igdb-contrib-notif";
    public const string progress_metadata_id = "progress-metadata";
    public const string progress_installed_games_id = "progress-installed-games";
    public const string progress_importin_games_id = "progress-importin-games";
    public const string progress_importin_emulated_games_id = "progress-importin-emulated-games";
    public const string progress_library_games_id = "progress-library-games";
    public const string progress_scanning_games_install_size_id = "progress-scanning-games-install-size";
    public const string progress_scanning_imported_games_install_size_id = "progress-scanning-imported-games-install-size";
    public const string progress_lib_import_finish_id = "progress-lib-import-finish";
    public const string progress_releasing_resources_id = "progress-releasing-resources";
    public const string menu_configuration_title_id = "menu-configuration-title";
    public const string menu_playnite_settings_title_id = "menu-playnite-settings-title";
    public const string menu_platform_emulator_settings_title_id = "menu-platform-emulator-settings-title";
    public const string menu_configure_emulators_menu_title_id = "menu-configure-emulators-menu-title";
    public const string menu_library_manager_title_id = "menu-library-manager-title";
    public const string menu_tools_id = "menu-tools";
    public const string menu_download_metadata_id = "menu-download-metadata";
    public const string menu_software_tools_id = "menu-software-tools";
    public const string menu_configure_integrations_id = "menu-configure-integrations";
    public const string menu_open_client_id = "menu-open-client";
    public const string menu_clients_id = "menu-clients";
    public const string menu_reload_library_id = "menu-reload-library";
    public const string menu_cancel_library_update_id = "menu-cancel-library-update";
    public const string menu_update_emulated_dirs_id = "menu-update-emulated-dirs";
    public const string menu_add_game_id = "menu-add-game";
    public const string menu_add_game_manual_id = "menu-add-game-manual";
    public const string menu_add_game_installed_id = "menu-add-game-installed";
    public const string menu_add_game_emulated_id = "menu-add-game-emulated";
    public const string menu_add_windows_store_id = "menu-add-windows-store";
    public const string menu_about_id = "menu-about";
    public const string menu_issues_id = "menu-issues";
    public const string menu_open_fullscreen_id = "menu-open-fullscreen";
    public const string menu_links_title_id = "menu-links-title";
    public const string menu_help_title_id = "menu-help-title";
    public const string menu_patreon_support_id = "menu-patreon-support";
    public const string sdkdocumentation_id = "sdkdocumentation";
    public const string menu_restart_system_id = "menu-restart-system";
    public const string menu_shutdown_system_id = "menu-shutdown-system";
    public const string menu_suspend_system_id = "menu-suspend-system";
    public const string menu_hibernate_system_id = "menu-hibernate-system";
    public const string menu_select_random_game_id = "menu-select-random-game";
    public const string settings_details_panel_items_id = "settings-details-panel-items";
    public const string settings_grid_item_spacing_id = "settings-grid-item-spacing";
    public const string settings_grid_item_draw_background_id = "settings-grid-item-draw-background";
    public const string settings_grid_item_cover_margin_id = "settings-grid-item-cover-margin";
    public const string settings_defaul_icon_source_id = "settings-defaul-icon-source";
    public const string settings_defaul_cover_source_id = "settings-defaul-cover-source";
    public const string settings_defaul_background_source_id = "settings-defaul-background-source";
    public const string settings_indent_game_details_id = "settings-indent-game-details";
    public const string settings_grid_view_details_position_id = "settings-grid-view-details-position";
    public const string settings_details_game_list_position_id = "settings-details-game-list-position";
    public const string settings_draw_panel_separators_id = "settings-draw-panel-separators";
    public const string settings_game_details_cover_height_id = "settings-game-details-cover-height";
    public const string settings_game_details_list_icon_size_id = "settings-game-details-list-icon-size";
    public const string settings_interface_font_id = "settings-interface-font";
    public const string settings_interface_mono_font_id = "settings-interface-mono-font";
    public const string settings_filter_panel_position_id = "settings-filter-panel-position";
    public const string settings_explorer_panel_position_id = "settings-explorer-panel-position";
    public const string settings_cover_art_rendering_label_id = "settings-cover-art-rendering-label";
    public const string settings_target_aspect_ratio_label_id = "settings-target-aspect-ratio-label";
    public const string settings_grid_tile_layout_fsnote_id = "settings-grid-tile-layout-fsnote";
    public const string settings_strech_mode_label_id = "settings-strech-mode-label";
    public const string settings_covert_aspect_dvd_id = "settings-covert-aspect-dvd";
    public const string settings_covert_aspect_epic_games_store_id = "settings-covert-aspect-epic-games-store";
    public const string settings_covert_aspect_gog_galaxy2_id = "settings-covert-aspect-gog-galaxy2";
    public const string settings_covert_aspect_igdb_id = "settings-covert-aspect-igdb";
    public const string settings_covert_aspect_square_id = "settings-covert-aspect-square";
    public const string settings_covert_aspect_steam_id = "settings-covert-aspect-steam";
    public const string settings_covert_aspect_steam_vertical_id = "settings-covert-aspect-steam-vertical";
    public const string settings_covert_aspect_twitch_id = "settings-covert-aspect-twitch";
    public const string settings_restart_notification_id = "settings-restart-notification";
    public const string settings_label_id = "settings-label";
    public const string settings_general_label_id = "settings-general-label";
    public const string settings_top_panel_label_id = "settings-top-panel-label";
    public const string settings_appearance_label_id = "settings-appearance-label";
    public const string settings_game_details_label_id = "settings-game-details-label";
    public const string settings_layout_label_id = "settings-layout-label";
    public const string settings_advanced_label_id = "settings-advanced-label";
    public const string settings_fullscreen_label_id = "settings-fullscreen-label";
    public const string settings_input_label_id = "settings-input-label";
    public const string settings_performance_label_id = "settings-performance-label";
    public const string settings_metadata_label_id = "settings-metadata-label";
    public const string settings_updating_id = "settings-updating";
    public const string settings_search_id = "settings-search";
    public const string settings_backup_id = "settings-backup";
    public const string menu_backup_data_id = "menu-backup-data";
    public const string menu_restore_backup_id = "menu-restore-backup";
    public const string settings_import_label_id = "settings-import-label";
    public const string settings_invalid_dblocation_id = "settings-invalid-dblocation";
    public const string settings_invalid_account_name_id = "settings-invalid-account-name";
    public const string settings_download_metadata_on_import_id = "settings-download-metadata-on-import";
    public const string settings_start_minimized_id = "settings-start-minimized";
    public const string settings_start_on_boot_id = "settings-start-on-boot";
    public const string settings_start_on_boot_closed_to_tray_id = "settings-start-on-boot-closed-to-tray";
    public const string settings_start_on_boot_registration_error_id = "settings-start-on-boot-registration-error";
    public const string settings_start_in_fullscreen_id = "settings-start-in-fullscreen";
    public const string settings_async_image_loading_id = "settings-async-image-loading";
    public const string settings_async_image_loading_tooltip_id = "settings-async-image-loading-tooltip";
    public const string settings_show_name_empty_cover_id = "settings-show-name-empty-cover";
    public const string settings_show_names_under_cover_id = "settings-show-names-under-cover";
    public const string settings_darken_uninstalled_grid_covers_id = "settings-darken-uninstalled-grid-covers";
    public const string settings_show_icon_list_id = "settings-show-icon-list";
    public const string settings_show_group_count_id = "settings-show-group-count";
    public const string settings_used_fields_only_on_filter_lists_id = "settings-used-fields-only-on-filter-lists";
    public const string settings_disable_acceleration_id = "settings-disable-acceleration";
    public const string settings_disable_acceleration_tooltip_id = "settings-disable-acceleration-tooltip";
    public const string settings_hidden_in_quick_launch_id = "settings-hidden-in-quick-launch";
    public const string settings_hidden_in_quick_launch_tooltip_id = "settings-hidden-in-quick-launch-tooltip";
    public const string settings_quic_launch_items_id = "settings-quic-launch-items";
    public const string settings_show_background_window_image_id = "settings-show-background-window-image";
    public const string settings_blur_window_backgroun_image_id = "settings-blur-window-backgroun-image";
    public const string settings_blur_high_quality_id = "settings-blur-high-quality";
    public const string settings_darken_window_backghroun_image_id = "settings-darken-window-backghroun-image";
    public const string settings_show_back_image_on_grid_view_id = "settings-show-back-image-on-grid-view";
    public const string settings_skin_id = "settings-skin";
    public const string settings_skin_color_id = "settings-skin-color";
    public const string settings_skin_fullscreen_id = "settings-skin-fullscreen";
    public const string settings_skin_color_fullscreen_id = "settings-skin-color-fullscreen";
    public const string settings_dblocation_id = "settings-dblocation";
    public const string settings_login_status_id = "settings-login-status";
    public const string settings_window_title_id = "settings-window-title";
    public const string settings_clear_web_cache_id = "settings-clear-web-cache";
    public const string settings_clear_web_cache_tooltip_id = "settings-clear-web-cache-tooltip";
    public const string settings_show_tray_id = "settings-show-tray";
    public const string settings_minimize_to_tray_id = "settings-minimize-to-tray";
    public const string settings_close_to_tray_id = "settings-close-to-tray";
    public const string settings_after_game_start_id = "settings-after-game-start";
    public const string settings_after_game_close_id = "settings-after-game-close";
    public const string settings_playtime_use_days_format_label_id = "settings-playtime-use-days-format-label";
    public const string settings_dates_formats_label_id = "settings-dates-formats-label";
    public const string settings_clear_cache_warn_id = "settings-clear-cache-warn";
    public const string settings_clear_cache_title_id = "settings-clear-cache-title";
    public const string settings_skin_change_restart_id = "settings-skin-change-restart";
    public const string settings_get_themes_id = "settings-get-themes";
    public const string settings_create_themes_id = "settings-create-themes";
    public const string settings_get_extensions_id = "settings-get-extensions";
    public const string settings_create_extensions_id = "settings-create-extensions";
    public const string settings_create_localization_id = "settings-create-localization";
    public const string settings_restart_ask_message_id = "settings-restart-ask-message";
    public const string settings_restart_title_id = "settings-restart-title";
    public const string settings_dbpath_notification_id = "settings-dbpath-notification";
    public const string settings_close_playtime_notif_id = "settings-close-playtime-notif";
    public const string settings_fullscreen_rows_id = "settings-fullscreen-rows";
    public const string settings_fullscreen_columns_id = "settings-fullscreen-columns";
    public const string settings_fullscreen_row_details_id = "settings-fullscreen-row-details";
    public const string settings_fullscreen_background_on_main_screen_id = "settings-fullscreen-background-on-main-screen";
    public const string background_image_screen_option_tooltip_id = "background-image-screen-option-tooltip";
    public const string settings_playtime_import_mode_id = "settings-playtime-import-mode";
    public const string settings_playtime_import_mode_tooltip_id = "settings-playtime-import-mode-tooltip";
    public const string settings_playtime_import_mode_always_id = "settings-playtime-import-mode-always";
    public const string settings_playtime_import_mode_new_imports_only_id = "settings-playtime-import-mode-new-imports-only";
    public const string settings_playtime_import_mode_never_id = "settings-playtime-import-mode-never";
    public const string settings_xinput_in_desktop_mode_id = "settings-xinput-in-desktop-mode";
    public const string settings_xinput_guide_opens_fullscreen_id = "settings-xinput-guide-opens-fullscreen";
    public const string settings_default_metadata_description_id = "settings-default-metadata-description";
    public const string settings_target_display_id = "settings-target-display";
    public const string settings_always_use_primary_display_id = "settings-always-use-primary-display";
    public const string settings_fullscreen_show_game_titles_id = "settings-fullscreen-show-game-titles";
    public const string settings_show_battery_status_id = "settings-show-battery-status";
    public const string settings_show_battery_percentage_id = "settings-show-battery-percentage";
    public const string settings_show_clock_id = "settings-show-clock";
    public const string settings_hide_mouse_cursor_id = "settings-hide-mouse-cursor";
    public const string settings_fullscreen_quick_filter_installed_id = "settings-fullscreen-quick-filter-installed";
    public const string settings_fullscreen_button_prompts_id = "settings-fullscreen-button-prompts";
    public const string settings_fullscreen_layout_id = "settings-fullscreen-layout";
    public const string settings_fullscreen_horizontal_scrolling_id = "settings-fullscreen-horizontal-scrolling";
    public const string settings_select_child_section_id = "settings-select-child-section";
    public const string settings_no_settings_available_id = "settings-no-settings-available";
    public const string settings_error_loading_settings_id = "settings-error-loading-settings";
    public const string settings_scripting_notice_id = "settings-scripting-notice";
    public const string settings_background_image_animation_id = "settings-background-image-animation";
    public const string settings_font_sizes_id = "settings-font-sizes";
    public const string settings_text_rendering_mode_option_auto_id = "settings-text-rendering-mode-option-auto";
    public const string settings_text_rendering_mode_option_aliased_id = "settings-text-rendering-mode-option-aliased";
    public const string settings_text_rendering_mode_option_grayscale_id = "settings-text-rendering-mode-option-grayscale";
    public const string settings_text_rendering_mode_option_clear_type_id = "settings-text-rendering-mode-option-clear-type";
    public const string settings_text_formatting_mode_option_ideal_id = "settings-text-formatting-mode-option-ideal";
    public const string settings_text_formatting_mode_option_display_id = "settings-text-formatting-mode-option-display";
    public const string settings_text_formatting_mode_id = "settings-text-formatting-mode";
    public const string settings_text_rendering_mode_id = "settings-text-rendering-mode";
    public const string settings_text_rendering_notice_id = "settings-text-rendering-notice";
    public const string settings_immediate_background_download_id = "settings-immediate-background-download";
    public const string settings_immediate_background_download_tooltip_id = "settings-immediate-background-download-tooltip";
    public const string settings_auto_close_launcher_option_id = "settings-auto-close-launcher-option";
    public const string settings_auto_close_grace_period_id = "settings-auto-close-grace-period";
    public const string settings_auto_close_minimal_session_time_id = "settings-auto-close-minimal-session-time";
    public const string settings_auto_close_specific_clients_id = "settings-auto-close-specific-clients";
    public const string settings_auto_close_section_id = "settings-auto-close-section";
    public const string settings_import_exclusion_list_id = "settings-import-exclusion-list";
    public const string settings_show_media_size_warning_id = "settings-show-media-size-warning";
    public const string open_directory_command_id = "open-directory-command";
    public const string settings_preferred_age_rating_org_id = "settings-preferred-age-rating-org";
    public const string settings_scan_lib_install_size_on_lib_update_id = "settings-scan-lib-install-size-on-lib-update";
    public const string settings_scan_lib_install_size_on_lib_update_tooltip_id = "settings-scan-lib-install-size-on-lib-update-tooltip";
    public const string strech_none_id = "strech-none";
    public const string strech_fill_id = "strech-fill";
    public const string strech_uniform_id = "strech-uniform";
    public const string strech_uniform_to_fill_id = "strech-uniform-to-fill";
    public const string dock_left_id = "dock-left";
    public const string dock_right_id = "dock-right";
    public const string dock_top_id = "dock-top";
    public const string dock_bottom_id = "dock-bottom";
    public const string import_error_id = "import-error";
    public const string login_required_id = "login-required";
    public const string login_failed_id = "login-failed";
    public const string settings_alt_web_view_rendering_id = "settings-alt-web-view-rendering";
    public const string settings_alt_web_view_rendering_tooltip_id = "settings-alt-web-view-rendering-tooltip";
    public const string settings_partial_description_loading_id = "settings-partial-description-loading";
    public const string settings_partial_description_loading_tooltip_id = "settings-partial-description-loading-tooltip";
    public const string meta_import_window_title_id = "meta-import-window-title";
    public const string download_meta_button_id = "download-meta-button";
    public const string save_default_tooltip_id = "save-default-tooltip";
    public const string emu_wizard_window_title_id = "emu-wizard-window-title";
    public const string emu_wizard_intro_id = "emu-wizard-intro";
    public const string emu_wizard_notice_id = "emu-wizard-notice";
    public const string emu_download_description_id = "emu-download-description";
    public const string emu_wizard_emu_import_intro_id = "emu-wizard-emu-import-intro";
    public const string emu_wizard_game_import_intro_id = "emu-wizard-game-import-intro";
    public const string emu_wizard_no_emulator_warning_id = "emu-wizard-no-emulator-warning";
    public const string emu_wizard_no_emulator_for_games_warning_id = "emu-wizard-no-emulator-for-games-warning";
    public const string emu_wizard_button_scan_games_id = "emu-wizard-button-scan-games";
    public const string emu_wizard_button_select_files_id = "emu-wizard-button-select-files";
    public const string emu_wizard_button_scan_emulator_id = "emu-wizard-button-scan-emulator";
    public const string emu_wizard_button_configure_emulator_id = "emu-wizard-button-configure-emulator";
    public const string emu_wizard_scanning_id = "emu-wizard-scanning";
    public const string emu_wizard_scanning_specific_id = "emu-wizard-scanning-specific";
    public const string first_window_title_id = "first-window-title";
    public const string first_intro_id = "first-intro";
    public const string first_external_title_id = "first-external-title";
    public const string first_import_introduction_id = "first-import-introduction";
    public const string first_config_finished_title_id = "first-config-finished-title";
    public const string first_config_finished_text_id = "first-config-finished-text";
    public const string first_plugin_download_error_id = "first-plugin-download-error";
    public const string first_downloading_addon_id = "first-downloading-addon";
    public const string default_addon_list_download_id = "default-addon-list-download";
    public const string default_addon_list_download_error_id = "default-addon-list-download-error";
    public const string platforms_window_title_id = "platforms-window-title";
    public const string emulators_window_title_id = "emulators-window-title";
    public const string platforms_title_id = "platforms-title";
    public const string platform_title_id = "platform-title";
    public const string emulators_title_id = "emulators-title";
    public const string emulator_title_id = "emulator-title";
    public const string add_platform_title_id = "add-platform-title";
    public const string select_icon_title_id = "select-icon-title";
    public const string select_cover_title_id = "select-cover-title";
    public const string select_image_title_id = "select-image-title";
    public const string select_item_title_id = "select-item-title";
    public const string select_background_title_id = "select-background-title";
    public const string select_file_title_id = "select-file-title";
    public const string select_url_title_id = "select-url-title";
    public const string add_emulator_title_id = "add-emulator-title";
    public const string supported_platforms_title_id = "supported-platforms-title";
    public const string confirm_unsaved_platforms_title_id = "confirm-unsaved-platforms-title";
    public const string confirm_unsaved_emulators_title_id = "confirm-unsaved-emulators-title";
    public const string executable_title_id = "executable-title";
    public const string arguments_title_id = "arguments-title";
    public const string working_dir_title_id = "working-dir-title";
    public const string supported_files_title_id = "supported-files-title";
    public const string import_emulators_button_id = "import-emulators-button";
    public const string download_emulators_button_id = "download-emulators-button";
    public const string emu_load_args_preset_tooltip_id = "emu-load-args-preset-tooltip";
    public const string emu_removal_confirmation_id = "emu-removal-confirmation";
    public const string platform_removal_confirmation_id = "platform-removal-confirmation";
    public const string emulator_settings_help_id = "emulator-settings-help";
    public const string menu_sort_by_title_id = "menu-sort-by-title";
    public const string menu_sort_by_direction_id = "menu-sort-by-direction";
    public const string menu_group_by_title_id = "menu-group-by-title";
    public const string menu_sort_ascending_id = "menu-sort-ascending";
    public const string menu_sort_descending_id = "menu-sort-descending";
    public const string menu_group_dont_id = "menu-group-dont";
    public const string menu_group_provider_id = "menu-group-provider";
    public const string menu_group_category_id = "menu-group-category";
    public const string menu_group_platform_id = "menu-group-platform";
    public const string view_type_id = "view-type";
    public const string menu_view_id = "menu-view";
    public const string menu_view_explorer_panel_id = "menu-view-explorer-panel";
    public const string menu_view_filter_panel_id = "menu-view-filter-panel";
    public const string game_icon_title_id = "game-icon-title";
    public const string library_icon_title_id = "library-icon-title";
    public const string game_cover_image_title_id = "game-cover-image-title";
    public const string game_background_title_id = "game-background-title";
    public const string game_sorting_name_title_id = "game-sorting-name-title";
    public const string game_provider_title_id = "game-provider-title";
    public const string game_manual_title_id = "game-manual-title";
    public const string game_name_title_id = "game-name-title";
    public const string install_drive_title_id = "install-drive-title";
    public const string game_account_name_title_id = "game-account-name-title";
    public const string game_platform_title_id = "game-platform-title";
    public const string game_categories_title_id = "game-categories-title";
    public const string game_genres_title_id = "game-genres-title";
    public const string game_release_date_title_id = "game-release-date-title";
    public const string game_release_year_title_id = "game-release-year-title";
    public const string game_developers_title_id = "game-developers-title";
    public const string game_tags_title_id = "game-tags-title";
    public const string game_publishers_title_id = "game-publishers-title";
    public const string game_installation_status_id = "game-installation-status";
    public const string use_filter_style_and_title_id = "use-filter-style-and-title";
    public const string use_filter_style_and_tooltip_id = "use-filter-style-and-tooltip";
    public const string game_is_installed_title_id = "game-is-installed-title";
    public const string game_is_game_installed_title_id = "game-is-game-installed-title";
    public const string game_is_un_installed_title_id = "game-is-un-installed-title";
    public const string game_hidden_title_id = "game-hidden-title";
    public const string game_favorite_title_id = "game-favorite-title";
    public const string game_hdr_title_id = "game-hdr-title";
    public const string game_hdr_tooltip_id = "game-hdr-tooltip";
    public const string game_hdr_not_supported_tooltip_id = "game-hdr-not-supported-tooltip";
    public const string game_last_activity_title_id = "game-last-activity-title";
    public const string game_category_title_id = "game-category-title";
    public const string game_description_title_id = "game-description-title";
    public const string game_install_dir_title_id = "game-install-dir-title";
    public const string game_cover_title_id = "game-cover-title";
    public const string game_links_title_id = "game-links-title";
    public const string game_romtitle_id = "game-romtitle";
    public const string genre_label_id = "genre-label";
    public const string genres_label_id = "genres-label";
    public const string company_label_id = "company-label";
    public const string companies_label_id = "companies-label";
    public const string developer_label_id = "developer-label";
    public const string developers_label_id = "developers-label";
    public const string publisher_label_id = "publisher-label";
    public const string publishers_label_id = "publishers-label";
    public const string category_label_id = "category-label";
    public const string categories_label_id = "categories-label";
    public const string tag_label_id = "tag-label";
    public const string tags_label_id = "tags-label";
    public const string feature_label_id = "feature-label";
    public const string features_label_id = "features-label";
    public const string age_rating_label_id = "age-rating-label";
    public const string age_ratings_label_id = "age-ratings-label";
    public const string region_label_id = "region-label";
    public const string regions_label_id = "regions-label";
    public const string source_label_id = "source-label";
    public const string sources_label_id = "sources-label";
    public const string recent_activity_label_id = "recent-activity-label";
    public const string database_erro_title_id = "database-erro-title";
    public const string database_open_error_id = "database-open-error";
    public const string database_not_opened_error_id = "database-not-opened-error";
    public const string database_open_access_error_id = "database-open-access-error";
    public const string diag_package_creation_error_id = "diag-package-creation-error";
    public const string diag_package_upload_error_id = "diag-package-upload-error";
    public const string diag_package_sent_success_id = "diag-package-sent-success";
    public const string diag_package_creation_success_id = "diag-package-creation-success";
    public const string library_import_error_id = "library-import-error";
    public const string library_import_emulated_error_id = "library-import-emulated-error";
    public const string scan_emulator_games_empty_profile_error_id = "scan-emulator-games-empty-profile-error";
    public const string start_generic_error_id = "start-generic-error";
    public const string skin_apply_error_id = "skin-apply-error";
    public const string urlformat_error_id = "urlformat-error";
    public const string app_startup_error_id = "app-startup-error";
    public const string cef_sharp_init_error_id = "cef-sharp-init-error";
    public const string emulator_import_no_definitions_error_id = "emulator-import-no-definitions-error";
    public const string xinput_init_error_message_id = "xinput-init-error-message";
    public const string menu_action_exec_error_id = "menu-action-exec-error";
    public const string game_edit_window_title_id = "game-edit-window-title";
    public const string use_exe_icon_id = "use-exe-icon";
    public const string image_url_id = "image-url";
    public const string add_link_button_id = "add-link-button";
    public const string add_rom_id = "add-rom";
    public const string save_changes_id = "save-changes";
    public const string game_edit_change_save_tooltip_id = "game-edit-change-save-tooltip";
    public const string add_action_id = "add-action";
    public const string delete_action_id = "delete-action";
    public const string remove_play_action_id = "remove-play-action";
    public const string add_games_id = "add-games";
    public const string scan_folder_id = "scan-folder";
    public const string detect_installed_id = "detect-installed";
    public const string browse_id = "browse";
    public const string open_playnite_id = "open-playnite";
    public const string profile_settings_id = "profile-settings";
    public const string empty_game_name_error_id = "empty-game-name-error";
    public const string empty_tracking_folder_error_id = "empty-tracking-folder-error";
    public const string empty_game_name_meta_search_error_id = "empty-game-name-meta-search-error";
    public const string invalid_game_data_id = "invalid-game-data";
    public const string urlinput_info_id = "urlinput-info";
    public const string urlinput_info_titile_id = "urlinput-info-titile";
    public const string metadata_download_error_id = "metadata-download-error";
    public const string download_error_id = "download-error";
    public const string clear_filters_id = "clear-filters";
    public const string private_account_id = "private-account";
    public const string public_account_id = "public-account";
    public const string apikey_id = "apikey";
    public const string startup_error_id = "startup-error";
    public const string skin_error_id = "skin-error";
    public const string clear_all_id = "clear-all";
    public const string setup_running_id = "setup-running";
    public const string uninstalling_id = "uninstalling";
    public const string game_launching_id = "game-launching";
    public const string game_running_id = "game-running";
    public const string invalid_url_id = "invalid-url";
    public const string do_nothing_id = "do-nothing";
    public const string minimize_id = "minimize";
    public const string restore_window_id = "restore-window";
    public const string close_id = "close";
    public const string change_id = "change";
    public const string advanced_id = "advanced";
    public const string never_id = "never";
    public const string completion_status_id = "completion-status";
    public const string completion_statuses_id = "completion-statuses";
    public const string user_score_id = "user-score";
    public const string critic_score_id = "critic-score";
    public const string community_score_id = "community-score";
    public const string game_scripts_id = "game-scripts";
    public const string application_scripts_id = "application-scripts";
    public const string scripts_id = "scripts";
    public const string plugins_id = "plugins";
    public const string metadata_providers_id = "metadata-providers";
    public const string extensions_id = "extensions";
    public const string extension_id_id = "extension-id";
    public const string reload_scripts_id = "reload-scripts";
    public const string start_interactive_power_shell_id = "start-interactive-power-shell";
    public const string reload_scripts_success_id = "reload-scripts-success";
    public const string no_games_found_id = "no-games-found";
    public const string no_items_found_id = "no-items-found";
    public const string back_to_desktop_mode_id = "back-to-desktop-mode";
    public const string exit_playnite_id = "exit-playnite";
    public const string libraries_id = "libraries";
    public const string update_all_id = "update-all";
    public const string extension_created_by_id = "extension-created-by";
    public const string extension_version_id = "extension-version";
    public const string extension_updated_id = "extension-updated";
    public const string extension_module_id = "extension-module";
    public const string library_id = "library";
    public const string statistics_id = "statistics";
    public const string all_id = "all";
    public const string none_id = "none";
    public const string notifications_id = "notifications";
    public const string width_id = "width";
    public const string height_id = "height";
    public const string size_id = "size";
    public const string font_small_id = "font-small";
    public const string font_normal_id = "font-normal";
    public const string font_large_id = "font-large";
    public const string font_larger_id = "font-larger";
    public const string font_largest_id = "font-largest";
    public const string default_label_id = "default-label";
    public const string select_id = "select";
    public const string select_all_id = "select-all";
    public const string deselect_all_id = "deselect-all";
    public const string first_id = "first";
    public const string random_id = "random";
    public const string user_select_id = "user-select";
    public const string load_more_id = "load-more";
    public const string transparent_id = "transparent";
    public const string collapse_id = "collapse";
    public const string expand_id = "expand";
    public const string collapse_all_id = "collapse-all";
    public const string expand_all_id = "expand-all";
    public const string other_id = "other";
    public const string themes_id = "themes";
    public const string emulator_arguments_id = "emulator-arguments";
    public const string builtin_arguments_id = "builtin-arguments";
    public const string custom_arguments_id = "custom-arguments";
    public const string additional_emulator_arguments_id = "additional-emulator-arguments";
    public const string override_emulator_arguments_id = "override-emulator-arguments";
    public const string is_play_action_id = "is-play-action";
    public const string medata_diff_window_title_id = "medata-diff-window-title";
    public const string game_import_window_title_id = "game-import-window-title";
    public const string meta_lookup_window_title_id = "meta-lookup-window-title";
    public const string updater_window_title_id = "updater-window-title";
    public const string updater_changes_info_id = "updater-changes-info";
    public const string updater_install_update_id = "updater-install-update";
    public const string check_for_updates_id = "check-for-updates";
    public const string update_error_id = "update-error";
    public const string update_check_fail_message_id = "update-check-fail-message";
    public const string update_no_new_update_message_id = "update-no-new-update-message";
    public const string general_update_fail_message_id = "general-update-fail-message";
    public const string update_progress_cancel_ask_id = "update-progress-cancel-ask";
    public const string background_progress_cancel_ask_exit_id = "background-progress-cancel-ask-exit";
    public const string background_progress_cancel_ask_switch_mode_id = "background-progress-cancel-ask-switch-mode";
    public const string update_is_available_notification_body_id = "update-is-available-notification-body";
    public const string theme_test_reload_list_id = "theme-test-reload-list";
    public const string theme_test_apply_skin_id = "theme-test-apply-skin";
    public const string theme_test_watch_changes_id = "theme-test-watch-changes";
    public const string theme_test_watch_changes_tooltip_id = "theme-test-watch-changes-tooltip";
    public const string script_runtime_id = "script-runtime";
    public const string pre_script_description_id = "pre-script-description";
    public const string post_script_description_id = "post-script-description";
    public const string game_started_script_description_id = "game-started-script-description";
    public const string app_script_startup_description_id = "app-script-startup-description";
    public const string app_script_shutdown_description_id = "app-script-shutdown-description";
    public const string script_type_starting_id = "script-type-starting";
    public const string script_type_started_id = "script-type-started";
    public const string script_type_exit_id = "script-type-exit";
    public const string execute_global_script_id = "execute-global-script";
    public const string stats_global_id = "stats-global";
    public const string stats_filtered_id = "stats-filtered";
    public const string metadata_diff_current_id = "metadata-diff-current";
    public const string metadata_diff_new_id = "metadata-diff-new";
    public const string test_script_id = "test-script";
    public const string only_items_selected_tooltip_id = "only-items-selected-tooltip";
    public const string save_as_default_id = "save-as-default";
    public const string favorite_game_id = "favorite-game";
    public const string remove_favorite_game_id = "remove-favorite-game";
    public const string hide_game_id = "hide-game";
    public const string un_hide_game_id = "un-hide-game";
    public const string enable_hdr_id = "enable-hdr";
    public const string disable_hdr_id = "disable-hdr";
    public const string edit_game_id = "edit-game";
    public const string calculate_install_size_id = "calculate-install-size";
    public const string calculate_games_all_install_size_id = "calculate-games-all-install-size";
    public const string calculate_games_missing_install_size_id = "calculate-games-missing-install-size";
    public const string install_size_menu_label_id = "install-size-menu-label";
    public const string set_game_category_id = "set-game-category";
    public const string set_completion_status_id = "set-completion-status";
    public const string remove_game_id = "remove-game";
    public const string play_game_id = "play-game";
    public const string install_game_id = "install-game";
    public const string game_options_id = "game-options";
    public const string game_details_id = "game-details";
    public const string uninstall_game_id = "uninstall-game";
    public const string open_game_location_id = "open-game-location";
    public const string create_desktop_shortcut_id = "create-desktop-shortcut";
    public const string open_game_manual_id = "open-game-manual";
    public const string more_action_id = "more-action";
    public const string play_action_use_plugin_id = "play-action-use-plugin";
    public const string play_action_use_plugin_tooltip_id = "play-action-use-plugin-tooltip";
    public const string metadownload_no_results_message_id = "metadownload-no-results-message";
    public const string metadownload_single_game_tip_id = "metadownload-single-game-tip";
    public const string progreess_availability_message_id = "progreess-availability-message";
    public const string description_htmlsupport_tooltip_id = "description-htmlsupport-tooltip";
    public const string description_playtime_seconds_id = "description-playtime-seconds";
    public const string description_size_bytes_id = "description-size-bytes";
    public const string release_date_tooltip_id = "release-date-tooltip";
    public const string description_score_values_id = "description-score-values";
    public const string patreon_develop_message_id = "patreon-develop-message";
    public const string about_contributors_message_id = "about-contributors-message";
    public const string cancel_monitoring_ask_title_id = "cancel-monitoring-ask-title";
    public const string cancel_monitoring_setup_ask_id = "cancel-monitoring-setup-ask";
    public const string cancel_monitoring_execution_ask_id = "cancel-monitoring-execution-ask";
    public const string time_played_id = "time-played";
    public const string last_played_id = "last-played";
    public const string played_days_id = "played-days";
    public const string played_hours_id = "played-hours";
    public const string played_minutes_id = "played-minutes";
    public const string played_seconds_id = "played-seconds";
    public const string played_none_id = "played-none";
    public const string opening_desktop_mode_message_id = "opening-desktop-mode-message";
    public const string opening_fullscreen_mode_message_id = "opening-fullscreen-mode-message";
    public const string opening_database_id = "opening-database";
    public const string calculating_install_size_message_id = "calculating-install-size-message";
    public const string calculating_install_size_of_game_message_id = "calculating-install-size-of-game-message";
    public const string script_install_fail_id = "script-install-fail";
    public const string script_install_success_id = "script-install-success";
    public const string install_script_id = "install-script";
    public const string script_error_id = "script-error";
    public const string script_execution_error_id = "script-execution-error";
    public const string open_metadata_folder_id = "open-metadata-folder";
    public const string install_size_calculate_id = "install-size-calculate";
    public const string install_size_calculate_edit_button_tooltip_id = "install-size-calculate-edit-button-tooltip";
    public const string client_not_installed_error_id = "client-not-installed-error";
    public const string sign_in_external_notif_id = "sign-in-external-notif";
    public const string sign_in_external_wait_message_id = "sign-in-external-wait-message";
    public const string install_dir_not_found_error_id = "install-dir-not-found-error";
    public const string invalid_game_action_settings_id = "invalid-game-action-settings";
    public const string trouble_shooting_account_link_id = "trouble-shooting-account-link";
    public const string trouble_shooting_issues_id = "trouble-shooting-issues";
    public const string rename_item_id = "rename-item";
    public const string add_new_item_id = "add-new-item";
    public const string enter_name_id = "enter-name";
    public const string enter_new_name_id = "enter-new-name";
    public const string playtime_less_then_an_hour_id = "playtime-less-then-an-hour";
    public const string playtime1to10_id = "playtime1to10";
    public const string playtime10to100_id = "playtime10to100";
    public const string playtime100to500_id = "playtime100to500";
    public const string playtime500to1000_id = "playtime500to1000";
    public const string playtime1000plus_id = "playtime1000plus";
    public const string ext_installation_restart_notif_id = "ext-installation-restart-notif";
    public const string general_extension_package_error_id = "general-extension-package-error";
    public const string general_theme_package_error_id = "general-theme-package-error";
    public const string specific_extension_load_error_id = "specific-extension-load-error";
    public const string specific_extension_load_sdkerror_id = "specific-extension-load-sdkerror";
    public const string specific_theme_load_error_id = "specific-theme-load-error";
    public const string specific_theme_load_sdkerror_id = "specific-theme-load-sdkerror";
    public const string general_extension_load_error_id = "general-extension-load-error";
    public const string general_theme_load_error_id = "general-theme-load-error";
    public const string general_extension_install_api_version_fails_id = "general-extension-install-api-version-fails";
    public const string general_extension_install_success_id = "general-extension-install-success";
    public const string general_extension_install_title_id = "general-extension-install-title";
    public const string extension_generic_id = "extension-generic";
    public const string addon_install_faild_id = "addon-install-faild";
    public const string extension_install_fail_id = "extension-install-fail";
    public const string extension_install_prompt_id = "extension-install-prompt";
    public const string extension_update_prompt_id = "extension-update-prompt";
    public const string theme_install_fail_id = "theme-install-fail";
    public const string theme_install_prompt_id = "theme-install-prompt";
    public const string theme_update_prompt_id = "theme-update-prompt";
    public const string url_navigation_message_id = "url-navigation-message";
    public const string game_image_size_warning_id = "game-image-size-warning";
    public const string performance_warning_title_id = "performance-warning-title";
    public const string dont_show_again_title_id = "dont-show-again-title";
    public const string incompatible_drag_and_drop_extension_error_id = "incompatible-drag-and-drop-extension-error";
    public const string incompatible_drag_and_drop_extension_error_title_id = "incompatible-drag-and-drop-extension-error-title";
    public const string large_media_warning_tooltip_id = "large-media-warning-tooltip";
    public const string theme_uninstall_question_id = "theme-uninstall-question";
    public const string theme_built_in_uninstall_hint_id = "theme-built-in-uninstall-hint";
    public const string theme_unsupported_id = "theme-unsupported";
    public const string extension_uninstall_question_id = "extension-uninstall-question";
    public const string extension_built_in_uninstall_hint_id = "extension-built-in-uninstall-hint";
    public const string extension_unsupported_id = "extension-unsupported";
    public const string extension_install_dir_id = "extension-install-dir";
    public const string extension_data_dir_id = "extension-data-dir";
    public const string diag_generating_id = "diag-generating";
    public const string diag_uploading_id = "diag-uploading";
    public const string add_from_exe_id = "add-from-exe";
    public const string what_is_this_id = "what-is-this";
    public const string confirumation_ask_generic_id = "confirumation-ask-generic";
    public const string stats_total_play_time_id = "stats-total-play-time";
    public const string stats_avarage_play_time_id = "stats-avarage-play-time";
    public const string stats_top_play_time_id = "stats-top-play-time";
    public const string stats_total_install_size_id = "stats-total-install-size";
    public const string overview_label_id = "overview-label";
    public const string sidebar_id = "sidebar";
    public const string tools_show_on_sidebar_id = "tools-show-on-sidebar";
    public const string settings_reset_id = "settings-reset";
    public const string settings_default_reset_desc_id = "settings-default-reset-desc";
    public const string settings_for_developers_id = "settings-for-developers";
    public const string settings_external_extensions_id = "settings-external-extensions";
    public const string settings_new_external_extension_box_id = "settings-new-external-extension-box";
    public const string common_links_achievements_id = "common-links-achievements";
    public const string common_links_forum_id = "common-links-forum";
    public const string common_links_news_id = "common-links-news";
    public const string common_links_store_page_id = "common-links-store-page";
    public const string fullscreen_first_time_error_id = "fullscreen-first-time-error";
    public const string quick_filter_recently_played_id = "quick-filter-recently-played";
    public const string quick_filter_favorites_id = "quick-filter-favorites";
    public const string quick_filter_most_played_id = "quick-filter-most-played";
    public const string quick_filter_all_games_id = "quick-filter-all-games";
    public const string game_list_filtered_id = "game-list-filtered";
    public const string game_list_extra_filtered_id = "game-list-extra-filtered";
    public const string game_list_search_results_id = "game-list-search-results";
    public const string item_already_exists_id = "item-already-exists";
    public const string random_game_limist_to_filter_id = "random-game-limist-to-filter";
    public const string random_game_pick_another_id = "random-game-pick-another";
    public const string menu_addons_id = "menu-addons";
    public const string extensions_installed_id = "extensions-installed";
    public const string extensions_settings_id = "extensions-settings";
    public const string extensions_browse_id = "extensions-browse";
    public const string extensions_updates_id = "extensions-updates";
    public const string extensions_updates_count_id = "extensions-updates-count";
    public const string addons_config_move_info_id = "addons-config-move-info";
    public const string libraries_config_window_description_id = "libraries-config-window-description";
    public const string addons_themes_desktop_id = "addons-themes-desktop";
    public const string addons_themes_fullscren_id = "addons-themes-fullscren";
    public const string addons_searching_id = "addons-searching";
    public const string addon_error_not_compatible_id = "addon-error-not-compatible";
    public const string addon_error_download_failed_id = "addon-error-download-failed";
    public const string addon_error_manifest_download_error_id = "addon-error-manifest-download-error";
    public const string addon_changes_restart_id = "addon-changes-restart";
    public const string addon_queued_for_install_id = "addon-queued-for-install";
    public const string addon_install_id = "addon-install";
    public const string addon_uninstall_id = "addon-uninstall";
    public const string addon_already_installed_id = "addon-already-installed";
    public const string addon_no_addons_available_id = "addon-no-addons-available";
    public const string addon_update_addons_id = "addon-update-addons";
    public const string addon_changelog_not_availavble_id = "addon-changelog-not-availavble";
    public const string addon_update_status_downloaded_id = "addon-update-status-downloaded";
    public const string addon_update_status_failed_id = "addon-update-status-failed";
    public const string addon_update_status_license_rejected_id = "addon-update-status-license-rejected";
    public const string addon_downloading_addon_id = "addon-downloading-addon";
    public const string addon_looking_for_updates_id = "addon-looking-for-updates";
    public const string addon_updates_available_id = "addon-updates-available";
    public const string addon_select_to_update_id = "addon-select-to-update";
    public const string addon_dev_reference_loaded_id = "addon-dev-reference-loaded";
    public const string addon_license_window_title_id = "addon-license-window-title";
    public const string license_accept_id = "license-accept";
    public const string license_decline_id = "license-decline";
    public const string include_plugin_game_actions_id = "include-plugin-game-actions";
    public const string select_action_title_id = "select-action-title";
    public const string action_tracking_mode_id = "action-tracking-mode";
    public const string action_tracking_path_id = "action-tracking-path";
    public const string game_action_type_link_id = "game-action-type-link";
    public const string game_action_type_file_id = "game-action-type-file";
    public const string game_action_type_emulator_id = "game-action-type-emulator";
    public const string game_action_type_script_id = "game-action-type-script";
    public const string action_tracking_mode_default_id = "action-tracking-mode-default";
    public const string action_tracking_mode_process_id = "action-tracking-mode-process";
    public const string action_tracking_mode_directory_id = "action-tracking-mode-directory";
    public const string action_tracking_original_process_id = "action-tracking-original-process";
    public const string devel_trace_log_enable_id = "devel-trace-log-enable";
    public const string multi_edit_overwrite_warning_id = "multi-edit-overwrite-warning";
    public const string grid_view_spacing_mode_none_id = "grid-view-spacing-mode-none";
    public const string grid_view_spacing_mode_uniform_id = "grid-view-spacing-mode-uniform";
    public const string grid_view_spacing_mode_between_items_only_id = "grid-view-spacing-mode-between-items-only";
    public const string grid_view_spacing_mode_start_and_end_only_id = "grid-view-spacing-mode-start-and-end-only";
    public const string scrolling_sensitivity_id = "scrolling-sensitivity";
    public const string smooth_scrolling_id = "smooth-scrolling";
    public const string smooth_scrolling_speed_id = "smooth-scrolling-speed";
    public const string ask_remove_item_title_id = "ask-remove-item-title";
    public const string ask_remove_item_message_id = "ask-remove-item-message";
    public const string settings_top_panel_items_id = "settings-top-panel-items";
    public const string settings_top_panel_general_view_item_id = "settings-top-panel-general-view-item";
    public const string settings_top_panel_grouping_item_id = "settings-top-panel-grouping-item";
    public const string settings_top_panel_sorting_item_id = "settings-top-panel-sorting-item";
    public const string settings_top_panel_filter_presets_item_id = "settings-top-panel-filter-presets-item";
    public const string top_panel_plugin_panel_position_id = "top-panel-plugin-panel-position";
    public const string top_panel_separator_width_id = "top-panel-separator-width";
    public const string top_panel_main_button_move_id = "top-panel-main-button-move";
    public const string top_panel_explorer_switch_id = "top-panel-explorer-switch";
    public const string top_panel_select_random_game_button_id = "top-panel-select-random-game-button";
    public const string top_panel_view_select_random_game_button_id = "top-panel-view-select-random-game-button";
    public const string top_panel_view_select_random_game_button_tooltip_id = "top-panel-view-select-random-game-button-tooltip";
    public const string filter_preset_save_view_options_id = "filter-preset-save-view-options";
    public const string filter_preset_show_on_fstop_panel_id = "filter-preset-show-on-fstop-panel";
    public const string in_past7_days_id = "in-past7-days";
    public const string in_past31_days_id = "in-past31-days";
    public const string in_past365_days_id = "in-past365-days";
    public const string more_than365_days_ago_id = "more-than365-days-ago";
    public const string configure_id = "configure";
    public const string filter_preset_save_id = "filter-preset-save";
    public const string settings_minimize_after_starting_game_id = "settings-minimize-after-starting-game";
    public const string settings_minimize_after_starting_game_description_id = "settings-minimize-after-starting-game-description";
    public const string settings_font_size_id = "settings-font-size";
    public const string settings_font_size_small_id = "settings-font-size-small";
    public const string settings_xinput_processing_id = "settings-xinput-processing";
    public const string settings_xinput_processing_description_id = "settings-xinput-processing-description";
    public const string settings_show_items_main_menu_header_id = "settings-show-items-main-menu-header";
    public const string settings_swap_main_view_xabuttons_id = "settings-swap-main-view-xabuttons";
    public const string settings_swap_main_view_xabuttons_descriptions_id = "settings-swap-main-view-xabuttons-descriptions";
    public const string settings_swap_confirm_cancel_buttons_id = "settings-swap-confirm-cancel-buttons";
    public const string settings_swap_confirm_cancel_buttons_descriptions_id = "settings-swap-confirm-cancel-buttons-descriptions";
    public const string settings_primary_controller_only_id = "settings-primary-controller-only";
    public const string settings_primary_controller_only_description_id = "settings-primary-controller-only-description";
    public const string settings_refocus_on_guid_button_id = "settings-refocus-on-guid-button";
    public const string settings_interface_volume_id = "settings-interface-volume";
    public const string settings_musi_volume_id = "settings-musi-volume";
    public const string settings_mute_background_id = "settings-mute-background";
    public const string error_audio_interface_init_id = "error-audio-interface-init";
    public const string settings_audio_output_api_id = "settings-audio-output-api";
    public const string settings_audio_output_api_description_id = "settings-audio-output-api-description";
    public const string settings_fssection_general_id = "settings-fssection-general";
    public const string settings_fssection_visuals_id = "settings-fssection-visuals";
    public const string settings_fssection_audio_id = "settings-fssection-audio";
    public const string settings_fssection_layout_id = "settings-fssection-layout";
    public const string settings_fssection_menus_id = "settings-fssection-menus";
    public const string settings_fssection_id = "settings-fssection";
    public const string game_is_starting_id = "game-is-starting";
    public const string game_is_running_id = "game-is-running";
    public const string text_input_capitalize_id = "text-input-capitalize";
    public const string text_input_space_id = "text-input-space";
    public const string settings_image_scaler_mode_id = "settings-image-scaler-mode";
    public const string settings_image_scaling_alternative_id = "settings-image-scaling-alternative";
    public const string settings_image_scaling_balanced_id = "settings-image-scaling-balanced";
    public const string settings_image_scaling_quality_id = "settings-image-scaling-quality";
    public const string settings_image_scaler_mode_tooltip_id = "settings-image-scaler-mode-tooltip";
    public const string select_file_tooltip_id = "select-file-tooltip";
    public const string select_directory_tooltip_id = "select-directory-tooltip";
    public const string startup_script_id = "startup-script";
    public const string addon_perf_notice_id = "addon-perf-notice";
    public const string game_action_select_on_start_id = "game-action-select-on-start";
    public const string emulator_select_on_start_id = "emulator-select-on-start";
    public const string emulator_built_in_profiles_id = "emulator-built-in-profiles";
    public const string emulator_built_in_profile_id = "emulator-built-in-profile";
    public const string emulator_custom_profiles_id = "emulator-custom-profiles";
    public const string emulator_custom_profile_id = "emulator-custom-profile";
    public const string emulator_function_handled_by_script_id = "emulator-function-handled-by-script";
    public const string emulator_spec_id = "emulator-spec";
    public const string platform_spec_id = "platform-spec";
    public const string region_spec_id = "region-spec";
    public const string emulator_pre_script_description_id = "emulator-pre-script-description";
    public const string emulator_post_script_description_id = "emulator-post-script-description";
    public const string emulator_started_script_description_id = "emulator-started-script-description";
    public const string error_emulator_executable_not_found_id = "error-emulator-executable-not-found";
    public const string error_emulator_specification_not_found_id = "error-emulator-specification-not-found";
    public const string error_emulator_startup_script_not_found_id = "error-emulator-startup-script-not-found";
    public const string split_emu_import_split_games_id = "split-emu-import-split-games";
    public const string split_emu_import_merge_games_id = "split-emu-import-merge-games";
    public const string emu_import_assign_platform_id = "emu-import-assign-platform";
    public const string emu_import_assign_region_id = "emu-import-assign-region";
    public const string emu_scan_directory_id = "emu-scan-directory";
    public const string emu_scan_configurations_id = "emu-scan-configurations";
    public const string emu_crc_exclude_file_types_id = "emu-crc-exclude-file-types";
    public const string emu_crc_exclude_file_types_tooltip_id = "emu-crc-exclude-file-types-tooltip";
    public const string emu_scan_emulator_id = "emu-scan-emulator";
    public const string scan_config_name_error_id = "scan-config-name-error";
    public const string scan_config_no_emulator_error_id = "scan-config-no-emulator-error";
    public const string scan_config_directory_error_id = "scan-config-directory-error";
    public const string scan_config_error_id = "scan-config-error";
    public const string emu_scan_include_global_update_id = "emu-scan-include-global-update";
    public const string emulator_scan_failed_id = "emulator-scan-failed";
    public const string emulated_game_scan_failed_id = "emulated-game-scan-failed";
    public const string emu_scan_hide_imported_id = "emu-scan-hide-imported";
    public const string emu_import_profiles_to_import_header_id = "emu-import-profiles-to-import-header";
    public const string emu_auto_scan_configurations_id = "emu-auto-scan-configurations";
    public const string emu_save_scan_config_id = "emu-save-scan-config";
    public const string emu_save_scan_config_tooltip_id = "emu-save-scan-config-tooltip";
    public const string emu_import_with_relative_paths_id = "emu-import-with-relative-paths";
    public const string emu_import_with_relative_paths_tooltip_id = "emu-import-with-relative-paths-tooltip";
    public const string emu_import_scan_subfolders_id = "emu-import-scan-subfolders";
    public const string emu_import_scan_inside_archives_id = "emu-import-scan-inside-archives";
    public const string emu_merge_related_files_id = "emu-merge-related-files";
    public const string emu_merge_related_files_tooltip_id = "emu-merge-related-files-tooltip";
    public const string emu_add_scanner_id = "emu-add-scanner";
    public const string emu_add_saved_scanner_id = "emu-add-saved-scanner";
    public const string start_scan_id = "start-scan";
    public const string emu_import_directory_config_desc_id = "emu-import-directory-config-desc";
    public const string completion_status_default_status_desc_id = "completion-status-default-status-desc";
    public const string completion_status_played_status_desc_id = "completion-status-played-status-desc";
    public const string power_shell_creation_error_id = "power-shell-creation-error";
    public const string filter_preset_name_conflict_id = "filter-preset-name-conflict";
    public const string sorting_name_autofill_id = "sorting-name-autofill";
    public const string sorting_name_autofill_tooltip_id = "sorting-name-autofill-tooltip";
    public const string sorting_name_removed_articles_id = "sorting-name-removed-articles";
    public const string sorting_name_removed_articles_tooltip_id = "sorting-name-removed-articles-tooltip";
    public const string sorting_name_autofill_button_id = "sorting-name-autofill-button";
    public const string settings_sorting_label_id = "settings-sorting-label";
    public const string sorting_name_autofill_progress_id = "sorting-name-autofill-progress";
    public const string nahimic_service_warning_id = "nahimic-service-warning";
    public const string elevated_process_warning_id = "elevated-process-warning";
    public const string elevated_process_warning_show_option_id = "elevated-process-warning-show-option";
    public const string install_size_scan_use_size_on_disk_option_id = "install-size-scan-use-size-on-disk-option";
    public const string install_size_scan_use_size_on_disk_option_tooltip_id = "install-size-scan-use-size-on-disk-option-tooltip";
    public const string warning_blacklisted_extensions_id = "warning-blacklisted-extensions";
    public const string emu_exclude_online_files_id = "emu-exclude-online-files";
    public const string emu_exclude_online_files_tooltip_id = "emu-exclude-online-files-tooltip";
    public const string emu_use_simplified_online_file_scan_id = "emu-use-simplified-online-file-scan";
    public const string emu_use_simplified_online_file_scan_tooltip_id = "emu-use-simplified-online-file-scan-tooltip";
    public const string metadat_set_all_fields_to_value_id = "metadat-set-all-fields-to-value";
    public const string override_install_state_id = "override-install-state";
    public const string override_install_state_tooltip_id = "override-install-state-tooltip";
    public const string option_only_manually_id = "option-only-manually";
    public const string option_once_aday_id = "option-once-aday";
    public const string option_once_aweek_id = "option-once-aweek";
    public const string option_on_every_startup_id = "option-on-every-startup";
    public const string check_program_updates_id = "check-program-updates";
    public const string check_addon_updates_id = "check-addon-updates";
    public const string check_library_updates_id = "check-library-updates";
    public const string check_emulated_library_updates_id = "check-emulated-library-updates";
    public const string stats_include_hidden_id = "stats-include-hidden";
    public const string menu_set_fields_id = "menu-set-fields";
    public const string item_selection_select_deselect_all_id = "item-selection-select-deselect-all";
    public const string open_id = "open";
    public const string activate_id = "activate";
    public const string assign_id = "assign";
    public const string default_search_description_id = "default-search-description";
    public const string default_search_hint_id = "default-search-hint";
    public const string search_filter_uninstalled_id = "search-filter-uninstalled";
    public const string search_filter_hidden_id = "search-filter-hidden";
    public const string search_filter_uninstalled_included_id = "search-filter-uninstalled-included";
    public const string search_filter_uninstalled_excluded_id = "search-filter-uninstalled-excluded";
    public const string search_filter_hidden_included_id = "search-filter-hidden-included";
    public const string search_filter_hiddenalled_excluded_id = "search-filter-hiddenalled-excluded";
    public const string game_search_item_action_play_id = "game-search-item-action-play";
    public const string game_search_item_action_switch_to_id = "game-search-item-action-switch-to";
    public const string game_search_item_action_open_menu_id = "game-search-item-action-open-menu";
    public const string game_search_item_action_edit_id = "game-search-item-action-edit";
    public const string open_search_id = "open-search";
    public const string top_panel_search_box_id = "top-panel-search-box";
    public const string top_panel_search_button_id = "top-panel-search-button";
    public const string search_settings_primary_action_id = "search-settings-primary-action";
    public const string search_settings_secondary_action_id = "search-settings-secondary-action";
    public const string search_settings_keyboard_open_search_id = "search-settings-keyboard-open-search";
    public const string search_settings_save_filter_id = "search-settings-save-filter";
    public const string search_settings_search_providers_id = "search-settings-search-providers";
    public const string search_settings_default_keyword_id = "search-settings-default-keyword";
    public const string search_settings_custom_keyword_id = "search-settings-custom-keyword";
    public const string search_settings_system_wide_shortcut_id = "search-settings-system-wide-shortcut";
    public const string search_title_id = "search-title";
    public const string extension_settings_menu_id = "extension-settings-menu";
    public const string exclusions_id = "exclusions";
    public const string emu_scanner_excluded_files_id = "emu-scanner-excluded-files";
    public const string emu_scanner_excluded_folders_id = "emu-scanner-excluded-folders";
    public const string emu_import_add_romexclusion_list_id = "emu-import-add-romexclusion-list";
    public const string emu_import_add_folder_exclusion_list_id = "emu-import-add-folder-exclusion-list";
    public const string emu_exclusion_no_config_error_id = "emu-exclusion-no-config-error";
    public const string emu_exclusion_added_message_id = "emu-exclusion-added-message";
    public const string emu_override_platform_id = "emu-override-platform";
    public const string emu_override_platform_tooltip_id = "emu-override-platform-tooltip";
    public const string search_include_commands_in_default_id = "search-include-commands-in-default";
    public const string search_include_commands_in_default_tooltip_id = "search-include-commands-in-default-tooltip";
    public const string name_filter_use_fuzzy_matching_id = "name-filter-use-fuzzy-matching";
    public const string name_filter_use_fuzzy_matching_tooltip_id = "name-filter-use-fuzzy-matching-tooltip";
    public const string search_view_game_field_options_id = "search-view-game-field-options";
    public const string hidden_status_id = "hidden-status";
    public const string backup_cancelled_id = "backup-cancelled";
    public const string backup_failed_id = "backup-failed";
    public const string backup_error_title_id = "backup-error-title";
    public const string backup_progress_id = "backup-progress";
    public const string backup_restore_progress_id = "backup-restore-progress";
    public const string backup_restore_failed_id = "backup-restore-failed";
    public const string backup_option_settings_id = "backup-option-settings";
    public const string backup_option_library_id = "backup-option-library";
    public const string backup_option_game_media_id = "backup-option-game-media";
    public const string backup_option_extensions_id = "backup-option-extensions";
    public const string backup_option_extensions_data_id = "backup-option-extensions-data";
    public const string backup_option_themes_id = "backup-option-themes";
    public const string backup_restore_message_id = "backup-restore-message";
    public const string backup_data_backup_message_id = "backup-data-backup-message";
    public const string settings_enable_automatic_backup_id = "settings-enable-automatic-backup";
    public const string settings_auto_backup_frequency_id = "settings-auto-backup-frequency";
    public const string settings_backup_folder_id = "settings-backup-folder";
    public const string settings_rotating_backups_id = "settings-rotating-backups";
    public const string settings_auto_backup_include_items_id = "settings-auto-backup-include-items";
    public const string settings_no_backup_dir_specified_error_id = "settings-no-backup-dir-specified-error";
    public const string update_notify_only_patches_id = "update-notify-only-patches";
    public const string update_notify_only_patches_toolip_id = "update-notify-only-patches-toolip";
    public const string settings_past_week_relative_format_id = "settings-past-week-relative-format";
    public const string settings_past_week_relative_format_tooltip_id = "settings-past-week-relative-format-tooltip";
    public const string settings_web_image_search_id = "settings-web-image-search";
    public const string settings_web_image_search_icon_term_id = "settings-web-image-search-icon-term";
    public const string settings_web_image_search_cover_term_id = "settings-web-image-search-cover-term";
    public const string settings_web_image_search_background_id = "settings-web-image-search-background";
    public const string gettings_addon_information_id = "gettings-addon-information";
    public const string no_metadata_source_id = "no-metadata-source";
    public const string scanner_config_play_action_settings_id = "scanner-config-play-action-settings";
    public const string scanner_config_play_action_settings_scanner_id = "scanner-config-play-action-settings-scanner";
    public const string scanner_config_play_action_settings_select_profile_id = "scanner-config-play-action-settings-select-profile";
    public const string scanner_config_play_action_settings_select_emulator_id = "scanner-config-play-action-settings-select-emulator";
    public const string automatic_id = "automatic";
    public const string always_on_id = "always-on";
    public const string always_off_id = "always-off";
    public const string settings_accessibility_interface_id = "settings-accessibility-interface";
    public const string application_menu_id = "application-menu";
    public const string game_menu_id = "game-menu";
    public const string program_folder_id = "program-folder";
    public const string user_data_folder_id = "user-data-folder";
    public const string dbcorruption_crash_message_id = "dbcorruption-crash-message";

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
    public static string aditional_filters()
    {
        return GetString("aditional-filters");
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
    public static string ext_crash_description(IFluentType var0)
    {
        return GetString("ext-crash-description", ("var0", var0));
    }
    public static string ext_crash_description_fs(IFluentType var0)
    {
        return GetString("ext-crash-description-fs", ("var0", var0));
    }
    public static string ext_crash_description_uknown()
    {
        return GetString("ext-crash-description-uknown");
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
    public static string game_remove_ask_message(IFluentType var0)
    {
        return GetString("game-remove-ask-message", ("var0", var0));
    }
    public static string games_remove_ask_message(IFluentType var0)
    {
        return GetString("games-remove-ask-message", ("var0", var0));
    }
    public static string game_remove_ask_message_ignore_option(IFluentType var0)
    {
        return GetString("game-remove-ask-message-ignore-option", ("var0", var0));
    }
    public static string games_remove_ask_message_ignore_option(IFluentType var0)
    {
        return GetString("games-remove-ask-message-ignore-option", ("var0", var0));
    }
    public static string remove_unused_fields_ask_message(IFluentType var0)
    {
        return GetString("remove-unused-fields-ask-message", ("var0", var0));
    }
    public static string remove_unused_fields_no_unused_message()
    {
        return GetString("remove-unused-fields-no-unused-message");
    }
    public static string remove_ask_add_to_exlusion_list_yes_response()
    {
        return GetString("remove-ask-add-to-exlusion-list-yes-response");
    }
    public static string game_edit_change_notif()
    {
        return GetString("game-edit-change-notif");
    }
    public static string dbupgrade_progress()
    {
        return GetString("dbupgrade-progress");
    }
    public static string dbupgrade_fail()
    {
        return GetString("dbupgrade-fail");
    }
    public static string dbupgrade_empty_space_fail(IFluentType var0)
    {
        return GetString("dbupgrade-empty-space-fail", ("var0", var0));
    }
    public static string game_error()
    {
        return GetString("game-error");
    }
    public static string game_start_error_no_game(IFluentType var0)
    {
        return GetString("game-start-error-no-game", ("var0", var0));
    }
    public static string game_start_error(IFluentType var0)
    {
        return GetString("game-start-error", ("var0", var0));
    }
    public static string game_start_action_error(IFluentType var0)
    {
        return GetString("game-start-action-error", ("var0", var0));
    }
    public static string game_open_location_error(IFluentType var0)
    {
        return GetString("game-open-location-error", ("var0", var0));
    }
    public static string calculate_game_size_error(IFluentType var0)
    {
        return GetString("calculate-game-size-error", ("var0", var0));
    }
    public static string calculate_game_size_error_caption()
    {
        return GetString("calculate-game-size-error-caption");
    }
    public static string calculate_games_size_error_message(IFluentType var0)
    {
        return GetString("calculate-games-size-error-message", ("var0", var0));
    }
    public static string game_shortcut_error(IFluentType var0)
    {
        return GetString("game-shortcut-error", ("var0", var0));
    }
    public static string manual_open_error(IFluentType var0)
    {
        return GetString("manual-open-error", ("var0", var0));
    }
    public static string game_install_error(IFluentType var0)
    {
        return GetString("game-install-error", ("var0", var0));
    }
    public static string game_uninstall_error(IFluentType var0)
    {
        return GetString("game-uninstall-error", ("var0", var0));
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
    public static string oklabel()
    {
        return GetString("oklabel");
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
    public static string urllabel()
    {
        return GetString("urllabel");
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
    public static string progress_importin_games(IFluentType var0)
    {
        return GetString("progress-importin-games", ("var0", var0));
    }
    public static string progress_importin_emulated_games(IFluentType var0)
    {
        return GetString("progress-importin-emulated-games", ("var0", var0));
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
    public static string sdkdocumentation()
    {
        return GetString("sdkdocumentation");
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
    public static string settings_defaul_icon_source()
    {
        return GetString("settings-defaul-icon-source");
    }
    public static string settings_defaul_cover_source()
    {
        return GetString("settings-defaul-cover-source");
    }
    public static string settings_defaul_background_source()
    {
        return GetString("settings-defaul-background-source");
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
    public static string settings_strech_mode_label()
    {
        return GetString("settings-strech-mode-label");
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
    public static string settings_invalid_dblocation()
    {
        return GetString("settings-invalid-dblocation");
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
    public static string settings_quic_launch_items()
    {
        return GetString("settings-quic-launch-items");
    }
    public static string settings_show_background_window_image()
    {
        return GetString("settings-show-background-window-image");
    }
    public static string settings_blur_window_backgroun_image()
    {
        return GetString("settings-blur-window-backgroun-image");
    }
    public static string settings_blur_high_quality()
    {
        return GetString("settings-blur-high-quality");
    }
    public static string settings_darken_window_backghroun_image()
    {
        return GetString("settings-darken-window-backghroun-image");
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
    public static string settings_dblocation()
    {
        return GetString("settings-dblocation");
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
    public static string settings_dbpath_notification()
    {
        return GetString("settings-dbpath-notification");
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
    public static string strech_none()
    {
        return GetString("strech-none");
    }
    public static string strech_fill()
    {
        return GetString("strech-fill");
    }
    public static string strech_uniform()
    {
        return GetString("strech-uniform");
    }
    public static string strech_uniform_to_fill()
    {
        return GetString("strech-uniform-to-fill");
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
    public static string emu_wizard_scanning_specific(IFluentType var0)
    {
        return GetString("emu-wizard-scanning-specific", ("var0", var0));
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
    public static string first_downloading_addon(IFluentType var0)
    {
        return GetString("first-downloading-addon", ("var0", var0));
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
    public static string emu_removal_confirmation(IFluentType var0, IFluentType var1)
    {
        return GetString("emu-removal-confirmation", ("var0", var0), ("var1", var1));
    }
    public static string platform_removal_confirmation(IFluentType var0, IFluentType var1, IFluentType var2)
    {
        return GetString("platform-removal-confirmation", ("var0", var0), ("var1", var1), ("var2", var2));
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
    public static string menu_group_dont()
    {
        return GetString("menu-group-dont");
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
    public static string game_romtitle()
    {
        return GetString("game-romtitle");
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
    public static string database_erro_title()
    {
        return GetString("database-erro-title");
    }
    public static string database_open_error()
    {
        return GetString("database-open-error");
    }
    public static string database_not_opened_error()
    {
        return GetString("database-not-opened-error");
    }
    public static string database_open_access_error(IFluentType var0)
    {
        return GetString("database-open-access-error", ("var0", var0));
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
    public static string library_import_error(IFluentType var0)
    {
        return GetString("library-import-error", ("var0", var0));
    }
    public static string library_import_emulated_error(IFluentType var0)
    {
        return GetString("library-import-emulated-error", ("var0", var0));
    }
    public static string scan_emulator_games_empty_profile_error()
    {
        return GetString("scan-emulator-games-empty-profile-error");
    }
    public static string start_generic_error()
    {
        return GetString("start-generic-error");
    }
    public static string skin_apply_error(IFluentType var0, IFluentType var1, IFluentType var2)
    {
        return GetString("skin-apply-error", ("var0", var0), ("var1", var1), ("var2", var2));
    }
    public static string urlformat_error()
    {
        return GetString("urlformat-error");
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
    public static string urlinput_info()
    {
        return GetString("urlinput-info");
    }
    public static string urlinput_info_titile()
    {
        return GetString("urlinput-info-titile");
    }
    public static string metadata_download_error(IFluentType var0)
    {
        return GetString("metadata-download-error", ("var0", var0));
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
    public static string apikey()
    {
        return GetString("apikey");
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
    public static string medata_diff_window_title()
    {
        return GetString("medata-diff-window-title");
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
    public static string metadownload_no_results_message(IFluentType var0)
    {
        return GetString("metadownload-no-results-message", ("var0", var0));
    }
    public static string metadownload_single_game_tip()
    {
        return GetString("metadownload-single-game-tip");
    }
    public static string progreess_availability_message()
    {
        return GetString("progreess-availability-message");
    }
    public static string description_htmlsupport_tooltip()
    {
        return GetString("description-htmlsupport-tooltip");
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
    public static string played_days(IFluentType var0, IFluentType var1, IFluentType var2)
    {
        return GetString("played-days", ("var0", var0), ("var1", var1), ("var2", var2));
    }
    public static string played_hours(IFluentType var0, IFluentType var1)
    {
        return GetString("played-hours", ("var0", var0), ("var1", var1));
    }
    public static string played_minutes(IFluentType var0)
    {
        return GetString("played-minutes", ("var0", var0));
    }
    public static string played_seconds(IFluentType var0)
    {
        return GetString("played-seconds", ("var0", var0));
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
    public static string calculating_install_size_of_game_message(IFluentType var0)
    {
        return GetString("calculating-install-size-of-game-message", ("var0", var0));
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
    public static string client_not_installed_error(IFluentType var0)
    {
        return GetString("client-not-installed-error", ("var0", var0));
    }
    public static string sign_in_external_notif(IFluentType var0)
    {
        return GetString("sign-in-external-notif", ("var0", var0));
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
    public static string specific_extension_load_error(IFluentType var0)
    {
        return GetString("specific-extension-load-error", ("var0", var0));
    }
    public static string specific_extension_load_sdkerror(IFluentType var0)
    {
        return GetString("specific-extension-load-sdkerror", ("var0", var0));
    }
    public static string specific_theme_load_error(IFluentType var0)
    {
        return GetString("specific-theme-load-error", ("var0", var0));
    }
    public static string specific_theme_load_sdkerror(IFluentType var0)
    {
        return GetString("specific-theme-load-sdkerror", ("var0", var0));
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
    public static string addon_install_faild(IFluentType var0)
    {
        return GetString("addon-install-faild", ("var0", var0));
    }
    public static string extension_install_fail(IFluentType var0)
    {
        return GetString("extension-install-fail", ("var0", var0));
    }
    public static string extension_install_prompt(IFluentType var0, IFluentType var1, IFluentType var2)
    {
        return GetString("extension-install-prompt", ("var0", var0), ("var1", var1), ("var2", var2));
    }
    public static string extension_update_prompt(IFluentType var0, IFluentType var1, IFluentType var2)
    {
        return GetString("extension-update-prompt", ("var0", var0), ("var1", var1), ("var2", var2));
    }
    public static string theme_install_fail(IFluentType var0)
    {
        return GetString("theme-install-fail", ("var0", var0));
    }
    public static string theme_install_prompt(IFluentType var0, IFluentType var1, IFluentType var2)
    {
        return GetString("theme-install-prompt", ("var0", var0), ("var1", var1), ("var2", var2));
    }
    public static string theme_update_prompt(IFluentType var0, IFluentType var1, IFluentType var2)
    {
        return GetString("theme-update-prompt", ("var0", var0), ("var1", var1), ("var2", var2));
    }
    public static string url_navigation_message(IFluentType var0)
    {
        return GetString("url-navigation-message", ("var0", var0));
    }
    public static string game_image_size_warning(IFluentType var0, IFluentType var1, IFluentType var2)
    {
        return GetString("game-image-size-warning", ("var0", var0), ("var1", var1), ("var2", var2));
    }
    public static string performance_warning_title()
    {
        return GetString("performance-warning-title");
    }
    public static string dont_show_again_title()
    {
        return GetString("dont-show-again-title");
    }
    public static string incompatible_drag_and_drop_extension_error(IFluentType var0)
    {
        return GetString("incompatible-drag-and-drop-extension-error", ("var0", var0));
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
    public static string confirumation_ask_generic()
    {
        return GetString("confirumation-ask-generic");
    }
    public static string stats_total_play_time()
    {
        return GetString("stats-total-play-time");
    }
    public static string stats_avarage_play_time()
    {
        return GetString("stats-avarage-play-time");
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
    public static string random_game_limist_to_filter()
    {
        return GetString("random-game-limist-to-filter");
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
    public static string extensions_updates_count(IFluentType var0)
    {
        return GetString("extensions-updates-count", ("var0", var0));
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
    public static string addons_themes_fullscren()
    {
        return GetString("addons-themes-fullscren");
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
    public static string addon_changelog_not_availavble()
    {
        return GetString("addon-changelog-not-availavble");
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
    public static string addon_downloading_addon(IFluentType var0)
    {
        return GetString("addon-downloading-addon", ("var0", var0));
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
    public static string addon_license_window_title(IFluentType var0)
    {
        return GetString("addon-license-window-title", ("var0", var0));
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
    public static string filter_preset_show_on_fstop_panel()
    {
        return GetString("filter-preset-show-on-fstop-panel");
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
    public static string settings_swap_main_view_xabuttons()
    {
        return GetString("settings-swap-main-view-xabuttons");
    }
    public static string settings_swap_main_view_xabuttons_descriptions()
    {
        return GetString("settings-swap-main-view-xabuttons-descriptions");
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
    public static string settings_musi_volume()
    {
        return GetString("settings-musi-volume");
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
    public static string settings_fssection_general()
    {
        return GetString("settings-fssection-general");
    }
    public static string settings_fssection_visuals()
    {
        return GetString("settings-fssection-visuals");
    }
    public static string settings_fssection_audio()
    {
        return GetString("settings-fssection-audio");
    }
    public static string settings_fssection_layout()
    {
        return GetString("settings-fssection-layout");
    }
    public static string settings_fssection_menus()
    {
        return GetString("settings-fssection-menus");
    }
    public static string settings_fssection()
    {
        return GetString("settings-fssection");
    }
    public static string game_is_starting(IFluentType var0)
    {
        return GetString("game-is-starting", ("var0", var0));
    }
    public static string game_is_running(IFluentType var0)
    {
        return GetString("game-is-running", ("var0", var0));
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
    public static string warning_blacklisted_extensions(IFluentType var0)
    {
        return GetString("warning-blacklisted-extensions", ("var0", var0));
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
    public static string metadat_set_all_fields_to_value()
    {
        return GetString("metadat-set-all-fields-to-value");
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
    public static string option_once_aday()
    {
        return GetString("option-once-aday");
    }
    public static string option_once_aweek()
    {
        return GetString("option-once-aweek");
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
    public static string search_filter_hiddenalled_excluded()
    {
        return GetString("search-filter-hiddenalled-excluded");
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
    public static string emu_import_add_romexclusion_list()
    {
        return GetString("emu-import-add-romexclusion-list");
    }
    public static string emu_import_add_folder_exclusion_list()
    {
        return GetString("emu-import-add-folder-exclusion-list");
    }
    public static string emu_exclusion_no_config_error()
    {
        return GetString("emu-exclusion-no-config-error");
    }
    public static string emu_exclusion_added_message(IFluentType var0)
    {
        return GetString("emu-exclusion-added-message", ("var0", var0));
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
    public static string update_notify_only_patches_toolip()
    {
        return GetString("update-notify-only-patches-toolip");
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
    public static string gettings_addon_information()
    {
        return GetString("gettings-addon-information");
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
    public static string dbcorruption_crash_message()
    {
        return GetString("dbcorruption-crash-message");
    }
}
