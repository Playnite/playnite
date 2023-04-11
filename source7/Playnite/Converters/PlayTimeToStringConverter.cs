using System.Windows.Data;
using System.Windows.Markup;

namespace Playnite;

public class PlayTimeToStringConverter : MarkupExtension, IValueConverter
{
    public static PlayTimeToStringConverter Instance { get; } = new PlayTimeToStringConverter();

    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is not ulong seconds)
        {
            return Loc.played_none();
        }

        if (seconds == 0)
        {
            return Loc.played_none();
        }

        // Can't use TimeSpan from seconds because ulong is too large for it
        if (seconds < 60)
        {
            return Loc.played_seconds(seconds);
        }

        var minutes = seconds / 60;
        if (minutes < 60)
        {
            return Loc.played_minutes(minutes);
        }

        var hours = minutes / 60;
        if (parameter is bool formatToDays && formatToDays && hours >= 24)
        {
            var days = hours / 24;
            var remainingHours = hours % 24;
            var remainingMinutes = minutes % 60;

            return  Loc.played_days(days, remainingHours, remainingMinutes);
        }

        return Loc.played_hours(hours, minutes - (hours * 60));
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotSupportedException();
    }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return this;
    }
}
