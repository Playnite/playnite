using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;

namespace Playnite;

public class DockToStringConverter : MarkupExtension, IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        return value switch
        {
            Dock.Left => Loc.dock_left(),
            Dock.Right => Loc.dock_right(),
            Dock.Top => Loc.dock_top(),
            Dock.Bottom => Loc.dock_bottom(),
            _ => new NotSupportedException(),
        };
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        return new NotSupportedException();
    }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return this;
    }
}
