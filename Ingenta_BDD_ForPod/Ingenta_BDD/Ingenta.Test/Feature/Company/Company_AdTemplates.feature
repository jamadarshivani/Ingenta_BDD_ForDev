Feature: Company_AdTemplates
Background:
    Given I am logged in Ingenta application and user is redirected to dashboard
	When I navigate to Companies from dashboard	
	And I search for company as "Test_Company"
	And I navigate to searched company
	And I navigate to Ad Templates tab 


Scenario: 1. Verifying Ad Templates Tab Details	
	Then Company Ad Templates tab details should be displayed

	Scenario: 2. Verifying all the elements on new Ad template
	When I click on new button of Ad Template
	Then all the elements should be displayed for new ad templates window

	Scenario: 3. Creating and verifying ad templates
	When I create new template 	
	Then the ad template should be created successfully

	Scenario: 4. Verifying edit button functionality in new window for Ad Template
	When I create new template 	
	And I edit the ad template details 
	Then the edited ad template should be saved successfully

	Scenario: 5. Verifying close button functionality in new window for Ad Template	
	When I create new template 	
	And I select any created template
	And I close the ad template window
	Then Ad Template window should be closed successfully

   Scenario: 6. Verifying View Thumbnail functionality in new window for Ad Template
	When I select any created template
	Then Thumbnail should be clickable