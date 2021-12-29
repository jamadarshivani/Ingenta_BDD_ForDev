Feature: Company_UserForms
	
Background:
    Given I am logged in Ingenta application and user is redirected to dashboard
	When I navigate to Companies from dashboard
	And I search for company as "testcompany" 
	And I navigate to searched company	
	And I navigate to Electronics Classification tab

Scenario: 1. Verifying Electronics Classification Button Functionality	
	Then Company Electronics Classification tab details should be displayed

Scenario: 2. Entering and Verifying The Details For The Electronics Classification Tab Are Saved Successfully	
	When I create Electronics Classification
	Then the details for electronics classification should be saved successfully

Scenario: 3. Verifying Reset Button Functionality For Electronics Classification
	When I create Electronics Classification
	And I enter additional telephone details
	And I reset the details for the electronics classification
	Then the details for electronics classification should be saved successfully

Scenario: 4. Verifying Delete Button Functionality For Electronics Classification
	When I create Electronics Classification
	Then the details for electronics classification should be saved successfully
	When I delete the electronics classification details
	Then the saved details for the electronics classification should be cleared successfully
