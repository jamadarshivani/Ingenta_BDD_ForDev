Feature: CompanySearchOpportunities
Below scenarios will verify the functionality of Opportunities inside Company Search Module

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1. Verifying Opportunities Tab Details
	When I navigate to Company from dashboard	
	And I search for company "Test_Company"
	And I navigate to searched company
	And I navigate to Opportunities tab
	Then Opportunities tab details should be displayed