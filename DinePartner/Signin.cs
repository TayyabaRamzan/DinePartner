using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;


namespace DinePartner
{
    public class Signin: CommonMethods
    {
        By guest = By.LinkText("Guest");
        By enterEmail = By.ClassName("formemail");
        By enterPassword = By.Name("login_password");
        By signIn = By.Name("login_submit");
        //By Fpass = By.LinkText("Forgot Password?");

        public Signin(IWebDriver driver)
        {
            this.driver = driver;
        }

        void EnterEmail(string Einput)
        {
            typetext(enterEmail, Einput);
        }

        void EnterPass(string Pinput)
        {
            typetext(enterPassword, Pinput);
        }

        void clickSignin()
        {
            click(signIn);
        }

        #region
        void guesttclick()
        {

            click(guest);

        }
       
        #endregion

        #region

        public void signin(string emailinput, string PassInput)
        {
            Program.log.Info("open Url");
            OpenURL();
            Program.log.Info("Click on Guest button");
            guesttclick();
            Program.log.Info("Enter email in email Field");
            EnterEmail(emailinput);
            Program.log.Info("Enter password in password field");
            EnterPass(PassInput);
            Program.log.Info("Click on Sign in Button");
            clickSignin();
            Thread.Sleep(5000);
        }

        #endregion

    }

}
