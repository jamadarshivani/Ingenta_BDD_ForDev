Feature: ContactCampaign
Below scenarios will verify the functionality of Contacts Campaign tab

Background:
Given I am logged in Ingenta application and user is redirected to dashboard
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to Campaign tab

Scenario: 1.Verify Campaign button details	
	Then Campaign tab details should be displayed

Scenario: 2.Verifying new Campaign button details
	When I click new campaign button
	Then New campaign details window should be displayed
	When I click on close campaign 
	Then Add campaign popup should be closed

Scenario: 3.Creating new Campaign
	When I create new campaign
	Then New campaign should be created




