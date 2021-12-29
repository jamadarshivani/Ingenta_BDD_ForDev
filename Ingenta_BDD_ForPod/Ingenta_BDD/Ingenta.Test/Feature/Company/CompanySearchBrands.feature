Feature: CompanySearchBrands
Below scenarios will verify the functionality of Brands inside Company Search Module

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1. Verify Brands Tab Details
	When I navigate to Company from dashboard	
	And I search for company "Test_Company"
	And I navigate to searched company
	And I navigate to brands tab
	Then Company brands tab details should be displayed