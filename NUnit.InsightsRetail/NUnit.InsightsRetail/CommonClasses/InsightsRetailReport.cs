﻿using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using System.IO;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Threading;
using TechTalk.SpecFlow;

namespace NUnit.InsightsRetail.CommonClasses
{
    /*
    [Binding]
    public sealed class InsightsRetailReport
    {
            public static IWebDriver driver;
            private static ExtentReports _extent;
            private static ExtentTest _test;

            
            [BeforeTestRun]
            public static void BeforeClass()
            {
                try
                {
                    _extent = new ExtentReports();
                    var dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug","");
                    DirectoryInfo di = Directory.CreateDirectory(dir + "\\Test_Execution_Reports");
                    var htmlReporter = new ExtentHtmlReporter(dir + "\\Test_Execution_Reports" + "\\Automation_Report" + ".html");
                    _extent.AddSystemInfo("Environment", "Journey of Quality");
                    _extent.AddSystemInfo("User Name", "Suresh");
                    _extent.AttachReporter(htmlReporter);
                }
                catch (Exception e)
                {
                    throw (e);
                }                
            }
 
            [SetUp]
            public void BeforeTest()
            {
                try
                {
                    _test = _extent.CreateTest(TestContext.CurrentContext.Test.Name);
                }
                catch (Exception e)
                {
                    throw (e);
                }
            }

          
            [AfterTestRun]
            public static void AfterTest()
            {
                try
                {
                
                    var status = TestContext.CurrentContext.Result.Outcome.Status;
                    var stacktrace = "" +TestContext.CurrentContext.Result.StackTrace + "";
                    var errorMessage = TestContext.CurrentContext.Result.Message;
                    Status logstatus;
                    switch (status)
                    {
                        case TestStatus.Failed:
                            logstatus = Status.Fail;
                            string screenShotPath = Capture(driver, TestContext.CurrentContext.Test.Name);
                            _test.Log(logstatus, "Test ended with " +logstatus + " – " +errorMessage);
                            _test.Log(logstatus, "Snapshot below: " +_test.AddScreenCaptureFromPath(screenShotPath));
                            break;
                        case TestStatus.Skipped:
                            logstatus = Status.Skip;
                            _test.Log(logstatus, "Test ended with " +logstatus);
                            break;
                        default:
                            logstatus = Status.Pass;
                            _test.Log(logstatus, "Test ended with " +logstatus);
                            break;
                    }
                 
                }
                catch (Exception e)
                {
                    throw (e);
                }
            }

          
            [OneTimeTearDown]
            public void AfterClass()
            {
                try
                {
                    _extent.Flush();
                }
                catch (Exception e)
                {
                    throw (e);
                }
               
            }

            private static string Capture(IWebDriver driver, string screenShotName)
            {
                string localpath = ""; 
            
                try
                {

                    Thread.Sleep(4000);
                    ITakesScreenshot ts = (ITakesScreenshot)driver;
                    Screenshot screenshot = ts.GetScreenshot();
                    string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
                    var dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
                    DirectoryInfo di = Directory.CreateDirectory(dir + "\\Defect_Screenshots\\");
                    string finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "\\Defect_Screenshots\\" +screenShotName + ".png";
                    localpath = new Uri(finalpth).LocalPath;
                    screenshot.SaveAsFile(localpath);

                }
                catch (Exception e)
                {
                    throw (e);
                }

                return localpath;
        }
    }
  */
}

