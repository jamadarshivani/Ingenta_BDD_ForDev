Feature: CompanySearchAdTemplates
Below scenarios will verify the functionality of AdTemplates inside Company Search Module

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1. Verifying Ad Templates Tab Details
	When I navigate to Company from dashboard	
	And I search for company "Test_Company"
	And I navigate to searched company
	And I navigate to Ad Templates tab
	Then Company Ad Templates tab details should be displayed

Scenario: 2. Verifying all the elements on new Ad template
	When I navigate to Company from dashboard	
	And I search for company "Test_Company"
	And I navigate to searched company 
	And I navigate to Ad Templates tab 
	And I click on Ad Template new button
	Then all the elements should be displayed