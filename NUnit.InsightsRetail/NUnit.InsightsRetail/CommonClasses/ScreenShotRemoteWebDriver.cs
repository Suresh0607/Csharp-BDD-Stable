using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NUnit.InsightsRetail
{
    public class ScreenShotRemoteWebDriver : RemoteWebDriver, ITakesScreenshot
    {
       // private Uri uri;

        public ScreenShotRemoteWebDriver(Uri remoteAddress, DriverOptions options)
        : base(remoteAddress, options)
        {
        }

        public new Screenshot GetScreenshot()
        {
            // Get the screenshot as base64. 
            Response screenshotResponse =
            this.Execute(DriverCommand.Screenshot, null);
            string base64 = screenshotResponse.Value.ToString();

            // ... and convert it. 
            return new Screenshot(base64);
        }
    }
}
