using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using TestovaniC;




namespace TestProject1
{
    [TestClass]
    public class Test1
    {
        //[TestMethod]
        //public void TestovaniPapouska()
        //{
        //    Papousek pap = new Papousek();
        //    Assert.AreEqual("ahoj, ahoj", pap.Zopakuj("ahoj"));

        //}
        [TestMethod]
        public void TestovaniWebu()
        {
            

            IWebDriver driver = new EdgeDriver();

            driver.Navigate().GoToUrl("https://www.google.cz");
            driver.Manage().Window.Maximize();

            IWebElement button = driver.FindElement(By.Id("L2AGLb"));
            button.Click();
            Thread.Sleep(2000);

            IWebElement input = driver.FindElement(By.ClassName("gLFyf"));
            input.SendKeys("ITnetwork");
            Thread.Sleep(2000);


            IWebElement searchButton = driver.FindElement(By.ClassName("gNO89b"));
            searchButton.Click();
            Thread.Sleep(2000);

            IWebElement capcha = driver.FindElement(By.ClassName("recaptcha-checkbox goog-inline-block recaptcha-checkbox-unchecked rc-anchor-checkbox"));
            capcha.Click();
            Thread.Sleep(2000);



        }
    }
}
