Feature: ContactsLandingPage

Scenario: Contacts Landing Page from Homepage
		Given I am logged in Ingenta application and user is redirected to dashboard
		When I click on Contacts link from homepage
		Then Contact Management screen will be displayed with the different search criterias

Scenario: Contacts Landing Page from Main Menu
		Given I am logged in Ingenta application
		When I click on Contacts link from main menu
		Then Contact Management screen will be displayed with the different search criterias