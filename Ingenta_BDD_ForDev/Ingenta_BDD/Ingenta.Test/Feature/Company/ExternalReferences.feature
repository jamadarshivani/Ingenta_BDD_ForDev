Feature: ExternalReferences
	
Background:
Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1. Verfiying External Refrences Tab details in companies
	When I navigate to Companies from dashboard
	And I search for company as "testcompany"
	And I navigate to searched company 
	And I navigate to External Refrences tab
	Then External Reference details should be displayed

Scenario: 2. Verfiying External Refrences Tab details in contacts
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to External References tab
	Then External Reference details should be displayed