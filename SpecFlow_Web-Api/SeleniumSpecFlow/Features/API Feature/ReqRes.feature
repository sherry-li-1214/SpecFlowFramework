@api
Feature: Disruptions Api Tests

	@api_get
	Scenario: Get all disruptions
		Given I go to the Disruption API portal
	    When I requested "GET" operation with following criteria and fetch the response 
	      |disruption_status | "C"   | 
		#When I requested "GET" operation and fetch the response    
		Then I should see the 200 status code
		And I get the total numbers of disruptions with following criteria
	
	