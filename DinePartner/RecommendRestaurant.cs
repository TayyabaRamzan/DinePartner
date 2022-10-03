using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace DinePartner
{
    public class RecommendRestaurant: CommonMethods
    {

        By recommend = By.LinkText("Recommend");
        By table = By.XPath("//div//button[@class='btn btn-full btnnfindtable']");
        By Name = By.Id("your_name");
        By email = By.Id("your_email");
        By rest_name = By.Id("restaurant_name");
        By Send = By.Name("recommend_mail");
        //By Send = By.XPath("//input[@name='recommend_mail' and @value ='Send']");
        public RecommendRestaurant(IWebDriver driver)
        {
            this.driver = driver;
        }
        void clickRecommend()
        {
            click(recommend);
        }
        void clickFindtablebutton()
        {
            click(table);
        }
      
        void inputYourName(string Finput)
        {
            typetext(Name, Finput);
        }
        void inputEmail(string Einput)
        {
            typetext(email, Einput);
        }
        void inputRestaurant(string Rinput)
        {
            typetext(rest_name, Rinput);
        }
        void clickSend()
        {
            click(Send);
        }

        public void Recommendbutton()
        {
            OpenURL();
            clickFindtablebutton();
            clickRecommend();
            Thread.Sleep(6000);
        }
        public void emailismandatory(string name,string Email, string Restaurant)
        {
            OpenURL();
            clickFindtablebutton();
            clickRecommend();
            MovetoNewTab();
            inputYourName(name);
            inputEmail(Email);
            inputRestaurant(Restaurant);
            clickSend();
            Thread.Sleep(6000);
        }
        public void sendbuttonclick()
        {
            OpenURL();
            clickFindtablebutton();
            clickRecommend();
            MovetoNewTab();
            clickSend();
            Thread.Sleep(6000);
        }
    }
}
