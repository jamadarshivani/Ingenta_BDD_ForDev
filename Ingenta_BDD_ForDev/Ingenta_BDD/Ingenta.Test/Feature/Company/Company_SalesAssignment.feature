Feature: Company_SalesAssignment
	
Background:
    Given I am logged in Ingenta application and user is redirected to dashboard
	When I navigate to Companies from dashboard
	And I search for company as "testcompany" 
	And I navigate to searched company	
	And I navigate to Sales Assignnment tab

Scenario: 1. Verifying Sales Assignnment Tab Details	
	Then Company Sales Assignnment tab details should be displayed

Scenario: 2. Verifying New Sales Assignment Button Functionality
	When I navigate to new Sales Assignment Window
	Then all the details of the new sales assignment window should be displayed

Scenario: 3. Entering and Verifying Sales Assignment Details
	When I navigate to new Sales Assignment Window
	And I enter the details of the new Sales Assignment
	And I save the details of the Sales Assignment
	And I close the sales assignment window
	Then details of the sales assignment should be displayed successfully

Scenario: 4. Entering Same Role and Media Group For A Sales Assignment 
	When I navigate to new Sales Assignment Window
	And I enter the details of the new Sales Assignment
	And I save the details of the Sales Assignment
	And I close the sales assignment window
	And I navigate to new Sales Assignment Window after saving the details
	And I enter the details of the new Sales Assignment
	And I save the details of the Sales Assignment
	Then the assignment already exists pop-up should be displayed

Scenario: 5. Entering Same Role and Different Media Group For A Sales Assignment 
	When I navigate to new Sales Assignment Window
	And I enter the details of the new Sales Assignment
	And I save the details of the Sales Assignment
	And I close the sales assignment window
	And I navigate to new Sales Assignment Window after saving the details
	And I enter the details of the new Sales Assignment with different media group
	And I save the details of the Sales Assignment
	And I close the sales assignment window
	Then details of both the sales assignment should be displayed successfully
	
Scenario: 6. Entering and Verifying Sales Assignment Details with media
	When I navigate to new Sales Assignment Window
	And I enter the details of the new Sales Assignment along with Media details
	And I save the details of the Sales Assignment
	And I close the sales assignment window
	Then details of the sales assignment and media should be displayed successfully

Scenario: 7. Entering Same Role and Media Group For A Sales Assignment With Media
	When I navigate to new Sales Assignment Window
	And I enter the details of the new Sales Assignment along with Media details
	And I save and close the details of the Sales Assignment	
	And I navigate to new Sales Assignment Window after saving the details
	And I enter the details of the new Sales Assignment along with Media details
	And I save and close the details of the Sales Assignment
	Then details of the sales assignment and media should be displayed successfully

Scenario: 8. Entering Different Sales Person For A Sales Assignment With Media
	When I navigate to new Sales Assignment Window
	And I enter the details of the new Sales Assignment along with Media details
	And I save and close the details of the Sales Assignment
	Then details of the sales assignment and media should be displayed successfully
	When I navigate to new Sales Assignment Window after saving the details
	And I enter the details of the new Sales Assignment along with Media details with different sales person
	And I save and close the details of the Sales Assignment
	Then details of the sales assignment and media should be displayed successfully with updated sales person

Scenario: 9. Verify Current Radio Button Functionality
	When I navigate to new Sales Assignment Window
	And I enter the details of the new Sales Assignment with "past date"
	And I save and close the details of the Sales Assignment
	And I navigate to new Sales Assignment Window again
	And I enter the details of the new Sales Assignment with "current date"
	And I save and close the details of the Sales Assignment
	And I select the sales assignment as current
	Then Only current and future assignments for the selected media will be displayed in the grid.

Scenario: 10. Verify All Radio Button Functionality
	When I navigate to new Sales Assignment Window
	And I enter the details of the new Sales Assignment with "past date"
	And I save and close the details of the Sales Assignment
	And I navigate to new Sales Assignment Window again
	And I enter the details of the new Sales Assignment with "current date"
	And I save and close the details of the Sales Assignment
	And I navigate to new Sales Assignment Window again
	And I enter the details of the new Sales Assignment with "future date"
	And I save and close the details of the Sales Assignment	
	And I select the sales assignment as all
	Then All the assignments for the selected media should be displayed in the grid.

Scenario: 11. Verify Edit Button Functionality
	When I navigate to new Sales Assignment Window
	And I enter the details of the new Sales Assignment
	And I save and close the details of the Sales Assignment	
	And I edit the selected sales assignment
	And I save and close the details of the Sales Assignment
	Then the updates to sales assignment should saved successfully

Scenario: 12. Verify Delete Button Functionality
	When I navigate to new Sales Assignment Window
	And I enter the details of the new Sales Assignment to be deleted
	And I save and close the details of the Sales Assignment
	And I select the sales assignment as all
	And I select the created sales assignment
	And I delete the selected sales assignment
	Then the sales assignment should be deleted successfully