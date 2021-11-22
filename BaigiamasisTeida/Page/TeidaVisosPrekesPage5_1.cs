using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisTeida.Page
{
   public class TeidaVisosPrekesPage5_1 : BasePage
    {
        public const string PageAddressPrekes = "https://www.teida.lt/Sveikatinimui/Koju-sveikatai/Koju-ir-pedu-masazuokliai/?force_sid=n8rnoj0ruc7mmeaf5mkqtok123";
        private IWebElement Kamuoliukas10 => Driver.FindElement(By.CssSelector("#prodList > ul:nth-child(3) > li:nth-child(1) > a > span.prodPav"));
        private IWebElement Kamuoliukas8 => Driver.FindElement(By.CssSelector("#prodList > ul:nth-child(1) > li:nth-child(3) > a > span.prodPav"));



        public TeidaVisosPrekesPage5_1(IWebDriver webdriver) : base(webdriver)
        { }

        public TeidaVisosPrekesPage5_1 NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddressPrekes)
                Driver.Url = PageAddressPrekes;
            return this;
        }

        public TeidaVisosPrekesPage5_1 ClickKamuoliukas10()
        {
            Kamuoliukas10.Click();
           
            return this;
        }


        public TeidaVisosPrekesPage5_1 ClickKamuoliukas8()
        {
            Kamuoliukas8.Click();
           return this;
        }
       
       
    }
}
