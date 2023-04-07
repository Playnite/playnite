namespace Playnite.Tests;

public enum TestEnum
{
    [System.ComponentModel.Description(Loc.dock_left_id)]
    Test1,
    Test2
}

[TestFixture]
public class EnumsTests
{
    [Test]
    public void GetDescriptionTest()
    {
        Assert.AreEqual("Left", TestEnum.Test1.GetDescription());
        Assert.AreEqual("Test2", TestEnum.Test2.GetDescription());
    }
}
