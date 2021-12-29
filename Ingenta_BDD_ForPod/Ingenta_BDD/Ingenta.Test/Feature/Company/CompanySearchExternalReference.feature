Feature: CompanySearchExternalReferences
Below scenarios will verify the functionality of external references inside Company Search Module

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1. Verify Company Search External References Details	
	When I navigate to Company from dashboard	
	And I search for company "Test_Company"
	And I navigate to searched company
	And I navigate to External Refrences tab
	Then External references details should be displayed