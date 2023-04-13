namespace Playnite;

/// <summary>
/// Specifies <see cref="Game"/> fields.
/// </summary>
public enum GameField : int
{
    ///
    BackgroundImage = 0,
    ///
    Description = 1,
    ///
    GenreIds = 2,
    ///
    Hidden = 3,
    ///
    Favorite = 4,
    ///
    Icon = 5,
    ///
    CoverImage = 6,
    ///
    InstallDirectory = 7,
    ///
    LastActivity = 9,
    ///
    SortingName = 10,
    ///
    Gameid = 11,
    ///
    PluginId = 12,
    ///
    PublisherIds = 16,
    ///
    DeveloperIds = 17,
    ///
    ReleaseDate = 18,
    ///
    CategoryIds = 19,
    ///
    TagIds = 20,
    ///
    Links = 21,
    ///
    IsInstalling = 22,
    ///
    IsUninstalling = 23,
    ///
    IsLaunching = 24,
    ///
    IsRunning = 25,
    ///
    IsInstalled = 26,
    ///
    IsCustomGame = 27,
    ///
    Playtime = 28,
    ///
    Added = 29,
    ///
    Modified = 30,
    ///
    PlayCount = 31,
    ///
    Version = 33,
    ///
    SourceId = 36,
    ///
    CompletionStatus = 37,
    ///
    UserScore = 38,
    ///
    CriticScore = 39,
    ///
    CommunityScore = 40,
    ///
    Genres = 41,
    ///
    Developers = 42,
    ///
    Publishers = 43,
    ///
    Tags = 44,
    ///
    Categories = 45,
    ///
    Source = 50,
    ///
    ReleaseYear = 51,
    ///
    PreScript = 53,
    ///
    PostScript = 54,
    ///
    Name = 55,
    ///
    Features = 56,
    ///
    FeatureIds = 57,
    ///
    UseGlobalPostScript = 58,
    ///
    UseGlobalPreScript = 59,
    ///
    UserScoreRating = 60,
    ///
    CommunityScoreRating = 61,
    ///
    CriticScoreRating = 62,
    ///
    UserScoreGroup = 63,
    ///
    CommunityScoreGroup = 64,
    ///
    CriticScoreGroup = 65,
    ///
    LastActivitySegment = 66,
    ///
    AddedSegment = 67,
    ///
    ModifiedSegment = 68,
    ///
    PlaytimeCategory = 69,
    ///
    InstallationStatus = 70,
    ///
    None = 71,
    ///
    GameStartedScript = 72,
    ///
    UseGlobalGameStartedScript = 73,
    ///
    Notes = 74,
    ///
    Manual = 75,
    ///
    GameActions = 76,
    ///
    IncludeLibraryPluginAction = 77,
    ///
    Roms = 78,
    ///
    AgeRatingIds = 79,
    ///
    AgeRatings = 80,
    ///
    SeriesIds = 81,
    ///
    Series = 82,
    ///
    RegionIds = 83,
    ///
    Regions = 84,
    ///
    PlatformIds = 85,
    ///
    Platforms = 86,
    ///
    CompletionStatusId = 87,
    ///
    OverrideInstallState = 88,
    ///
    InstallSize = 89,
    ///
    LastSizeScanDate = 90,
    ///
    RecentActivity = 91,
    ///
    EnableSystemHdr = 92
}

/// <summary>
///
/// </summary>
public class Game : DatabaseObject
{
}