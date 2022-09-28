﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DinePartner
{
    [TestClass]
    public class TestCases : CommonMethods
    {

        public TestContext instance;

        public TestContext TestContext { get; set; }


        [TestInitialize]
        public void testinit()
        {
            startBrowser();

        }
        [TestCleanup]

        public void Testclean()
        {

            closebrowser();
        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "new1.xml", "signupforvalid", DataAccessMethod.Sequential)]
        public void FYP_T1_SignupButtonClickable()
        {

            signupFunctionality ss = new signupFunctionality(driver);

            string firstname = TestContext.DataRow["firstname"].ToString();
            string lastname = TestContext.DataRow["lastname"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string phone = TestContext.DataRow["phone"].ToString();
            string city = TestContext.DataRow["city"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();

            ss.signup(firstname, lastname, email, phone, city, password, confirmpassword);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "new1.xml", "signupbuttonclickable", DataAccessMethod.Sequential)]
        public void FYP_T2_SignupforValid()
        {

            signupFunctionality ss = new signupFunctionality(driver);

            string firstname = TestContext.DataRow["firstname"].ToString();
            string lastname = TestContext.DataRow["lastname"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string phone = TestContext.DataRow["phone"].ToString();
            string city = TestContext.DataRow["city"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();

            ss.signup(firstname, lastname, email, phone, city, password, confirmpassword);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "new1.xml", "signupwithincorrectemail", DataAccessMethod.Sequential)]
        public void FYP_T3_Signupwithincorrectemail()
        {

            signupFunctionality ss = new signupFunctionality(driver);

            string firstname = TestContext.DataRow["firstname"].ToString();
            string lastname = TestContext.DataRow["lastname"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string phone = TestContext.DataRow["phone"].ToString();
            string city = TestContext.DataRow["city"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();

            ss.signup(firstname, lastname, email, phone, city, password, confirmpassword);
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "new1.xml", "signupwithregister", DataAccessMethod.Sequential)]
        public void FYP_T4_Signupwithregisteruser()
        {

            signupFunctionality ss = new signupFunctionality(driver);

            string firstname = TestContext.DataRow["firstname"].ToString();
            string lastname = TestContext.DataRow["lastname"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string phone = TestContext.DataRow["phone"].ToString();
            string city = TestContext.DataRow["city"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();

            ss.signup(firstname, lastname, email, phone, city, password, confirmpassword);
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "new1.xml", "signupwithoutconfirmpassword", DataAccessMethod.Sequential)]
        public void FYP_T5_signupwithoutconfirmpassword()
        {

            signupFunctionality ss = new signupFunctionality(driver);

            string firstname = TestContext.DataRow["firstname"].ToString();
            string lastname = TestContext.DataRow["lastname"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string phone = TestContext.DataRow["phone"].ToString();
            string city = TestContext.DataRow["city"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();

            ss.signup(firstname, lastname, email, phone, city, password, confirmpassword);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "new1.xml", "signinvalid", DataAccessMethod.Sequential)]
        public void FYP_T6_signinforValid()
        {

            Signin obj = new Signin(driver);

            string email = TestContext.DataRow["email"].ToString();
            string password = TestContext.DataRow["password"].ToString();

            obj.signin(email, password);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "new1.xml", "signinincorre", DataAccessMethod.Sequential)]
        public void FYP_T7_signinwithIncorrectEmail()
        {

            Signin obj = new Signin(driver);

            string email = TestContext.DataRow["email"].ToString();
            string password = TestContext.DataRow["password"].ToString();

            obj.signin(email, password);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "new1.xml", "signinbutton", DataAccessMethod.Sequential)]
        public void FYP_T9_validateSigninbutton()
        {

            Signin obj = new Signin(driver);
   
            string email = TestContext.DataRow["email"].ToString();
            string password = TestContext.DataRow["password"].ToString();

            obj.signin(email, password);
        }

       
       
    }
}
