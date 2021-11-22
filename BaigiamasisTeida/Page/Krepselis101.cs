using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisTeida.Page
{
    public class Krepselis101 : BasePage

    {
        public const string PageAddressKrepselis22 = "https://www.teida.lt/index.php?force_sid=sdeuqk6tbhekn2j4sd3c8fnmg5&";
       // public Krepselis101 KrepselioRezultText => Driver.FindElement(By.CssSelector("#basketcontents > table > tbody > tr:nth-child(2) > td:nth-child(2) > span > span");
        public Krepselis101(IWebDriver webdriver) : base(webdriver)
        { }

        public Krepselis101 NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddressKrepselis22)
                Driver.Url = PageAddressKrepselis22;
            return this;
        }

       

    }
}
