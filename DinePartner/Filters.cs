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
        By FiveStar = By.XPath("//div//label//input[@name='ratings' and @value='5']");
        By scrlelement = By.XPath("//*[@id='myNav']/ul/aside/form/ul/li[16]/div[1]/label/input");
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
            click(FiveStar);
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
            //scroll(scrlelement);
            click5Star();
            clickApplybutton();
            Thread.Sleep(6000);
        }




    }
}
