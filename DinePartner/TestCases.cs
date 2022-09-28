using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            wait();
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




    }
}
