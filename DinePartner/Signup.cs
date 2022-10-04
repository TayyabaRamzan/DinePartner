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
        By scrlelement = By.XPath("//h5[@class='bold white footer-header']");

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
        public void signupbuttonisclickable()
        {
            Program.log.Info("FYP_T1_Verify sign up button is clickable and functional");
            Program.log.Info("Launch the Website ");
            OpenURL();
            Program.log.Info("Website should be launched successfully");
            Program.log.Info("Click on Guest button");
            guesttclick();
            Program.log.Info("Sign up form should be opened");
            Program.log.Info("Scroll to an element");
            scroll(scrlelement);
            Program.log.Info("It should display Sign up button");
            Program.log.Info("Click on Sign up button ");
            submitclick();
            Program.log.Info("Sign up button is clickable and Functional");
            Thread.Sleep(6000);
            
        }
        public void signupForValid(string Firstname, string Lastname, string Email, string PhoneNo, string City, string pass, string Confirmpassword)
        {
            Program.log.Info("FYP_T2_Verify sign up With valid Credentials");
            Program.log.Info("Launch the Website ");
            OpenURL();
            Program.log.Info("Website should be launched successfully");
            Program.log.Info("Click on Guest button");
            guesttclick();
            Program.log.Info("Sign up form should be opened");
            Program.log.Info("Enter data in firstname field ");
            inputFirstname(Firstname);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Enter data in lastname field ");
            inputLastname(Lastname);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Enter data in email field ");
            inputemail(Email);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Enter data in Contact numbber field ");
            inputPhonenumber(PhoneNo);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Enter data in Your city field ");
            inputCity(City);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Scroll to an element");
            scroll(scrlelement);
            Program.log.Info("It should display Password Field");
            Program.log.Info("Enter data in password field ");
            inputPassword(pass);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Enter data in Confirm password field ");
            inputConfirmPass(Confirmpassword);
            Program.log.Info("Data should be entered successfully");
            clickcheckbox();
            Program.log.Info("Click on Sign up button");
            submitclick();
            Program.log.Info("It should Sign up Successfuly");
            Thread.Sleep(6000);

        }

        public void signupwithincorrectEmail(string Firstname, string Lastname, string Email, string PhoneNo, string City, string pass, string Confirmpassword)
        {
            Program.log.Info("FYP_T3_Verify sign up With incorrect email");
            Program.log.Info("Launch the Website ");
            OpenURL();
            Program.log.Info("Website should be launched successfully");
            Program.log.Info("Click on Guest button");
            guesttclick();
            Program.log.Info("Sign up form should be opened");
            Program.log.Info("Enter data in firstname field ");
            inputFirstname(Firstname);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Enter data in lastname field ");
            inputLastname(Lastname);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Enter incorrect email in email field ");
            inputemail(Email);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Enter data in Contact numbber field ");
            inputPhonenumber(PhoneNo);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Enter data in Your city field ");
            inputCity(City);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Scroll to an element");
            scroll(scrlelement);
            Program.log.Info("It should display Password Field");
            Program.log.Info("Enter data in password field ");
            inputPassword(pass);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Enter data in Confirm password field ");
            inputConfirmPass(Confirmpassword);
            Program.log.Info("Data should be entered successfully");
            clickcheckbox();
            Program.log.Info("Click on Sign up button");
            submitclick();
            Program.log.Info("It should not Sign up Successfuly");
            Thread.Sleep(6000);

        }

        public void signupWithRegisteredUSer(string Firstname, string Lastname, string Email, string PhoneNo, string City, string pass, string Confirmpassword)
        {
            Program.log.Info("FYP_T4_Verify sign up With incorrect email");
            Program.log.Info("Launch the Website ");
            OpenURL();
            Program.log.Info("Website should be launched successfully");
            Program.log.Info("Click on Guest button");
            guesttclick();
            Program.log.Info("Sign up form should be opened");
            Program.log.Info("Enter data in firstname field ");
            inputFirstname(Firstname);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Enter data in lastname field ");
            inputLastname(Lastname);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Enter registered email in Email field ");
            inputemail(Email);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Enter data in Contact numbber field ");
            inputPhonenumber(PhoneNo);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Enter data in Your city field ");
            inputCity(City);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Scroll to an element");
            scroll(scrlelement);
            Program.log.Info("It should display Password Field");
            Program.log.Info("Enter data in password field ");
            inputPassword(pass);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Enter data in Confirm password field ");
            inputConfirmPass(Confirmpassword);
            Program.log.Info("Data should be entered successfully");
            clickcheckbox();
            Program.log.Info("Click on Sign up button");
            submitclick();
            Program.log.Info("It should display an error message");
            Thread.Sleep(6000);

        }
        public void signupWithoutConfirmPassword(string Firstname, string Lastname, string Email, string PhoneNo, string City, string pass, string Confirmpassword)
        {
            Program.log.Info("FYP_T4_Verify sign up With incorrect email");
            Program.log.Info("Launch the Website ");
            OpenURL();
            Program.log.Info("Website should be launched successfully");
            Program.log.Info("Click on Guest button");
            guesttclick();
            Program.log.Info("Sign up form should be opened");
            Program.log.Info("Enter data in firstname field ");
            inputFirstname(Firstname);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Enter data in lastname field ");
            inputLastname(Lastname);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Enter registered email in Email field ");
            inputemail(Email);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Enter data in Contact numbber field ");
            inputPhonenumber(PhoneNo);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Enter data in Your city field ");
            inputCity(City);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Scroll to an element");
            scroll(scrlelement);
            Program.log.Info("It should display Password Field");
            Program.log.Info("Enter data in password field ");
            inputPassword(pass);
            Program.log.Info("Data should be entered successfully");
            Program.log.Info("Do not enter password in confirm password field ");
            inputConfirmPass(Confirmpassword);
            Program.log.Info("It should display an empty field ");
            clickcheckbox();
            Program.log.Info("Click on Sign up button");
            submitclick();
            Program.log.Info("It should display an error message");
            Thread.Sleep(6000);

        }

        #endregion
    }
}
