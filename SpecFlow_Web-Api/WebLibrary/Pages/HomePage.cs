using OpenQA.Selenium;
using System;

namespace WebLibrary.Pages
{
    public class HomePage : PageBase
    {
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
        }
        #region WebElement

        private IWebElement newHomeLoansRadio
            => Driver.FindElement(By.Id("sales"));
             
        private IWebElement existedHomeLoansRadio 
            => Driver.FindElement(By.Id("servicing"));
     
        private IWebElement nextButton
            => Driver.FindElement(By.XPath("//*[contains(text(),'Next')]"));
       
        
       
        private IWebElement newBuyRadio
            => Driver.FindElement(By.Id("0110"));
        //private IWebElement LoginTextBox => driver.FindElement(By.Id("Bugzilla_login"));

        private IWebElement switchLoanRaido
            =>Driver.FindElement((By.Id("0101")));
       
        private IWebElement firstBuyRadio
            =>Driver.FindElement(By.Id("0111"));
    
        private IWebElement familyHomeRaido
            =>Driver.FindElement(By.Id(("0112")));

        private IWebElement all_Home_Loans_link
            => Driver.FindElement(By.LinkText("View all home loans"));
   
   
        #endregion
        private IWebElement UserNameInputField 
            => Driver.FindElement(By.XPath("//input[@id='worrior_username']"));
        private IWebElement CreateWarriorButton 
            => Driver.FindElement(By.Id("warrior"));
        private IWebElement StartJourneyButton 
            => Driver.FindElement(By.Id("start"));

        public void CreateWarrior(string userNameInput)
        {
            UserNameInputField.SendKeys(userNameInput);

            CreateWarriorButton.Click();

            StartJourney();
        }

        public void go_to_all_loans()
        {
            WaitForElement(all_Home_Loans_link);
            all_Home_Loans_link.Click();
        }
      
        public void StartJourney()
        {
            WaitForElement(StartJourneyButton);

            StartJourneyButton.Click();
        }

        protected override bool EvaluateLoadedStatus()
        {
            try
            {
                WaitForElement(all_Home_Loans_link);
                return true;
            }
            catch
            {
                throw new Exception("page not load");
            }    
        }
    }
}
