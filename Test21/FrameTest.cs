using OpenQA.Selenium.Chrome;
using Test21.Page;


namespace Test21;

[TestFixture]
public class FrameTest : BaseTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Frame()
    {
        
        var framesPage = new FramesPage(driver);
        framesPage.OpenFrames();
        var text = framesPage.SwitchToLeftFrame();
        var textParentFrame = framesPage.SwitchToParentFrame();
    }
}