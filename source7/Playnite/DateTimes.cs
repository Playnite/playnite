using System.Globalization;

namespace Playnite;

public static class DateTimes
{
    public const string DefaultDateTimeFormat = "d";
    public const string DefaultPartialReleaseDateTimeFormat = "y";

    public static string DateUiFormat { get; } = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
    public static string TimeUiFormat { get; } = CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern;

    public interface IDateTimes
    {
        DateTime Now { get; }
        DateTime Today { get; }
    }

    public class DefaultDateProvider : IDateTimes
    {
        public DateTime Now => DateTime.Now;
        public DateTime Today => DateTime.Today;
    }

    public class TempDateTime : IDisposable
    {
        public TempDateTime(IDateTimes customDates)
        {
            dateProvider = customDates;
        }

        public void Dispose()
        {
            dateProvider = defaultDateProvider;
        }
    }

    private static readonly IDateTimes defaultDateProvider = new DefaultDateProvider();
    private static IDateTimes dateProvider = defaultDateProvider;

    public static DateTime Now => dateProvider.Now;
    public static DateTime Today => dateProvider.Today;

    public static IDisposable UseCustomDates(IDateTimes dates)
    {
        return new TempDateTime(dates);
    }

    public static string ToDisplayString(this DateTime date, DateFormattingOptions? options = null)
    {
        if (options == null)
        {
            return date.ToString(DateUiFormat);
        }

        if (options.PastWeekRelativeFormat)
        {
            var today = Today;
            var dayDiff = (today - date.Date).TotalDays;

            if (dayDiff == 0)
            {
                return Loc.today();
            }

            if (dayDiff == 1)
            {
                return Loc.yesterday();
            }

            if (dayDiff > 1 && dayDiff < 7)
            {
                switch (date.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        return Loc.sunday();
                    case DayOfWeek.Monday:
                        return Loc.monday();
                    case DayOfWeek.Tuesday:
                        return Loc.tuesday();
                    case DayOfWeek.Wednesday:
                        return Loc.wednesday();
                    case DayOfWeek.Thursday:
                        return Loc.thursday();
                    case DayOfWeek.Friday:
                        return Loc.friday();
                    case DayOfWeek.Saturday:
                        return Loc.saturday();
                }
            }
        }

        return date.ToString(options.Format ?? DateUiFormat);
    }

    public static string ToDisplayString(this ReleaseDate date, ReleaseDateFormattingOptions? options = null)
    {
        if (date.Month == null && date.Day == null)
        {
            return date.Year.ToString();
        }

        if (date.Month != null && date.Day == null)
        {
            return date.Date.ToString(options?.PartialFormat ?? DefaultPartialReleaseDateTimeFormat);
        }

        return date.Date.ToDisplayString(options);
    }
}
