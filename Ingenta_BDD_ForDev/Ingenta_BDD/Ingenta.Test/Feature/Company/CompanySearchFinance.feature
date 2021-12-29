Feature: CompanySearchFinance
Below scenarios will verify the functionality of Finance inside Company Search Module

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1. Verifying Company Finance Tab Details
	When I navigate to Company from dashboard	
	And I search for company "Test_Company"
	And I navigate to searched company
	And I navigate to Finance tab
	Then Company Search Finance details should be displayed
