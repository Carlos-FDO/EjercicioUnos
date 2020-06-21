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
    public class WindowsPage : Base
    {



        [FindsBy(How = How.CssSelector, Using = "#c-shellmenu_50")]
        public IWebElement windows10Menu { get; set; }

        
        [FindsBy(How = How.CssSelector, Using = "#c-shellmenu_42")]
        //[FindsBy(How = How.XPath, Using = "/html/body/span[2]/div/div/div/header/div/div/nav/ul/li[2]/div/ul/li[1]/a")]
        public IWebElement obtainWin10 { get; set; }

        
        [FindsBy(How = How.CssSelector, Using = "#search")]
        public IWebElement searchButton{ get; set; }

        
        [FindsBy(How = How.CssSelector, Using = "#R1MarketRedirect-close")]
        public IWebElement remainTranslateModalButton { get; set; }

        
        [FindsBy(How = How.XPath, Using = "//button[@title='Permanecer en United States - English']")]

        public IWebElement remainTranslateModalButton2 { get; set; }

        
        [FindsBy(How = How.CssSelector, Using = "#R1MarketRedirect-1 > button")]
        public IWebElement closeTranslateModalButton { get; set; }

        
        [FindsBy(How = How.CssSelector, Using = "#cli_shellHeaderSearchInput")]
        public IWebElement searchTextBox { get; set; }


    }
}
