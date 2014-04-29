using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Configuration;

namespace CoreModel.Elements
{
    public class Link : Element
    {
        public Link(IWebDriver driver, string xPath, string linkID) : base(driver, xPath, linkID) { }

        public virtual void Click()
        {
            _element.Click();
        }
    }
}
