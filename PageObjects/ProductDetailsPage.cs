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
    public class ProductDetailsPage : Base
    {

        [FindsBy(How = How.CssSelector, Using = "#ProductPrice_productPrice_PriceContainer > span")]
        public IWebElement price { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#buttonPanel_AddToCartButton")]
        public IWebElement addToCartButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#DynamicHeading_productTitle")]
        public IWebElement pruductItemTitle { get; set; }


    }
}
