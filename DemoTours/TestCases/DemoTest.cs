using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test.Framework;
using Test.Framework.Helpers;
using Test.Framework.Reporting;
using DemoTours.PageObjects;

namespace DemoTours.TestCases
{
    [TestClass]
    public class DemoTest : TestBase
    {
        private string url = string.Empty;

        [TestInitialize]
        public void BasicSetUp()
        {
            string urlXML = ConfigurationManager.AppSettings["URLMapping"];
            string url = CommonFunctions.GetXMLNode(urlXML, "DemoTours");
            Browser.Start(url);
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            TestCaseResult result = new TestCaseResult();
            result.TestCaseName = this.TestContext.TestName;
            result.ResultDir = this.TestContext.ResultsDirectory;

            UnitTestOutcome executionResult = this.TestContext.CurrentTestOutcome;

            if (executionResult == UnitTestOutcome.Passed)
                result.ExecutionResult = TestExecutionOutcome.Pass;
            else
                result.ExecutionResult = TestExecutionOutcome.Fail;


            var currentlyRunningClassType = this.GetType().Assembly.GetTypes().FirstOrDefault(f => f.FullName == this.TestContext.FullyQualifiedTestClassName);
            var method = currentlyRunningClassType.GetMethod(this.TestContext.TestName);
            var workItemAttribute = method.GetCustomAttributes(typeof(TestCategoryAttribute)).First();

            result.TestCaseCategory = ((TestCategoryAttribute)workItemAttribute).TestCategories[0];

            resultSet.Add(result);
        }

        [TestMethod]
        [TestCategory("Registration")]
        public void Demo_Registration_Success()
        {
            TestStep.Execute(
                () =>
                {
                    PageObjects.RegistrationPage.RegisterLinkClick();
                },
                1,
                @"User Clicks on Registration Link", ScreenCapture.Accept);
            TestStep.Execute(
                () =>
                {
                    PageObjects.RegistrationPage.DemoEnterFirstName();
                },
                2,
                @"User enters First name", ScreenCapture.Accept);
            TestStep.Execute(
                () =>
                {
                    PageObjects.RegistrationPage.DemoEnterLastName();
                },
                3,
                @"User enters Last name", ScreenCapture.Accept);
            TestStep.Execute(
                () =>
                {
                    PageObjects.RegistrationPage.DemoEnterPhone();
                },
                4,
                @"User enters Phone number", ScreenCapture.Accept);
            TestStep.Execute(
                () =>
                {
                    PageObjects.RegistrationPage.DemoEnterEMail();
                },
                5,
                @"User enters Email", ScreenCapture.Accept);
            TestStep.Execute(
                () =>
                {
                    PageObjects.RegistrationPage.DemoEnterAddress1();
                },
                6,
                @"User enters Address 1", ScreenCapture.Accept);
            TestStep.Execute(
                () =>
                {
                    PageObjects.RegistrationPage.DemoEnterAddress2();
                },
                7,
                @"User enters Address 2", ScreenCapture.Accept);
            TestStep.Execute(
                () =>
                {
                    PageObjects.RegistrationPage.DemoEnterCity();
                },
                8,
                @"User enters City", ScreenCapture.Accept);
            TestStep.Execute(
                () =>
                {
                    PageObjects.RegistrationPage.DemoEnterState();
                },
                9,
                @"User enters State", ScreenCapture.Accept);
            TestStep.Execute(
                () =>
                {
                    PageObjects.RegistrationPage.DemoEnterPostCode();
                },
                10,
                @"User enters Postcode", ScreenCapture.Accept);
            TestStep.Execute(
                () =>
                {
                    PageObjects.RegistrationPage.DemoEnterCountry();
                },
                11,
                @"User selects Country", ScreenCapture.Accept);
            TestStep.Execute(
                () =>
                {
                    PageObjects.RegistrationPage.DemoEnterUserName();
                },
                12,
                @"User enters Username", ScreenCapture.Accept);
            TestStep.Execute(
                () =>
                {
                    PageObjects.RegistrationPage.DemoEnterPassword();
                },
                13,
                @"User enters Password", ScreenCapture.Accept);
            TestStep.Execute(
                () =>
                {
                    PageObjects.RegistrationPage.DemoEnterConfirmPassword();
                },
                14,
                @"User enters Confirm Password", ScreenCapture.Accept);
            TestStep.Execute(
                () =>
                {
                    PageObjects.RegistrationPage.DemoRegSubmit();
                },
                8,
                @"User Submits the form", ScreenCapture.Accept);
        }

        [TestMethod]
        [TestCategory("Login")]
        public void Demo_Login_Success()
        {
            TestStep.Execute(
                () =>
                {
                    PageObjects.LoginPage.DemoEnterUserName();
                },
                1,
                @"User enters Username", ScreenCapture.Accept);
            TestStep.Execute(
                () =>
                {
                    PageObjects.LoginPage.DemoEnterPassword();
                },
                2,
                @"User enters Password", ScreenCapture.Accept);
            TestStep.Execute(
                () =>
                {
                    PageObjects.LoginPage.DemoEnterLoginBtn();
                },
                3,
                @"User clicks on Login button", ScreenCapture.Accept);
        }

    }
}
