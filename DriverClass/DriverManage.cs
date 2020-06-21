using NUnitSelenium1.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace NUnitSelenium1.DriverClass
{
    public class DriverManage
    {
       public static  IWebDriver driver;
      //public WebDriverWait Wait { get; set; }
        //public string urlTestSite = "https://www.microsoft.com/en-us/";
        //public string urlTestSite = ConfigurationManager.AppSettings["UrlTestSite"];

        //public void initDriver(string urlPage)
        public void initDriver()
        {

            driver = new ChromeDriver();
            //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\instaladores\geckoDriver", "geckodriver.exe");
            //IWebDriver driver = new FirefoxDriver(service);
            driver.Url = ConfigurationManager.AppSettings["UrlTestSite"];
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            //Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }

        public void closeDriver()
        {
            driver.Quit();

        }

    }
}
