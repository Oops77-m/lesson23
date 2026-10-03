using Allure.Net.Commons;
using Allure.Net.Commons.Attributes;
using Allure.NUnit;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Test21.Page;
using Test21.Helpers;


namespace Test21;

[AllureNUnit]
[AllureSeverity(SeverityLevel.critical)]
public class BaseTest
{
    protected IWebDriver driver = null!;
    //public IWebDriver driver = null!;
    //private ILog logger = LogManager.GetLogger(typeof(BaseTest));
    //public IWebDriver driver;
    [SetUp]
    public void Test1()
    {
        LogHelper.Info("═══════════════════════════════");
        LogHelper.Info("Запуск Chrome");
        
        var options = new ChromeOptions();
        LogHelper.Info("Настройка скачивания файлов");
        options.AddUserProfilePreference("download.default_directory", @"C:\Users\petys\Downloads");
        options.AddUserProfilePreference("download.prompt_for_download", false);
        driver = new ChromeDriver();
        var basePage = new BasePage(driver);
        basePage.OpenAlerts();
        LogHelper.Info("Браузер запущен");
    }

    [TearDown]
    public void TearDown()
    {
        LogHelper.Info("Закрытие браузера");
        driver.Quit();
        driver.Dispose();
        LogHelper.Info("═══════════════════════════════");
    }
    
    
}