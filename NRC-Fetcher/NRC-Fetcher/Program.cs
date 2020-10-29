using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

//Inspiration: https://github.com/yasoob/nrc-exporter

namespace NRC_Fetcher
{
    class Program
    {
        //TODO: Add Commandline parser
        public static void Main(string[] args)
        {
            //IWebDriver
            var driver = new FirefoxDriver();
            //var driver = new ChromeDriver();  //Nike doesn't allow login from ChromeDriver.
            var homeURL = "https://www.nike.com/login?continueUrl=https://www.nike.com/member/profile";
            driver.Navigate().GoToUrl(homeURL);

            //Now that we are on the homepage, try and input login information into the form...

            var email_input = driver.FindElementByCssSelector("input[data-componentname='emailAddress']");
            email_input.SendKeys(""); //Username

            var password_input = driver.FindElementByCssSelector("input[data-componentname='password']");
            password_input.SendKeys(""); //Password

            var submit_button = driver.FindElementByCssSelector("div.nike-unite-submit-button.loginSubmit.nike-unite-component input[type='button']");
            submit_button.Click();

            //var login_button = driver.FindElementByCssSelector("button.join-log-in.text-color-grey.prl3-sm.pt2-sm.pb2-sm.fs12-sm.d-sm-b");
            //login_button.Click();
        }
    }
}
