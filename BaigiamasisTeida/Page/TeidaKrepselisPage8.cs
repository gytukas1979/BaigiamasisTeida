using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisTeida.Page
{
     public class TeidaKrepselisPage8 : BasePage
    {
        public const string PageAddressKrepselis = "https://www.teida.lt/Krepselis/?force_sid=6pvi0j3e6vi5v49nqnovqk4er1";
       private IWebElement ButtonIstrynti => Driver.FindElement(By.Id("basketRemove"));
       private IWebElement kamuoliukas10 =>Driver.FindElement(By.CssSelector("#basketcontents > table > tbody > tr:nth-child(2) > td:nth-child(2) > span"));
        private IWebElement kamuoliukas8 => Driver.FindElement(By.CssSelector("#basketcontents > table > tbody > tr:nth-child(4) > td:nth-child(2) > span"));

        private IWebElement Sumazinti1 => Driver.FindElement(By.Id("qtyMinus_9decf050242dc18ca6f107d714d3d44c"));
        private IWebElement Sumazinti2 => Driver.FindElement(By.Id("qtyMinus_7f21cb34da39d803e0ca190f151d07a6"));


        public TeidaKrepselisPage8(IWebDriver webdriver) : base(webdriver)
        { }

        public TeidaKrepselisPage8 NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddressKrepselis)
                Driver.Url = PageAddressKrepselis;
            return this;
        }

        // public TeidaKrepselisPage8 Click

        /* public TeidaKrepselisPage8 ClickButtonIstrynti()
         {
             ButtonIstrynti.Click();
             return this;
         }*/

         public TeidaKrepselisPage8 CheckKamuoliukas10()
         {
           
             kamuoliukas10.Click();
             
             return this;

         }
        
         public TeidaKrepselisPage8 ClickKamuoliukas8()
         {
             kamuoliukas8.Click();

             return this;
         }

        public TeidaKrepselisPage8 ClickButtonIstrynti()
        {   //kamuoliukas10.Click()
            //Sumazinti1.Click();
           // kamuoliukas10.Click();
            ButtonIstrynti.Click();
            return this;
        }
     /*   public TeidaKrepselisPage8 ClickButtonIstrynti()
        {
            // kamuoliukas8.Click();
            ButtonIstrynti.Click();
           // Sumazinti2.Click();
            return this;
        }*/


    }

}
