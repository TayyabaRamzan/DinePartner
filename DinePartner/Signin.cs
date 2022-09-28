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
            entertext(enterEmail, Einput);
        }

        void EnterPass(string Pinput)
        {
            entertext(enterPassword, Pinput);
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
        void entertext(By locator, string text)
        {
            IWebElement element = findElement(locator);
            element.SendKeys(text);
        }


        IWebElement findElement(By locator)
        {
            return driver.FindElement(locator);
        }
        void click(By locator)
        {
            findElement(locator).Click();
        }
        #endregion

        #region

        public void signin(string emailinput, string emailPass)
        {
            OpenURL();
            guesttclick();
            EnterEmail(emailinput);
            EnterPass(emailPass);
            clickSignin();
            Thread.Sleep(5000);
        }

        #endregion

    }

}
