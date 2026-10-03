using OpenQA.Selenium.Chrome;
using Test21.Page;
using Allure.Net.Commons.Attributes;

namespace Test21;

public class AlertTest : BaseTest
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    [AllureTag("ДЗ")]
    public void AlertTest1()
    {
        var alertPage = new AlertPage(driver);
        alertPage.ClickAletr();
        Assert.That(alertPage.GetAlertText(), Is.EqualTo( "I am a JS Alert"));
        alertPage.AcceptAlert();
        Assert.That(alertPage.GetResult(), Is.EqualTo("You successfully clicked an alert"));
    }
    
    [Test]
    public void AlertTest2()
    {
        var alertPage = new AlertPage(driver);
        alertPage.ClickConfirm();
        Assert.That(alertPage.GetAlertText(), Is.EqualTo( "I am a JS Confirm"));
        alertPage.AcceptAlert();
        Assert.That(alertPage.GetResult(), Is.EqualTo("You clicked: Ok"));

        alertPage.ClickConfirm();
        Assert.That(alertPage.GetAlertText(), Is.EqualTo( "I am a JS Confirm"));
        alertPage.DismissAlert();
        Assert.That(alertPage.GetResult(), Is.EqualTo("You clicked: Cancel"));
    }
    
    [Test]
    public void AlertTest3()
    {
        string expectedValue = "test";
        var alertPage = new AlertPage(driver);
        alertPage.ClickPrompt();
        
        Assert.That(alertPage.GetAlertText(), Is.EqualTo( "I am a JS prompt"));
        alertPage.SendValuePrompt(expectedValue);
        alertPage.AcceptAlert();
        Assert.That(alertPage.GetResult(), Is.EqualTo($"You entered: {expectedValue}"));
    }
    public void FramesTest()
    {
        
    }
}