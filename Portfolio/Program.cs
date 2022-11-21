using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

// open chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

driver.Navigate().GoToUrl("https://marcio.vercel.app/");
driver.FindElement(By.Id("homeGithub")).Click();
driver.Navigate().GoToUrl("https://marcio.vercel.app/");
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
driver.FindElement(By.Id("technical")).Click();
driver.FindElement(By.Id("experience")).Click();
driver.FindElement(By.Id("education")).Click();
driver.FindElement(By.Id("hobbies")).Click();
driver.FindElement(By.Id("burgerMenu")).Click();