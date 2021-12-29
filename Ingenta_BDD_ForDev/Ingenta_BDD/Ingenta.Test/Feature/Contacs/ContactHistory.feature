Feature: ContactHistory
Below scenarios will verify the functionality of Contacts History tab

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1. Verify Contact History Details	
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	Then History details should be displayed

Scenario: 2. Verify Task Information Details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	And I click on the New Task button
	Then Task Information details should be displayed

Scenario: 3. Creating New Task in History Tab
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	And I create new task		
	Then Task should be created successfully
	And save and save and close button should be disabled 
	And delete,stationery and create booking button should be displayed
	And title should be combination of company Name , Contact Name and Subject
	And task and user forms tabs should be enabled

Scenario: 4. Follow Up Calls In History
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	And I create new task with mandatory fields
	And I navigate to follow up calls
	And I click the new follow up calls button
	Then Task window details should be displayed
	When I close the Task window
	Then Task window should be closed

Scenario: 5. Notes button In History
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	And I create new task with mandatory fields
	And I navigate to notes	
	Then Notes details should be displayed

Scenario: 6. Creating and replying notes in new history tab
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	And I create new task with mandatory fields
	And I navigate to notes
	And I create a note
	And I click post button
	Then I should see the note with date,name and post should be created successfully in contacts
	When I select the created note
	And I enter a reply note
	And I click reply button
	Then I should see that a reply note has been successfully created

Scenario: 7. Replying to note with blank editbox
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	And I create new task with mandatory fields		
	And I navigate to notes
	And I create a note
	And I click post button
	And I select the created note
	And I click reply button
	Then Error message should be displayed under editbox
	
Scenario: 8. Deleting a note
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	And I create new task with mandatory fields	
	And I navigate to notes
	And I create a note
	And I click post button
	And I select the created note
	And I click delete note button
	Then the selected note should be deleted

Scenario: 9. Attachments button In History
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	And I create new task with mandatory fields
	And I navigate to attachments tab from History
	Then Attachments tab details should be displayed
	When I click new attachments button
	Then New attachment window should be displayed
	
Scenario: 10. Uploading a new attachment
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	And I create new task with mandatory fields
	And I navigate to attachments tab from History	
	And I click new attachments button
	And I upload a new attachment
	And I save the attachment	
	And I edit this attachment 
	Then Uploaded attachment details should be displayed

Scenario: 11. Deleting an attachment from attachments page
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	And I create new task with mandatory fields	
	And I navigate to attachments tab from History	
	And I click new attachments button
	And I upload a new attachment
	And I save the attachment	
	And I select the attachment
	And I delete the attachment
	Then the attachment should be succesfully deleted.

Scenario: 12. Deleting an attachment from the pop-up window	
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	And I create new task with mandatory fields		
	And I navigate to attachments tab from History	
	And I click new attachments button
	And I upload a new attachment
	And I save the attachment	
	And I edit this attachment
	And I delete attachment from pop-up window
	Then the attachment should be succesfully deleted in the previous window.

Scenario: 13. Navigating to messages button
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	And I create new task with mandatory fields
	And I navigate to messages
	Then Messages details should be displayed

Scenario: 14. Verifying New Booking button window details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	And I create new task with mandatory fields	
	And I click create booking button
	Then Create booking popup should be displayed

Scenario: 15.Creating a new booking from create button in new task
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	#And I create new task with mandatory fields
	And click view this call button
	And I click create booking button
	And I enter the new booking details
	Then the details of the new booking should be successfully visible
	
Scenario: 16. Verifying stationery button functionality
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts	
	And I click stationery button
	Then Stationery details should be displayed

Scenario: 17. Verifying contact button functionality
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	And click view this call button
	And I click contact button
	Then History details should be displayed

Scenario: 18. Verifying close button functionality
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	And click view this call button
	And I click close button
	Then I should get redirected to contact history page

Scenario: 19. Verifying delete button functionality
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	And I create new task with mandatory fields
	And I click close button
	And click view this call button
	And I delete the task
	Then Pending task details should be displayed
	And User Calender details should be displayed
	When I navigate to Home Page
	And I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts	
	Then Deleted task should not be displayed

Scenario: 20. Creating a new booking from history
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	And I create a new booking from history tab		
	Then New booking details should be displayed

Scenario: 21. Selecting the starting from date for a task as a future date
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	And I select the start date of task as a "future date"
	And I click refresh button
	Then the tasks till present date should be visible

Scenario: 22. Verifying Inventory button details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to History Tab from Contacts
	And I navigate to Inventory
	And Inventory details should be displayed