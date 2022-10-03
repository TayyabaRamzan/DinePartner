using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace DinePartner
{
    public class Filters : CommonMethods
    {
        By islamabad = By.XPath("//div//div//label//input[@type='radio']");
        By Apply = By.XPath("//li//div//div//a[@class='btn btn-primary smooth_scroll MainSearch mobserach']");
        By table = By.XPath("//div//button[@class='btn btn-full btnnfindtable']");
        public Filters(IWebDriver driver)
        {
            this.driver = driver;
        }

        void selectIslamabad()
        {
            click(islamabad);
        }

        void clickApplybutton()
        {
            click(Apply);
        }
        
        public void ApplyFilter()
        {
            OpenURL();
            click(table);
            selectIslamabad();
            clickApplybutton();
            Thread.Sleep(6000);
        }

        public void applyfilters()
        {
            OpenURL();
            click(table);

        }






    }
}
