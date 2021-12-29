Feature: Company_Brands

Background:
	Given I am logged in Ingenta application and user is redirected to dashboard

	When I navigate to Companies from dashboard
	And I search for company as "testcompany"
	And I navigate to searched company 
	And I click on brands Tab

Scenario: 1. Verifying brands tab details	
	Then all the elements of the brands tab should be visible
	
Scenario: 2. Verifying new button functionality in brands
	When I click new button in brands tab
	Then New brand details should be displayed

Scenario: 3. Saving company details and manually entering the brand name
	When I click new button in brands tab
	And I enter the details under information tab of brands
	And I enter the brand name as "test brand"
	And I click on save button
	Then details under information tab of brands will be visible
	And the tabs on the left menu will be enabled
	

Scenario: 4. Saving company details and selecting the brand name as comapany name
	When I click on cog button
	Then details under information tab of brands will be visible with company name same as the brand name
	And the tabs on the left menu will be enabled
	
Scenario: 5. Verifying relationships button functionality
	When I click the first brand's cog button
	And I click relationship tab
	Then the relationship tab's elements should be visible
	
Scenario: 6. Verifying sales assignment button functionality
	When I click the first brand's cog button
	And I click sales assignment tab
	Then the sales assignment tab's elements should be visible

Scenario: 7. Verifying company button functionality under view the brands
	When I click the first brand's cog button
	And I click company button in view brands tab
	Then I should be able to see details of the company information page

Scenario: 8. Verifying view brand and detach the brand are visible
	Then view brand and detach the brand should be visible

Scenario: 9. Detaching and reassigning brands
	When I click the first brand's pin button
	And I select the new company in the new window
	And I click on Detach and Reassign Brand
	Then the brand should be successfully be detached and new brand should be reassigned