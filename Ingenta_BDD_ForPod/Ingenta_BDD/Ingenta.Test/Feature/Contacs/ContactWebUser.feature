Feature: ContactWebUser
Below scenarios will verify the functionality of Contacts Web User tab

Background:
Given I am logged in Ingenta application and user is redirected to dashboard
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to Web User tab

Scenario: 1.Verify Web User button details
	Then Website User details should be displayed

Scenario: 2.Verifying new Web Site User button details
	When I click new web site users button
	Then New web site user details window should be displayed


Scenario: 3. Creating new Web Site User 
	When I create new website user
	Then New website user should be created

Scenario: 4. Creating new Web Site User with invalid data
	When I create new website user with invalid data
	Then I should get an error message
	When I close Web site user window
	Then Web site user window should be closed