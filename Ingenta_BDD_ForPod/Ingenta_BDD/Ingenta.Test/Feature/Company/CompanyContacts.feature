Feature: CompanyContacts
Below scenarios will verify the functionality of contacts inside Company Module

Background:
     Given I am logged in Ingenta application and user is redirected to dashboard
	When I navigate to Companies from dashboard
	And I search for company as "test_company" 
	And I navigate to searched company	

Scenario: 1. Verify Contacts Tab Details via Company	
	When I navigate to contacts tab
	And I click on New button in contacts tab
	Then Company Contacts tab details should be displayed


Scenario: 2. Creating New Contact	
	When I navigate to contacts tab
	And I click on New button in contacts tab
	And I enter contact details
	And I save the information details
	And I click on override button if exists
	Then contact should be saved with name field should be generated automatically
	#When I click on active button
	#Then contact should be inactive
	#When I click on active button
	#Then contact should be active
	#When I click on company button available in the header page
	#Then I should get redirected to company information page
	#When I navigate to contacts tab
	#Then New contact record should be created