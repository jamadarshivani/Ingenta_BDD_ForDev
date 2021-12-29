Feature: CompanySearchResponsibilities
Below scenarios will verify the functionality of Responsibilities inside Company Search Module

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1. Verifying Responsibilities Tab Details
	When I navigate to Company from dashboard	
	And I search for company "Test_Company"
	And I navigate to searched company
	And I navigate to Responsibilities tab
	Then Company Responsibilities tab details should be displayed