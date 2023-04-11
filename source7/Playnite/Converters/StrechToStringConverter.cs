using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace Playnite;

public class StrechToStringConverter : MarkupExtension, IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        return value switch
        {
            Stretch.None => Loc.stretch_none(),
            Stretch.Fill => Loc.stretch_fill(),
            Stretch.Uniform => Loc.stretch_uniform(),
            Stretch.UniformToFill => Loc.stretch_uniform_to_fill(),
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
