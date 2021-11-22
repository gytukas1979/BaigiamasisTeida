using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisTeida.Page
{
    public class TeidaKamuoliukas10Page6 : BasePage
    {
        public const string PageAddressKamuoliukas10 = "https://www.teida.lt/Sveikatinimui/Koju-sveikatai/Koju-ir-pedu-masazuokliai/Masazo-kamuoliukas-Sensyball-10.html?force_sid=6pvi0j3e6vi5v49nqnovqk4er1";
        private IWebElement ButtonIKrepseli1 => Driver.FindElement(By.Id("toBasket"));

        private IWebElement KrepselisResult => Driver.FindElement(By.Id("krepselisNum"));

        private IWebElement Krepselis => Driver.FindElement(By.Id("#headerKrepselis > a > button"));
        public TeidaKamuoliukas10Page6(IWebDriver webdriver) : base(webdriver)
        { }
        public TeidaKamuoliukas10Page6 NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddressKamuoliukas10)
                Driver.Url = PageAddressKamuoliukas10;
            return this;
        }

        public TeidaKamuoliukas10Page6 ClickButtonIKrepseli1()
        {
            ButtonIKrepseli1.Click();
            return this;
        }
        //KAZKO NERANDA
        public TeidaKamuoliukas10Page6 CheckKrepselisResult()
        {
            Assert.AreEqual(KrepselisResult, KrepselisResult.Text, "4.60€");
            return this;
        }

        public TeidaKamuoliukas10Page6 ClickKrepselis()
        {
           Krepselis.Click();
            return this;
        }



    }
}
