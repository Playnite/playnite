﻿using Playnite.SDK.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;

namespace Playnite.Converters
{
    public class NullableDateToStringConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
            {
                return string.Empty;
            }

            var date = ((DateTime?)value).Value;
            return date.ToString(Common.Constants.DateUiFormat);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (string.IsNullOrEmpty(value as string))
            {
                return null;
            }

            var sucess = DateTime.TryParseExact(value as string, Common.Constants.DateUiFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out var newDate);
            if (sucess)
            {
                return newDate;
            }
            else
            {
                return DependencyProperty.UnsetValue;
            }
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }

    public class ReleaseDateToStringConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is ReleaseDate date)
            {
                return date.Serialize();
            }
            else if (value == null)
            {
                return null;
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
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

    public class ReleaseDateFieldValidation : ValidationRule
    {
        private const string InvalidInput = "Release date must be in year-month-day format!";

        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (!string.IsNullOrEmpty((string)value))
            {
                if (!ReleaseDate.TryDeserialize((string)value, out var _))
                {
                    return new ValidationResult(false, InvalidInput);
                }
            }

            return new ValidationResult(true, null);
        }
    }
}
