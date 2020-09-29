using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Configuration;
using System.Threading;

namespace BookswagonAzureTest.Pages
{
    class SearchBook
    {
        readonly string BookName = ConfigurationManager.AppSettings["bookName"];
        public IWebDriver driver;
        public SearchBook(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='search-input']//input")]
        IWebElement searchBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/form/div/div/div[3]/div[2]/div[1]")]
        IWebElement Book { get; set; }

        public void SearchBookPage()
        {
            searchBox.SendKeys(BookName+Keys.Enter);
            Thread.Sleep(2000);
            Book.Click();
        }
    }
}
