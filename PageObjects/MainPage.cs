using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnitSelenium1.DriverClass;
using SeleniumExtras.PageObjects;
using NUnitSelenium1.Helpers;

namespace NUnitSelenium1.PageObjects
{
    public class MainPage : Base
    {



        [FindsBy(How = How.CssSelector, Using = "#shellmenu_1")]
        public IWebElement officeMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#shellmenu_2")]
        public IWebElement windowsMenu  { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#shellmenu_3")]
        public IWebElement surfaceMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#shellmenu_4")]
        public IWebElement xboxMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#shellmenu_5")]
        public IWebElement dealsMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#l1_support")]
        public IWebElement supportMenu { get; set; }
    }
}
