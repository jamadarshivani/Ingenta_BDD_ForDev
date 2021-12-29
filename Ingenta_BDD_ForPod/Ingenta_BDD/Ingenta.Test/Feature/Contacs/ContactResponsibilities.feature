Feature: ContactResponsibilities
Below scenarios will verify the functionality of Responsibilities inside Contact Module

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to Responsibilities tab from contact

Scenario: 1. Verifying Responsibilities Tab Details from Contact	
	Then Contact Responsibilities tab details should be displayed

Scenario: 2. Verifying New responsibilities Tab Details from Contact
	When I navigate to new responsibility pop-up
	Then new responsibility pop-up details should be displayed

Scenario: 3. Verifying contact name ellipsis button functionality from Contact
	When I navigate to new responsibility pop-up
	And I click contact name ellipsis button
	Then all the details of the contact name ellipsis should be displayed

Scenario: 4. Creating and Verifying A New Responsibility	
	When I navigate to new responsibility pop-up
	And I create responsibility
	Then the details of the responsibility should be saved successfully

Scenario: 5. Deleting a responsibility	
	When I navigate to new responsibility pop-up
	And I create responsibility
	And I select the responsibility
	And I delete the selected responsibility
	Then the responsibility should be deleted