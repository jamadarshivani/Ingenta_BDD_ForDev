Feature: Company_Territories
	Background:
    Given I am logged in Ingenta application and user is redirected to dashboard
	When I navigate to Companies from dashboard
	And I search for company "Test_Company"
	And I navigate to searched company
	And I navigate to Territories tab

Scenario: 1. Verifying Territories Tab Details	
	Then Company Territories tab details should be displayed

Scenario: 2. Verifying all the elements in new territories window
	When I click on new button in territories tab
	Then all the elements in new territories should be displayed


