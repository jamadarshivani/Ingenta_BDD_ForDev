Feature: CompanySearchSalesAssignments
Below scenarios will verify the functionality of Sales Assignments inside Company Search Module

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1. Verifying Sales Assignments Tab Details
	When I navigate to Company from dashboard	
	And I search for company "Test_Company"
	And I navigate to searched company
	And I navigate to Sales Assignments tab
	Then Sales Assignments tab details should be displayed