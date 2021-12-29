Feature: ContactDocument
Below scenarios will verify the functionality of Contacts Documents tab

Background:
Given I am logged in Ingenta application and user is redirected to dashboard
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to Documents tab

Scenario: 1.Verify Documents tab details	
	Then Documents tab details should be displayed


Scenario: 2.Update Document Details
	When I update the document details	
	And I navigate to Documents tab
	Then Documents details should be updated