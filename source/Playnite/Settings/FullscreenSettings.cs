using Newtonsoft.Json;
using Playnite.Audio;
using Playnite.Common;
using Playnite.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playnite
{
    public class FullscreenFilterSettings : FilterSettings
    {
        public FullscreenFilterSettings() : base()
        {
            FilterChanged += (s, e) => OnPropertyChanged(nameof(IsSubAdditionalFilterActive));
        }

        [JsonIgnore]
        public bool IsSubAdditionalFilterActive
        {
            get
            {
                return
                    Series?.IsSet == true ||
                    Source?.IsSet == true ||
                    AgeRating?.IsSet == true ||
                    Region?.IsSet == true ||
                    Genre?.IsSet == true ||
                    Publisher?.IsSet == true ||
                    Developer?.IsSet == true ||
                    Tag?.IsSet == true ||
                    Feature?.IsSet == true ||
                    CompletionStatuses?.IsSet == true ||
                    UserScore?.IsSet == true ||
                    CriticScore?.IsSet == true ||
                    CommunityScore?.IsSet == true ||
                    LastActivity?.IsSet == true ||
                    Added?.IsSet == true ||
                    Modified?.IsSet == true ||
                    ReleaseYear?.IsSet == true ||
                    PlayTime?.IsSet == true;
            }
        }
    }

    
}
