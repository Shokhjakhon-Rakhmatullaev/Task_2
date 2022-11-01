// See https://aka.ms/new-console-template for more information 
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            string pageTitle;
            driver.Navigate().GoToUrl("https://www.google.com");
            IWebElement searchBar = driver.FindElement(By.Name("q"));

            searchBar.SendKeys("Hello World");
            searchBar.SendKeys(Keys.Enter);

            pageTitle = driver.Title;
            driver.Quit();
            logger(pageTitle); 
            //Console.WriteLine(pageTitle); //In case you want to see result in console 


        }

        static void logger(string str)
        {
            //string logPath = Directory.GetCurrentDirectory() + "/" + "Log.txt"; for all directories
            string logPath = "C:\\Users\\Asus\\source\\repos\\LoginToWebSite\\LoginToWebSite\\Log.txt";
            using(StreamWriter sw = new StreamWriter(logPath))
            {
                sw.WriteLine(str);
            }
        }
    }
}