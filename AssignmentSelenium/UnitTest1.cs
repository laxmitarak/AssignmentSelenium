using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;

namespace AssignmentSelenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.matchingengine.com/");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.LinkText("Modules")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.LinkText("Repertoire Management Module")).Click();
            Thread.Sleep(3000);

            //scroll down the page
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

            jse.ExecuteScript("window.scroll(0,1400)");

            Thread.Sleep(3000);

            driver.FindElement(By.CssSelector("li[class='vc_tta-tab'] span[class='vc_tta-title-text']")).Click();

            String text = driver.FindElement(By.XPath("//h3[normalize-space()='There are several types of Product Supported:']")).GetAttribute("innerText").ToString();
            
            Assert.That("There are several types of Product Supported:", Is.EqualTo(text));
            driver.Close();
         

            

            

        }
    }
}