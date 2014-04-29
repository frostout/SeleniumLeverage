using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLeverage.Elements
{
    class TextBox : Element
    {
        public TextBox(IWebDriver driver, string xPath, string linkID) : base(driver, xPath, linkID) { }

        public void SendKeys(string keysToSend)
        {
            _element.SendKeys(keysToSend);
        }
    }
}
