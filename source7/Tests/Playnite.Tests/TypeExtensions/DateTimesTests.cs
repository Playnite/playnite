namespace Playnite.Tests;

[TestFixture]
public class DateTimesTests
{
    [Test]
    [SetCulture("en-US")]
    public void FutureDatesAreNotWeekdays()
    {
        var dates = new TestDateTimes(new DateTime(2023, 3, 24));
        var releaseDate = new ReleaseDate(2023, 6, 6);
        using (DateTimes.UseCustomDates(dates))
        {
            var dateString = DateTimes.ToDisplayString(releaseDate, new ReleaseDateFormattingOptions("d", pastWeekRelativeFormat: true));
            Assert.AreEqual("6/6/2023", dateString);
        }
    }
}
