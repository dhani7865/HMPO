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
using NUnit.Framework;
using System.Runtime.Remoting.Contexts;
using SeleniumExtras.WaitHelpers;

namespace HMPO_Test.Test_Cases
{
    public static class StartScriptTest
    {
        private static double maxWaitSeconds;
        private static object byLocatorType;
        private static IWebElement element;

        public static void StartScript(IWebDriver driver, ExtentReports extent)
        {
            var test = extent.CreateTest("HMPO - Start Script Page Test").Info("Test Started");

            // Test 1
            // Openning the tp oxygen hmpo and setting the window size
            driver.Navigate().GoToUrl("https://tpoxygen-hmpo-pal-qa/");
            driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "HMPO QA Oxygen Launched");
            test.Log(Status.Pass, "Test 1 Passed");
            extent.Flush();

            // Test 2
            // Clicking on the start script button and PAL Button
            driver.FindElement(By.CssSelector("li:nth-child(1) img")).Click();
            driver.FindElement(By.CssSelector("li:nth-child(1) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the start script button and PAL Button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3

            // Clicking the call reason check box
            driver.FindElement(By.Id("CallReasonCheckBoxes_9__isSelected")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);

            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the call reason check box");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Selected yes from drop down to finish the script, which then directs to the finish page
            driver.FindElement(By.Id("SelectedFinish")).Click();

            var dropdown = driver.FindElement(By.Id("SelectedFinish"));
            dropdown.FindElement(By.XPath("//option[. = 'YES']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selected yes from drop down to finish the script, which then directs to the finish page");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Clicking the continue button
            driver.FindElement(By.CssSelector("p:nth-child(1) > input")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Selecting yes from the drop down for DAP Call
            driver.FindElement(By.Id("SelectedDAPResult")).Click();

            dropdown = driver.FindElement(By.Id("SelectedDAPResult"));
            dropdown.FindElement(By.XPath("//option[. = 'YES']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting yes from the drop down for DAP Call");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();


            // Test 7
            // Selecting NO from the dropdown to select Pre Application Result
            dropdown = driver.FindElement(By.Id("SelectedPreApplicationResult"));

            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("NO");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting NO from the dropdown to select Pre Application Result");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Selected UK Advice from the dorpdown for outcome
            dropdown = driver.FindElement(By.Id("SelectedOutcome_ID"));


            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("UK Advice");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting UK Advice from the dorpdown for outcome");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Selecting Nationality for the child outcome
            driver.FindElement(By.Id("SelectedChildOutcome_ID1"));

            dropdown = driver.FindElement(By.Id("SelectedChildOutcome_ID1"));
            dropdown.FindElement(By.XPath("//option[. = 'Nationality']")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Nationality for the child outcome");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();


            // Test 10
            // Selecting Nationality - General from the dropdown for the child outcome 2
            dropdown = driver.FindElement(By.Id("SelectedChildOutcome_ID2"));


            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Nationality - General");


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Nationality - General from the dropdown for the child outcome 2");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Enterring Test in the Notes text box
            driver.FindElement(By.Id("Notes")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring Test in the Notes text box");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // test 12
            // Clicking the finish button
            driver.FindElement(By.CssSelector(".submit-button-container > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the finish button");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();

            // Test 13
            // Clicking on the start script button and PAL Button
            driver.FindElement(By.CssSelector("li:nth-child(1) img")).Click();
            driver.FindElement(By.CssSelector("li:nth-child(1) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the start script button and PAL Button");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 14
            // Clicking the call reason check box
            driver.FindElement(By.Id("CallReasonCheckBoxes_8__isSelected")).Click();
            driver.FindElement(By.Id("CallReasonCheckBoxes_9__isSelected")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the call reason check box");
            test.Log(Status.Pass, "Test 14 Passed");
            extent.Flush();

            // Test 15
            // Selecting YES to finish the call from the drop down
            dropdown = driver.FindElement(By.Id("SelectedFinish"));


            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("YES");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting YES to finish the call from the drop down");
            test.Log(Status.Pass, "Test 15 Passed");
            extent.Flush();

            // Test 16
            // Selecting NO to finish the call from the drop down
            dropdown = driver.FindElement(By.Id("SelectedFinish"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("NO");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting YES to finish the call from the drop down");
            test.Log(Status.Pass, "Test 16 Passed");
            extent.Flush();

            // Test 17
            // Selecting title ID and selecting the option Mr from the dropdown
            driver.FindElement(By.CssSelector("p:nth-child(1) > input")).Click();
            driver.FindElement(By.Id("SelectedTitle_ID")).Click();

            dropdown = driver.FindElement(By.Id("SelectedTitle_ID"));
            dropdown.FindElement(By.XPath("//option[. = 'Mr']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting title ID and selecting the option Mr from the dropdown");
            test.Log(Status.Pass, "Test 17 Passed");
            extent.Flush();

            // Test 18
            // Entering test for the firstname
            driver.FindElement(By.Id("Firstname")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering test for the firstname");
            test.Log(Status.Pass, "Test 18 Passed");
            extent.Flush();

            // test 19
            // Entering test for the Lastname
            driver.FindElement(By.Id("Lastname")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering test for the Lastname");
            test.Log(Status.Pass, "Test 19 Passed");
            extent.Flush();

            // test 20
            // Entering NE11 9SZ for the postcode
            driver.FindElement(By.Id("Postcode")).SendKeys("NE11 9SZ");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering NE11 9SZ for the postcode");
            test.Log(Status.Pass, "Test 20 Passed");
            extent.Flush();

            // Test 21
            // Selecting the country ID
            dropdown = driver.FindElement(By.Id("SelectedCountry_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Uganda");
            selectElement.SelectByText("United Kingdom");


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the country ID");
            test.Log(Status.Pass, "Test 21 Passed");
            extent.Flush();

            // Test 22
            // Clicking the continue button
            driver.FindElement(By.CssSelector(".isValid:nth-child(1)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 22 Passed");
            extent.Flush();

            // Test 23
            // Clicking the payment button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(3) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the payment button");
            test.Log(Status.Pass, "Test 23 Passed");
            extent.Flush();

            // Test 24
            // Clicking the search button
            driver.FindElement(By.Id("lnkSearch")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 24 Passed");
            extent.Flush();

            // Test 25
            // Clicking ther search button
            driver.FindElement(By.CssSelector("div:nth-child(12) > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 25 Passed");
            extent.Flush();

            // Test 26
            // Clicking the create new button
            driver.FindElement(By.LinkText("Create New")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the create new button");
            test.Log(Status.Pass, "Test 26 Passed");
            extent.Flush();

            // Test 27
            // Selecting the title
            driver.FindElement(By.Id("SelectedTitle_ID")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the title");
            test.Log(Status.Pass, "Test 27 Passed");
            extent.Flush();

            // Test 28
            // Selecting the firstname
            driver.FindElement(By.Id("Firstname")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the firstname");
            test.Log(Status.Pass, "Test 28 Passed");
            extent.Flush();

            // Test 29
            // Selecting the Lastname
            driver.FindElement(By.Id("Lastname")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Lastname");
            test.Log(Status.Pass, "Test 29 Passed");
            extent.Flush();


            // Test 30
            // Enterring the telephone number
            driver.FindElement(By.Id("TelephoneNumberViewModel_TelephoneNumber")).SendKeys("07800000000");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the telephone number");
            test.Log(Status.Pass, "Test 30 Passed");
            extent.Flush();

            // Test 31
            // Clicking the submit button
            driver.FindElement(By.Id("submit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the submit button");
            test.Log(Status.Pass, "Test 31 Passed");
            extent.Flush();

            // Test 32
            // Enterring the building number
            driver.FindElement(By.Id("BuildingNameNumber")).SendKeys("23");


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the building number");
            test.Log(Status.Pass, "Test 32 Passed");
            extent.Flush();

            // Test 33
            // Clicking the continue button
            driver.FindElement(By.CssSelector(".isValid:nth-child(1)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 33 Passed");
            extent.Flush();

            // Test 34
            // Selecting the address
            driver.FindElement(By.CssSelector("tr:nth-child(3) > td")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the address");
            test.Log(Status.Pass, "Test 34 Passed");
            extent.Flush();

            // Test 35
            // Selecting the title
            driver.FindElement(By.Id("SelectedTitle_ID")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the title");
            test.Log(Status.Pass, "Test 35 Passed");
            extent.Flush();

            // Test 36
            // Selecting the Firstname
            driver.FindElement(By.Id("Firstname")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Firstname");
            test.Log(Status.Pass, "Test 35 Passed");
            extent.Flush();

            // Test 37
            // Selecting the Firstname
            driver.FindElement(By.Id("Lastname")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Lastname");
            test.Log(Status.Pass, "Test 37 Passed");
            extent.Flush();

            // Test 38
            // Selecting the telephone number
            driver.FindElement(By.Id("TelephoneNumberViewModel_TelephoneNumber")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the telephone number");
            test.Log(Status.Pass, "Test 38 Passed");
            extent.Flush();

            // Test 39
            // Selecting the address line 1
            driver.FindElement(By.Id("PrimaryAddress_AddressLine1")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the address line 1");
            test.Log(Status.Pass, "Test 39 Passed");
            extent.Flush();

            // Test 40
            // Selecting the address postal town
            driver.FindElement(By.Id("PrimaryAddress_PostalTown")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the address postal town");
            test.Log(Status.Pass, "Test 40 Passed");
            extent.Flush();

            // Test 41
            driver.FindElement(By.CssSelector("fieldset:nth-child(4) > .field-holder:nth-child(4) > label")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Pass, "Test 41 Passed");
            extent.Flush();

            // Test 42
            // Selecting the address postcode
            driver.FindElement(By.Id("PrimaryAddress_Postcode")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the address postcode");
            test.Log(Status.Pass, "Test 42 Passed");
            extent.Flush();

            // Test 43
            // Selecting the county
            driver.FindElement(By.Id("PrimaryAddress_County")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the county");
            test.Log(Status.Pass, "Test 43 Passed");
            extent.Flush();

            // Test 44
            driver.FindElement(By.CssSelector("fieldset > p")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);

            // Test 45
            // Clicking the submit button
            driver.FindElement(By.Id("submit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the submit button");
            test.Log(Status.Pass, "Test 45 Passed");
            extent.Flush();


            // Test 46
            // Selecting the ID OfficeId and selecting liverpool from the dropdown
            driver.FindElement(By.Id("OfficeId")).Click();

            dropdown = driver.FindElement(By.Id("OfficeId"));
            dropdown.FindElement(By.XPath("//option[. = 'Liverpool']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the ID OfficeId and selecting liverpool from the dropdown");
            test.Log(Status.Pass, "Test 46 Passed");
            extent.Flush();

            // Test 47
            // Clicking the filter button
            driver.FindElement(By.Id("btnFilter")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the filter button");
            test.Log(Status.Pass, "Test 47 Passed");
            extent.Flush();

            // Test 48
            // Clicking the Add Applicant button to create a new Applicant
            driver.FindElement(By.LinkText("Add Applicant")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Add Applicant button to create a new Applicant");
            test.Log(Status.Pass, "Test 48 Passed");
            extent.Flush();

            // Test 49
            // Enterring test for the name
            driver.FindElement(By.Id("Name")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring test for the name");
            test.Log(Status.Pass, "Test 49 Passed");
            extent.Flush();

            // Test 50
            // Enterring 12345678A for the Rrference
            driver.FindElement(By.Id("Reference")).SendKeys("12345678A");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring 5.00 for the amount");
            test.Log(Status.Pass, "Test 50 Passed");
            extent.Flush();

            // Test 51
            // Enterring 5.00 for the amount
            driver.FindElement(By.Id("Amount")).SendKeys("5.00");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring 5.00 for the amount");
            test.Log(Status.Pass, "Test 51 Passed");
            extent.Flush();



            // Test 52
            // Clicking the continue button
            driver.FindElement(By.CssSelector(".field-holder:nth-child(2) > label")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 52 Passed");
            extent.Flush();

            // Test 53
            // Clicking the filter button
            driver.FindElement(By.Id("btnFilter")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the filter button");
            test.Log(Status.Pass, "Test 53 Passed");
            extent.Flush();

            // Test 54
            // Clicking the Edit Applicant button
            driver.FindElement(By.LinkText("Edit Applicant")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Edit Applicant button");
            test.Log(Status.Pass, "Test 54 Passed");
            extent.Flush();

            // Test 55
            // Clicking the Back button
            driver.FindElement(By.LinkText("Back")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Back button");
            test.Log(Status.Pass, "Test 55 Passed");
            extent.Flush();

            // Test 56
            // Clicking the Remove Applicant button
            driver.FindElement(By.LinkText("Remove Applicant")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Remove Applicant button");
            test.Log(Status.Pass, "Test 56 Passed");
            extent.Flush();

            // Test 57
            // Selecting the ID OfficeId and selecting liverpool from the dropdown
            driver.FindElement(By.Id("OfficeId")).Click();

            dropdown = driver.FindElement(By.Id("OfficeId"));
            dropdown.FindElement(By.XPath("//option[. = 'Liverpool']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the ID OfficeId and selecting liverpool from the dropdown");
            test.Log(Status.Pass, "Test 57 Passed");
            extent.Flush();

            // Test 58
            // Clicking the filter button
            driver.FindElement(By.Id("btnFilter")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the filter button");
            test.Log(Status.Pass, "Test 58 Passed");
            extent.Flush();

            // Test 59
            // Clicking the Add Applicant button to create a new Applicant
            driver.FindElement(By.LinkText("Add Applicant")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Add Applicant button to create a new Applicant");
            test.Log(Status.Pass, "Test 59 Passed");
            extent.Flush();

            // Test 60
            // Enterring test for the name
            driver.FindElement(By.Id("Name")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring test for the name");
            test.Log(Status.Pass, "Test 60 Passed");
            extent.Flush();


            // Test 61
            // Enterring 12345678A for the reference
            driver.FindElement(By.Id("Reference")).SendKeys("12345678A");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring 12345678A for the reference");
            test.Log(Status.Pass, "Test 61 Passed");
            extent.Flush();

            // test 62
            // Enterring 5.00 for the amount
            driver.FindElement(By.Id("Amount")).SendKeys("5.00");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring 5.00 for the amount");
            test.Log(Status.Pass, "Test 62 Passed");
            extent.Flush();

            // Test 63
            // Enterring the reference number 12345678A
            driver.FindElement(By.Id("Reference"));

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the reference number 12345678A");
            test.Log(Status.Pass, "Test 63 Passed");
            extent.Flush();

            // Test 64
            // Clicking the filter button
            driver.FindElement(By.Id("btnFilter")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the filter button");
            test.Log(Status.Pass, "Test 64 Passed");
            extent.Flush();

            // Test 65
            // Clicking the Edit Applicant button
            driver.FindElement(By.LinkText("Edit Applicant")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Edit Applicant button");
            test.Log(Status.Pass, "Test 65 Passed");
            extent.Flush();

            // Test 66
            // Clicking the back button
            driver.FindElement(By.LinkText("Back")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Back button");
            test.Log(Status.Pass, "Test 66 Passed");
            extent.Flush();

            // Test 67
            // Clicking the Remove Applicant button
            driver.FindElement(By.LinkText("Remove Applicant")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Remove Applicant button");
            test.Log(Status.Pass, "Test 67 Passed");
            extent.Flush();

            // Test 68
            // Clicking the Office ID and selecting liverpool from the dropdown.
            driver.FindElement(By.Id("OfficeId")).Click();

            dropdown = driver.FindElement(By.Id("OfficeId"));
            dropdown.FindElement(By.XPath("//option[. = 'Liverpool']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Office ID and selecting liverpool from the dropdown.");
            test.Log(Status.Pass, "Test 68 Passed");
            extent.Flush();

            // Test 69
            // Clicking the filter button
            driver.FindElement(By.Id("btnFilter")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the filter button");
            test.Log(Status.Pass, "Test 69 Passed");
            extent.Flush();

            // Test 70
            // Clicking the Add Applicant button
            driver.FindElement(By.LinkText("Add Applicant")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Add Applicant button");
            test.Log(Status.Pass, "Test 70 Passed");
            extent.Flush();

            // Test 71
            // Enterring test in the name field
            driver.FindElement(By.Id("Name")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring test in the name field");
            test.Log(Status.Pass, "Test 71 Passed");
            extent.Flush();

            // Test 72
            // Enterring 12345678A in the Reference field
            driver.FindElement(By.Id("Reference")).SendKeys("12345678A");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring 12345678A in the Reference field");
            test.Log(Status.Pass, "Test 72 Passed");
            extent.Flush();

            // Test 73
            // Enterring 10.00 in the Amount field
            driver.FindElement(By.Id("Amount")).SendKeys("3.00");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring 10.00 in the Amount field");
            test.Log(Status.Pass, "Test 73 Passed");
            extent.Flush();

            // Test 74
            // Clicking the Filter button
            driver.FindElement(By.Id("btnFilter")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Filter button");
            test.Log(Status.Pass, "Test 74 Passed");
            extent.Flush();

            // Test 75
            // Clicking the Filter button
            driver.FindElement(By.Id("btnFilter")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Filter button");
            test.Log(Status.Pass, "Test 75 Passed");
            extent.Flush();

            // Test 76
            // Clicking the Filter button
            driver.FindElement(By.Id("btnFilter")).Click();
            driver.FindElement(By.Id("btnFilter")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Filter button");
            test.Log(Status.Pass, "Test 76 Passed");
            extent.Flush();

            // Test 77
            // Enterring the Card number 4111 1111 4555 1142
            driver.FindElement(By.Id("CardNumber")).SendKeys("4111 1111 4555 1142");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the Card number 4111 1111 4555 1142");
            test.Log(Status.Pass, "Test 77 Passed");
            extent.Flush();

            // Test 78
            // Enterring the Expiry Date 03/22
            driver.FindElement(By.Id("ExpiryDate")).SendKeys("03/22");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the Expiry Date 03/22");
            test.Log(Status.Pass, "Test 78 Passed");
            extent.Flush();

            // Test 79
            // Enterring the CV2 712
            driver.FindElement(By.Id("CV2")).SendKeys("712");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the CV2 712");
            test.Log(Status.Pass, "Test 79 Passed");
            extent.Flush();

            // Test 81
            // Enterring test for the card holder field
            driver.FindElement(By.Id("CardHolder")).SendKeys("Test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring test for the card holder field");
            test.Log(Status.Pass, "Test 81 Passed");
            extent.Flush();

            // Test 82
            // Enterring 02/20 for the Valid From Date
            driver.FindElement(By.Id("ValidFromDate")).SendKeys("02/20");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring 02/20 for the Valid From Date");
            test.Log(Status.Pass, "Test 82 Passed");
            extent.Flush();

            // Test 83
            // Enterring 12 for the Issue No
            driver.FindElement(By.Id("IssueNo")).SendKeys("12");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring 12 for the Issue No");
            test.Log(Status.Pass, "Test 83 Passed");
            extent.Flush();

            // Test 84
            // Clicking the Filter button
            driver.FindElement(By.Id("btnFilter")).Click();
            driver.FindElement(By.Id("btnFilter")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Filter button");
            test.Log(Status.Pass, "Test 84 Passed");
            extent.Flush();

            // Test 85
            // Clicking the contact button to view the contact
            driver.FindElement(By.CssSelector(".script-stage:nth-child(2) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the contact button to view the contact");
            test.Log(Status.Pass, "Test 85 Passed");
            extent.Flush();

            // Test 86
            // Clicking the continue/submit button
            driver.FindElement(By.Id("submit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue/submit button");
            test.Log(Status.Pass, "Test 86 Passed");
            extent.Flush();

            // Test 87
            // Clicking the progress enquiry button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(4) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the progress enquiry button");
            test.Log(Status.Pass, "Test 87 Passed");
            extent.Flush();

            // Test 88
            // Clicking the DateOfApplication and selecting the date
            driver.FindElement(By.Id("DateOfApplication")).Click();
            driver.FindElement(By.LinkText("4")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the DateOfApplication and selecting the date");
            test.Log(Status.Pass, "Test 88 Passed");
            extent.Flush();

            // Test 89
            // Selecting no after selecting the date of application
            driver.FindElement(By.Id("SearchAuthority_False")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting no after selecting the date of application");
            test.Log(Status.Pass, "Test 89 Passed");
            extent.Flush();


            // Test 90
            // Clicking the DateOfApplication and selecting the date
            driver.FindElement(By.Id("DateOfApplication")).Click();
            driver.FindElement(By.LinkText("1")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the DateOfApplication and selecting the date");
            test.Log(Status.Pass, "Test 90 Passed");
            extent.Flush();

            // test 91
            // Selecting yes after selecitng the date of application
            driver.FindElement(By.Id("SearchAuthority_True")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting yes after selecitng the date of application");
            test.Log(Status.Pass, "Test 91 Passed");
            extent.Flush();

            // Test 92
            // Entering the Application number 1234567899
            driver.FindElement(By.Id("ApplicationNumber")).SendKeys("1234567899");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the Application number 1234567899");
            test.Log(Status.Pass, "Test 92 Passed");
            extent.Flush();

            // test 93
            // Selecting the Date Of Birth
            driver.FindElement(By.Id("DateOfBirth")).Click();
            driver.FindElement(By.Id("DateOfBirth")).SendKeys("09/01/1999");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(5000);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Date Of Birth");
            test.Log(Status.Pass, "Test 93 Passed");
            extent.Flush();

            // Test 94
            // Clicking the search button
            driver.FindElement(By.CssSelector(".extraFields:nth-child(1)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the search button");
            test.Log(Status.Pass, "Test 94 Passed");
            extent.Flush();



            // Test 95
            // Clicking the decision trees button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(5) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the decision trees button");
            test.Log(Status.Pass, "Test 95 Passed");
            extent.Flush();

            // Test 96
            // Clicking the lost in transit button
            driver.FindElement(By.CssSelector("li:nth-child(1) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the lost in transit button");
            test.Log(Status.Pass, "Test 96 Passed");
            extent.Flush();

            // Test 97
            // Selecting YES for Did the applicant apply online through DCS?
            SelectRadioButtonWithIdStarting("Yes", driver);

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting YES for Did the applicant apply online through DCS?");
            test.Log(Status.Pass, "Test 97 Passed");
            extent.Flush();


            // Test 98
            // Selecting YES for Has the passport been sent by tracked mail?
            SelectRadioButtonWithIdStarting("No", driver);


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting YES for Has the passport been sent by tracked mail?");
            test.Log(Status.Pass, "Test 98 Passed");
            extent.Flush();

            // Test 99
            // Selecting YES for Have two working days elapsed since it was signed for by HMPO?
            SelectRadioButtonWithIdStarting("Yes", driver);


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting YES for Have two working days elapsed since it was signed for by HMPO?");
            test.Log(Status.Pass, "Test 99 Passed");
            extent.Flush();


            // Test 100
            // Clicking the reset button
            driver.FindElement(By.Id("btnReset")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the reset button");
            test.Log(Status.Pass, "Test 100 Passed");
            extent.Flush();

            // Test 101
            // Clicking the back button
            driver.FindElement(By.LinkText("Back")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the back button");
            test.Log(Status.Pass, "Test 101 Passed");
            extent.Flush();

            // Test 102
            // Clicking the Nationality Check button
            driver.FindElement(By.CssSelector("li:nth-child(2) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Nationality Check button");
            test.Log(Status.Pass, "Test 102 Passed");
            extent.Flush();

            // test 103
            // Selecting the datre of birth

            driver.FindElement(By.Name("DateOfBirth")).Click();
            driver.FindElement(By.Name("DateOfBirth")).SendKeys("09/01/1990");

            //driver.FindElement(By.LinkText("7")).Click();

            driver.FindElement(By.CssSelector(".script")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the datre of birth");
            test.Log(Status.Pass, "Test 103 Passed");
            extent.Flush();

            // Test 104
            // Selecting Yes for Was the applicant born in the UK?
            //driver.FindElement(By.Id("Yes_a2c6aacf-96d0-4db1-a9a4-f766c5b33786")).Click();
            SelectRadioButtonWithIdStarting("Yes", driver);

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Yes for Was the applicant born in the UK?");
            test.Log(Status.Pass, "Test 104 Passed");
            extent.Flush();

            // Test 105
            // Selecting Yes for Was mother British at time of birth?
            SelectRadioButtonWithIdStarting("Yes", driver);

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Yes for Was mother British at time of birth");
            test.Log(Status.Pass, "Test 105 Passed");
            extent.Flush();

            // Test 108
            // Clicking the reset button
            driver.FindElement(By.Id("btnReset")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the reset button");
            test.Log(Status.Pass, "Test 108 Passed");
            extent.Flush();

            // Test 109
            // Clicking the back button
            driver.FindElement(By.LinkText("Back")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the back button");
            test.Log(Status.Pass, "Test 109 Passed");
            extent.Flush();

            // Test 110
            // Clicking the Parent Check button
            driver.FindElement(By.CssSelector("li:nth-child(3) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Parent Check button");
            test.Log(Status.Pass, "Test 110 Passed");
            extent.Flush();

            // Test 111
            // Selecting No for Was the applicant born after 31.12.1982?
            SelectRadioButtonWithIdStarting("No", driver);

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting No for Was the applicant born after 31.12.1982?");
            test.Log(Status.Pass, "Test 111 Passed");
            extent.Flush();

            // Test 112
            // Selecting No for Was the applicant born after 31.12.1982?
            SelectRadioButtonWithIdStarting("No", driver);

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting No for Was the applicant born after 31.12.1982?");
            test.Log(Status.Pass, "Test 112 Passed");
            extent.Flush();

            // Test 113
            // Selecting Yes for Was the applicant born after 31.12.1982?
            SelectRadioButtonWithIdStarting("Yes", driver);

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Yes for Was the applicant born after 31.12.1982?");
            test.Log(Status.Pass, "Test 113 Passed");
            extent.Flush();


            // Test 114
            // Clicking the back button
            driver.FindElement(By.LinkText("Back")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the back button");
            test.Log(Status.Pass, "Test 114 Passed");
            extent.Flush();

            // Test 115
            // Clicking the Upgrade check button
            driver.FindElement(By.CssSelector("li:nth-child(4) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Upgrade check button");
            test.Log(Status.Pass, "Test 115 Passed");
            extent.Flush();

            // Test 116
            // Selecting Yes for Has the customer already requested an upgrade?
            SelectRadioButtonWithIdStarting("Yes", driver);

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Yes for Has the customer already requested an upgrade?");
            test.Log(Status.Pass, "Test 116 Passed");
            extent.Flush();

            // Test 117
            // Selecting No for Is this a DCS application?
            SelectRadioButtonWithIdStarting("No", driver);

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Is this a DCS application?");
            test.Log(Status.Pass, "Test 117 Passed");
            extent.Flush();

            // Test 118
            // Selecting Yes for Has HMPO requested further documents?
            SelectRadioButtonWithIdStarting("Yes", driver);

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Yes for Has HMPO requested further documents?");
            test.Log(Status.Pass, "Test 118 Passed");
            extent.Flush();

            // Test 119
            // Selecting Yes for Has the applicant sent in all required documents?
            SelectRadioButtonWithIdStarting("Yes", driver);

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Yes for Has the applicant sent in all required documents?");
            test.Log(Status.Pass, "Test 119 Passed");
            extent.Flush();

            // Test 120
            // Selecting Yes for Did the applicant use tracked mail?
            SelectRadioButtonWithIdStarting("Yes", driver);

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Yes for Did the applicant use tracked mail?");
            test.Log(Status.Pass, "Test 120 Passed");
            extent.Flush();

            // Test 121
            // Selecting Yes for Have two working days elapsed since it was signed for by HMPO?
            SelectRadioButtonWithIdStarting("Yes", driver);

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting Yes for  Have two working days elapsed since it was signed for by HMPO?");
            test.Log(Status.Pass, "Test 121 Passed");
            extent.Flush();

            // Test 122
            // Clicking the back button
            driver.FindElement(By.LinkText("Back")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the back button");
            test.Log(Status.Pass, "Test 122 Passed");
            extent.Flush();

            // Test 123
            // Clicking the fulfilment button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(6) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the fulfilment button");
            test.Log(Status.Pass, "Test 123 Passed");
            extent.Flush();

            // Test 124
            // Selecting the Title
            driver.FindElement(By.Id("SelectedTitle_ID")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Title");
            test.Log(Status.Pass, "Test 124 Passed");
            extent.Flush();

            // test 125
            // Selecting the Firstname
            driver.FindElement(By.Id("Firstname")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Firstname");
            test.Log(Status.Pass, "Test 125 Passed");
            extent.Flush();

            // Test 126
            // Selecting the Lastname
            driver.FindElement(By.Id("Lastname")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Lastname");
            test.Log(Status.Pass, "Test 126 Passed");
            extent.Flush();

            // Test 127
            // Selecting the telephone number
            driver.FindElement(By.Id("TelephoneNumberViewModel_TelephoneNumber")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the telephone number");
            test.Log(Status.Pass, "Test 127 Passed");
            extent.Flush();

            // Test 128
            // Enterring the email address
            driver.FindElement(By.Id("EmailAddressViewModel_EmailAddress")).SendKeys("123@gmail.com");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Sending the keys for the email address");
            test.Log(Status.Pass, "Test 128 Passed");
            extent.Flush();

            // Test 129
            // Enterring the address line 1
            driver.FindElement(By.Id("PrimaryAddress_AddressLine1")).SendKeys("20 Av. Halley, 59650 Villeneuve-d\'Ascq, France");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Sending the keys for the address line 1");
            test.Log(Status.Pass, "Test 129 Passed");
            extent.Flush();

            // Test 130
            // Enterring the postal town
            driver.FindElement(By.Id("PrimaryAddress_PostalTown")).SendKeys("59650 Villeneuve-d\'Ascq");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the postal town");
            test.Log(Status.Pass, "Test 130 Passed");
            extent.Flush();

            // Test 131
            // Enterring the postcode
            driver.FindElement(By.Id("PrimaryAddress_Postcode"));

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the postcode");
            test.Log(Status.Pass, "Test 131 Passed");
            extent.Flush();

            // Test 132
            // Selecting the address line 1
            driver.FindElement(By.Id("PrimaryAddress_AddressLine1")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the address line 1");
            test.Log(Status.Pass, "Test 132 Passed");
            extent.Flush();


            // Test 133
            // Clicking the continue button
            driver.FindElement(By.CssSelector("fieldset:nth-child(4) > .field-holder:nth-child(2) > label")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 133 Passed");
            extent.Flush();

            // Test 134
            // Clicking the continue button
            driver.FindElement(By.CssSelector("fieldset:nth-child(4) > .field-holder:nth-child(3) > label")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 134 Passed");
            extent.Flush();

            // Test 135
            // Selecting the postal town
            driver.FindElement(By.Id("PrimaryAddress_PostalTown")).Click();
            driver.FindElement(By.Id("PrimaryAddress_PostalTown")).Click();
            driver.FindElement(By.Id("PrimaryAddress_PostalTown")).Click();
            {
                var element = driver.FindElement(By.Id("PrimaryAddress_PostalTown"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }
            driver.FindElement(By.Id("PrimaryAddress_PostalTown")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the postal town");
            test.Log(Status.Pass, "Test 135 Passed");
            extent.Flush();


            // Test 136
            // Selecting the postal county
            driver.FindElement(By.Id("PrimaryAddress_County")).Click();
            driver.FindElement(By.Id("PrimaryAddress_County")).Click();
            {
                var element = driver.FindElement(By.Id("PrimaryAddress_County"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }
            driver.FindElement(By.Id("PrimaryAddress_County")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the county");
            test.Log(Status.Pass, "Test 136 Passed");
            extent.Flush();

            // Test 137
            // Selecting the postcode
            driver.FindElement(By.Id("PrimaryAddress_Postcode")).Click();
            driver.FindElement(By.Id("PrimaryAddress_Postcode")).Click();
            {
                var element = driver.FindElement(By.Id("PrimaryAddress_Postcode"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }
            driver.FindElement(By.Id("PrimaryAddress_Postcode")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the postcode");
            test.Log(Status.Pass, "Test 137 Passed");
            extent.Flush();

            // Test 138
            // Clicking the submit button
            driver.FindElement(By.Id("submit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the submit button");
            test.Log(Status.Pass, "Test 138 Passed");
            extent.Flush();

            // Test 139
            // Selecting IsLargePrintRequired
            driver.FindElement(By.Id("IsLargePrintRequired")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting IsLargePrintRequired");
            test.Log(Status.Pass, "Test 139 Passed");
            extent.Flush();

            // Test 140
            // Selecting IsWelshRequired
            driver.FindElement(By.Id("IsWelshRequired")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting IsWelshRequired");
            test.Log(Status.Pass, "Test 140 Passed");
            extent.Flush();

            // Test 141
            // Un-selecting IsWelshRequired
            driver.FindElement(By.Id("IsWelshRequired")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Un-selecting IsWelshRequired");
            test.Log(Status.Pass, "Test 141 Passed");
            extent.Flush();

            // Test 142
            // Requesting ammount for Fulfilment Items and sending the keys
            driver.FindElement(By.Name("FulfilmentItems[0].AmountRequested")).Click();
            driver.FindElement(By.Name("FulfilmentItems[0].AmountRequested")).SendKeys("1");
            driver.FindElement(By.Name("FulfilmentItems[0].AmountRequested")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Requesting ammount for Fulfilment Items and sending the keys");
            test.Log(Status.Pass, "Test 142 Passed");
            extent.Flush();

            // Test 143
            // Clicking the submit button
            driver.FindElement(By.Id("submit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the submit button");
            test.Log(Status.Pass, "Test 143 Passed");
            extent.Flush();

            // Test 144
            // Clicking the locator button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(7) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the locator button");
            test.Log(Status.Pass, "Test 144 Passed");
            extent.Flush();


            // Test 145
            // Selecting the postcode
            driver.FindElement(By.Id("Postcode")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the postcode");
            test.Log(Status.Pass, "Test 145 Passed");
            extent.Flush();

            // Test 146
            // Selecting the Office Type and choosing regional from the dropdown.
            driver.FindElement(By.Id("SelectedType_ID")).Click();
            {
                dropdown = driver.FindElement(By.Id("SelectedType_ID"));
                dropdown.FindElement(By.XPath("//option[. = 'Regional']")).Click();
            }

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Office Type and choosing regional from the dropdown");
            test.Log(Status.Pass, "Test 146 Passed");
            extent.Flush();

            // Test 147
            driver.FindElement(By.CssSelector(".isValid:nth-child(1)")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Office Type and choosing regional from the dropdown");
            test.Log(Status.Pass, "Test 147 Passed");
            extent.Flush();

            // Test 148
            driver.FindElement(By.CssSelector(".script-stage:nth-child(8) > .icon")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Office Type and choosing regional from the dropdown");
            test.Log(Status.Pass, "Test 148 Passed");
            extent.Flush();


            // Test 149
            // Clicking the Apply For Passport button
            driver.FindElement(By.CssSelector("div:nth-child(1) > label > img")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Apply For Passport button");
            test.Log(Status.Pass, "Test 149 Passed");
            extent.Flush();

            // Test 150
            // Clicking the email text box
            driver.FindElement(By.Id("EmailAddress")).Click();
            driver.FindElement(By.Id("EmailAddress")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the email text box");
            test.Log(Status.Pass, "Test 150 Passed");
            extent.Flush();

            // Test 151
            // Clicking the Mobile Telephone Number text box
            driver.FindElement(By.Id("MobileTelephoneNumber")).Click();
            driver.FindElement(By.Id("MobileTelephoneNumber")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Mobile Telephone Number text box");
            test.Log(Status.Pass, "Test 151 Passed");
            extent.Flush();

            // Test 152
            // Clicking the Telephone Number text box and enterring 01616260900
            driver.FindElement(By.Id("TelephoneNumber")).Click();
            driver.FindElement(By.Id("TelephoneNumber")).Click();
            driver.FindElement(By.Id("TelephoneNumber")).Click();
            driver.FindElement(By.Id("TelephoneNumber")).SendKeys("01616260900");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Telephone Number text box and enterring 01616260900");
            test.Log(Status.Pass, "Test 152 Passed");
            extent.Flush();

            // Test 153
            // Clicking the submit button
            driver.FindElement(By.Id("submit")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the submit button");
            test.Log(Status.Pass, "Test 153 Passed");
            extent.Flush();

            // Test 154
            // Selecting active
            driver.FindElement(By.CssSelector(".active")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting active");
            test.Log(Status.Pass, "Test 154 Passed");
            extent.Flush();

            // Test 155
            // Clicking the Check and Send button
            driver.FindElement(By.CssSelector("div:nth-child(2) > label > img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Check and Send button");
            test.Log(Status.Pass, "Test 155 Passed");
            extent.Flush();


            // Test 156
            // Clicking the Apply by Post button
            driver.FindElement(By.CssSelector("div:nth-child(3) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Apply by Post button");
            test.Log(Status.Pass, "Test 156 Passed");
            extent.Flush();

            // Test 157
            // Clicking the Collective Passport Application button
            driver.FindElement(By.CssSelector("div:nth-child(4) > label > img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Collective Passport Application button");
            test.Log(Status.Pass, "Test 157 Passed");
            extent.Flush();

            // Test 158
            // Clicking the transfer button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(9) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the transfer button");
            test.Log(Status.Pass, "Test 158 Passed");
            extent.Flush();

            // Test 159
            // Clicking the create new button
            driver.FindElement(By.CssSelector("#ichTransferLink > img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the create new button");
            test.Log(Status.Pass, "Test 159 Passed");
            extent.Flush();

            // Test 160
            // Selecting the reason ID
            driver.FindElement(By.Id("Reason_ID")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the reason ID");
            test.Log(Status.Pass, "Test 160 Passed");
            extent.Flush();

            // Test 161
            // Selecting the reason ID and selecting Child Change of Name option from the dropdown 
            dropdown = driver.FindElement(By.Id("Reason_ID"));
            dropdown.FindElement(By.XPath("//option[. = 'Child Change of Name']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the reason ID and selecting Child Change of Name option from the dropdown");
            test.Log(Status.Pass, "Test 161 Passed");
            extent.Flush();

            // Test 162
            // Selecting the Initiate Transfer test box
            driver.FindElement(By.Id("InitiateTransfer")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Initiate Transfer test box");
            test.Log(Status.Pass, "Test 162 Passed");
            extent.Flush();

            // Test 163
            // Clicking the cancel transfer button
            driver.FindElement(By.Id("Cancel")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the cancel transfer button");
            test.Log(Status.Pass, "Test 163 Passed");
            extent.Flush();

            // Test 164
            // Entering the phone number and selecting the task ID and then clicking the confirm the callers response button
            driver.FindElement(By.CssSelector("input:nth-child(11)")).Click();
            driver.FindElement(By.Id("SelectedTaskId")).Click();
            driver.FindElement(By.Id("BtnProcessSelection")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the phone number and selecting the task ID and then clicking the confirm the callers response button");
            test.Log(Status.Pass, "Test 164 Passed");
            extent.Flush();

            // Test 165
            // Selecting notes text box and enterring test
            driver.FindElement(By.Id("Notes")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting notes text box and enterring test");
            test.Log(Status.Pass, "Test 165 Passed");
            extent.Flush();


            // Test 166
            // Selecting the callback telephone number
            driver.FindElement(By.Id("CallBackNumber_TelephoneNumber")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the callback telephone number");
            test.Log(Status.Pass, "Test 166 Passed");
            extent.Flush();

            // Test 167
            // Entering 1 for the Application Number
            driver.FindElement(By.Id("ffb9474c-12e3-4e79-aeb1-4afbf9c01df9")).SendKeys("1");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering 1 for the Application Number");
            test.Log(Status.Pass, "Test 167 Passed");
            extent.Flush();

            // Test 168
            // Selecting payment from the dropdown for Task Classification
            driver.FindElement(By.Id("TaskClassificationId")).Click();
            dropdown = driver.FindElement(By.Id("TaskClassificationId"));
            dropdown.FindElement(By.XPath("//option[. = 'Payment']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting payment from the dropdown for Task Classification");
            test.Log(Status.Pass, "Test 168 Passed");
            extent.Flush();

            // Test 169
            // Clicking the submit button
            driver.FindElement(By.Id("SubmitCreateUpdateTask")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the submit button");
            test.Log(Status.Pass, "Test 169 Passed");
            extent.Flush();

            // Test 170
            // Clicking the feedback button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(10) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the feedback button");
            test.Log(Status.Pass, "Test 170 Passed");
            extent.Flush();

            // Test 171
            // Clicking the Compliment button
            driver.FindElement(By.CssSelector(".imageRadio > label:nth-child(1)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Compliment button");
            test.Log(Status.Pass, "Test 171 Passed");
            extent.Flush();

            // Test 172
            // Selecting feedback category ID from the drop down
            driver.FindElement(By.Id("SelectedFeedbackCategoryId")).Click();

            dropdown = driver.FindElement(By.Id("SelectedFeedbackCategoryId"));
            dropdown.FindElement(By.XPath("//option[. = 'Call centre advice']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting feedback category ID from the drop down");
            test.Log(Status.Pass, "Test 172 Passed");
            extent.Flush();

            // Test 173
            // Entering This is a test for the feedback details
            driver.FindElement(By.Id("FeedbackDetails")).SendKeys("this is a test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering This is a test for the feedback details");
            test.Log(Status.Pass, "Test 173 Passed");
            extent.Flush();

            // Test 174
            // Clicking the continue button
            driver.FindElement(By.CssSelector("form")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the continue button");
            test.Log(Status.Pass, "Test 174 Passed");
            extent.Flush();

            // Test 175
            // Clicking the submit button
            driver.FindElement(By.CssSelector(".submit-button-container > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the submit button");
            test.Log(Status.Pass, "Test 175 Passed");
            extent.Flush();

            // Test 176
            // Clicking the feedback button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(10) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the feedback button");
            test.Log(Status.Pass, "Test 176 Passed");
            extent.Flush();

            // Test 177
            // clicked on the comment button to make a comment
            driver.FindElement(By.CssSelector("label:nth-child(2)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the feedback button");
            test.Log(Status.Pass, "Test 177 Passed");
            extent.Flush();

            // Test 178
            // Selecting feedback category ID from the drop down
            driver.FindElement(By.Id("SelectedFeedbackCategoryId")).Click();

            dropdown = driver.FindElement(By.Id("SelectedFeedbackCategoryId"));
            dropdown.FindElement(By.XPath("//option[. = 'General gratitude']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting feedback category ID from the drop down");
            test.Log(Status.Pass, "Test 178 Passed");
            extent.Flush();

            // Test 179
            // Enterring the feedback details
            driver.FindElement(By.Id("FeedbackDetails")).SendKeys("This is a test");


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the feedback details");
            test.Log(Status.Pass, "Test 179 Passed");
            extent.Flush();

            // Test 180
            // Clicking the submit button
            driver.FindElement(By.CssSelector(".submit-button-container > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the submit button");
            test.Log(Status.Pass, "Test 180 Passed");
            extent.Flush();

            // Test 181
            // Clicking the feedback button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(10) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the feedback button");
            test.Log(Status.Pass, "Test 181 Passed");
            extent.Flush();

            // Test 182
            // Clicking the Complaint button
            driver.FindElement(By.CssSelector("label:nth-child(3)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Complaint button");
            test.Log(Status.Pass, "Test 182 Passed");
            extent.Flush();

            // Test 183
            // Selecting feedback category ID from the drop down
            driver.FindElement(By.Id("SelectedFeedbackCategoryId")).Click();

            dropdown = driver.FindElement(By.Id("SelectedFeedbackCategoryId"));
            dropdown.FindElement(By.XPath("//option[. = 'Post Office']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting feedback category ID from the drop down");
            test.Log(Status.Pass, "Test 183 Passed");
            extent.Flush();

            // Test 184
            // Selecting the Feedback Response Method Id from the dropdown
            driver.FindElement(By.Id("SelectedFeedbackResponseMethodId")).Click();

            dropdown = driver.FindElement(By.Id("SelectedFeedbackResponseMethodId"));
            dropdown.FindElement(By.XPath("//option[. = 'Email']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Feedback Response Method Id from the dropdown");
            test.Log(Status.Pass, "Test 184 Passed");
            extent.Flush();

            // Test 185
            // Entering test for the applicant name
            driver.FindElement(By.Id("ApplicantName")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering test for the applicant name");
            test.Log(Status.Pass, "Test 185 Passed");
            extent.Flush();

            // Test 186
            // Entering 1234567 for the application number
            driver.FindElement(By.Id("ApplicationNumber")).SendKeys("1234567");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering 1234567 for the application number");
            test.Log(Status.Pass, "Test 186 Passed");
            extent.Flush();

            // Test 187
            driver.FindElement(By.CssSelector(".field-holder > .field-holder:nth-child(2) > label")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Pass, "Test 187 Passed");
            extent.Flush();

            // Test 188
            // Entering the feedback details
            driver.FindElement(By.Id("FeedbackDetails")).SendKeys("This is a test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Entering the feedback details");
            test.Log(Status.Pass, "Test 188 Passed");
            extent.Flush();

            // Test 189
            // Selecting the Feedback Agent Categorisation Id
            driver.FindElement(By.Id("SelectedFeedbackAgentCategorisationId")).Click();

            dropdown = driver.FindElement(By.Id("SelectedFeedbackAgentCategorisationId"));
            dropdown.FindElement(By.XPath("//option[. = 'HMPO policy/procedures']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Feedback Agent Categorisation Id");
            test.Log(Status.Pass, "Test 189 Passed");
            extent.Flush();

            // Test 190
            // Clicking the submit button
            driver.FindElement(By.CssSelector(".submit-button-container > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the submit button");
            test.Log(Status.Pass, "Test 190 Passed");
            extent.Flush();

            // Test 191
            // Clicking the Contact History button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(12) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Contact History button");
            test.Log(Status.Pass, "Test 191 Passed");
            extent.Flush();

            // Test 192
            // Clicking the Communications button to view all Communications
            driver.FindElement(By.LinkText("Communications")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Communications button to view all Communications");
            test.Log(Status.Pass, "Test 192 Passed");
            extent.Flush();

            // Test 193
            // Clicking the Fulfilments button to view all Fulfilments
            driver.FindElement(By.LinkText("Fulfilments")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Fulfilments button to view all Fulfilments");
            test.Log(Status.Pass, "Test 193 Passed");
            extent.Flush();

            // Test 194
            // Clicking the Feedbacks button to view all Feedbacks
            driver.FindElement(By.LinkText("Feedbacks")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Fulfilments button to view all Fulfilments");
            test.Log(Status.Pass, "Test 194 Passed");
            extent.Flush();

            // Test 195
            // Selecting a feedback to view all details for each feedback
            driver.FindElement(By.CssSelector(".initial-data:nth-child(1) > td:nth-child(2)")).Click();
            driver.FindElement(By.CssSelector(".ExpandedHistoryTop > td:nth-child(2)")).Click();
            driver.FindElement(By.CssSelector(".initial-data:nth-child(1) > td:nth-child(2)")).Click();
            driver.FindElement(By.CssSelector(".ExpandedHistoryTop > td:nth-child(2)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting a feedback to view all details for each feedback");
            test.Log(Status.Pass, "Test 195 Passed");
            extent.Flush();

            // Test 196
            // Clicking the transfers button to view all transfers
            driver.FindElement(By.LinkText("Transfers")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the transfers button to view all transfers");
            test.Log(Status.Pass, "Test 196 Passed");
            extent.Flush();

            // Test 197
            // Selecting a transfer to view all details for each transfer that has been made
            driver.FindElement(By.CssSelector(".initial-data > td:nth-child(1)")).Click();
            driver.FindElement(By.CssSelector(".initial-data > td:nth-child(1)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting a transfer to view all details for each transfer that has been made");
            test.Log(Status.Pass, "Test 197 Passed");
            extent.Flush();

            // Test 198
            // Clicking the Tasks button
            driver.FindElement(By.LinkText("Tasks")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Tasks button");
            test.Log(Status.Pass, "Test 198 Passed");
            extent.Flush();

            /*
            // Test 199
            // Selecting a Task to view all details for each Task
            driver.FindElement(By.CssSelector("td:nth-child(2)")).Click();
            driver.FindElement(By.CssSelector("td:nth-child(2)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting a Task to view all details for each Task");
            test.Log(Status.Pass, "Test 199 Passed");
            extent.Flush();
            */

            // Test 200
            // Clicking the Payments button
            driver.FindElement(By.LinkText("Payments")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Payments button");
            test.Log(Status.Pass, "Test 200 Passed");
            extent.Flush();

            // Test 201
            // Selecting a Payment to view all details for each Payment that has been made
            driver.FindElement(By.CssSelector(".initial-data > td:nth-child(1)")).Click();
            driver.FindElement(By.CssSelector(".initial-data > td:nth-child(1)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting a Payment to view all details for each Payment that has been made");
            test.Log(Status.Pass, "Test 201 Passed");
            extent.Flush();

            // Test 202
            // Clicking the surveys button to view all surveys
            driver.FindElement(By.LinkText("Surveys")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the surveys button to view all surveys");
            test.Log(Status.Pass, "Test 202 Passed");
            extent.Flush();

            // Test 203
            // Clicking the Email/Chat button to view all Emails/Chats
            driver.FindElement(By.LinkText("Email/Chat")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Email/Chat button to view all Emails/Chats");
            test.Log(Status.Pass, "Test 203 Passed");
            extent.Flush();

            // Test 204
            // Clicking the OAB button
            driver.FindElement(By.LinkText("OAB")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the OAB button");
            test.Log(Status.Pass, "Test 204 Passed");
            extent.Flush();

            // Test 205
            // Clicking the IAB button
            driver.FindElement(By.LinkText("IAB")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the 1AB button");
            test.Log(Status.Pass, "Test 205 Passed");
            extent.Flush();

            // Test 206
            // Clicking the finish button
            driver.FindElement(By.CssSelector(".script-stage:nth-child(13) > .icon")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the Finish button");
            test.Log(Status.Pass, "Test 206 Passed");
            extent.Flush();

            // Test 207
            // Selecting the DAP Result from the dropdown
            driver.FindElement(By.Id("SelectedDAPResult")).Click();

            dropdown = driver.FindElement(By.Id("SelectedDAPResult"));
            dropdown.FindElement(By.XPath("//option[. = 'YES']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the DAP Result from the dropdown");
            test.Log(Status.Pass, "Test 207 Passed");
            extent.Flush();

            // Test 208
            // Selecting the Pre Application Result from the dropdown
            dropdown = driver.FindElement(By.Id("SelectedPreApplicationResult"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("YES");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Pre Application Result from the dropdown");
            test.Log(Status.Pass, "Test 208 Passed");
            extent.Flush();

            // Test 209
            // Selecting the Outcome ID from the dropdown
            dropdown = driver.FindElement(By.Id("SelectedOutcome_ID"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("UK Advice");


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Outcome ID from the dropdown");
            test.Log(Status.Pass, "Test 209 Passed");
            extent.Flush();

            // Test 210
            // Selecting the Outcome ID from the dropdown
            driver.FindElement(By.Id("SelectedChildOutcome_ID1")).Click();

            dropdown = driver.FindElement(By.Id("SelectedChildOutcome_ID1"));
            dropdown.FindElement(By.XPath("//option[. = 'Sign on Receipt']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Outcome ID from the dropdown");
            test.Log(Status.Pass, "Test 210 Passed");
            extent.Flush();

            // test 211
            // Selecting the Child Outcome ID2
            dropdown = driver.FindElement(By.Id("SelectedChildOutcome_ID2"));

            selectElement = new SelectElement(dropdown);
            selectElement.SelectByText("Advice");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the Child Outcome ID2");
            test.Log(Status.Pass, "Test 211 Passed");
            extent.Flush();


            // Test 212
            // Enterring test for the notes
            driver.FindElement(By.Id("Notes")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring test for the notes");
            test.Log(Status.Pass, "Test 212 Passed");
            extent.Flush();

            // Test 213
            // Clicking the submit button
            driver.FindElement(By.CssSelector(".submit-button-container > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the submit button");
            test.Log(Status.Pass, "Test 213 Passed");
            extent.Flush();


            // quit driver after all tests completed
            driver.Quit();
        }

        // Creating a public static method for the radio buttons and creating a for each loop to get the attribute ID for the radio buttons
        public static void SelectRadioButtonWithIdStarting(string Id, IWebDriver driver)
        {
            var elements = driver.FindElements(By.XPath("//input[@type='radio']"));
            var isClicked = false;

            foreach (var item in elements)
            {
                if (item.Displayed && item.Enabled && isClicked == false)
                {
                    var radio = item.GetAttribute("id");
                    if (radio.StartsWith(Id))
                    {
                        item.Click();
                        isClicked = true;
                    }
                }
            }
            NUnit.Framework.Assert.IsTrue(isClicked);
        }
    }
}

