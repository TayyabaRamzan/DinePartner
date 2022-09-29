using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace DinePartner
{
    public class FindYourTable:CommonMethods
    {
        By search = By.XPath("//div//a//i[@class='fa fa-search']");
        By table = By.XPath("//div//button[@class='btn btn-full btnnfindtable']");
        By restaurantSearch = By.Id("searchText");

        public FindYourTable(IWebDriver driver)
        {
            this.driver = driver;
        }
        void clicksearch()
        {
            click(search);
        }

        void inputrestaurant(string Rinput)
        {
            typetext(restaurantSearch, Rinput);
        }
        void clickFindtablebutton()
        {
            click(table);
        }
        void clickrestaurantsearchfield()
        {
            click(restaurantSearch);
        }
        public void searchbutton()
        {
            OpenURL();
            clicksearch();
            
            Thread.Sleep(6000);
        }
        public void Findtable(string restaurant)
        {
            OpenURL();
            clickrestaurantsearchfield();
            inputrestaurant(restaurant);        
            clickFindtablebutton();
            Thread.Sleep(6000);
        }

    }
    
}
