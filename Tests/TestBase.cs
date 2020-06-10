using BaigiamasisDarbas.Drivers;
using BaigiamasisDarbas.Pages;
using BaigiamasisDarbas.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace BaigiamasisDarbas.Tests
{
    public class TestBase
    {
        public static IWebDriver _driver;
        public static PrisijungimasPage _prisijungimas;
        public static NustatymaiPage _nustatymai;
        //public static DazniausiKlausimaiPage _dazniausiKlausimai;

        [OneTimeSetUp]
        public static void SetUpChrome()
        {
            _driver = CustomDrivers.GetChromeDriver();
            _prisijungimas = new PrisijungimasPage(_driver);
            _nustatymai = new NustatymaiPage(_driver);
            //_dazniausiKlausimai = new DazniausiKlausimaiPage(_driver);
        }

        //[TearDown]
        //public static void SingleTestTearDown()
        //{
        //    if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
        //    {
        //        MyScreenshot.MakePhoto(_driver);
        //    }
        //}

        //[OneTimeTearDown]
        //public void CloseBrowser()
        //{
        //    _driver.Quit();
        //}
    }
}
