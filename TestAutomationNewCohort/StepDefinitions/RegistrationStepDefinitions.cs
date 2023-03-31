using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestAutomationNewCohort.PageObject;

namespace TestAutomationNewCohort.StepDefinitions
{
    [Binding]
    public class RegistrationStepDefinitions
    {

        RegistrationPage registrationPage;

        public RegistrationStepDefinitions ()
        {
            registrationPage= new RegistrationPage (); 

        }

        [Given(@"I naviage to the website")]
        public void GivenINaviageToTheWebsite()
        {
            registrationPage.NavigateToWebsite();
        }

        [Given(@"I click on sign up")]
        public void GivenIClickOnSignUp()
        {
         registrationPage.ClickOnSignUp();
        }

        [Given(@"I enter Username")]
        public void GivenIEnterUsername()
        {
            registrationPage.EnterUsername();
        }

        [Given(@"I enter Email")]
        public void GivenIEnterEmail()
        {
           registrationPage.EnterEmail();
        }

        [Given(@"I Enter password")]
        public void GivenIEnterPassword()
        {
           registrationPage.EnterPassword();
        }

        [When(@"I click on the sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            registrationPage.ClickSignUpButton();
        }

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(registrationPage.IsNewArticleDisplayed);
        }
    }
}
