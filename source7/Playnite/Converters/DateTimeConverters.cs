using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;

namespace Playnite;

public class DateTimeToLastPlayedConverter : MarkupExtension, IValueConverter
{
    public static readonly DateTimeToLastPlayedConverter Instance = new DateTimeToLastPlayedConverter();

    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is not DateTime lastPlayed)
        {
            return Loc.never();
        }

        if (parameter is DateFormattingOptions options)
        {
            return lastPlayed.ToDisplayString(options);
        }

        return lastPlayed.ToString(DateTimes.DateUiFormat);
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

public class NullableDateToStringConverter : MarkupExtension, IValueConverter
{
    public static readonly NullableDateToStringConverter Instance = new NullableDateToStringConverter();

    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is DateTime date)
        {
            if (parameter is DateFormattingOptions options)
            {
                return date.ToDisplayString(options);
            }

            return date.ToString(DateTimes.DateUiFormat);
        }

        return string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is string strValue && DateTime.TryParseExact(strValue, DateTimes.DateUiFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out var newDate))
        {
            return newDate;
        }

        return DependencyProperty.UnsetValue;
    }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return this;
    }
}

public class ReleaseDateToStringConverter : MarkupExtension, IValueConverter
{
    public static readonly ReleaseDateToStringConverter Instance = new ReleaseDateToStringConverter();

    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is ReleaseDate date)
        {
            if (parameter is ReleaseDateFormattingOptions options)
            {
                return date.ToDisplayString(options);
            }
            else if (date.Month != null && date.Day != null)
            {
                return date.Date.ToString(DateTimes.DateUiFormat);
            }
            else
            {
                return date.Serialize();
            }
        }

        return string.Empty;
    }

    public object? ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        var str = value as string;
        if (str.IsNullOrEmpty())
        {
            return null;
        }

        return ReleaseDate.Deserialize(str);
    }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return this;
    }
}

public class EditingReleaseDateToStringConverter : MarkupExtension, IValueConverter
{
    public object? Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is ReleaseDate date)
        {
            return date.Serialize();
        }

        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is string str)
        {
            return ReleaseDate.Deserialize(str);
        }

        throw new NotSupportedException();
    }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return this;
    }
}

public class ReleaseDateFieldValidation : ValidationRule
{
    private const string InvalidInput = "Release date must be in year-month-day format!";

    public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
    {
        if (value is string str && !str.IsNullOrWhiteSpace())
        {
            if (ReleaseDate.TryDeserialize(str, out var _))
            {
                return new ValidationResult(true, null);
            }
        }

        return new ValidationResult(false, InvalidInput);
    }
}

public class DateTimeFormatToStringValidation : ValidationRule
{
    private const string InvalidFormatInput = "Format does not contain a valid custom format pattern!";
    private const string InvalidArgumentRangeInput = "The date and time is outside the range of dates supported!";
    private static DateTime TestDate = DateTime.Now;

    public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
    {
        if (value is string str && !str.IsNullOrWhiteSpace())
        {
            try
            {
                TestDate.ToString(str);
                return new ValidationResult(true, null);
            }
            catch (FormatException)
            {
                return new ValidationResult(false, InvalidFormatInput);
            }
            catch (ArgumentOutOfRangeException)
            {
                return new ValidationResult(false, InvalidArgumentRangeInput);
            }
        }
        else
        {
            return new ValidationResult(false, InvalidFormatInput);
        }
    }
}
