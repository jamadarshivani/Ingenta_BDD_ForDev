Feature: Company_Creation

Background:
	Given I am logged in Ingenta application and user is redirected to dashboard


Scenario: 1. Verifying company page details when CCCTY flag is false in User Preference Default	
	When I set CCCTY flag in User Preference Default to "False" 
	And I navigate to Companies from dashboard	
	And I click on New company button
	Then I should be able to see details of the company information page

Scenario: 2. Verifying company page details when CCCTY flag is true in User Preference Default	
	When I set CCCTY flag in User Preference Default to "True" 
	And I navigate to Companies from dashboard	
	And I click on New company button	
	Then company type pop up should be displayed with company type dropdown
	When I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown
	Then the company type name should be displayed as "Advertiser"

Scenario: 3. Search button functionality - after creating an existing company	
	When I navigate to Companies from dashboard
	And I click on New company button
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown
	And I enter "5 Fifteen" in company name text field
	And I click on save button
	Then I should see the search,select,cancel and override buttons
	When I click on search button
	Then search company page details should be displayed

Scenario: 4. Select button functionality - after creating an existing company	
	When I navigate to Companies from dashboard
	And I click on New company button
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown
	And I enter "5 Fifteen" in company name text field	
	And I click on save button
	Then I should see the search,select,cancel and override buttons
	When I click on select button
	And I close the drop down
	Then search company page details should be displayed

Scenario: 5. Cancel button functionality - after creating an existing company	
	When I navigate to Companies from dashboard
	And I click on New company button
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown
	And I enter "5 Fifteen" in company name text field
	And I click on save button
	Then I should see the search,select,cancel and override buttons
	When I click on Cancel button
	Then save,save and close and close button should be enabled
	And search button should be disabled
	And possible matches grid will be dismissed

Scenario: 6. Override button functionality - after creating an existing company
	When I navigate to Companies from dashboard
	And I click on New company button	
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown	
	And I enter the Information details for a new company with Name as "Random I"
	And I click on save button
	And I click on Home button
	And I navigate to Companies from dashboard
	And I click on New company button
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown
	And I enter the Information details for a new company with Name as "Random I"
	And I click on save button
	And I click on override button if exists
	Then save,save and close, close and active button should be disabled
	And search and stationery button should be enabled
	And tabs on the left should be enabled

Scenario: 7. Creating non existing company with company type as Advertiser from company
	When I navigate to Companies from dashboard
	And I click on New company button
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown
	And I enter the Information details for a new company
	And I click on save button
	And I click on override button if exists
	Then tabs on the left should be enabled
	And save,save and close, close and active button should be disabled
	And stationary button should be displayed
	And company details should be saved successfully
		
Scenario: 8. Editing and Saving Company	
	When I navigate to Companies from dashboard
	And I click on New company button
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown	
	And I enter the Information details for a new company
	And I click save and close button	
	And I search for company 
	And I edit company information
	And I click on save button
	Then edited fields should be saved successfully.

Scenario: 9. Verifying History button functionality
	When I navigate to Companies from dashboard
	And I search for company as "testcompany"	
	And I navigate to searched company		
	And I navigate to contacts tab
	And I navigate to a created contact	
	And I navigate to History Tab from Contacts
	Then I should be navigated to the history tab

Scenario: 10. Verifying Responsibilities button functionality
	When I navigate to Companies from dashboard
	And I search for company as "testcompany"	
	And I navigate to searched company		
	And I navigate to contacts tab
	And I navigate to a created contact
	And I navigate to reponsibilities tab
	Then I should be navigated to the reponsibility tab	

Scenario: 11. Verifying Relationships button functionality
	When I navigate to Companies from dashboard
	And I search for company as "testcompany"	
	And I navigate to searched company		
	And I navigate to contacts tab
	And I navigate to a created contact
	And I navigate to Relationships tab
	Then I should be navigated to the Relationships tab

Scenario: 12. Verifying Opportunities button functionality
	When I navigate to Companies from dashboard
	And I search for company as "testcompany"	
	And I navigate to searched company		
	And I navigate to contacts tab
	And I navigate to a created contact
	And I navigate to opportunites tab from contact
	Then I should be navigated to the Opportunities tab

Scenario: 13. Verifying Notes button functionality
	When I navigate to Companies from dashboard
	And I search for company as "testcompany"	
	And I navigate to searched company		
	And I navigate to contacts tab
	And I navigate to a created contact	
	And I navigate to Notes tab
	Then I should be navigated to the Notes tab

Scenario: 14. Verifying Attachement button functionality
	When I navigate to Companies from dashboard
	And I search for company as "testcompany"	
	And I navigate to searched company		
	And I navigate to contacts tab
	And I navigate to a created contact
	And I navigate to Attachments tab
	Then I should be navigated to the Attachements tab

Scenario: 15. Verify Web User Button Functionality
	When I navigate to Companies from dashboard
	And I search for company as "testcompany"	
	And I navigate to searched company		
	And I navigate to contacts tab
	And I navigate to a created contact
	And I navigate to Web User tab
	Then I should be navigated to the Web User tab

	
Scenario: 16. Verify Campaign Button Functionality
	When I navigate to Companies from dashboard
	And I search for company as "testcompany"	
	And I navigate to searched company		
	And I navigate to contacts tab
	And I navigate to a created contact
	And I navigate to Campaign tab
	Then I should be navigated to the Campaign tab

Scenario: 17. Verify External References Button Functionality
	When I navigate to Companies from dashboard
	And I search for company as "testcompany"	
	And I navigate to searched company		
	And I navigate to contacts tab
	And I navigate to a created contact
	And I navigate to External References tab
	Then I should be navigated to the External References tab

Scenario: 18. Verify Documents Button Functionality
	When I navigate to Companies from dashboard
	And I search for company as "testcompany"	
	And I navigate to searched company		
	And I navigate to contacts tab
	And I navigate to a created contact
	And I navigate to Documents tab
	Then I should be navigated to the Documents tab


