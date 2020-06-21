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
    public class CartPage : Base
    {
        [FindsBy(How = How.CssSelector, Using = "#store-cart-root > div > div > div > section._3a6I5TkT > div > div > div > div > div > div.item-details > div.item-quantity-price > div.item-price > div > span > span:nth-child(3) > span")]
        public IWebElement productPrice { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#store-cart-root > div > div > div > section._3LWrsBIG > div > div > div:nth-child(2) > div > span:nth-child(1) > span:nth-child(2) > div > span > span:nth-child(3) > span")]
        public IWebElement itemPrice { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#store-cart-root > div > div > div > section._3LWrsBIG > div > div > div:nth-child(4) > div > span > span:nth-child(2) > strong > span")]
        public IWebElement totalPrice { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#store-cart-root > div > div > div > section._3LWrsBIG > div > div > button")]
        public IWebElement checkOutButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".item-quantity > select")]
        public IWebElement quantityList { get; set; }
    }
}
