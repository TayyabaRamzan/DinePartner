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
        By cuisine = By.Name("cuisines[]");
        By BBQ = By.XPath("//li//div//div//label//input[@value='LIve BBQ']");
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
        void clickContinentalcuisine()
        {
            click(cuisine);
        }
        void clickLiveBBQ()
        {
            click(BBQ);
        }
        void click5Star()
        {
            click(BBQ);
        }

        public void ApplyFilters1()
        {
            OpenURL();
            click(table);
            selectIslamabad();
            clickApplybutton();
            Thread.Sleep(6000);
        }

        public void ApplyFilters2()
        {
            OpenURL();
            click(table);
            clickContinentalcuisine();
            clickLiveBBQ();
            clickApplybutton();
            Thread.Sleep(6000);
        }
        public void ApplyFilters3()
        {
            OpenURL();
            click(table);
            selectIslamabad();
            click5Star();
            clickApplybutton();
            Thread.Sleep(6000);
        }




    }
}
