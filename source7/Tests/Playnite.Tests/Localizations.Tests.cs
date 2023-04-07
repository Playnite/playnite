namespace Playnite.Tests;

[TestFixture]
public class LocalizationsTests
{
    [Test]
    public void LocalizationTest()
    {
        Assert.AreEqual("Filter Active", Loc.filter_active_label());
        Assert.AreEqual("10h 5m", Loc.played_hours(10.ToFluentNumber(), 5.ToFluentNumber()));
        Assert.AreEqual("aaah bbbm", Loc.played_hours("aaa".ToFluentString(), "bbb".ToFluentString()));
        Assert.AreEqual("aaah 5m", Loc.played_hours("aaa".ToFluentString(), 5.ToFluentNumber()));
    }
}
    