using NUnitSelenium1.DriverClass;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium1.Helpers
{
    public class Base : DriverManage
    {
        public Base()
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
