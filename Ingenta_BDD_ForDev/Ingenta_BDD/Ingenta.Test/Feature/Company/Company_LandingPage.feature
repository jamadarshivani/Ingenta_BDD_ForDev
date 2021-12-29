Feature: CompanyLandingPage

Background:
	Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1.Redirecting to company landing page from home page
	When I navigate to Companies from dashboard
	Then search company page details should be displayed

Scenario: 2.Redirecting to company landing page from menu option
	When I click Company link from menu option
	Then search company page details should be displayed

Scenario: 3. Selecting company from the search for dropdown
	When I navigate to Companies from dashboard
	And I select the company option from search for dropdown
	Then the company option should be selected successfully
	