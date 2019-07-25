using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Events;

using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;


namespace NUnit.InsightsRetail 
{
    public class MyEventFiringWebDriver : EventFiringWebDriver, IHasCapabilities
    {

        private RemoteWebDriver driver;

        public MyEventFiringWebDriver(RemoteWebDriver driver): base(driver)
        {
            this.driver = driver;
        }

        public ICapabilities Capabilities => ((IHasCapabilities)driver).Capabilities;
        
    }
}
