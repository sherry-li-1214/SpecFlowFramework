using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;

namespace WebLibrary.Pages
{
    public class CallBackFormPage : PageBase
    {
        public CallBackFormPage(IWebDriver webDriver) : base(webDriver)
        {
        }
        #region WebElement

        private IWebElement stateField
            => Driver.FindElement(By.Id("btnGroup"));
         private IWebElement newCustomerRadio 
            => Driver.FindElement(By.XPath("//*[@id='field-page-Page1-isExisting']/label[2]"));
        
        private IWebElement firstNameField
            => Driver.FindElement(By.Id("field-page-Page1-aboutYou-firstName"));
        private IWebElement lastNameField
            => Driver.FindElement(By.Id("label-page-Page1-aboutYou-lastName"));
        private IWebElement phoneNumberField
            => Driver.FindElement(By.Id("field-page-Page1-aboutYou-phoneNumber"));
        private IWebElement emailAddressField
            => Driver.FindElement(By.Id("field-page-Page1-aboutYou-email"));
        
        private IWebElement submitButton
            => Driver.FindElement(By.Id("page-Page1-btnGroup-submitBtn"));
       
   
        #endregion
          private IWebElement StartJourneyButton 
            => Driver.FindElement(By.Id("start"));

  
       
        public void StartJourney()
        {
            WaitForElement(submitButton);

            caputureClientInfor();
            
            submitButton.Click();
        }

        private void caputureClientInfor()
        {
            newCustomerRadio.Click();
            firstNameField.SendKeys("sherr");
            lastNameField.SendKeys("li");
            stateField.Click();
            
            var selectElement = new SelectElement(stateField);
            selectElement.SelectByText("VIC");
            emailAddressField.SendKeys("test@gmail.com");
            phoneNumberField.SendKeys("0411629426");
       }
        protected override bool EvaluateLoadedStatus()
        {
            try
            {
                WaitForElement(submitButton);
                return true;
            }
            catch
            {
                throw new Exception("page not load");
            }    
        }
    }
}
