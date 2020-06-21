using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSelenium1.DriverClass;
using NUnitSelenium1.ActionMethods;
using NUnitSelenium1.PageObjects;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace NUnitSelenium1.TestScenarios
{
    [TestFixture]
    public class TestClass : InitializeTest
    {
        
        
        [Test]
        public void ValidatePrivaliaBR()
        {
            //initDriver("https://www.privalia.com");
            //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\instaladores\geckoDriver", "geckodriver.exe");
            //IWebDriver driver2 = new FirefoxDriver(service);
           
            //driver.Navigate().GoToUrl("https://br.privalia.com/");
            ActionEvents.NavigateTo("https://br.privalia.com");
            PrivaliaBRHomePage homee = new PrivaliaBRHomePage();
            ActionEvents.ClickOnItem(homee.entrarLink);
            Assert.IsTrue(true);
            //closeDriver();
        }

        [Test]
        public void ValidateOfficeMenuExist()
        {
            MainPage mainn = new MainPage();
            Assert.IsTrue(mainn.officeMenu.Displayed);
            Console.WriteLine("The next menu item is correctly displayed: " + mainn.officeMenu.Text);
        }

        [Test]
        public void ValidateWindoswMenuExist()
        {
            MainPage mainn = new MainPage();
            Assert.IsTrue(mainn.windowsMenu.Displayed);
            Console.WriteLine("The next menu item is correctly displayed: " + mainn.windowsMenu.Text);
        }

        [Test]
        public void ValidateSurfaceMenuExist()
        {
            MainPage mainn = new MainPage();
            Assert.IsTrue(mainn.surfaceMenu.Displayed);
            Console.WriteLine("The next menu item is correctly displayed: " + mainn.surfaceMenu.Text);
        }

        [Test]
        public void ValidateXBoxMenuExist()
        {
            MainPage mainn = new MainPage();
            Assert.IsTrue(mainn.xboxMenu.Displayed);
            Console.WriteLine("The next menu item is correctly displayed: " + mainn.xboxMenu.Text);
        }

        [Test]
        public void ValidateDealsMenuExist()
        {
            MainPage mainn = new MainPage();
            Assert.IsTrue(mainn.dealsMenu.Displayed);
            Console.WriteLine("The next menu item is correctly displayed: " + mainn.dealsMenu.Text);
        }

        [Test]
        public void ValidateSupportMenuExist()
        {
            MainPage mainn = new MainPage();
            Assert.IsTrue(mainn.supportMenu.Displayed);
            Console.WriteLine("The next menu item is correctly displayed: " + mainn.supportMenu.Text);
        }

        [Test]
        [Ignore("getting issues to indetify win 10 submenu items ")]
        public void ValidateWindows10ItemsPrinting()
        {
            ActionEvents.SelectWindowsMenu();
            ActionEvents.SelectWindows10();
            ActionEvents.PrintWin10Items();
            //WindowsPage winPage = new WindowsPage();
            //Assert.IsTrue(winPage.obtainWin10.Displayed);
            //Console.WriteLine("The next menu item is correctly displayed: ");
        }

        [Test]
        public void ValidateSearchOnWinPage()
        {
            ActionEvents.NavigateToWinPage();
            Thread.Sleep(10000);
            ActionEvents.SelectSearchButton();
            Thread.Sleep(10000);
            ActionEvents.EnterSearchText("Visual Studio");
            Thread.Sleep(10000);
            ActionEvents.PressEnter();
            Thread.Sleep(10000);
            ActionEvents.CloseMarketModal();
            SearchResultsPage resultsPage = new SearchResultsPage();
            Assert.IsTrue(resultsPage.softwareTitle.Text.Contains("Software"));
            Console.WriteLine("Visual Studio search was successfully performed");
            ActionEvents.PrintVSPrices();
            ActionEvents.storeFirstResultItem();
        }

        [Test]
        public void ValidateBothPricesOnDetailsPage()
        {
            string price1;
            string price2;

            ActionEvents.NavigateToWinPage();
            Thread.Sleep(10000);
            ActionEvents.SelectSearchButton();
            Thread.Sleep(10000);
            ActionEvents.EnterSearchText("Visual Studio");
            Thread.Sleep(10000);
            ActionEvents.PressEnter();
            Thread.Sleep(10000);
            ActionEvents.CloseMarketModal();
            SearchResultsPage resultsPage = new SearchResultsPage();
            price1 = resultsPage.firstPriceItem.Text;
            ActionEvents.SelectFirstPriceitem();
            Thread.Sleep(10000);
            ActionEvents.CloseMarketModal();
            ProductDetailsPage detailsPage = new ProductDetailsPage();
            price2 = detailsPage.price.Text;
            Assert.IsTrue(price1.Equals(price2));
            Console.WriteLine("Both Prices are the same");
            //ActionEvents.PrintVSPrices();
            //ActionEvents.storeFirstResultItem();
        }

        [Test]
        public void ValidateAddToCartFunctionality()
        {
            
            ActionEvents.NavigateToWinPage();
            Thread.Sleep(10000);
            ActionEvents.SelectSearchButton();
            Thread.Sleep(10000);
            ActionEvents.EnterSearchText("Visual Studio");
            Thread.Sleep(10000);
            ActionEvents.PressEnter();
            Thread.Sleep(10000);
            ActionEvents.CloseMarketModal();
            ActionEvents.SelectFirstPriceitem();
            Thread.Sleep(10000);
            ActionEvents.CloseMarketModal();
            Thread.Sleep(10000);
            //ActionEvents.MoveToAddToCartButton();
           
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,250)", "");
            ActionEvents.SelectAddToCartButton();
            bool samePricesFlag = ActionEvents.ComparePricesOnCartPage();
            Assert.IsTrue(samePricesFlag);
            Console.WriteLine("The 3 dispalyed prices are the same");
            
        }

        [Test]
        public void ValidateTotalAmount()
        {
            float totalPrice;

            ActionEvents.NavigateToWinPage();
            Thread.Sleep(10000);
            ActionEvents.SelectSearchButton();
            Thread.Sleep(10000);
            ActionEvents.EnterSearchText("Visual Studio");
            Thread.Sleep(10000);
            ActionEvents.PressEnter();
            Thread.Sleep(10000);
            ActionEvents.CloseMarketModal();
            ActionEvents.SelectFirstPriceitem();
            Thread.Sleep(10000);
            ActionEvents.CloseMarketModal();
            Thread.Sleep(10000);
            //ActionEvents.MoveToAddToCartButton();

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,250)", "");
            ActionEvents.SelectAddToCartButton();
            ActionEvents.SelectQtyOfItems("20");
            Thread.Sleep(10000);
            CartPage cart = new CartPage();
            totalPrice = ActionEvents.CalculateTotal();
            string cad1 = cart.totalPrice.Text.Substring(1, cart.totalPrice.Text.Length-1);
            float displayedTotal = float.Parse(cad1);
            //bool samePricesFlag = ActionEvents.ComparePricesOnCartPage();
            Assert.IsTrue(totalPrice == displayedTotal);
            Console.WriteLine("The total price is correct: " + totalPrice);

        }
    }
}
