using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Configuration;

namespace BookswagonAzureTest.Pages
{
    class ShippingAddress
    {
        readonly string Address = ConfigurationManager.AppSettings["address"];
        readonly string ReceipientName = ConfigurationManager.AppSettings["receipientName"];
        readonly string State = ConfigurationManager.AppSettings["state"];
        readonly string City = ConfigurationManager.AppSettings["city"];
        readonly string Pincode = ConfigurationManager.AppSettings["pincode"];
        readonly string MobileNo = ConfigurationManager.AppSettings["mobileNo"];
        
        public IWebDriver driver;
        public ShippingAddress(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewRecipientName")]
        IWebElement receipientName { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewAddress")]
        IWebElement address { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_ddlNewState")]
        IWebElement state { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewCity")]
        IWebElement city { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewPincode")]
        IWebElement pinCode { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewMobile")]
        IWebElement mobileNo { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_imgSaveNew")]
        IWebElement saveAndContinueBtn { get; set; }

        public void ShippingAddressPage()
        {
            receipientName.SendKeys(ReceipientName);
            address.SendKeys(Address);
            state.SendKeys(State);
            city.SendKeys(City);
            pinCode.SendKeys(Pincode);
            mobileNo.SendKeys(MobileNo);
            saveAndContinueBtn.Click();
        }
    }
}
