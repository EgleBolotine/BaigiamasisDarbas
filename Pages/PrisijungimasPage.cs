using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace BaigiamasisDarbas.Pages
{
    public class PrisijungimasPage : PageBase
    {
        private IWebElement _prisijungimoIDIvedimoField => _driver.FindElement(By.CssSelector(".js-v-user-name"));
        private IWebElement _passwordIvedimoField => _driver.FindElement(By.Name("userPassword"));
        private IWebElement _prisimintiTickBox => _driver.FindElement(By.XPath("//div[@id='login-global']/div/section/div/div/form/div[2]/div[2]/span/label/span"));
        private IWebElement _prisijungimoMygtukas => _driver.FindElement(By.CssSelector(".btn-primary"));
        private IWebElement _manoTeliaAntraste => _driver.FindElement(By.CssSelector(".section-header__title"));

        private IWebElement _nustatymaiTabas => _driver.FindElement(By.CssSelector(".navigation-bar__item:nth-child(6) > a"));


        public PrisijungimasPage(IWebDriver webdriver) : base(webdriver) { }

        public PrisijungimasPage OpenPrisijungimasPage()
        {
            _driver.Url = "https://www.telia.lt/mano/sso";
            return this;
        }

        public PrisijungimasPage EnterCredentials(string myPrisijungimoID, string myPrisijungimoPassword)
        {
            _prisijungimoIDIvedimoField.Clear();
            _prisijungimoIDIvedimoField.SendKeys(myPrisijungimoID);
            _passwordIvedimoField.Clear();
            _passwordIvedimoField.SendKeys(myPrisijungimoPassword);
            return this;
        }

        public PrisijungimasPage PrisimintiManeTick()
        {
            if (_prisimintiTickBox.Selected != true)
                _prisimintiTickBox.Click();
            return this;
        }

        public PrisijungimasPage ClickPrisijungtiButton()
        {
            _prisijungimoMygtukas.Click();
            return this;
        }

        public PrisijungimasPage PatikrintiArPrisijungiauWithWait(string expectedManoTelia)
        {
            GetWait().Until(ExpectedConditions.TextToBePresentInElement(_manoTeliaAntraste, expectedManoTelia));
            Assert.True(_manoTeliaAntraste.Text.Contains(expectedManoTelia));
            return this;
        }

        public PrisijungimasPage AddCookieConsent()
        {
            Cookie myCookie = new Cookie(
                "COOKIE-CONSENT",
                "3",
                ".telia.lt",
                "/",
                DateTime.Now.AddYears(1));

            _driver.Manage().Cookies.AddCookie(myCookie);
            _driver.Navigate().Refresh();
            return this;
        }

        public NustatymaiPage ClickNustatymaiTab()
        {
            _nustatymaiTabas.Click();
            return new NustatymaiPage(_driver);
        }
    }
}
