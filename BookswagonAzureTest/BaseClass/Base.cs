using System;
using System.Net.NetworkInformation;
using System.Threading;
using AventStack.ExtentReports;
using AventStack.ExtentReports.MarkupUtils;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BookswagonAzureTest.ExtentReport;
using BookswagonAzureTest.Utilities;

namespace BookswagonAzureTest.BaseClass
{
    public class Base
    {
        public IWebDriver driver;
       // public const string path = "F:\\VS\\BookswagonAzureTest\\BookswagonAzureTest\\Screenshots";
        public static ExtentReports extent = ReportManager.GetInstance();
        public static ExtentTest test;
        [OneTimeSetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized", "--disable-notifications");
            driver = new ChromeDriver(options);
            driver.Url = "https://www.bookswagon.com/login";
        }

        [TearDown]
        public void Close()
        {
            var filepath = $"{ TestContext.CurrentContext.TestDirectory}\\{TestContext.CurrentContext.Test.MethodName}.jpg";
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(filepath);
            TestContext.AddTestAttachment(filepath, "Test Screenshots");
           /* try
            {
                test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
                if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                {
                    string path = Utility.TakeScreenshot(driver, TestContext.CurrentContext.Test.Name);
                    test.Log(Status.Fail, "Test Failed");
                    test.AddScreenCaptureFromPath(path);
                    test.Fail(MarkupHelper.CreateLabel(TestContext.CurrentContext.Test.Name, ExtentColor.Red));
                }
                else if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
                {
                    test.Log(Status.Pass, "Test Sucessful");
                    test.Pass(MarkupHelper.CreateLabel(TestContext.CurrentContext.Test.Name, ExtentColor.Green));
                }
            }
            catch (Exception e)
            {
                
                Console.Out.WriteLine(e.StackTrace);
                Console.Out.WriteLine(e.Message);
            }

            Thread.Sleep(5000);
            extent.Flush();*/
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
