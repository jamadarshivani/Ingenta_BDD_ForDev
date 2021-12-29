Feature: CompanyFinance
Below scenarios will verify the functionality of Finance inside Company Module

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard	
	When I navigate to Company from dashboard
	And I click on New button
	And I select the company type from the pop-up as "Advertiser"
	And I click OK button in the dropdown

Scenario: 1. Verify Finance Details	
	When I enter mandatory Information details
	And I save the information details
	And I navigate to Finance tab
	And I click on first Sales account from the sales accounts grid 
	And I click on delete button
	And I navigate to Finance tab
	Then Finance details should be displayed

Scenario: 2. Saving Finance Details 	
	When I enter mandatory Information details
	And I save the information details
	And I click on override button if exists
	And I navigate to Finance tab
	And I enter Finance details with tax registration no as "TAX12345"
	And I save the information details
	And I navigate to Finance tab
	Then verfiy the finance details are saved with tax registration no as "TAX12345" and New button is enabled

Scenario: 3. Verify New Sales Account Details in Finance 	
	When I enter mandatory Information details
	And I save the information details
	And I click on override button if exists
	And I navigate to Finance tab
	And I enter Finance details with tax registration no as "TAX12345"
	And I save the information details
	And I navigate to Finance tab
	And I click on New button in finance details screen
	Then New window pop up should be opened with New Sales Account Details

Scenario: 4. Verify Adderss Tab Fields in New Sales Account	
	When I enter mandatory Information details
	And I save the information details
	And I click on override button if exists
	And I navigate to Finance tab	
	And I click on New button in finance details screen	
	And I navigate to Address/Contact tab
	Then Address tab fields will be displayed

Scenario: 5. Create New Sales Account which is not a global account with Copy address functionality 
	#When I enter mandatory Information details
	#And I save the information details
	#And I click on override button if exists
	#And I navigate to Finance tab
	#And I enter Finance details with tax registration no as "TAX12345"
	#And I save the information details
	When I navigate to Home Page
	And I navigate to Company from dashboard
	And I search for company as "testcompany"
	And I navigate to searched company
	And I navigate to Finance tab
	And I click on New button in finance details screen
	And I enter sales account details "DoNotAutoGenerateSalesAccountCode"
	And I navigate to Address/Contact tab
	And I click on copy address button
	And I navigate to Address/Contact tab
	Then address will be copied which was entered in Company Information page
	When I navigate to schedule tab
	And I enter schedule details
	And I save the information details available in schedules tab
	And I click on Information tab
	And I save the information details
	Then Details in all three tabs should be saved successfully "234, Progress Business Park"	

Scenario: 6. Create New Sales Account which is not a global account Information Tab with manual address functionality	
	#When I enter mandatory Information details
	#And I save the information details
	#And I click on override button if exists
	#And I navigate to Finance tab
	#And I enter Finance details with tax registration no as "TAX12345"
	#And I save the information details
	When I navigate to Home Page
	And I navigate to Company from dashboard
	And I search for company as "testcompany"
	And I navigate to searched company
	And I navigate to Finance tab
	And I click on New button in finance details screen
	And I enter sales account details "DoNotAutoGenerateSalesAccountCode"
	And I navigate to Address/Contact tab	
	And I enter Address/Contact details
	And I navigate to schedule tab
	And I enter schedule details
	And I save the information details available in schedules tab
	And I click on Information tab
	And I save the information details
	Then Details in all three tabs should be saved successfully "Manual Address Line 1"

Scenario: 7. Edit existing Sales Account	
	#When I enter mandatory Information details
	#And I save the information details
	#And I click on override button if exists
	#And I navigate to Finance tab
	#And I enter Finance details with tax registration no as "TAX12345"
	#And I save the information details
	When I navigate to Home Page
	And I navigate to Company from dashboard
	And I search for company as "testcompany"
	And I navigate to searched company
	And I navigate to Finance tab
	And I click on New button in finance details screen
	And I enter sales account details "AutoGenerateSalesAccountCode"
	And I navigate to Address/Contact tab	
	And I enter Address/Contact details			
	And I save the information details
	Then Sales account code should be automatically generated
	When I click on close button to close the Sales account popup
	And I navigate back to Finance tab
	And I click on Sales account from the sales accounts grid 
	And I click on edit button
	And I edit sales account details
	And I save the information details
	Then the edited sales account should be saved successfully.


Scenario: 8. Delete Existing Sales Account	
	#When I enter mandatory Information details
	#And I save the information details
	#And I click on override button if exists
	#And I navigate to Finance tab
	#And I enter Finance details with tax registration no as "TAX12345"
	#And I save the information details
	When I navigate to Home Page
	And I navigate to Company from dashboard
	And I search for company as "testcompany"
	And I navigate to searched company
	And I navigate to Finance tab
	And I click on New button in finance details screen
	And I enter sales account details "AutoGenerateSalesAccountCode"
	And I navigate to Address/Contact tab	
	And I enter Address/Contact details			
	And I save the information details	
	And I click on close button to close the Sales account popup
	And I navigate back to Finance tab
	And I delete all the sales accounts
	#And I click on first Sales account from the sales accounts grid 
	#And I click on delete button
	#And I navigate to Finance tab
	#And I click on first Sales account from the sales accounts grid 
	#And I click on delete button
	#And I navigate to Finance tab
	Then edit and delete button should be disabled