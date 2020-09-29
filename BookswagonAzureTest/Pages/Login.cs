using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace BookswagonAzureTest.Pages
{

    class Login
    {
        public IWebDriver driver;
        public Login(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);   
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Login')]")]
        IWebElement loginBtn{ get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='ctl00$phBody$SignIn$txtEmail']")]
        IWebElement email { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='ctl00$phBody$SignIn$txtPassword']")]
        IWebElement password { get; set; }

        public void LoginPage()
        {
            loginBtn.Click();
            Thread.Sleep(4000);
            email.SendKeys("pratikshatamadalge");
            password.SendKeys("9890046630");
        }
    }
}
