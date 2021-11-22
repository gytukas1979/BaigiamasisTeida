using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisTeida.Page
{
    public class TeidaPagrindinisPage1: BasePage

    {
        private const string PageAddressPagrindinis = "https://www.teida.lt/";

        //  private IWebElement PopUp => Driver.FindElement(By.CssSelector("body > div.cc-window.cc-banner.cc-type-opt-in.cc-theme-block.cc-bottom.cc-color-override--1214213648 > div > a.cc-btn.cc-allow"));
        // WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        private const string ExpectedLoginResult = "Atsijungti";
        private const string ExpectedLogoutResult = "Prisijungti";

        private IWebElement ButtonPagrindinisPrisijungti => Driver.FindElement(By.Id("prisijungti"));
        private IWebElement InputLaukelis => Driver.FindElement(By.Id("searchParam"));
        private IWebElement InputLaukelis2 => Driver.FindElement(By.Id("searchParam"));
        private IWebElement Paieska => Driver.FindElement(By.Id("search_icon"));
        private IWebElement Paieska2 => Driver.FindElement(By.Id("search_icon"));
        private IWebElement Kamuolys => Driver.FindElement(By.CssSelector("#search_div > table > tbody > tr > td.url > a"));

        public TeidaPagrindinisPage1(IWebDriver webdriver) : base(webdriver)   //konstruktorius
         { }  
        
        public TeidaPagrindinisPage1 NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddressPagrindinis)
                Driver.Url = PageAddressPagrindinis;
            return this;
        }

        /*ARBA TAIP
         public void TeidaPagrindinisPage1 ClickCookiesSutinku()
        {
           Cookies.Click();
            return this;
        }

        /*public TeidaPagrindinisPage1 AcceptCookie()
        {
           Cookie myCookie = new Cookie("Cookiesent", "{"www.teida.lt", "/"
        DateTime
        Driver.Manage().Cookies.AddCookie(myCookie);
        Driver.Navigate().Refresh();
         return this;

        }*/

        public TeidaPagrindinisPage1 ClickButtonPagrindinisPrisijungti()
        {
            ButtonPagrindinisPrisijungti.Click();
            return this;
        }

        public TeidaPagrindinisPage1 InsertInputLaukelis(string preke1)
        {
            InputLaukelis.Clear();
            InputLaukelis.SendKeys(preke1);
            return this;
        }

        public TeidaPagrindinisPage1 ClickPaieska()
        {
            Paieska.Click();
            return this;
        }

        public TeidaPagrindinisPage1 InsertInputLaukelis2(string preke2)
        {
            InputLaukelis2.Clear();
            InputLaukelis2.SendKeys(preke2);
            return this;
        }

        public TeidaPagrindinisPage1 ClickPaieska2()
        {
            Paieska2.Click();
            return this;
        }

        public TeidaPagrindinisPage1 ClickKamuolys()
        {
            Kamuolys.Click();
            return this;
        }

        public TeidaPagrindinisPage1 CheckLoginResult()
        {
            Assert.AreEqual(ExpectedLoginResult, ButtonPagrindinisPrisijungti.Text, "Logout wasn't succesfull");
            return this;
        }

        public TeidaPagrindinisPage1 CheckLogoutResult()
        {
            Assert.AreEqual(ExpectedLogoutResult, ButtonPagrindinisPrisijungti.Text, "Logout wasn't succesfull");
            return this;
        }




    }

}
