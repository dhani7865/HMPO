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
    public static class OfficeManagementTest
    {
        private static double maxWaitSeconds;
        private static object byLocatorType;
        private static IWebElement element;

        public static void OfficeManagement(IWebDriver driver, ExtentReports extent)
        {
            var test = extent.CreateTest("HMPO - Office Management Page Test").Info("Test Started");

            // Test 1
            // Openning the tp oxygen hmpo and setting the window size
            driver.Navigate().GoToUrl("https://tpoxygen-hmpo-pal-qa/");
            driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "HMPO QA Oxygon Launched");
            test.Log(Status.Pass, "Test 1 Passed");
            extent.Flush();

            // Test 2
            // Clicking on the Office Management button
            driver.FindElement(By.CssSelector("li:nth-child(6) img")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking on the next contact history button");
            test.Log(Status.Pass, "Test 2 Passed");
            extent.Flush();

            // Test 3
            // Enterring test for the office name
            driver.FindElement(By.Id("OfficeName")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring test for the office name");
            test.Log(Status.Pass, "Test 3 Passed");
            extent.Flush();

            // Test 4
            // Selecting the office type ID
            driver.FindElement(By.Id("OfficeTypeID")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the office type ID");
            test.Log(Status.Pass, "Test 4 Passed");
            extent.Flush();

            // Test 5
            // Selecting the page size
            driver.FindElement(By.Id("Pagesize")).Click();
            driver.FindElement(By.Id("Pagesize")).Click();


            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the page size");
            test.Log(Status.Pass, "Test 5 Passed");
            extent.Flush();

            // Test 6
            // Clicking the filter button
            driver.FindElement(By.Id("btnFilter")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the filter button");
            test.Log(Status.Pass, "Test 6 Passed");
            extent.Flush();


            // Test 7
            // Clicking the add new office button to create a new office
            driver.FindElement(By.LinkText("Add New Office")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Clicking the add new office button to create a new office");
            test.Log(Status.Pass, "Test 7 Passed");
            extent.Flush();

            // Test 8
            // Selecting the office type ID from the dropdown
            driver.FindElement(By.Id("OfficeTypeId")).Click();

            var dropdown = driver.FindElement(By.Id("OfficeTypeId"));
            dropdown.FindElement(By.XPath("//option[. = 'Post office']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the office type ID from the dropdown");
            test.Log(Status.Pass, "Test 8 Passed");
            extent.Flush();

            // Test 9
            // Enterring test for the value
            driver.FindElement(By.Id("Value")).SendKeys("Test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring test for the value");
            test.Log(Status.Pass, "Test 9 Passed");
            extent.Flush();

            // Test 10
            // Enterring the address line 1
            driver.FindElement(By.Id("Address_AddressLine1")).SendKeys("Tyne River House, The Watermark, Gateshead NE11 9SZ");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the address line 1");
            test.Log(Status.Pass, "Test 10 Passed");
            extent.Flush();

            // Test 11
            // Enterring the address line 2
            driver.FindElement(By.Id("Address_AddressLine2")).SendKeys("Tyne River House, The Watermark");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the address line 2");
            test.Log(Status.Pass, "Test 11 Passed");
            extent.Flush();

            // Test 12
            // Enterring the postal town
            driver.FindElement(By.Id("Address_PostalTown")).SendKeys("Gateshead");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the postal town");
            test.Log(Status.Pass, "Test 12 Passed");
            extent.Flush();

            // Test 13
            // Enterring the postcode
            driver.FindElement(By.Id("Address_Postcode")).SendKeys("NE11 9SZ");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the postcode");
            test.Log(Status.Pass, "Test 13 Passed");
            extent.Flush();

            // Test 14
            // Selecting the postal town
            driver.FindElement(By.Id("Address_PostalTown")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Enterring the postaltown");
            test.Log(Status.Pass, "Test 14 Passed");
            extent.Flush();

            // Test 15
            // Selecting the address county
            driver.FindElement(By.Id("Address_County")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Info, "Selecting the address county");
            test.Log(Status.Pass, "Test 15 Passed");
            extent.Flush();

            // Test 16
            driver.FindElement(By.CssSelector("p:nth-child(10)")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Pass, "Test 16 Passed");
            extent.Flush();

            // Test 17
            driver.FindElement(By.CssSelector(".field-holder:nth-child(8) > .forCheckbox")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            // Logging the test in the extent report and pass status
            test.Log(Status.Pass, "Test 17 Passed");
            extent.Flush();

            // Test 17
            // Selecting is active
            driver.FindElement(By.Id("isActive")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            test.Log(Status.Info, "Selecting is active");
            // Logging the test in the extent report and pass status
            test.Log(Status.Pass, "Test 18 Passed");
            extent.Flush();

            // Test 19
            // Clicking the submit button
            driver.FindElement(By.CssSelector(".submit-button-container > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            test.Log(Status.Info, "Clicking the submit button");
            // Logging the test in the extent report and pass status
            test.Log(Status.Pass, "Test 19 Passed");
            extent.Flush();

            // Test 20
            // Enterring test for the office name
            driver.FindElement(By.Id("OfficeName")).SendKeys("test");

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            test.Log(Status.Info, "Enterring test for the office name");
            // Logging the test in the extent report and pass status
            test.Log(Status.Pass, "Test 20 Passed");
            extent.Flush();

            // Test 21
            // Selecting the office ID from the dropdown
            driver.FindElement(By.Id("OfficeTypeID")).Click();

            dropdown = driver.FindElement(By.Id("OfficeTypeID"));
            dropdown.FindElement(By.XPath("//option[. = '(All Office Types)']")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            test.Log(Status.Info, "Selecting the office ID from the dropdown");
            // Logging the test in the extent report and pass status
            test.Log(Status.Pass, "Test 21 Passed");
            extent.Flush();

            // Test 22
            // Clicking the filter button
            driver.FindElement(By.Id("btnFilter")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            test.Log(Status.Info, "Clicking the filter button");
            // Logging the test in the extent report and pass status
            test.Log(Status.Pass, "Test 22 Passed");
            extent.Flush();

            // Test 23
            // Clicking the Edit details button
            driver.FindElement(By.LinkText("Edit Details")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            test.Log(Status.Info, "Clicking the Edit details button");
            // Logging the test in the extent report and pass status
            test.Log(Status.Pass, "Test 23 Passed");
            extent.Flush();

            // Test 24
            // Clicking the submit button
            driver.FindElement(By.CssSelector(".submit-button-container > input")).Click();

            // 5 seconds implicit wait (C# code)
            System.Threading.Thread.Sleep(500);
            test.Log(Status.Info, "Clicking the submit button");
            // Logging the test in the extent report and pass status
            test.Log(Status.Pass, "Test 23 Passed");
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

