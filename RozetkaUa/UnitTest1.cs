using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace RozetkaUa
{
    public class UnitTest1
    {
        IWebDriver driver;
        
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://rozetka.com.ua");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        [TearDown]

        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void Test()
        {
            RozetkaObjects rozetkaObjects = new RozetkaObjects(driver);
            var laptopsAndComputers = rozetkaObjects.laptopsAndComputers;
            var asus = rozetkaObjects.asus;


            // IWebElement element = null;
            //  IWebElement target = null;
            Actions actions = new Actions(driver);
            actions.Build();
            IAction action = actions.Build();
            actions.Click(laptopsAndComputers);
                // .MoveToElement(asus).Click().Release();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
    }
}
