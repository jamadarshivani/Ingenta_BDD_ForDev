Feature: Company_Relationships
	
	Background:
	Given I am logged in Ingenta application and user is redirected to dashboard
	When I navigate to Companies from dashboard
	And I search for company as "testcompany"
	And I navigate to searched company 
	And I navigate to relationship tab

Scenario: 1.Verifying new relationships button functionality	
	When I click new relationship button
	Then all the elements of the new relationship tab should be visible

Scenario: 2.Creating a new linked relationship
	When I click new relationship button
	And I select relationship type as linked
	And I enter the details for the linked relationship
	And I save the created relationship
	And I navigate to relationship tab
	Then the created linked relationship should be succesfully visible

Scenario: 3.Creating a new owner relationship
	When I click new relationship button
	And I enter the details for the owner relationship
	And I save the created relationship
	And I navigate to relationship tab
	Then the created owner relationship should be succesfully visible

Scenario: 4. Verifying current and future radio button functionality	
	Then the start date of existing relationships should be greater than or equal to the present date should be visible

Scenario: 5. Verifying all radio button functionality
	When I navigate to relationship tab
	And I select all radio button
	Then all the existing relationships should be visible

Scenario: 6. Verifying edit the relationship button functionality
	When I click on edit this relationship button
	Then all the elements the created relationship should be visible
	
Scenario: 7. Verifying Sales Assignment Button Functionality
	When I click on edit this relationship button
	And I click sales assignment button
	Then Company Sales Assignnment tab details should be displayed

Scenario: 8. Verifying New Sales Assignment Button Functionality
	When I click on edit this relationship button
	And I click sales assignment button
	And I navigate to new Sales Assignment Window
	Then all the details of the new sales assignment window should be displayed

Scenario: 9. Creating and Verifying a New Sales Assignment
	When I click on edit this relationship button
	And I click sales assignment button
	And I navigate to new Sales Assignment Window
	And I enter the details of the new Sales Assignment to be verified
	And I save the details of the Sales Assignment
	And I close the sales assignment window
	Then details of the sales assignment should be displayed successfully under relationship