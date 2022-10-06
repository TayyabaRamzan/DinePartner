using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;

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
            //closebrowser();
            QuitBrowser();
        }
        

        [TestCategory("SignUp")]
        [TestMethod]
        
        public void FYP_T1_SignupButtonClickable()
        {

            signupFunctionality ss = new signupFunctionality(driver);
            ss.signupbuttonisclickable();
            //ExtentTest test = extent.CreateTest("FYP_T1_Verify sign up button is clickable and functional");

        }
        [TestCategory("SignUp")]
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "file.xml", "signupforvalid", DataAccessMethod.Sequential)]
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

            ss.signupForValid(firstname, lastname, email, phone, city, password, confirmpassword);
        }
        [TestCategory("SignUp")]
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "file.xml", "signupwithincorrectemail", DataAccessMethod.Sequential)]
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

            ss.signupwithincorrectEmail(firstname, lastname, email, phone, city, password, confirmpassword);
        }
        [TestCategory("SignUp")]
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "file.xml", "signupwithregister", DataAccessMethod.Sequential)]
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

            ss.signupWithRegisteredUSer(firstname, lastname, email, phone, city, password, confirmpassword);
        }
        [TestCategory("SignUp")]
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "file.xml", "signupwithoutconfirmpassword", DataAccessMethod.Sequential)]
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

            ss.signupWithoutConfirmPassword(firstname, lastname, email, phone, city, password, confirmpassword);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "file.xml", "signinvalid", DataAccessMethod.Sequential)]
        public void FYP_T6_signinforValid()
        {

            Signin obj = new Signin(driver);

            string email = TestContext.DataRow["email"].ToString();
            string password = TestContext.DataRow["password"].ToString();

            obj.signin(email, password);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "file.xml", "signinincorrectemail", DataAccessMethod.Sequential)]
        public void FYP_T7_signinwithIncorrectEmail()
        {

            Signin obj = new Signin(driver);

            string email = TestContext.DataRow["email"].ToString();
            string password = TestContext.DataRow["password"].ToString();

            obj.signin(email, password);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "file.xml", "signinbutton", DataAccessMethod.Sequential)]
        public void FYP_T9_Signinbutton()
        {

            Signin obj = new Signin(driver);
   
            string email = TestContext.DataRow["email"].ToString();
            string password = TestContext.DataRow["password"].ToString();

            obj.signin(email, password);
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "file.xml", "signinincorrectpass", DataAccessMethod.Sequential)]
        public void FYP_T8_signinwithIncorrectpass()
        {

            Signin obj = new Signin(driver);

            string email = TestContext.DataRow["email"].ToString();
            string password = TestContext.DataRow["password"].ToString();

            obj.signin(email, password);
        }
        [TestMethod]


        public void FYP_T10_SearchiconClickable()
        {

            FindYourTable obj = new FindYourTable(driver);

            obj.searchbutton();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "file.xml", "findtable", DataAccessMethod.Sequential)]
        public void Fyp_T11_findtableusingRestaurantName()
        {

            FindYourTable obj = new FindYourTable(driver);
            string Rest_name = TestContext.DataRow["Rname"].ToString();
            obj.Findtable(Rest_name);
        }
        [TestMethod]
        public void FYP_T12_searchIslrestaurants()
        {

            Filters obj = new Filters(driver);

            obj.ApplyFilters1();
        }
        [TestMethod]
        public void FYP_T13_searchContinentalCuisinewithLiveBBQ()
        {

            Filters obj = new Filters(driver);

            obj.ApplyFilters2();
        }
        [TestMethod]
        public void FYP_T14_search5StarISlRestaurant()
        {

            Filters obj = new Filters(driver);

            obj.ApplyFilters3();
        }
        [TestMethod]
        public void FYP_T15_RecommendIsClickable()
        {

            RecommendRestaurant obj = new RecommendRestaurant(driver);

            obj.Recommendbutton(); 
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "file.xml", "EmailMandatory", DataAccessMethod.Sequential)]
        public void FYP_T16_EmailForMandatory()
        { 

            RecommendRestaurant obj = new RecommendRestaurant(driver);
            string Myname = TestContext.DataRow["name"].ToString();
            string MyEmail = TestContext.DataRow["email"].ToString();
            string MyRestaurant = TestContext.DataRow["restaurant"].ToString();
            obj.emailismandatory(Myname, MyEmail, MyRestaurant);
        } 
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "file.xml", "NameMandatory", DataAccessMethod.Sequential)]
        public void FYP_T17_NameForMandatory()
        {

            RecommendRestaurant obj = new RecommendRestaurant(driver);
            string Myname = TestContext.DataRow["name"].ToString();
            string MyEmail = TestContext.DataRow["email"].ToString();
            string MyRestaurant = TestContext.DataRow["restaurant"].ToString();
            obj.emailismandatory(Myname, MyEmail, MyRestaurant);
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "file.xml", "RestaurantMandatory", DataAccessMethod.Sequential)]
        public void FYP_T18_RestaurantForMandatory()
        {

            RecommendRestaurant obj = new RecommendRestaurant(driver);
            string Myname = TestContext.DataRow["name"].ToString();
            string MyEmail = TestContext.DataRow["email"].ToString();
            string MyRestaurant = TestContext.DataRow["restaurant"].ToString();
            obj.emailismandatory(Myname, MyEmail, MyRestaurant);
        }
        [TestMethod]
        public void FYP_T19_SendIsClickable()
        {
            RecommendRestaurant obj = new RecommendRestaurant(driver);
            obj.sendbuttonclick();
        }
    }
}
