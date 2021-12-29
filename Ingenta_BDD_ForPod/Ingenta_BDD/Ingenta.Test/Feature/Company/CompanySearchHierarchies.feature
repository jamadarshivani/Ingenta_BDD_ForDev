Feature: CompanySearchHierarchies
Below scenarios will verify the functionality of hierarchies inside Company Search Module

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1. Verify Company Search Hierarchies Details	
	When I navigate to Company from dashboard	
	And I search for company "TestCompany"
	And I navigate to searched company
	And I navigate to Hierarchy tab
	Then Hierarchy details should be displayed