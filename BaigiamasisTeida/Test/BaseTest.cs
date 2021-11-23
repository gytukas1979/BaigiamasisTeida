using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using BaigiamasisTeida.Drivers;
using BaigiamasisTeida.Page;
using BaigiamasisTeida.Tools;

namespace BaigiamasisTeida.Test
{
    public class BaseTest
    {
        public static IWebDriver driver;
        public static TeidaPagrindinisPage1 _teidaPagrindinisPage1;
        public static TeidaPrisijungtiPage2 _teidaPrisijungtiPage2;
        public static TeidaManoPaskyraPage3 _teidaManoPaskyraPage3;
        public static TeidaSveikatinimuiPage4 _teidaSveikatinimuiPage4;
        public static TeidaKojuMasazuokliaiPage5 _teidaKojuMasazuokliaiPage5;
        public static TeidaVisosPrekesPage5_1 _teidaVisosPrekesPage5_1;
        public static TeidaKamuoliukas10Page6 _teidaKamuoliukas10Page6;
        public static TeidaKamuoliukas8Page7 _teidaKamuoliukas8Page7;
        public static TeidaKrepselisPage8 _teidaKrepselisPage8;

        public static KamuolysPage100 _kamuolysPage100;
        public static Krepselis101 _krepselis101;
        public static KrepselisPage _krepselisPage; //NAUJAS


        // public static AlertPage _alertPage;



        [OneTimeSetUp]
        public static void SetUp()
        {
            driver = CustomDriver.GetChromeDriver();
            //driver = CustomDriver.GetIncognitoChrome();

            _teidaPagrindinisPage1 = new TeidaPagrindinisPage1(driver);
            _teidaPrisijungtiPage2 = new TeidaPrisijungtiPage2(driver);
            _teidaManoPaskyraPage3 = new TeidaManoPaskyraPage3(driver);
            _teidaSveikatinimuiPage4 = new TeidaSveikatinimuiPage4(driver);
            _teidaKojuMasazuokliaiPage5 = new TeidaKojuMasazuokliaiPage5(driver);
            _teidaVisosPrekesPage5_1 = new TeidaVisosPrekesPage5_1(driver);
            _teidaKamuoliukas10Page6 = new TeidaKamuoliukas10Page6(driver);
            _teidaKamuoliukas8Page7 = new TeidaKamuoliukas8Page7(driver);
            _teidaKrepselisPage8 = new TeidaKrepselisPage8(driver);

            _kamuolysPage100 = new KamuolysPage100(driver);
            _krepselis101 = new Krepselis101(driver);
            _krepselisPage = new KrepselisPage(driver); //NAUJAS

            //_alertPage = new AlertPage(driver);
        }

        [TearDown]

        public static void TakeScreenshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                MyScreenshot.MakeScreenshot(driver);
        }

        [OneTimeTearDown]

        public static void TearDown()
        {
            //driver.Quit();
        }
    }
}