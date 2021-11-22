using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisTeida.Page
{
    public class TeidaKamuoliukas8Page7 : BasePage
    {
        public const string PageAddressKamuoliukas8 = "https://www.teida.lt/Sveikatinimui/Koju-sveikatai/Koju-ir-pedu-masazuokliai/REFLEXBALL-8-cm-skersmens-dygliuotas-masazo-kamuoliukas.html?force_sid=6pvi0j3e6vi5v49nqnovqk4er1";
        private IWebElement ButtonIKrepseli2 => Driver.FindElement(By.Id("toBasket"));
        public TeidaKamuoliukas8Page7(IWebDriver webdriver) : base(webdriver)
        { }

        public TeidaKamuoliukas8Page7 NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddressKamuoliukas8)
                Driver.Url = PageAddressKamuoliukas8;
            return this;
        }

        public TeidaKamuoliukas8Page7 ClickButtonIKrepseli2()
        {
            ButtonIKrepseli2.Click();
            return this;
        }
 
    }
}

