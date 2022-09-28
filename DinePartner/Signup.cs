using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Cryptography.X509Certificates;

namespace DinePartner

{

    public class signupFunctionality : CommonMethods
    {
        //IWebDriver driver;

        By guest = By.LinkText("Guest");
        By firstname = By.ClassName("fname");
        By lastname = By.XPath("//input[@class='fname' and @name='last_name']");
        By phone = By.XPath("//input[@name='phone_num']");
        By email = By.XPath("//input[@class='femail' and @name='email']");
        //By element1 = By.XPath("//h5[@class='bold white footer-header']");
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

        void scroll()
        {
            var element1 = driver.FindElement(By.XPath("//h5[@class='bold white footer-header']"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element1);
        }
        void inputPassword(string Pinput)
        {
            typetext(password, Pinput);
        }

        void inputConfirmPass(string Cinput)
        {
            typetext(confirmPassword, Cinput);
        }
        void submitclick()
        {
            click(agreeCheckbox);
            click(submit);

        }
        #endregion

        #region operation_methods
        IWebElement findElement(By locator)
        {
            return driver.FindElement(locator);
        }
        #endregion

        #region
        void typetext(By locator, string text)
        {
            IWebElement element = findElement(locator);
            //element.Clear();
            // removeText(element);
            element.SendKeys(text);
        }
        void click(By locator)
        {
            findElement(locator).Click();
        }
        #endregion
        #region signUP     
        public void signup(string Firstname, string Lastname, string Email, string PhoneNo, string City, string pass, string Confirmpassword)
        {
            OpenURL();
            inputFirstname(Firstname);
            inputLastname(Lastname);
            inputemail(Email);
            inputPhonenumber(PhoneNo);
            inputCity(City);
            scroll();
            inputPassword(pass);
           // inputConfirmPass(Confirmpassword);
            submitclick();
            
        }
        #endregion
    }
}
