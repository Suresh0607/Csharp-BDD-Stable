using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NUnit.InsightsRetail.Hooks
{
    [Binding]
    public class DriverSetup
    {
      /*
        private IObjectContainer _objectContainer;
        public IWebDriver _driver;
        
        //
        public DriverSetup(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            InsightsRetail_TestIter intr = null;
            intr = new InsightsRetail_TestIter("chrome");
            _driver = intr.eveDriver;
            _objectContainer.RegisterInstanceAs(_driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }
     */
    }
}
