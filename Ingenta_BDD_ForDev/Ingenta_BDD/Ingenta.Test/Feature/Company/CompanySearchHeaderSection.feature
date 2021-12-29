Feature: CompanySearchHeaderSection
Below scenarios will verify the functionality of Territories inside Company Search Module

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1. Verifying Search Button Details available in the header
	When I navigate to Company from dashboard	
	And I search for company "Test_Company"
	And I navigate to searched company
	And I click on Search Button available in the header
	Then Contact Management Screen with different search criterias should be displayed


Scenario: 2. Verifying Stationery Button Details available in the header
	When I navigate to Company from dashboard	
	And I search for company "Test_Company"
	And I navigate to searched company
	And I click on Stationery Button available in the header
	Then Stationery popup should be displayed

Scenario: 3. Verifying Active Checkbox functionality available in the header
	When I navigate to Company from dashboard	
	And I search for company "Test_Company"
	And I navigate to searched company
	And I click on active checkbox available in the header
	Then Active checkbox should be renamed to Inactive
	When I edit Market Name field in information
	And I save the information details
	Then Save , Save and Close and Close buttons will be disabled
	When I edit Market Name field in information
	And I save and close information details
	Then Data will be saved and Contact Management screen should be displayed.		
	When I navigate to searched company
	And I edit Market Name field in information
	And I close the information details
	Then Confirmation popup should be displayed	
	When I dismiss confirmation popup
	And I close the information details
	And I Accept confirmation popup
	Then Data will be saved and Contact Management screen should be displayed.	