using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using Xunit;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using HMPO_Test.Test_Cases;

namespace HMPO_Test
{
    public class Program
    {
        private static ExtentReports extent;
        private static object perform;


        // Start method for extent reports
        [OneTimeSetUp]
        public static void ExtentStart()
        {
            extent = new ExtentReports();

            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;

            // string reportPath = projectPath + "TestReport\\Start Script Button Test Documentation - Passed - 15-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Task Button Test Documentation - Passed - 15-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Next Tasks Button Test Documentation - Passed - 15-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Contact History Button Test Documentation - Passed - 15-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Payment History Button Test Documentation - Passed - 15-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Office Management Button Test Documentation - Passed - 15-02-2022.html";
            // string reportPath = projectPath + "TestReport\\QA Feedback Button Test Documentation - Passed - 15-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Fees Management Button Test Documentation - Passed - 15-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Countries Management Button Test Documentation - Passed - 15-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Transfer Management Button Test Documentation - Passed - 15-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Forecasts Button Test Documentation - Passed - 15-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Trigger Management Button Test Documentation - Passed - 15-02-2022.html";
            // string reportPath = projectPath + "TestReport\\QA Allocation Button Test Documentation - Passed - 15-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Agent Call Search Button Test Documentation - Passed - 15-02-2022.html";
            // string reportPath = projectPath + "TestReport\\Call Reasons Button Test Documentation - Passed - 15-02-2022.html";
            string reportPath = projectPath + "TestReport\\Dashboard Button Test Documentation - Passed - 15-02-2022.html";



            var htmlReporter = new ExtentV3HtmlReporter(reportPath);

            extent.AttachReporter(htmlReporter);
        }


        public void ExtentClose()
        {
            extent.Flush();
        }


        class OneTimeSetUpAttribute : Attribute
        {
        }


        [Fact]
        static void Main()
        {
            // Test
            // This is where everything is run
            IWebDriver driver = new ChromeDriver();

            ExtentStart();


            // StartScriptTest.StartScript(driver, extent);
            // TaskTest.Task(driver, extent);
            // NextTaskTest.NextTask(driver, extent);
            // ContactHistoryTest.ContactHistory(driver, extent);
            // PaymentHistoryTest.PaymentHistory(driver, extent);
            // OfficeManagementTest.OfficeManagement(driver, extent);
            // QAFeedbackTest.QAFeedback(driver, extent);
            // FeesManagementTest.FeesManagement(driver, extent);
            // CountriesManagementTest.CountriesManagement(driver, extent);
            // TransferManagementTest.TransferManagement(driver, extent);
            // ForecastsTest.Forecasts(driver, extent);
            // TriggerManagementTest.TriggerManagement(driver, extent);
            // QAAllocationTest.QAAllocation(driver, extent);
            // AgentCallSearchTest.AgentCallSearch(driver, extent);
            // CallReasonsTest.CallReasons(driver, extent);
            DashboardTest.Dashboard(driver, extent);




        }
    }
}
