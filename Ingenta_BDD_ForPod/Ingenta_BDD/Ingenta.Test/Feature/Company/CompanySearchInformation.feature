Feature: CompanySearchInformation
Below scenarios will verify the functionality of Information Tab in Searching for companies

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1. Verifying Email popup details
	When I navigate to Company from dashboard	
	And I search for company "Test_Company"
	And I navigate to searched company
	And I Click text in “Email” text box.
	Then Email details popup should be displayed

Scenario: 2. Verifying To Address popup details
	When I navigate to Company from dashboard	
	And I search for company "Test_Company"
	And I navigate to searched company
	And I Click text in “Email” text box.	
	And I click on To button in Email Popup
	Then Email Address Book details popup should be displayed

Scenario: 3. Email popup buttons functionality
	When I navigate to Company from dashboard	
	And I search for company "Test_Company"
	And I navigate to searched company
	And I Click text in “Email” text box.
	And I verify email popup functionality