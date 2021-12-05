using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumSpecFlow.Utilities;
using TechTalk.SpecFlow;
using TestLibrary.Utilities;
using WebLibrary.Pages;

namespace SeleniumSpecFlow.Steps
{
    [Binding]
    public  class NabTestSteps : ObjectFactory
    {
        private readonly HomePage _homePage;
        private readonly HomeLoansPage _homeLoansPage;
        private readonly QuestionsListPage _questionsListPage;
        private readonly CallBackFormPage _callBackFormPage;
        public NabTestSteps(HomePage loginPage,
            HomeLoansPage homeLoansPage,
            QuestionsListPage questionsListPage,
            CallBackFormPage callBackFormPage)
        {
            _homePage = loginPage;
            _homeLoansPage = homeLoansPage;
            _questionsListPage = questionsListPage;
            _callBackFormPage = callBackFormPage;

        }

        [Given(@"I enter into Nab Website")]
        public void GivenIEnterIntoNabWebsite()
        {
            //
            

        }

        [Given(@"I go to Home Loans")]
        public void GivenIGoToHomeLoans()
        {
            _homePage.go_to_all_loans();
        }

        [Then(@"I want to request a call back using following information")]
        public void ThenIWantToRequestACallBackUsingFollowingInformation(Table table)
        {
            _homeLoansPage.StartJourney();
            
        }

  
        [When(@"I fill into and submit the call back form using information from /test_data/user_info\.json")]
        public void WhenIFillIntoAndSubmitTheCallBackFormUsingInformationFromTestDataUserInfoJson()
        {
            _callBackFormPage.StartJourney();
        }

        [Then(@"I should go to confirmation page with ""(.*)""")]
        public void ThenIShouldGoToConfirmationPageWith(string p0)
        {
            string ExpectedText ="We have received your feedback";
            IWebElement body = _homePage._driver.FindElement(By.TagName("body"));

            Assert.IsTrue(body.Text.Contains(ExpectedText));
        }

        [Then(@"I need answer some questions before call back form open")]
        public void ThenINeedAnswerSomeQuestionsBeforeCallBackFormOpen()
        {
            _questionsListPage.StartJourney();
        }
    }
}