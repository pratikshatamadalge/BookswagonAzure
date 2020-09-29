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

        [FindsBy(How = How.LinkText, Using = "Login")]
        IWebElement loginBtn{ get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='ctl00$phBody$SignIn$txtEmail']")]
        IWebElement email { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='ctl00$phBody$SignIn$txtPassword']")]
        IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='ctl00$phBody$SignIn$btnLogin']")]
        IWebElement login { get; set; }

        public void LoginPage()
        {
            loginBtn.Click();
            Thread.Sleep(6000);
            email.SendKeys("pratikshatamadalge@gmail.com");
            password.SendKeys("9890046630");
            login.Click();
        }
    }
}
