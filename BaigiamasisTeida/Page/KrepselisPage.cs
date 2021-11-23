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
    public class KrepselisPage :BasePage
    {
        private const string PageAddress = "https://www.teida.lt/Krepselis/";
        private IWebElement ProductText => Driver.FindElement(By.ClassName("spanProdCode"));

        public KrepselisPage(IWebDriver webdriver) : base(webdriver)   //konstruktorius
        { }

        public KrepselisPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }

        public KrepselisPage CheckIfRightProduct(string productCode)
        {
            Assert.IsTrue(ProductText.Text.Contains(productCode), "Product code is not right");
            return this;
        }
    }
}
