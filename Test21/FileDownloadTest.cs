using Allure.Net.Commons.Attributes;
using Test21.Page;

namespace Test21;

public class FileDownloadTest : BaseTest
{
    [Test]
    [AllureTag("ДЗ")]
    [AllureName("Скачивание файла")]
    public void FileDownload()
    {
        FileDownloadPage fileDownloadPage = new FileDownloadPage(driver);
        fileDownloadPage.OpenDemoqaFile2();
        fileDownloadPage.DownloadFile();
        Thread.Sleep(2000);
        string filePath = Path.Combine(@"C:\Users\petys\Downloads", fileDownloadPage.GetFileName());
        Thread.Sleep(2000);
        Assert.That(File.Exists(filePath), Is.True);
    }
}