Feature: Company_Responsibilities
	
Background:
    Given I am logged in Ingenta application and user is redirected to dashboard
	When I navigate to Companies from dashboard
	And I search for company as "testcompany" 
	And I navigate to searched company	
	And I navigate to Responsibilities tab

Scenario: 1. Verifying Responsibilities Tab Details
	
	Then Company Responsibilities tab details should be displayed

Scenario: 2. Verifying New responsibilities Tab Details
	When I navigate to new responsibility pop-up
	Then new responsibility pop-up details should be displayed

Scenario: 3. Verifying contact name ellipsis button functionality
	When I navigate to new responsibility pop-up
	And I click contact name ellipsis button
	Then all the details of the contact name ellipsis should be displayed

Scenario: 4. Verifying Search Functionality by Last Name in Contact Ellipsis
	When I navigate to new responsibility pop-up
	And I click contact name ellipsis button
	And I search for last name in contact ellipsis
	Then the search result with same last name should be displayed

Scenario: 5. Verifying Search Functionality by Company Name in Contact Ellipsis
	When I navigate to new responsibility pop-up
	And I click contact name ellipsis button
	And I search for company name in contact ellipsis
	Then the search result with same company name should be displayed

Scenario: 6. Verifying Search Functionality by Telephone in Contact Ellipsis
	When I navigate to new responsibility pop-up
	And I click contact name ellipsis button
	And I search for Telephone in contact ellipsis
	Then the search result with same telephone should be displayed

Scenario: 7. Verifying Search Functionality by Email in Contact Ellipsis
	When I navigate to Responsibilities tab
	And I navigate to new responsibility pop-up
	And I click contact name ellipsis button
	And I search for email in contact ellipsis
	Then the search result with same email should be displayed

Scenario: 8. Creating and Verifying A New Responsibility
	When I navigate to Responsibilities tab
	And I navigate to new responsibility pop-up
	And I click contact name ellipsis button
	And I select the contact name from ellipsis
	And I enter the details of the responsibility from the pop-up window
	And I save the responsibility from the pop-up window
	Then Details of company responsibility should be saved successfully

Scenario: 9. Check cancel button functionality
	When I navigate to Responsibilities tab
	And I view this responsibility button
	And I cancel the responsibility button
	Then Company Responsibilities tab details should be displayed

Scenario: 10. Deleting a responsibility
	When I navigate to Responsibilities tab
	And I select the responsibility
	And I delete the selected responsibility
	Then the responsibility will be deleted