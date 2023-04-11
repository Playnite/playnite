using CommunityToolkit.Mvvm.ComponentModel;

namespace Playnite;

/// <summary>
/// Represents plugin search support.
/// </summary>
public class SearchSupport
{
    internal string? Keyword { get; set; }

    /// <summary>
    /// Gets or sets default keyword.
    /// </summary>
    public string DefaultKeyword { get; set; }

    /// <summary>
    /// Gets or sets search name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets search context.
    /// </summary>
    public SearchContext Context { get; set; }

    /// <summary>
    /// Creates new instance of <see cref="SearchSupport"/>.
    /// </summary>
    /// <param name="defaultKeyword"></param>
    /// <param name="name"></param>
    /// <param name="context"></param>
    public SearchSupport(string defaultKeyword, string name, SearchContext context)
    {
        DefaultKeyword = defaultKeyword;
        Name = name;
        Context = context;
    }
}

/// <summary>
/// Represents search context.
/// </summary>
public abstract class SearchContext
{
    internal List<SearchItem>? AutoSearchCache { get; set; }

    /// <summary>
    /// Gets or sets search description.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets search hint.
    /// </summary>
    public string? Hint { get; set; }

    /// <summary>
    /// Gets or sets search label.
    /// </summary>
    public string? Label { get; set; }

    /// <summary>
    /// Gets or sets search delay in milliseconds.
    /// </summary>
    public int Delay { get; set; } = 0;

    /// <summary>
    /// Gets or sets value indicating whether auto search should be used in this context.
    /// </summary>
    public bool UseAutoSearch { get; set; }

    /// <summary>
    /// Gets search results.
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    public abstract IEnumerable<SearchItem>? GetSearchResults(GetSearchResultsArgs args);
}

/// <summary>
/// Represents generic list with static items.
/// </summary>
public class GenericListSearchContext : SearchContext
{
    /// <summary>
    /// Creates new instance of <see cref="GenericListSearchContext"/>.
    /// </summary>
    /// <param name="items"></param>
    /// <param name="label"></param>
    public GenericListSearchContext(List<SearchItem> items, string label)
    {
        Label = label;
        AutoSearchCache = items;
        UseAutoSearch = true;
    }

    /// <inheritdoc/>
    public sealed override IEnumerable<SearchItem>? GetSearchResults(GetSearchResultsArgs args)
    {
        return AutoSearchCache;
    }
}

/// <summary>
/// Represents global search game filter.
/// </summary>
public class GameSearchFilterSettings
{
    /// <summary>
    /// Gets or set value indicating whether uninstalled games should be included.
    /// </summary>
    public bool Uninstalled { get; set; }

    /// <summary>
    /// Gets or set value indicating whether hidden games should be included.
    /// </summary>
    public bool Hidden { get; set; }
}

/// <summary>
/// Represents search request arguments.
/// </summary>
public class GetSearchResultsArgs
{
    internal Action<SearchContext>? SwitchContextAction { get; set; }

    /// <summary>
    /// Gets search term.
    /// </summary>
    public string? SearchTerm { get; internal set; }

    /// <summary>
    /// Gets search cancellation token.
    /// </summary>
    public CancellationToken CancelToken { get; internal set; }

    /// <summary>
    /// Gets game filter.
    /// </summary>
    public GameSearchFilterSettings? GameFilterSettings { get; internal set; }

    /// <summary>
    /// Switch to new search context.
    /// </summary>
    /// <param name="newContext"></param>
    public void SwitchContext(SearchContext newContext)
    {
        SwitchContextAction?.Invoke(newContext);
    }
}

/// <summary>
/// Represents search item action.
/// </summary>
public class SearchItemAction
{
    /// <summary>
    /// Gets or sets action name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets item's action.
    /// </summary>
    public Action? Action { get; set; }

    /// <summary>
    /// Gets or sets value indicating whether this action should close search window when executed.
    /// </summary>
    public bool CloseSearch { get; set; } = true;

    /// <summary>
    /// Creates new instance of <see cref="SearchItemAction"/>.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="action"></param>
    public SearchItemAction(string name, Action? action)
    {
        Name = name;
        Action = action;
    }
}

/// <summary>
/// Represents search item action that switches to new context.
/// </summary>
public class ContextSwitchSearchItemAction : SearchItemAction
{
    /// <summary>
    /// Gets context to switch to when action is executed.
    /// </summary>
    public SearchContext Context { get; }

    /// <summary>
    /// Creates new instance of <see cref="ContextSwitchSearchItemAction"/>.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="newContext"></param>
    public ContextSwitchSearchItemAction(string name, SearchContext newContext)
        : base(name, null)
    {
        Context = newContext;
        CloseSearch = false;
    }
}

/// <summary>
/// Represents search item for global search results.
/// </summary>
public class SearchItem
{
    /// <summary>
    /// Gets or sets primary actions.
    /// </summary>
    public SearchItemAction PrimaryAction { get; set; }

    /// <summary>
    /// Gets or sets secondary action.
    /// </summary>
    public SearchItemAction? SecondaryAction { get; set; }

    /// <summary>
    /// Gets or sets menu action context.
    /// </summary>
    public ContextSwitchSearchItemAction? MenuAction { get; set; }

    /// <summary>
    /// Gets or sets item icon.
    /// </summary>
    public object? Icon { get; set; }

    /// <summary>
    /// Gets or sets item name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets item description.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Creates new instance of <see cref="SearchItem"/>.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="primaryAction"></param>
    public SearchItem(string name, SearchItemAction primaryAction)
    {
        Name = name;
        PrimaryAction = primaryAction;
    }

    /// <summary>
    /// Creates new instance of <see cref="SearchItem"/>.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="primaryAction"></param>
    /// <param name="icon"></param>
    public SearchItem(string name, SearchItemAction primaryAction, object icon)
        : this(name, primaryAction)
    {
        Icon = icon;
    }

    /// <summary>
    /// Creates new instance of <see cref="SearchItem"/>.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="primaryActionName"></param>
    /// <param name="primaryAction"></param>
    public SearchItem(string name, string primaryActionName, Action primaryAction)
        : this(name, new SearchItemAction(primaryActionName, primaryAction))
    {
    }

    /// <summary>
    /// Creates new instance of <see cref="SearchItem"/>.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="primaryActionName"></param>
    /// <param name="primaryAction"></param>
    /// <param name="icon"></param>
    public SearchItem(string name, string primaryActionName, Action primaryAction, object icon)
        : this(name, new SearchItemAction(primaryActionName, primaryAction), icon)
    {
    }
}

/// <summary>
/// Represents game search item for global search results.
/// </summary>
public class GameSearchItem : SearchItem
{
    /// <summary>
    /// Gets associated game.
    /// </summary>
    public Game Game { get; }

    /// <summary>
    /// Creates new instance of <see cref="GameSearchItem"/>.
    /// </summary>
    /// <param name="game"></param>
    /// <param name="primaryAction"></param>
    public GameSearchItem(Game game, SearchItemAction primaryAction)
        : base(game.Name ?? "uknown", primaryAction)
    {
        Game = game;
    }

    /// <summary>
    /// Creates new instance of <see cref="GameSearchItem"/>.
    /// </summary>
    /// <param name="game"></param>
    /// <param name="primaryActionName"></param>
    /// <param name="primaryAction"></param>
    public GameSearchItem(Game game, string primaryActionName, Action primaryAction)
        : base(game.Name ?? "uknown", primaryActionName, primaryAction)
    {
        Game = game;
    }
}
