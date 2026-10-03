using Allure.Net.Commons;
using Test21.Page;
using Allure.Net.Commons.Attributes;
using Test21.Helpers;

namespace Test21;


public class FileUploadTest : BaseTest
{
    [Test]
    [AllureTag("ДЗ")]
    public void FileUpload()
    {
        LogHelper.Info("Проверка логирования");
        FileUploadPage fileUploadPage = new FileUploadPage(driver);
        AllureApi.Step("Открыть страницу", () =>
        {
            fileUploadPage.OpenDemoqaFile();
        });
        
        //fileUploadPage.OpenDemoqaFile();
        Thread.Sleep(5000);
        AllureApi.Step("Загрузить файл");
        fileUploadPage.FileInput();
        Thread.Sleep(5000);
        AllureApi.Step("Проверить загрузку файла");
        Assert.That(fileUploadPage.FileInputText(), Does.Contain("test.txt"));
    }
}