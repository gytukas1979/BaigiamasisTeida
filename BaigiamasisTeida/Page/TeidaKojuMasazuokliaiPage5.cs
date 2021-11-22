using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisTeida.Page
{
    public class TeidaKojuMasazuokliaiPage5 : BasePage
    {
        public const string PageAddressKojuMasazuokliai = "https://www.teida.lt/Sveikatinimui/Koju-sveikatai/?force_sid=n8rnoj0ruc7mmeaf5mkqtok123";

        private IWebElement ButtonKojuMasazuokliai => Driver.FindElement(By.Id("moreSubCat_1"));
        public TeidaKojuMasazuokliaiPage5(IWebDriver webdriver) : base(webdriver)
        { }

        public TeidaKojuMasazuokliaiPage5 NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddressKojuMasazuokliai)
                Driver.Url = PageAddressKojuMasazuokliai;
            return this;
        }

        public TeidaKojuMasazuokliaiPage5 ClickButtonKojuMasazuokliai()
        {
            ButtonKojuMasazuokliai.Click();
            return this;
        }

    }
}
