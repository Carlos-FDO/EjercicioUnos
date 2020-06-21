using System;
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
    public class PrivaliaBRHomePage : Base
    {
        
       

        [FindsBy(How = How.Id, Using = "authLogin")]
        public IWebElement entrarLink { get; set; }
    }
}
