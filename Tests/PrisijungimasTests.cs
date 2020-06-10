using System.Reflection;
using NUnit.Framework;

namespace BaigiamasisDarbas.Tests
{
    public class PrisijungimasTests : TestBase
    {
        [Test]
        public static void PrisijungimoTestas()
        {
            _prisijungimas
                .OpenPrisijungimasPage()
                .AddCookieConsent()
                .EnterCredentials("egle.jonaityte@yahoo.com", "egle3793")
                .PrisimintiManeTick()
                .ClickPrisijungtiButton()
                .PatikrintiArPrisijungiauWithWait("MANO TELIA")
                .ClickNustatymaiTab();
        }
    }
}
