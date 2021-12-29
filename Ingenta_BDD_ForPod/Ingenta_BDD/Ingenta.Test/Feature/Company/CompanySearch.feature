Feature: CompanySearch
Below scenarios will verify the functionality of Searching for companies

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1. Searching an existing company	
	When I navigate to Company from dashboard	
	And I search for company "Adams State College"
	Then "Adams State College" company should be displayed in the result

Scenario: 2. Searching a non existing company	
	When I navigate to Company from dashboard	
	And I search for company "Infosys"
	Then Nothing should be displayed in the result

Scenario: 3. Searching a company by incomplete Company Name	
	When I navigate to Company from dashboard	
	And I search for company "Vic"
	Then all the companies starting with the text "Vic" should be displayed in the result

Scenario: 4. Searching an existing company by Last Name
	When I navigate to Company from dashboard	
	And I search for company "Pendlebury" by last name
	Then "Adams State College" company should be displayed in the result

Scenario: 5. Searching an existing company by Town
	When I navigate to Company from dashboard	
	And I search for company "Alamosa" by town
	Then all the companies having "Alamosa" as town should be displayed in the result

Scenario: 6. Searching an existing company by Postal Code
	When I navigate to Company from dashboard	
	And I search for company "81102" by postal code
	Then all the companies having "81102" as postal code should be displayed in the result

Scenario: 7. Searching an existing company by Telephone Number
	When I navigate to Company from dashboard	
	And I search for company "719-587-7011" by telephone number
	Then all the companies having "719-587-7011" as telephone number should be displayed in the result

Scenario: 8. Searching an existing company by Country
	When I navigate to Company from dashboard	
	And I search for company "United States" by country
	Then all the companies having "United States" as country should be displayed in the result

Scenario: 9. Searching an existing company by Company Type
	When I navigate to Company from dashboard	
	And I search for company "Advertiser" by company type
	Then all the companies having "Advertiser" as company type should be displayed in the result

Scenario: 10. Searching active existing companies
	When I navigate to Company from dashboard	
	And I search for "Active" companies
	Then all the "Active" companies should be displayed in the result

Scenario: 11. Searching In active existing companies
	When I navigate to Company from dashboard	
	And I search for "Inactive" companies
	Then all the "Inactive" companies should be displayed in the result
	
Scenario: 12. Verifying Site Display Mode Button Functionality
	When I navigate to Company from dashboard
	And I search for the company
	And I click Site Display Mode button
	Then search company page details should be displayed

Scenario: 13.Verifying Save Search Results button functionality
	When I navigate to Company from dashboard
	And I search for the company
	And I click Save Search Results button
	Then Save Search Results Page details should be displayed successfully

Scenario: 14.Verifying Save Search Results save button functionality
	When I navigate to Company from dashboard
	And I search for the company
	And I click Save Search Results button
	And I save the save search results
	Then search company page details should be displayed with run stationery button

Scenario: 15. Verifying Open Search Results button functionality
	When I navigate to Company from dashboard
	And I search for the company
	And I click Open Search Results button
	Then Open Search Results button details should be displayed successfully
	When I click on cancel Open Search Results button
	Then search company page details should be displayed
	When I navigate to searched company
	Then Company Information page details should be displayed successfully