Feature: CompanySearchUserForms
Below scenarios will verify the functionality of UserForms inside Company Search Module

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1. Verifying UserForms Tab Details
	When I navigate to Company from dashboard	
	And I search for company "Test_Company"
	And I navigate to searched company
	And I navigate to Electronics Classification UserForms tab
	Then Electronic Classification UserForms tab details should be displayed