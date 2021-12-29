Feature: ContactCreation
	
Background:
	Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1. Verifying new contact button functionality
	When I navigate to Contacts from dashboard
	And I click new contact button
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown	
	Then Contact Information tab details should be displayed

Scenario: 2. Creating a company from contact
	When I navigate to Contacts from dashboard
	And I click on New company button
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown
	And I enter mandatory Information details
	And I click on save button
	And I click on override button if exists
	Then tabs on the left should be enabled
	And save,save and close, close and active button should be disabled
	And stationary button should be displayed
	And company details should be saved successfully

Scenario: 3. Creating a contact under a contact tab
	When I navigate to Contacts from dashboard
	And I click on New company button
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown	
	And I enter mandatory Information details
	And I click on save button
	And I navigate to contacts tab
	And I click on New button in contacts tab
	And I enter contact details
	And I save the information details
	Then contact should be saved with name field should be generated automatically
	When I click on active button
	Then contact should be inactive
	When I click on active button
	Then contact should be active
	When I click on company button available in the header page
	Then I should get redirected to company information page
	When I navigate to contacts tab
	Then New contact record should be created

Scenario: 4. Verify History Button Functionality
	When I navigate to Contacts from dashboard
	And I click on New company button
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown	
	And I enter mandatory Information details
	And I click on save button
	And I navigate to contacts tab
	And I click on New button in contacts tab
	And I enter contact details
	And I save the information details
	And I navigate to History Tab from Contacts
	Then I should be navigated to the history tab

Scenario: 5. Verify Responsibilities Button Functionality
	When I navigate to Contacts from dashboard
	And I click on New company button
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown	
	And I enter mandatory Information details
	And I click on save button
	And I navigate to contacts tab
	And I click on New button in contacts tab
	And I enter contact details
	And I save the information details
	And I navigate to reponsibilities tab
	Then I should be navigated to the reponsibility tab

Scenario: 6. Verify Relationships Button Functionality
	When I navigate to Contacts from dashboard
	And I click on New company button
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown	
	And I enter mandatory Information details
	And I click on save button
	And I navigate to contacts tab
	And I click on New button in contacts tab
	And I enter contact details
	And I save the information details
	And I navigate to Relationships tab
	Then I should be navigated to the Relationships tab
	
Scenario: 7. Verify Opportunities Button Functionality
	When I navigate to Contacts from dashboard
	And I click on New company button
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown	
	And I enter mandatory Information details
	And I click on save button
	And I navigate to contacts tab
	And I click on New button in contacts tab
	And I enter contact details
	And I save the information details
	And I navigate to opportunites tab from contact
	Then I should be navigated to the Opportunities tab

Scenario: 8. Verify Notes Button Functionality
	When I navigate to Contacts from dashboard
	And I click on New company button
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown	
	And I enter mandatory Information details
	And I click on save button
	And I navigate to contacts tab
	And I click on New button in contacts tab
	And I enter contact details
	And I save the information details
	And I navigate to Notes tab
	Then I should be navigated to the Notes tab

Scenario: 9. Verify Attachements Button Functionality
	When I navigate to Contacts from dashboard
	And I click on New company button
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown	
	And I enter mandatory Information details
	And I click on save button
	And I navigate to contacts tab
	And I click on New button in contacts tab
	And I enter contact details
	And I save the information details
	And I navigate to Attachments tab
	Then I should be navigated to the Attachements tab

Scenario: 10. Verify External References Button Functionality
	When I navigate to Contacts from dashboard
	And I click on New company button
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown	
	And I enter mandatory Information details
	And I click on save button
	And I navigate to contacts tab
	And I click on New button in contacts tab
	And I enter contact details
	And I save the information details
	And I navigate to External References tab
	Then I should be navigated to the External References tab

Scenario: 11. Verify Documents Button Functionality
	When I navigate to Contacts from dashboard
	And I click on New company button
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown	
	And I enter mandatory Information details
	And I click on save button
	And I navigate to contacts tab
	And I click on New button in contacts tab
	And I enter contact details
	And I save the information details
	And I navigate to Documents tab
	Then I should be navigated to the Documents tab

Scenario: 12. Verify Web User Button Functionality
	When I navigate to Contacts from dashboard
	And I click on New company button
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown	
	And I enter mandatory Information details
	And I click on save button
	And I navigate to contacts tab
	And I click on New button in contacts tab
	And I enter contact details
	And I save the information details
	And I navigate to Web User tab
	Then I should be navigated to the Web User tab

Scenario: 13. Verify Campaign Button Functionality
	When I navigate to Contacts from dashboard
	And I click on New company button
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown	
	And I enter mandatory Information details
	And I click on save button
	And I navigate to contacts tab
	And I click on New button in contacts tab
	And I enter contact details
	And I save the information details
	And I navigate to Campaign tab
	Then I should be navigated to the Campaign tab