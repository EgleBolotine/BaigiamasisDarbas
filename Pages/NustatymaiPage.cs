using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BaigiamasisDarbas.Pages
{
    public class NustatymaiPage : PageBase
    {
        private IWebElement _irangosNustatymaiTab => _driver.FindElement(By.XPath("/html/body/main/div/div/div/div/section/div/div/div[1]/div/div/ul/li[5]/a"));
        


        public NustatymaiPage(IWebDriver webdriver) : base(webdriver) { }

        
        public NustatymaiPage ClickNustatymaiTab()
        {
            Thread.Sleep(5);
            _irangosNustatymaiTab.Click();
            return this;
        }

        //public NustatymaiPage AssertMoketojoKoda(string expectedKodas)
        //{
        //    Assert.True(_moketojoKodas.Text.Contains(expectedKodas));
        //    return this;
        //}
    }
}
