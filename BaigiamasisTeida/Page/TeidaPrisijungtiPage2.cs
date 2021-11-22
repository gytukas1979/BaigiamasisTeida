using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisTeida.Page
{
    public class TeidaPrisijungtiPage2 : BasePage
    {
        public const string PageAddressPrisijungti = "https://www.teida.lt/Mano-paskyra/?force_sid=cqjiq7sj4vqlgtae30np814go0";
       
       
        private IWebElement userElPastas => Driver.FindElement(By.Id("loginUser"));
        private IWebElement userSlaptazodis => Driver.FindElement(By.Id("loginPwd"));
        private IWebElement ButtonPrisijungti => Driver.FindElement(By.Id("loginButton"));

        public TeidaPrisijungtiPage2(IWebDriver webdriver) : base(webdriver)
        { }

        public TeidaPrisijungtiPage2 NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddressPrisijungti)
                Driver.Url = PageAddressPrisijungti;
            return this;
        }

        public TeidaPrisijungtiPage2 InsertElPastas(string elPastas)
        {
            userElPastas.Clear();
            userElPastas.SendKeys(elPastas);
            return this;
        }

        public TeidaPrisijungtiPage2 InsertSlaptazodis(string slaptazodis)
        {
            userSlaptazodis.Clear();
            userSlaptazodis.SendKeys(slaptazodis);
            return this;
        }

        public TeidaPrisijungtiPage2 PrisijungtiElPastasAndSlaptazodis(string elPastas, string slaptazodis)
        {
            InsertElPastas(elPastas);
            InsertSlaptazodis(slaptazodis);
           
            return this;
        }

        public TeidaPrisijungtiPage2 ClickButtonPrisijungti()
        {
            ButtonPrisijungti.Click();
            return this;
        }


        
        
    }
        
}

    

