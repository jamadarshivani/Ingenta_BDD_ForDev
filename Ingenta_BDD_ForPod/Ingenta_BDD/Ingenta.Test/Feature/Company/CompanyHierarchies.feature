Feature: CompanyHierarchies
Below scenarios will verify the functionality of hierarchies inside Company Module

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1. Verify Hierarchies Details	
	When I navigate to Companies from dashboard
	And I search for company as "testcompany" 
	And I navigate to searched company
	And I navigate to Hierarchy tab
	Then Hierarchy details should be displayed

Scenario: 2. Creating New Hierarchies	
	When I navigate to Company from dashboard
	And I click on New button	
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown	
	And I enter mandatory Information details
	And I save the information details
	And I navigate to Hierarchy tab
	And I click on create new button and click on Ok button in popup
	Then Current company name should be displayed in ultimate parent field
	And Current company name should be displayed in company text box
	And create new button should be disabled
	And move button should be enabled
	When I click on move button
	Then company search by hierarchy popup details should be displayed
