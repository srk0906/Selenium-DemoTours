using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Framework.Extensions.MSTest;
using Test.Framework.Helpers;
using Test.Framework.Reporting;

namespace DemoTours
{
    [TestClass]
    public class TestBase : BaseTest
    {
        public static List<TestCaseResult> resultSet = new List<TestCaseResult>();

        static TestBase()
        {
            // write your class initialize logic here.
            System.AppDomain.CurrentDomain.DomainUnload += CurrentDomain_DomainUnload;
        }

        private static void CurrentDomain_DomainUnload(object sender, EventArgs e)
        {
            // write clean up logic here.
            ReportHelper.GetConsolidatedReport(resultSet);
        }

        /// <summary>
        /// To start the report log
        /// </summary>
        [TestInitialize]
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public void BaseTestInitialize()
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {
            TestStep.TestContext = this.TestContext;

            ReportingManager.SetTestContext(this.TestContext);
            ReportingManager.StartReportAndLog();

        }


        [TestCleanup]
        public virtual void BaseTestCleanUps()
        {

            if (this.TestContext.CurrentTestOutcome != UnitTestOutcome.Passed)
            {
                // result.ExecutionResult = TestExecutionOutcome.Fail;

                Summary.ReportEvent(
                    ReportEventStatus.Fail,
                    "Test is not successful",
                    "Test is not successful",
                    ScreenCapture.Accept);

            }

            if (this.TestContext.CurrentTestOutcome == UnitTestOutcome.Passed)
            {
                // result.ExecutionResult = TestExecutionOutcome.Pass;
                Summary.ReportEvent(
                    ReportEventStatus.Pass,
                    "Test successful",
                    "Test successful",
                    ScreenCapture.Accept);
            }



        }

        public class TestCaseResult
        {
            public string TestCaseName { get; set; }
            public TestExecutionOutcome ExecutionResult { get; set; }
            //public string ExecutionResult{get; set;}

            public string TestCaseCategory { get; set; }

            public string ResultDir { get; set; }

            public string link { get; set; }

            public string logFile { get; set; }

        }

        public enum TestExecutionOutcome
        {
            Pass,
            Fail
        }

    }
}
