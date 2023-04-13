using CommunityToolkit.Mvvm.ComponentModel;
using System.Text.Json.Serialization;

namespace Playnite;

public enum MetadataGamesSource
{
    AllFromDB,
    Selected,
    Filtered
}

public partial class MetadataFieldSettings : ObservableObject
{
    [ObservableProperty] private bool import = true;
    [ObservableProperty] private HashSet<Guid> sources = new();

    public MetadataFieldSettings()
    {
    }

    public MetadataFieldSettings(bool import, HashSet<Guid> sources)
    {
        Import = import;
        Sources = sources;
    }
}

public partial class MetadataDownloaderSettings : ObservableObject
{
    [ObservableProperty][property: JsonIgnore] private MetadataGamesSource gamesSource = MetadataGamesSource.AllFromDB;
    [ObservableProperty][property: JsonIgnore] private bool skipExistingValues = true;

    // TODO: autogen fields
    [ObservableProperty] private MetadataFieldSettings name = new();
    [ObservableProperty] private MetadataFieldSettings genre = new();
    [ObservableProperty] private MetadataFieldSettings releaseDate = new();
    [ObservableProperty] private MetadataFieldSettings developer = new();
    [ObservableProperty] private MetadataFieldSettings publisher = new();
    [ObservableProperty] private MetadataFieldSettings tag = new();
    [ObservableProperty] private MetadataFieldSettings feature = new();
    [ObservableProperty] private MetadataFieldSettings description = new();
    [ObservableProperty] private MetadataFieldSettings coverImage = new();
    [ObservableProperty] private MetadataFieldSettings backgroundImage = new();
    [ObservableProperty] private MetadataFieldSettings icon = new();
    [ObservableProperty] private MetadataFieldSettings links = new();
    [ObservableProperty] private MetadataFieldSettings criticScore = new();
    [ObservableProperty] private MetadataFieldSettings communityScore = new();
    [ObservableProperty] private MetadataFieldSettings ageRating = new();
    [ObservableProperty] private MetadataFieldSettings series = new();
    [ObservableProperty] private MetadataFieldSettings region = new();
    [ObservableProperty] private MetadataFieldSettings platform = new();
    [ObservableProperty] private MetadataFieldSettings installSize = new();

    public MetadataDownloaderSettings()
    {
    }

    public static MetadataDownloaderSettings GetDefaultSettings()
    {
        var igdbPluginId = Guid.Parse("000001DB-DBD1-46C6-B5D0-B1BA559D10E4");
        var settings = new MetadataDownloaderSettings();
        settings.ConfigureFields(new HashSet<Guid> { igdbPluginId }, true);
        settings.Description.Sources = new HashSet<Guid> { Guid.Empty, igdbPluginId };
        settings.Icon.Sources = new HashSet<Guid> { Guid.Empty, igdbPluginId };
        settings.BackgroundImage.Sources = new HashSet<Guid> { Guid.Empty, igdbPluginId };
        settings.CoverImage.Sources = new HashSet<Guid> { igdbPluginId, Guid.Empty };
        settings.Name.Import = false;
        return settings;
    }

    public void ConfigureFields(HashSet<Guid> sources, bool import)
    {
        // TODO: autogen
        Name = new MetadataFieldSettings(import, sources);
        Genre = new MetadataFieldSettings(import, sources);
        Description = new MetadataFieldSettings(import, sources);
        Developer = new MetadataFieldSettings(import, sources);
        Publisher = new MetadataFieldSettings(import, sources);
        Tag = new MetadataFieldSettings(import, sources);
        Links = new MetadataFieldSettings(import, sources);
        CoverImage = new MetadataFieldSettings(import, sources);
        BackgroundImage = new MetadataFieldSettings(import, sources);
        Icon = new MetadataFieldSettings(import, sources);
        ReleaseDate = new MetadataFieldSettings(import, sources);
        CommunityScore = new MetadataFieldSettings(import, sources);
        CriticScore = new MetadataFieldSettings(import, sources);
        Feature = new MetadataFieldSettings(import, sources);
        AgeRating = new MetadataFieldSettings(import, sources);
        Platform = new MetadataFieldSettings(import, sources);
        Series = new MetadataFieldSettings(import, sources);
        Region = new MetadataFieldSettings(import, sources);
        InstallSize = new MetadataFieldSettings(import, sources);
    }
}
