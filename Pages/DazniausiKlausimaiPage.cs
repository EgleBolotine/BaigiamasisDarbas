//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium;

//namespace BaigiamasisDarbas.Pages
//{
//    public class DazniausiKlausimaiPage : PageBase
//    {
//        private IWebElement _laukelisTekstui => _driver.FindElement(By.XPath("input[@value='']"));

//        private IWebElement _daugiauPicasaInfo => _driver.FindElement(By.CssSelector(".link-block__link-title"));

//        private IWebElement _naudingaInfoTaip => _driver.FindElement(By.CssSelector("*[data-test='action--button']"));


//        public DazniausiKlausimaiPage(IWebDriver webdriver) : base(webdriver) { }


//        public DazniausiKlausimaiPage ClickTekstoLaukeli()
//        {
//            _laukelisTekstui.Click();
//            return this;
//        }

//        public DazniausiKlausimaiPage EnterKoIeskau(string manoPaieskosTekstas)
//        {
//            _laukelisTekstui.Clear();
//            _laukelisTekstui.SendKeys(manoPaieskosTekstas);
//            return this;
//        }

//        public DazniausiKlausimaiPage ReadPicasaMoreInfo()
//        {
//            _daugiauPicasaInfo.Click();
//            return this;
//        }

//        public DazniausiKlausimaiPage ClickIssprestaProblema()
//        {
//            _naudingaInfoTaip.Click();
//            return this;
//        }

//        //toliau i kita puslapi..

//    }
//}
