using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSelenium1.PageObjects;
using NUnitSelenium1.DriverClass;
using NUnitSelenium1.Helpers;
using System.Collections.ObjectModel;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.IO;
using OpenQA.Selenium.Interactions;

namespace NUnitSelenium1.ActionMethods
{
    public class ActionEvents : Base
    {


        public static void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static void ClickOnItem(IWebElement webElement)
        {
            webElement.Click();
        }

        public static void SelectWindowsMenu()
        {
            MainPage mainn = new MainPage();
            mainn.windowsMenu.Click();
        }

        public static void SelectWindows10()
        {
            WindowsPage winPage = new WindowsPage();
            winPage.windows10Menu.Click();
        }

        public static void PrintWin10Items()
        {
            IList<IWebElement> win10List = driver.FindElements(By.XPath("//ul[contains(@data-m, 'Windows10_cont')]/li/a"));

            for (int n = 0; n < win10List.Count; n++)
            {
                Console.WriteLine(win10List[n].Text);
                IWebElement obj = driver.FindElement(By.Id("c-shellmenu_45"));
                Console.WriteLine(obj.Text);
            }
        }

        public static void NavigateToWinPage()
        {
            MainPage mainn = new MainPage();
            driver.Navigate().GoToUrl(mainn.windowsMenu.GetAttribute("href"));
        }

        public static void SelectSearchButton()
        {
            WindowsPage winPage = new WindowsPage();
            winPage.searchButton.Click();
            
        }

        public static void EnterSearchText(string textt)
        {
            WindowsPage winPage = new WindowsPage();
            winPage.searchTextBox.SendKeys(textt);
        }

        public static void PressEnter()
        {
            WindowsPage winPage = new WindowsPage();
            winPage.searchTextBox.SendKeys(Keys.Enter);
        }

        public static void CloseMarketModal()
        {
            
            WindowsPage winPage = new WindowsPage();
            if (winPage.closeTranslateModalButton.Displayed)
            {

                winPage.closeTranslateModalButton.Click();
            }
        }

        public static void PrintVSPrices (){
            IList<IWebElement> vsPrices = driver.FindElements(By.CssSelector(".c-price > span:nth-child(3) > span:nth-child(1)"));

            for (int n = 0; n < vsPrices.Count; n++)
            {
                Console.WriteLine("Price VS option " + n + ": " + vsPrices[n].Text);
               
            }
        }

        public static void storeFirstResultItem()
        {
            SearchResultsPage resultsPage = new SearchResultsPage();
            /* try
             {
                 using (System.IO.StreamWriter file = new System.IO.StreamWriter("PricesList.txt", true))
                 {
                     file.WriteLine("Product Item: " + resultsPage.firstProductResultItem.Text + "," + resultsPage.firstPriceItem.Text);
                 }
             }catch(Exception ex)
             {
                 throw new ApplicationException("writing file exception: ", ex);
             }*/
            StringBuilder csvContent = new StringBuilder();
            csvContent.AppendLine("Product Item: " + resultsPage.firstProductResultItem.Text + "," + resultsPage.firstPriceItem.Text);
            //string csvPath = Environment.CurrentDirectory; 
            string csvPath = "D:\\Visual Studio Repo\\NUnitSelenium1\\PricesList.csv";
            File.AppendAllText(csvPath, csvContent.ToString());
        }

        public static void SelectFirstPriceitem()
        {
            SearchResultsPage resultPage = new SearchResultsPage();
            resultPage.firstProductResultItem.Click();
        }

        public static void SelectAddToCartButton()
        {
            ProductDetailsPage detailsPage = new ProductDetailsPage();
            detailsPage.addToCartButton.Click();
        }

        public static void MoveToAddToCartButton()
        {
            ProductDetailsPage detailsPage = new ProductDetailsPage();
            Actions actions = new Actions(driver);
            actions.MoveToElement(detailsPage.addToCartButton);
            actions.Perform();
            //detailsPage.addToCartButton.Click();
        }

        public static bool ComparePricesOnCartPage()
        {
            CartPage cart = new CartPage();
            if (cart.productPrice.Text.Equals(cart.itemPrice.Text))
            {
                if (cart.productPrice.Text.Equals(cart.totalPrice.Text))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static void SelectQtyOfItems(string value)
        {
            CartPage cart = new CartPage();
            SelectElement selectt = new SelectElement(driver.FindElement(By.CssSelector(".item-quantity > select")));
            selectt.SelectByText(value);
        }

        public static float CalculateTotal()
        {
            string pricecadena, auxCad;
            float unitPrice, qtyItemsNumber, totalPrice;
            CartPage cart = new CartPage();
            auxCad = cart.itemPrice.Text;
            pricecadena = auxCad.Substring(1, auxCad.Length-1);
            //string numberOfItemCad = cart.quantityList.GetAttribute("value");
            unitPrice = float.Parse(pricecadena);
            qtyItemsNumber = float.Parse(cart.quantityList.GetAttribute("value"));
            return totalPrice = unitPrice * qtyItemsNumber;

        }



    }
}
