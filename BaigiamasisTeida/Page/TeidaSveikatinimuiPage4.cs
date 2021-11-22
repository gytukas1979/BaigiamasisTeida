using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisTeida.Page
{
    public class TeidaSveikatinimuiPage4 :BasePage
    {
        public const string PageAddressSveikatinimui = "https://www.teida.lt/Sveikatinimui/?force_sid=6pvi0j3e6vi5v49nqnovqk4er1";
        private IWebElement ButtonKojuSveikata => Driver.FindElement(By.Id("moreSubCat_4"));

        public TeidaSveikatinimuiPage4(IWebDriver webdriver) : base(webdriver)
        { }

        public TeidaSveikatinimuiPage4 NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddressSveikatinimui)
                Driver.Url = PageAddressSveikatinimui;
            return this;
        }

        public TeidaSveikatinimuiPage4 ClickButtonKojuSveikata()
        {
            ButtonKojuSveikata.Click();
            return this;
        }
    }

}
