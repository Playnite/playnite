namespace Playnite.Tests;

[TestFixture]
public class LocalizationsTests
{
    [Test]
    public void LocalizationTest()
    {
        Assert.AreEqual("Filter Active", Loc.filter_active_label());
        Assert.AreEqual("10h 5m", Loc.played_hours((int)10, (int)5));
        Assert.AreEqual("10h 5m", Loc.played_hours((uint)10, (uint)5));
        Assert.AreEqual("10h 5m", Loc.played_hours((long)10, (long)5));
        Assert.AreEqual("10h 5m", Loc.played_hours((ulong)10, (ulong)5));
        Assert.AreEqual("10h 5m", Loc.played_hours((float)10, (float)5));
        Assert.AreEqual("10h 5m", Loc.played_hours((double)10, (double)5));
        Assert.AreEqual("10h 5m", Loc.played_hours((decimal)10, (decimal)5));
        Assert.AreEqual("10h 5m", Loc.played_hours("10", "5"));
    }
}
    