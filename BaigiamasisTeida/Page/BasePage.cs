using OpenQA.Selenium;

namespace BaigiamasisTeida.Page
{
    public class BasePage
    {
        protected static IWebDriver Driver;

        public BasePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public void CloseBrowser()
        {
            //Driver.Quit();
        }
    }
}