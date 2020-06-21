// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace NUnitSelenium1
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestPrivalia()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://wwww.https://www.privalia.com";
            driver.Navigate().GoToUrl("https://br.privalia.com/");
            driver.Quit();
        }
    }
}
