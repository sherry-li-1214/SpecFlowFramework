@ui
Feature: Loan Query Test on Nab Website
UI Test for NAB website 
 
    Background: 
 
	@Web
	Scenario: Test the call back process
		Given I enter into Nab Website
		And I go to Home Loans
		Then I want to request a call back using following information 
		  | Home Loan Type | Home Loan Topics      |
		  | New Home Loan  | Buying a new property |
		Then I need answer some questions before call back form open
		When I fill into and submit the call back form using information from /test_data/user_info.json 
		Then I should go to confirmation page with "WE'VE RECEIVED YOUR REQUEST"