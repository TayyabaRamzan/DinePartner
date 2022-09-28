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
            driver.Close();
        }

        public void OpenURL()
        {
            driver.Navigate().GoToUrl("https://dinepartner.com/guest/login");
            driver.Manage().Window.Maximize();

        }
        public void wait()
        {
            driver.Manage().Timeouts().ImplicitWait =TimeSpan.FromSeconds(2500);
        }

    }
}