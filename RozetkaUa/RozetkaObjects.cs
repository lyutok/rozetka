using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RozetkaUa
{
    class RozetkaObjects
    {
        public IWebDriver driver;


        public RozetkaObjects(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            
        }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/div[1]/div[1]/header/div/div[2]/div[2]/fat-menu/div/ul/li[1]/a")]
        public IWebElement laptopsAndComputers;

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/div[1]/div[1]/header/div/div[2]/div[2]/fat-menu/div/ul/li[1]/div/div[2]/div[1]/div[1]/ul[1]/li/ul/li[1]/a")]
        public IWebElement asus;

    }
}
