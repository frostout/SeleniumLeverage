using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CoreModel.Pages
{
    public abstract class Page
    {
        protected IWebDriver _driver;
        protected string url;
        protected string pageTitle;
        protected WebDriverWait wait;

        public Page(IWebDriver driver, int waitTimeOut)
        {
            _driver = driver;
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTimeOut));
        }

        public virtual void Load()
        {
            _driver.Navigate().GoToUrl(url);
            wait.Until(x => x.Title == pageTitle);
        }

        public virtual bool IsLoaded()
        {
            return (_driver.Title == pageTitle);
        }
    }
}
