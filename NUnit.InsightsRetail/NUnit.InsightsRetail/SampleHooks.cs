using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Reflection;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;
using System;
using NUnit.InsightsRetail.Steps;
using NUnit.Framework;

namespace NUnit.InsightsRetail
{
    [Binding]
    public class SampleHooks
    {
        /*
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        private static ExtentKlovReporter klov;
        //private readonly IObjectContainer _objectContainer;
        private MyEventFiringWebDriver _driver;
        ReportSteps stps;
        InsightsRetail_TestIter testIter;


        [BeforeTestRun]
        public static void InitializeReport()
        {
            //Initialize Extent report before test starts
            //var htmlReporter = new ExtentHtmlReporter(@"C:\Automation_Results\InsightsRetail\Test_Execution_Reports\ExtentReport.html");
            //htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            //htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            //Attach report to reporter
            //extent = new ExtentReports();
            //klov = new ExtentKlovReporter();

            // klov.InitMongoDbConnection("localhost", 27017);

            //klov.ProjectName = "ExecuteAutomation Test";

            // URL of the KLOV server
            //klov.InitKlovServerConnection("http://localhost:5689");
            //klov.ReportName = "Suresh" + DateTime.Now.ToString();
            //extent.AttachReporter(htmlReporter, klov);

            extent = new ExtentReports();
            //var htmlReporter = new ExtentHtmlReporter(dir + "\\Test_Execution_Reports" + "\\Automation_Report" + ".html");
            var htmlReporter = new ExtentHtmlReporter(@"C:\Automation_Results\InsightsRetail\Test_Execution_Reports\ExtentReport.html");
            extent.AddSystemInfo("Environment", "Journey of Quality");
            extent.AddSystemInfo("User Name", "Suresh");
            extent.AttachReporter(htmlReporter);


        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            //Flush report once test completes
            extent.Flush();
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            //Create dynamic feature name
            //featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        }

        [AfterStep]
        public void InsertReportingSteps()
        {
            /*
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            PropertyInfo pInfo = typeof(ScenarioContext).GetProperty("TestStatus", BindingFlags.Instance | BindingFlags.NonPublic);
            MethodInfo getter = pInfo.GetGetMethod(nonPublic: true);
            object TestResult = getter.Invoke(ScenarioContext.Current, null);

            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
            }

            //Pending Status
            if (TestResult.ToString() == "StepDefinitionPending")
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");

            }
            
        }

        [BeforeScenario]
        public void Initialize()
        {
            testIter = null;
            testIter = new InsightsRetail_TestIter("chrome");\
            
            //SelectBrowser(BrowserType.Chrome);
            //Create dynamic scenario name
            //Scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        

        [AfterScenario]
        public void CleanUp()
        {
            testIter.eveDriver.Quit();
            testIter.eveDriver.Close();
        }
        
        /*
        internal void SelectBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:                   
                    string Browser = "chrome";
                    testiter = new InsightsRetail_TestIter(Browser);
                    this._driver = testiter.eveDriver;                   
                    break;

                case BrowserType.Firefox:                   
                    break;

                case BrowserType.IE:
                    break;

                default:
                    break;
            }
        }
        
    }

    enum BrowserType
    {
        Chrome,
        Firefox,
        IE

    */
    }
}
   
  


