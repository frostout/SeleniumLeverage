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
    public class Element
    {
        protected IWebDriver _driver;        
        protected readonly string _xPath;

        protected readonly IWebElement _element;

        public string Text 
        {
            get { return _element.Text; }
        }

        public Element(IWebDriver driver, string xPath, string elementID)
        {
            _driver = driver;
            _xPath = xPath;

            try
            {
                _element = _driver.FindElement(By.XPath(_xPath));
            }
            catch (NoSuchElementException ex)
            {
                throw new NoSuchElementException(elementID, ex);
            }
        }


        public System.Drawing.Point Location
        {
            get 
            {
                return _element.Location;
            }
        }
    }
}
