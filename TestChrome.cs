using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace SeleniumTester
{
    class TestChrome
    {
            //Zakładka Kontakt zmienia kolor czcionki po najechaniu
        public void zadanie1() {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Url = "https://www.medicalgorithmics.pl/";
            Actions ruch = new Actions(driver);
            ruch.MoveToElement(driver.FindElement(By.XPath("//*[@id='mega-menu-item-29']/a"))).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='mega-menu-item-29']/a")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/div[2]/div/div[7]/div/div/div/div/div/div[4]/div/div/div/div[1]/div/div/div[1]/div/a/div/img")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/ html / body / div[3] / div / div / div / div[2] / div / div[2] / div / div / div / div / div / div / div / div[1] / div / div / div / div[2] / div / div / div[1] / div / h1 / a / strong")).Click();

        }


        //Zadanie2
        public void zadanie2() {
            Thread.Sleep(2000);
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.medicalgorithmics.pl");
            driver.FindElement(By.Name("s")).SendKeys("Pocket ECG CRS" + Keys.Enter);

            //wyszukiwanie 10 elementów
            IList<IWebElement> wyszukane = driver.FindElements(By.ClassName("latest_post_custom"));
            Console.WriteLine("wyszukane elementy dla Pocket ECG CRS=" + wyszukane.Count);

            //wyszukiwanie gdzie powinny być 1 element ale jest 0
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("https://www.medicalgorithmics.pl");
            driver.FindElement(By.Name("s")).SendKeys("PocketECG CRS – telerehabilitacja kardiologiczna" + Keys.Enter);
            IList<IWebElement> wyszukane2 = driver.FindElements(By.ClassName("latest_post_custom"));
            Console.WriteLine("wyszukane elementy dla PocketECG CRS – telerehabilitacja kardiologiczna =" + wyszukane2.Count);


            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("https://www.medicalgorithmics.pl");
            driver.FindElement(By.Name("s")).SendKeys("a" + Keys.Enter);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/div[2]/div[2]/div/ul/div[11]/ul/li[4]/a")).Click();
        }

        }
    }

