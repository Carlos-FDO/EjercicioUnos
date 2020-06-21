using NUnit.Framework;
using NUnitSelenium1.DriverClass;
using NUnitSelenium1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium1
{
    [TestFixture]
    public class InitializeTest: DriverManage
    {
        [SetUp]
        public void Setup()
        {
            //initDriver("https://www.microsoft.com/en-us/");
            initDriver();
        }


        [TearDown]
        public void CleanUp()
        {
            closeDriver();
        }
    }
}
