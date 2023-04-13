using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playnite.SDK.Models
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class FilterPresetSettings
    {
        public bool UseAndFilteringStyle { get; set; }
        public bool IsInstalled { get; set; }
        public bool IsUnInstalled { get; set; }
        public bool Hidden { get; set; }
        public bool Favorite { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public StringFilterItemProperties ReleaseYear { get; set; }
        public IdItemFilterItemProperties Genre { get; set; }
        public IdItemFilterItemProperties Platform { get; set; }
        public IdItemFilterItemProperties Publisher { get; set; }
        public IdItemFilterItemProperties Developer { get; set; }
        public IdItemFilterItemProperties Category { get; set; }
        public IdItemFilterItemProperties Tag { get; set; }
        public IdItemFilterItemProperties Series { get; set; }
        public IdItemFilterItemProperties Region { get; set; }
        public IdItemFilterItemProperties Source { get; set; }
        public IdItemFilterItemProperties AgeRating { get; set; }
        public IdItemFilterItemProperties Library { get; set; }
        public IdItemFilterItemProperties CompletionStatuses { get; set; }
        public IdItemFilterItemProperties Feature { get; set; }
        public EnumFilterItemProperties UserScore { get; set; }
        public EnumFilterItemProperties CriticScore { get; set; }
        public EnumFilterItemProperties CommunityScore { get; set; }
        public EnumFilterItemProperties LastActivity { get; set; }
        public EnumFilterItemProperties RecentActivity { get; set; }
        public EnumFilterItemProperties Added { get; set; }
        public EnumFilterItemProperties Modified { get; set; }
        public EnumFilterItemProperties PlayTime { get; set; }
        public EnumFilterItemProperties InstallSize { get; set; }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    /// <summary>
    /// Represents filter for ID based fields.
    /// </summary>
    public class IdItemFilterItemProperties
    {
        /// <summary>
        /// Gets or sets list of item IDs to filter.
        /// </summary>
        public List<Guid> Ids { get; set; }

        /// <summary>
        /// Gets or sets full text search to filter.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Creates new instance of <see cref="IdItemFilterItemProperties"/>.
        /// </summary>
        public IdItemFilterItemProperties()
        {
        }

        /// <summary>
        /// Creates new instance of <see cref="IdItemFilterItemProperties"/>.
        /// </summary>
        /// <param name="ids"></param>
        public IdItemFilterItemProperties(List<Guid> ids)
        {
            Ids = ids;
        }

        /// <summary>
        /// Creates new instance of <see cref="IdItemFilterItemProperties"/>.
        /// </summary>
        /// <param name="id"></param>
        public IdItemFilterItemProperties(Guid id)
        {
            Ids = new List<Guid>() { id };
        }

        /// <summary>
        /// Creates new instance of <see cref="IdItemFilterItemProperties"/>.
        /// </summary>
        /// <param name="text"></param>
        public IdItemFilterItemProperties(string text)
        {
            Text = text;
        }
    }

    /// <summary>
    /// Represents filter for string based fields.
    /// </summary>
    public class StringFilterItemProperties
    {
        /// <summary>
        /// Gets or sets values to filter.
        /// </summary>
        public List<string> Values { get; set; }

        /// <summary>
        /// Creates new instance of <see cref="StringFilterItemProperties"/>.
        /// </summary>
        public StringFilterItemProperties()
        {
        }

        /// <summary>
        /// Creates new instance of <see cref="StringFilterItemProperties"/>.
        /// </summary>
        /// <param name="values"></param>
        public StringFilterItemProperties(List<string> values)
        {
            Values = values;
        }

        /// <summary>
        /// Creates new instance of <see cref="StringFilterItemProperties"/>.
        /// </summary>
        /// <param name="value"></param>
        public StringFilterItemProperties(string value)
        {
            Values = new List<string>() { value };
        }
    }

    /// <summary>
    /// Represents filter for enum based fields.
    /// </summary>
    public class EnumFilterItemProperties
    {
        /// <summary>
        /// Gets or sets values to filter.
        /// </summary>
        public List<int> Values { get; set; }

        /// <summary>
        /// Creates new instance of <see cref="EnumFilterItemProperties"/>.
        /// </summary>
        public EnumFilterItemProperties()
        {
        }

        /// <summary>
        /// Creates new instance of <see cref="EnumFilterItemProperties"/>.
        /// </summary>
        /// <param name="values"></param>
        public EnumFilterItemProperties(List<int> values)
        {
            Values = values;
        }

        /// <summary>
        /// Creates new instance of <see cref="EnumFilterItemProperties"/>.
        /// </summary>
        /// <param name="value"></param>
        public EnumFilterItemProperties(int value)
        {
            Values = new List<int>() { value };
        }
    }

    /// <summary>
    /// Represents filter preset.
    /// </summary>
    public class FilterPreset : DatabaseObject
    {
        private FilterPresetSettings settings;
        /// <summary>
        /// Gets or sets filter settings.
        /// </summary>
        public FilterPresetSettings Settings
        {
            get => settings;
            set
            {
                settings = value;
                OnPropertyChanged();
            }
        }

        private SortOrder? sortingOrder;
        /// <summary>
        /// Gets or sets view sorting order.
        /// </summary>
        public SortOrder? SortingOrder
        {
            get
            {
                return sortingOrder;
            }

            set
            {
                sortingOrder = value;
                OnPropertyChanged();
            }
        }

        private SortOrderDirection? sortingOrderDirection;
        /// <summary>
        /// Gets or sets view sorting order direction.
        /// </summary>
        public SortOrderDirection? SortingOrderDirection
        {
            get
            {
                return sortingOrderDirection;
            }

            set
            {
                sortingOrderDirection = value;
                OnPropertyChanged();
            }
        }

        private GroupableField? groupingOrder;
        /// <summary>
        /// Gets or sets view grouping.
        /// </summary>
        public GroupableField? GroupingOrder
        {
            get
            {
                return groupingOrder;
            }

            set
            {
                groupingOrder = value;
                OnPropertyChanged();
            }
        }

        private bool showInFullscreeQuickSelection = true;
        /// <summary>
        /// Gets or sets value indicating whether a filter preset should be shown in FS mode quick filter list.
        /// </summary>
        public bool ShowInFullscreeQuickSelection
        {
            get => showInFullscreeQuickSelection;
            set
            {
                showInFullscreeQuickSelection = value;
                OnPropertyChanged();
            }
        }

        /// <inheritdoc/>
        public override void CopyDiffTo(object target)
        {
            base.CopyDiffTo(target);
            if (target is FilterPreset tro)
            {
                if (!Data.Serialization.AreObjectsEqual(Settings, tro.Settings))
                {
                    tro.Settings = Settings;
                }

                if (SortingOrder != tro.SortingOrder)
                {
                    tro.SortingOrder = SortingOrder;
                }

                if (SortingOrderDirection != tro.SortingOrderDirection)
                {
                    tro.SortingOrderDirection = SortingOrderDirection;
                }

                if (GroupingOrder != tro.GroupingOrder)
                {
                    tro.GroupingOrder = GroupingOrder;
                }

                if (ShowInFullscreeQuickSelection != tro.ShowInFullscreeQuickSelection)
                {
                    tro.ShowInFullscreeQuickSelection = ShowInFullscreeQuickSelection;
                }
            }
            else
            {
                throw new ArgumentException($"Target object has to be of type {GetType().Name}");
            }
        }
    }
}
