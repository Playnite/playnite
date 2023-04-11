using System.Windows.Data;
using System.Windows.Markup;

namespace Playnite;

public class BoolToYesNoConverter : MarkupExtension, IValueConverter
{
    private readonly string yesString;
    private readonly string noString;

    public BoolToYesNoConverter()
    {
        yesString = Loc.yes_label();
        noString = Loc.no_label();
    }

    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is bool boolVal)
        {
            return boolVal ? yesString : noString;
        }

        return noString;
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
