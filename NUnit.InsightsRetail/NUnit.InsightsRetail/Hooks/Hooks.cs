﻿using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NUnit.InsightsRetail.Hooks
{
    [Binding]
    public class Hooks
    {
        private ExtentTest featureName;
        private ExtentTest scenario;
        private static ExtentReports extent;               
        private IObjectContainer _objectContainer;
        public IWebDriver _driver;
        FeatureContext _featurecontext;
        ScenarioContext _scenarioContext;

        //
        public Hooks(IObjectContainer objectContainer, FeatureContext featurecontext, ScenarioContext scenarioContext)
        {
            _objectContainer = objectContainer;
            this._featurecontext = featurecontext;
            this._scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            InsightsRetail_TestIter intr = null;
            intr = new InsightsRetail_TestIter("chrome");
            _driver = intr.eveDriver;
            _objectContainer.RegisterInstanceAs(_driver);
            this.featureName = extent.CreateTest<Feature>(this._featurecontext.FeatureInfo.Title);
            this.scenario = featureName.CreateNode<Scenario>(this._scenarioContext.ScenarioInfo.Title);

        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }

        [BeforeTestRun]
       public static void InitializeReport()
       {
           extent = new ExtentReports();
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
            //featureName = extent.CreateTest<Feature>(ftr.FeatureInfo.Title);
        }

        [AfterStep]
       public void InsertReportingSteps()
       {
             //this.featureName = extent.CreateTest<Feature>(this._featurecontext.FeatureInfo.Title);
             //this.scenario = featureName.CreateNode<Scenario>(this._scenarioContext.ScenarioInfo.Title);
             var stepType = this._scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            

              PropertyInfo pInfo = typeof(ScenarioContext).GetProperty("ScenarioExecutionStatus", BindingFlags.Instance | BindingFlags.Public);
              MethodInfo getter = pInfo.GetGetMethod(nonPublic: true);
              object TestResult = getter.Invoke(this._scenarioContext, null);
            

              if (this._scenarioContext.TestError == null)
             {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(this._scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(this._scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(this._scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(this._scenarioContext.StepContext.StepInfo.Text);
             }
             else if (this._scenarioContext.TestError != null)
             {
                 if (stepType == "Given")
                     scenario.CreateNode<Given>(this._scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.InnerException);
                 else if (stepType == "When")
                     scenario.CreateNode<When>(this._scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.InnerException);
                 else if (stepType == "Then")
                     scenario.CreateNode<Then>(this._scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message);
             }

          
/*
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
*/
        }
    }

   enum BrowserType
   {
       Chrome,
       Firefox,
       IE
    }
}
