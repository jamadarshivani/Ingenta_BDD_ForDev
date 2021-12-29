Feature: Company_History

Background:
	Given I am logged in Ingenta application and user is redirected to dashboard
	When I navigate to Companies from dashboard
	And I search for company as "testcompany"
	And I navigate to searched company
	And I navigate to History Tab
	

Scenario: 1. Verifying history tab details
	Then I should be navigated to the history tab

Scenario: 2. Verifying New Task button details
	When I click on the New Task button
	Then New Task details should be displayed	

Scenario: 3. Verify company ellipsis button pop-up
	When I click on the New Task button
	And I click on the company ellipsis button
	Then I should be able to see the company details pop-up

Scenario: 4. Verify contact ellipsis button pop-up
	When I click on the New Task button
	And I click on the contact ellipsis button
	Then I should be able to see the contact details pop-up

Scenario: 5. Saving information details in new history tab
	When I click on the New Task button
	And I enter the information under new task tab
	And I click on save button
	Then all the details of the information tab should be saved successfully
	And save and save and close button will be disabled 
	And delete,stationery and create booking button will be displayed
	And title should be combination of company Name , Contact Name and Subject
	And task and user forms tabs should be enabled

Scenario: 6. Saving follow up details in new history tab
	When I click on the New Task button
	And I enter the information under new task tab
	And I click on save button
	And I click the follow up calls button
	And I click the new follow up calls button
	And I enter the information under new task tab from follow up calls tab
	And I click on save button of new window
	And I click close button for follow up calls
	And I click close button for history tab
	And I navigate to History Tab
	Then I should be able to see the tasks successfully

Scenario: 7. Creating and replying notes in new history tab
	When I click on the New Task button
	And I enter the information under new task tab
	And I click on save button
	And I click on notes button
	And I create a note
	And I click post button
	Then I should see the note with date,name and post should be created successfully
	When I select the created note
	And I enter a reply note
	And I click reply button
	Then I should see that a reply note has been successfully created

Scenario: 8. Replying to note with blank editbox
	When I click on the New Task button
	And I enter the information under new task tab
	And I click on save button
	And I click on notes button
	And I create a note
	And I click post button
	And I select the created note
	And I click reply button
	Then I should see the error message under the editbox

Scenario: 9.Verify the starting date as today for the created note
	When I click on the New Task button
	And I enter the information under new task tab
	And I click on save button
	And I click on notes button
	And I create a note
	And I click post button
	And I select the starting date as "current date"
	Then created note should be displayed in notes grid

Scenario: 10.Verify the starting date as yesterday for the created note
	When I click on the New Task button
	And I enter the information under new task tab
	And I click on save button
	And I click on notes button
	And I create a note
	And I click post button
	And I select the starting date as "past date"
	Then created note should be displayed in notes grid

Scenario: 11.Verify the starting date as tomorrow for the created note
	When I click on the New Task button
	And I enter the information under new task tab
	And I click on save button
	And I click on notes button
	And I create a note
	And I click post button
	And I select the starting date as "future date"
	Then created note should not be displayed in notes grid

Scenario: 12.Verifying whether a note with a child note can be deleted or not
	When I click on the New Task button
	And I enter the information under new task tab
	And I click on save button
	And I click on notes button
	And I create a note
	And I click post button
	And I select the created note
	And I enter a reply note
	And I click reply button
	And I select the parent note
	Then the delete note should be disabled

Scenario: 13. Deleting a note with no child notes
	When I click on the New Task button
	And I enter the information under new task tab
	And I click on save button
	And I click on notes button
	And I create a note
	And I click post button
	And I select the created note
	And I click delete note button
	Then the selected note should be deleted

Scenario: 14. Verifying new attachment button functionality
	When I click on the New Task button
	And I enter the information under new task tab
	And I click on save button
	And I click on attachments button
	And I click new attachments button
	Then I should be navigated to the new attachment window

Scenario: 15. Uploading a new attachment
	When I click on the New Task button
	And I enter the information under new task tab
	And I click on save button
	And I click on attachments button
	And I click new attachments button
	And I upload a new attachment
	And I save the attachment	
	And I edit this attachment 
	Then Uploaded attachment details should be displayed

Scenario: 16. Deleting an attachment from attachments page
	When I click on the New Task button
	And I enter the information under new task tab
	And I click on save button
	And I click on attachments button
	And I click new attachments button
	And I upload a new attachment
	And I save the attachment
	And I select the attachment
	And I delete the attachment
	Then the attachment should be succesfully deleted.

Scenario: 17. Deleting an attachment from the pop-up window
	When I click on the New Task button
	And I enter the information under new task tab
	And I click on save button
	And I click on attachments button
	And I click new attachments button
	And I upload a new attachment
	And I save the attachment
	And I edit this attachment
	And I delete attachment from pop-up window
	Then the attachment should be succesfully deleted in the previous window.

Scenario: 18. Navigating to messages button
	When I click on the New Task button
	And I enter the information under new task tab
	And I click on save button
	And I click on messages button
	Then I should be successfully navigated to the messages button

Scenario: 19. Verifying create booking button functionality
	#When I click on the New Task button
	#And I enter the information under new task tab
	#And I click on save button
	When click view this call button
	And I click create booking button
	Then I should be successfully navigated to create booking pop-up

Scenario: 20.Creating a new booking from create button in new task
	When click view this call button
	#When I click on the New Task button
	#And I enter the information under new task tab
	#And I click on save button
	And I click create booking button
	And I enter the new booking details
	Then the details of the new booking should be successfully visible

Scenario: 21. Verifying stationery button functionality
	When I click on the New Task button
	And I enter the information under new task tab
	And I click on save button
	And I click stationery button
	Then I should be navigated to the stationery window	

Scenario: 22. Verifying company button functionality
	When I click on the New Task button
	And I enter the information under new task tab
	And I click on save and close button
	And click view this call button
	And I click company button
	Then I should be navigated to the history tab

Scenario: 23. Verifying close button functionality
	When I click on the New Task button
	And I enter the information under new task tab
	And I click on save and close button
	And click view this call button
	And I click close button for company history
	Then I should be able to see details of the company information page

Scenario: 24. Verifying delete button functionality for History	
	When I Create New Task to be deleted
	And I navigate to created task	
	And I click delete button
	Then I should be able to see all the elements of the pending task 
	And I should be able to see all the elements of the user calendar
	When I click home button
	And I navigate to Companies from dashboard
	And I search for company as "testcompany"
	And I navigate to searched company
	And I navigate to History Tab
	Then the created task should be deleted

Scenario: 25. Navigating to New Booking From History Tab
	When I click New Booking Button
	Then elements of new booking page should be visible

Scenario: 26. Creating a new booking from new booking tab
	When I click New Booking Button
	And I enter the new booking details in a new window
	Then the details of the new booking should be successfully visible in new window

Scenario: 27. Selecting the starting from date for a task as a past date
	When I select the start date of task as a "past date"
	And I click refresh button
	Then the tasks till present date should be visible

Scenario: 28. Selecting the starting from date for a task as a present date
	When I select the start date of task as a "current date"
	And I click refresh button
	Then the tasks till present date should be visible

Scenario: 29. Selecting the starting from date for a task as a future date
	When I select the start date of task as a "future date"
	And I click refresh button
	Then the tasks till present date should be visible

Scenario: 30. Verifying inventory button functionality
	When I navigate to new inventory window
	Then all the details of the inventory window should be displayed successfully