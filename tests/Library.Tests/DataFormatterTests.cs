using TestDateFormat;
namespace Library.Tests;

public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FechaOk()
    {
        string testDate = "10/11/1997";
        Assert.AreEqual(DateFormatter.ChangeFormat(testDate), "1997-11-10");
    }

    [Test]
    public void FechaNotOK()
    {
        string testDate = "19-11-17";
        Assert.AreEqual(DateFormatter.ChangeFormat(testDate), "Formato Incorrecto");
    }

    [Test]
    public void FechaEnBlanco()
    {
        string testDate = "";
        Assert.AreEqual(DateFormatter.ChangeFormat(testDate), "Formato Incorrecto");
    }
}