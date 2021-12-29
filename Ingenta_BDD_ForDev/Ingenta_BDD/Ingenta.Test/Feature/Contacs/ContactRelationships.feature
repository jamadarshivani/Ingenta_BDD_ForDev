Feature: ContactRelationships
Below scenarios will verify the functionality of Relationships inside ContactModule

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1. Verify Relationships Tab Details from Contact
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to relationship tab from contact
	Then Company relationship tab details should be displayed

Scenario: 2.Verifying new relationships button functionality
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to relationship tab from contact
	And I click new relationship button
	Then all the elements of the new relationship tab should be visible

Scenario: 3.Creating a new linked relationship
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to relationship tab from contact
	And I create new linked relationship	
	And I navigate to relationship tab from contact
	Then Created Linked relationship should be displayed

Scenario: 4.Creating a new owner relationship
	When I navigate to Contacts from dashboard
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to relationship tab from contact
	And I create new owner relationship
	And I navigate to relationship tab from contact
	Then Created contact owner relationship should be displayed

Scenario: 5. Verifying current and future radio button functionality
	When I navigate to Contacts from dashboard
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to relationship tab from contact
	Then Only those relationships should be displayed which have start date in past but end date is a future date
	
Scenario: 6. Verifying all radio button functionality
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to relationship tab from contact
	And I select all radio button
	Then all the existing relationships should be displayed

Scenario: 7. Verifying edit the relationship button functionality
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to relationship tab from contact
	And I click on edit this relationship button
	Then all the elements the created relationship should be visible

Scenario: 8. Verifying Sales Assignnment Tab Details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to relationship tab from contact
	And I click on edit this relationship button
	And I navigate to Sales Assignnment tab from relationship
	Then Sales Assignments tab details should be displayed

Scenario: 9. Cretaing New Sales Assignment
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to relationship tab from contact
	And I click on edit this relationship button
	And I navigate to Sales Assignnment tab from relationship
	And I select all radio button in Sales Assignemnts
	And I create new sales assignment	
	Then Sales assignment details should be displayed
	
Scenario: 10. Verifying current radio button functionality for Sales Assignments
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to relationship tab from contact
	And I click on edit this relationship button
	And I navigate to Sales Assignnment tab from relationship
	And I select all radio button in Sales Assignemnts
	And I create current and past sales assignment
	And I select current radio button in Sales Assignemnts
	Then Only current and future assignments for the selected media should be displayed in the grid.

Scenario: 11. Verifying All radio button functionality for Sales Assignments
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to relationship tab from contact
	And I click on edit this relationship button
	And I navigate to Sales Assignnment tab from relationship
	And I select all radio button in Sales Assignemnts
	And I create future sales assignment
	And I select current radio button in Sales Assignemnts
	And I select all radio button in Sales Assignemnts
	Then All the assignments for the selected media should be displayed in the grid.

Scenario: 12. Verifying edit the sales assignment button functionality
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to relationship tab from contact
	And I click on edit this relationship button
	And I navigate to Sales Assignnment tab from relationship
	And I select all radio button in Sales Assignemnts
	And I create new sales assignment	
	And I edit Sales Assignment
	Then Selected Sales assignment should be displayed

Scenario: 13. Verifying Delete Sales assignment button functionality
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to relationship tab from contact
	And I click on edit this relationship button
	And I navigate to Sales Assignnment tab from relationship
	And I select all radio button in Sales Assignemnts
	And I create new sales assignment	
	And I Select Sales Assignment to be deleted
	And I Delete Sales Assignment
	Then Selected Sales assignment should be deleted