using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using System.Runtime.CompilerServices;

namespace NUnit.InsightsRetail
{
    public class CommonTestExecute
    {
            protected IWebDriver Driver;
            protected ICapabilities Capabilities;
            protected string TargetUrl;
            protected string GridUrl;

            RemoteWebDriverwithScreenShot threadDriverRemote;
            MyEventFiringWebDriver eveDriver;
            public ThreadLocal<IWebDriver> threadLocalDriver = new ThreadLocal<IWebDriver>();

            public void setUpSuite()
            {
                threadDriverRemote = new RemoteWebDriverwithScreenShot();              
            }

            
            public MyEventFiringWebDriver SetUp(String BrowserType) 
            {
                threadDriverRemote = new RemoteWebDriverwithScreenShot();
                eveDriver = (MyEventFiringWebDriver) threadDriverRemote.LaunchBrowser(BrowserType);
                threadLocalDriver.Value = eveDriver;
                return eveDriver;
	        }
                    
            public void TestCleanup()
            {
                Driver.Quit();
            }           
          
    }
 }
