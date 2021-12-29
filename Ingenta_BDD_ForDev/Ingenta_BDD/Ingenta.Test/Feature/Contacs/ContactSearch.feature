Feature: ContactSearch
Below scenarios will verify the functionality of Searching for contacts

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1. Searching an existing Contact by Last Name
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	Then "Pendlebury" Contact should be displayed in the result

Scenario: 2. Searching an existing Contact by First Name
	When I navigate to Contacts from dashboard	
	And I search for Contact "Peter" by first name	
	Then all the contacts having "Peter" as first name should be displayed in the result

Scenario: 3. Searching an existing Contact by Job Title
	When I navigate to Contacts from dashboard 	
	And I search for Contact "Advertising Manager" by job title
	Then all the contacts having "Advertising Manager" as Job Title should be displayed in the result

Scenario: 4. Searching an existing Contact by E-Mail
	When I navigate to Contacts from dashboard 	
	And I search for Contact "peter.Pendlebury@adams.com" by E-Mail
	Then all the contacts having "peter.Pendlebury@adams.com" as E-Mail address should be displayed in the result
	
Scenario: 5. Searching an existing Contact by Telphone
	When I navigate to Contacts from dashboard 	
	And I search for Contact "719-587-7011" by Telephone
	Then all the contacts having "719-587-7011" as telphone number should be displayed in the result
	
Scenario: 6. Searching an existing Contact by Company
	When I navigate to Contacts from dashboard 	
	And I search for Contact "Adams State College" by Company
	Then all the contacts having "Adams State College" as Company should be displayed in the result

Scenario: 7. Searching an existing Contact by Postal Code
	When I navigate to Contacts from dashboard 	
	And I search for Contact "81102" by PostalCode
	Then all the contacts having "81102" as postalcode should be displayed in the result
		
Scenario: 8. Searching an existing Contact by Country
	When I navigate to Contacts from dashboard 	
	And I search for Contact "United States" by country
	Then all the contacts having "United States" as country should be displayed in the result

Scenario: 9. Searching active existing contacts
	When I navigate to Contacts from dashboard 	
	And I search for "Active" contacts
	Then all the "Active" contacts should be displayed in the result

Scenario: 10. Searching In active existing contacts
	When I navigate to Contacts from dashboard
	And I search for "Inactive" contacts
	Then all the "Inactive" contacts should be displayed in the result

Scenario: 11. Search Button Functionality in header section via contacts
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I click on Search Button available in the header
	Then Contact Management Screen with different search criterias should be displayed for contacts	

Scenario: 12. Verifying active/inactive button functionality in header	
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact	
	And I click on active/inactive button in the header
	Then the button should be displayed as active or inactive as expected
	When I click on active/inactive button in the header
	Then the button should be displayed as active or inactive as expected