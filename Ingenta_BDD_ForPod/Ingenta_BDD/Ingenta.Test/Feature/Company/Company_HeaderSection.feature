Feature: Company_HeaderSection

Background:
Given I am logged in Ingenta application and user is redirected to dashboard
	When I navigate to Companies from dashboard
	And I search for company as "testcompany" 
	And I navigate to searched company	

Scenario: 1. Verifying search button functionality in header	
	When I click on search button in the header
	Then the company details should be displayed succesfully

Scenario: 2. Verifying stationery button functionality in header		
	When I click on stationery button in the header
	Then the stationery details should be displayed successfully

Scenario: 3. Verifying active/inactive button functionality in header of company search	
	When I click on active/inactive button in the header of company
	Then the button should be displayed as active or inactive as expected of company
	When I click on active/inactive button in the header of company
	Then the button should be displayed as active or inactive as expected of company


