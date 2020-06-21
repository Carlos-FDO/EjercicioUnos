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
    public class SearchResultsPage : Base
    {

        [FindsBy(How = How.CssSelector, Using = "#coreui-productplacement-30l7ywa > div.m-channel-placement > h2 > span")]
        public IWebElement softwareTitle { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#coreui-productplacement-30l7ywa_0 > div.c-channel-placement-price > div > span:nth-child(3) > span:nth-child(1)")]
        public IWebElement firstPriceItem { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#coreui-productplacement-30l7ywa_0 > h3.c-subheading-6")]
        public IWebElement firstProductResultItem { get; set; }




    }
}
