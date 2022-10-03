using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace DinePartner

{

    public class signupFunctionality : CommonMethods
    {
        

        By guest = By.LinkText("Guest");
        By firstname = By.ClassName("fname");
        By lastname = By.XPath("//input[@class='fname' and @name='last_name']");
        By phone = By.XPath("//input[@name='phone_num']");
        By email = By.XPath("//input[@class='femail' and @name='email']");
        By city = By.XPath("//select[@id='val-city']");
        By password = By.XPath("//input[@class='fpass' and @name='password']");
        By confirmPassword = By.XPath("//input[@class='fpass' and @name='confirm_password']");
        By agreeCheckbox = By.Id("agree");
        By submit = By.Name("signup_submit");

        public signupFunctionality(IWebDriver driver)
        {
            this.driver = driver;
        }


        #region
        void guesttclick()
        {
            
            click(guest);

        }
        void inputFirstname(string Finput)
        {
            typetext(firstname, Finput);
        }

        void inputLastname(string Linput)
        {
            typetext(lastname, Linput);
        }
        void inputemail(string Einput)
        {
            typetext(email, Einput);
        }
        void inputPhonenumber(string Finput)
        {
            typetext(phone, Finput);
        }

        void inputCity(string Cinput)
        {
            typetext(city, Cinput);
        }

       
        void inputPassword(string Pinput)
        {
            typetext(password, Pinput);
        }

        void inputConfirmPass(string Cinput)
        {
            typetext(confirmPassword, Cinput);
        }
        void clickcheckbox()
        {

            click(agreeCheckbox);
        }
        void submitclick()
        {
            click(submit);

        }
        #endregion
   
        #region signUP     
        public void signup(string Firstname, string Lastname, string Email, string PhoneNo, string City, string pass, string Confirmpassword)
        {
            OpenURL();
            guesttclick();  
            inputFirstname(Firstname);
            inputLastname(Lastname);
            inputemail(Email);
            inputPhonenumber(PhoneNo);
            inputCity(City);
            scroll();
            inputPassword(pass);
            inputConfirmPass(Confirmpassword);
            clickcheckbox();
            submitclick();
            Thread.Sleep(6000);
            
        }
        #endregion
    }
}
