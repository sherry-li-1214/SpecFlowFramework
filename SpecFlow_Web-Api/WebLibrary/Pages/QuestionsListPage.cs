using OpenQA.Selenium;
using System;

namespace WebLibrary.Pages
{
    public class QuestionsListPage : PageBase
    {
        public QuestionsListPage(IWebDriver webDriver) : base(webDriver)
        {
        }
        #region WebElement

        private IWebElement newHomeLoansRadio
            => Driver.FindElement(By.Id("sales"));
             
        private IWebElement existedHomeLoansRadio 
            => Driver.FindElement(By.Id("servicing"));
     
        private IWebElement nextButton
            => Driver.FindElement(By.XPath("//*[contains(text(),'Next')]"));
       
        private IWebElement previousButton
            => Driver.FindElement(By.XPath("//*[contains(text(),'Previous')]"));

        
       
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
          private IWebElement StartJourneyButton 
            => Driver.FindElement(By.Id("start"));

  
       
        public void StartJourney()
        {
            WaitForElement(nextButton);
            
            newHomeLoansRadio.Click();
            nextButton.Click();
            WaitForElement(nextButton);
            newBuyRadio.Click();
            nextButton.Click();
        }

        protected override bool EvaluateLoadedStatus()
        {
            try
            {
                WaitForElement(nextButton);
                return true;
            }
            catch
            {
                throw new Exception("page not load");
            }    
        }
    }
}
