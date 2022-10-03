using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace DinePartner
{
    public class Restaurateur:CommonMethods
    {
        By restaurateur = By.XPath("//div//a[@class='btn-sm  btn-signup']");
        By NewReataurant = By.LinkText("Add new Restaurant");
        By firstname = By.Name("first_name");
        By lastname = By.Name("last_name");

        public Restaurateur(IWebDriver driver)
        {
            this.driver = driver;
        }

        void clickrestaurateur()
        {
            click(restaurateur);
        }
        void AddNewRestaurant()
        {
            click(NewReataurant);
        }
        public void restaurateurSignup()
        {
            OpenURL();
            clickrestaurateur();
            MovetoNewTab();
            AddNewRestaurant();

        }


    }
}
