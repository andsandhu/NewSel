using System;
using Reqnroll;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace NewSel.StepDefinitions
{
    [Binding]
    public class OpenbrowserStepDefinitions

    {
        IWebDriver dr=new ChromeDriver();
        [Given("open browser with url as  https:\\/\\/practicetestautomation.com\\/practice-test-login\\/")]
        public void GivenOpenBrowserWithUrlAsHttpsPracticetestautomation_ComPractice_Test_Login()
        {
            dr.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login");
        }

        [When("enter username and password and click on Submit button")]
        public void WhenEnterUsernameAndPasswordAndClickOnSubmitButton()
        {
            IWebElement e = dr.FindElement(By.Id("username"));
            //.SendKeys("student");
            e.SendKeys("student");
            IWebElement f = dr.FindElement(By.Id("password"));
                f.SendKeys("Password123");
                IWebElement s= dr.FindElement(By.Id("submit"));
            s.Click();
        }

        [Then("logged in successfully page should be displayed")]
        public void ThenLoggedInSuccessfullyPageShouldBeDisplayed()
        {
          dr.Close();
        }
    }
}
