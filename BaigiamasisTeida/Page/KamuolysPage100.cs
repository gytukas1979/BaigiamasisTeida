using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisTeida.Page
{
    public class KamuolysPage100 : BasePage

    {
        public const string PageAddressKamuolys = "https://www.teida.lt/Sveikatinimui/Sissel-Pilates-kamuolys-26-cm-melynas.html?listtype=search&searchparam=310.031";
        private IWebElement Krepselis3 => Driver.FindElement(By.Id("toBasket"));
        private IWebElement PagrindinisKrepselis => Driver.FindElement(By.CssSelector("#headerKrepselis > a > button"));

        public KamuolysPage100(IWebDriver webdriver) : base(webdriver)
        { }

        public KamuolysPage100 NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddressKamuolys)
                Driver.Url = PageAddressKamuolys;
            return this;
        }

        public KamuolysPage100 ClickKrepselis3()
        {
            Krepselis3.Click();
            return this;
        }

        public KamuolysPage100 ClickPagrindinisKrepselis()
        {
            PagrindinisKrepselis.Click();
            return this;
        }


    }
}
