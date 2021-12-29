Feature: Company_Notes
	

Background:
Given I am logged in Ingenta application and user is redirected to dashboard
	When I navigate to Companies from dashboard
	And I search for company as "testcompany" 
	And I navigate to searched company
	And I navigate to notes tab

Scenario: 1. Verfiying elements in Notes Tab	
	Then all the elements of notes tab should be displayed	

Scenario: 2. Creating a note and replying to the created note
	When I create a note
	And I click post button
	Then I should see the note with date,name and post should be created successfully under notes tab
	When I select the created note
	And I enter a reply note
	And I click reply button
	Then I should see that a reply note has been successfully created

Scenario: 3.Replying to note with blank editbox
	When I create a note
	And I click on post button
	And I select the created note
	And I click on post button
	Then I should see the error message under the editbox

Scenario: 4. Verify the starting date as today for the created note
	When I create a note
	And I click post button
	And I select the starting date as "current date"
	Then created note should be displayed in notes grid

	Scenario: 5. Verifying start date dropdown functionality for a past date
	When I create a note
	And I click post button
	And I select the starting date as "past date"
	Then created note should be displayed in notes grid

	Scenario: 6. Verifying start date dropdown functionality for a future date
	When I create a note
	And I click post button
	And I select the starting date as "future date"
	Then created note should be displayed in notes grid

	Scenario: 7. Verifying notes with a child note can be deleted
	When I create a note
	And I click post button
	And I select the created note
	And I enter a reply note
	And I click reply button
	And I select the parent note
	Then the delete note should be disabled

	Scenario: 8. Verifying notes without a child note cannot be deleted
	When I create a note
	And I click post button
	And I select the created note
	And I click delete note button
	Then the selected note should be deleted
	