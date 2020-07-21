using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeTestName
{
    class SomeTestClass
    {
        IWebDriver driver;
        
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void test()
        {
            driver.Url = "https://www.youtube.com/";
            IWebElement element = driver.FindElement(By.Id("search"));
            element.SendKeys("C# Videos");
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}