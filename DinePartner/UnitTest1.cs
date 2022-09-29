using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinePartner
{

    public class CommonMethods
    {
        public IWebDriver driver;
        //Actions actions;

        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        public void closebrowser()
        {
            wait();
            driver.Close();
        }

        public void OpenURL()
        {
            driver.Navigate().GoToUrl("https://dinepartner.com/");
            driver.Manage().Window.Maximize();

        }
        public void wait()
        {
            driver.Manage().Timeouts().ImplicitWait =TimeSpan.FromSeconds(1000);
        }
       
        public IWebElement findElement(By locator)
        {
            return driver.FindElement(locator);
        }
        
        public void click(By locator)
        {
            findElement(locator).Click();
        }
       
        public void typetext(By locator, string text)
        {
            IWebElement element = findElement(locator);
            element.SendKeys(text);
        }

       
    }
}