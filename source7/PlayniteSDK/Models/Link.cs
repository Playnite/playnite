using CommunityToolkit.Mvvm.ComponentModel;

namespace Playnite;

/// <summary>
/// Represents web link.
/// </summary>
public partial class Link : ObservableObject, IEquatable<Link>
{
    /// <summary>
    /// Gets or sets name of the link.
    /// </summary>
    [ObservableProperty] private string? name;

    /// <summary>
    /// Gets or sets web based URL.
    /// </summary>
    [ObservableProperty] private string? url;

    /// <summary>
    /// Creates new instance of Link.
    /// </summary>
    public Link()
    {
    }

    /// <summary>
    /// Creates new instance of Link with specific values.
    /// </summary>
    /// <param name="name">Link name.</param>
    /// <param name="url">Link URL.</param>
    public Link(string name, string url)
    {
        Name = name;
        Url = url;
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return Equals(obj as Link);
    }

    /// <inheritdoc/>
    public bool Equals(Link? other)
    {
        if (other is null)
        {
            return false;
        }

        if (!string.Equals(Name, other.Name, StringComparison.Ordinal))
        {
            return false;
        }

        if (!string.Equals(Url, other.Url, StringComparison.Ordinal))
        {
            return false;
        }

        return true;
    }

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public Link GetCopy()
    {
        return new Link
        {
            Name = Name,
            Url = Url
        };
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Url);
    }
}
