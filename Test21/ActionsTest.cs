using Test21.Page;
using Allure.Net.Commons.Attributes;

namespace Test21;

public class ActionsTest : BaseTest
{
    [Test]
    [AllureTag("ДЗ")]
    public void ActionTest()
    {
        ActionsPage actionsPage = new ActionsPage(driver);
        actionsPage.OpenDemoqa();
        Thread.Sleep(3000);
        actionsPage.DragAndDrop();
        Thread.Sleep(3000);
        Assert.That(actionsPage.IsDroppedText(), Is.True);
    }
}