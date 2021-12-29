Feature: CompanySearchContacts
Below scenarios will verify the functionality of contacts inside Company Search Module

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1. Verify Contacts Tab Details
	When I navigate to Company from dashboard	
	And I search for company "Test_Company"
	And I navigate to searched company
	And I navigate to contacts tab
	And I click on New button in contacts tab
	Then Company Contacts tab details should be displayed