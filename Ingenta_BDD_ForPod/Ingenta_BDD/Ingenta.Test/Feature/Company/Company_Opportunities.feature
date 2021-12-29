Feature: Company_Opportunities

Background:
	Given I am logged in Ingenta application and user is redirected to dashboard
	When I navigate to Companies from dashboard
	And I search for company as "testcompany"
	And I navigate to searched company
	And I navigate to opportunities Tab
	

Scenario: 1. Verifying opportunities tab details	
	Then I should be navigated to the opportunities tab

Scenario: 2. Verifying new opportunities button details	
	When I navigate to new opportunities tab
	Then I should be navigated to new opportunities tab

Scenario: 3. Creating and verifying new opportunities details
	When I navigate to new opportunities tab
	And I enter opportunities information
	And I save the details
	Then the details of the information should be saved and displayed
	
Scenario: 4.Verifying relations button details
	When I select the created opportunity
	And I navigate to relations tab
	Then all the details of the relations tab should be displayed

Scenario: 5.Verifying competitor button details
	When I select the created opportunity
	And I navigate to competitor tab
	Then all the details of the competitor tab should be displayed

Scenario: 6.Verifying new competitor button details
	When I select the created opportunity
	And I navigate to competitor tab
	And I navigate to new competitor window
	Then all the new competitor details should be displayed

Scenario: 7. Creating and verifying new competitor details
	When I select the created opportunity
	And I navigate to competitor tab
	And I navigate to new competitor window
	And I enter the details of the new competitor
	And I save the details for competitor in the new window
	Then I should be able to see the details of new competitor

Scenario: 8. Deleting a competitor	
	When I select the created opportunity	
	And I navigate to competitor tab
	And I navigate to new competitor window		
	And I create new competitor to be deleted	
	And I save the details for competitor in the new window
	And I select the created competitor
	And I delete the competitor
	Then the selected competitor should be deleted

Scenario: 9.Verifying reponsibility button details
	When I select the created opportunity
	And I navigate to reponsibility tab
	Then all the details of the reponsibility tab should be displayed

Scenario: 10.Verifying new reponsibility button details
	When I select the created opportunity
	And I navigate to reponsibility tab
	And I navigate to new responsibility tab
	Then all the details of the new responsibility tab should be displayed

Scenario: 11. Creating and verifying new reponsibility details
	When I select the created opportunity
	And I navigate to reponsibility tab
	And I navigate to new responsibility tab
	And I enter the details of the new reponsibility
	And I save the details for reponsibility in the new window
	Then I should be able to see the details of new reponsibility	

Scenario: 12. Deleting a reponsibility
	When I select the created opportunity
	And I navigate to reponsibility tab
	And I navigate to new responsibility tab
	And I enter the details of the new reponsibility to be deleted
	And I save the details for reponsibility in the new window
	And I select the created reponsibility
	And I delete the reponsibility
	Then the selected reponsibility should be deleted

Scenario: 13.Verifying media button details
	When I select the created opportunity
	And I navigate to media tab
	Then all the details of the media tab should be displayed

Scenario: 14.Verifying new media button details
	When I select the created opportunity
	And I navigate to media tab
	And I navigate to new media tab
	Then all the details of the new media tab should be displayed

Scenario: 15. Creating and verifying new media details
	When I select the created opportunity
	And I navigate to media tab
	And I navigate to new media tab
	And I enter the details of the new media
	And I save the details for media in the new window
	Then I should be able to see the details of new media

Scenario: 16. Deleting a media
	When I select the created opportunity
	And I navigate to media tab
	And I navigate to new media tab
	And I enter the details of the new media to be deleted
	And I save the details for media in the new window
	And I select the created media 
	And I delete the media
	Then the selected media should be deleted

Scenario: 17. Verifying quote button details
	When I select the created opportunity
	And I navigate to quote tab
	Then all the details of the quote tab should be displayed

Scenario: 18.Verifying new quote button details
	When I select the created opportunity
	And I navigate to quote tab
	And I navigate to new quote tab
	Then all the details of the new quote tab should be displayed

Scenario: 19. Creating and verifying new quote details
	When I select the created opportunity
	And I navigate to quote tab
	And I navigate to new quote tab
	And I create new quote
	And I navigate to the created quote
	And I click edit the quote button
	Then the details of the quote should be displayed successfully
	
Scenario: 20. Deleting a quote
	When I select the created opportunity
	And I navigate to quote tab
	And I navigate to new quote tab
	And I create new quote
	And I delete the created quote
	Then the quote should be deleted successfully
	When I cancel the quote creation
	Then all the details of the quote tab should be displayed

Scenario: 21.Editing a quote
	When I select the created opportunity
	And I navigate to quote tab
	And I navigate to new quote tab
	And I create new quote
	And I navigate to the created quote
	And I click edit the quote button
	And I edit the quote
	And I click edit the quote button
	Then the quote should be edited successfully

Scenario: 22.Verifying Create booking details inside Quote via Company
	When I select the created opportunity
	And I navigate to quote tab	
	And I navigate to the created quote
	And I click on Create Booking
	Then Qoute Booking details should be displayed

Scenario: 23.Verifying stationery button functionality
	When I select the created opportunity
	And I navigate to quote tab	
	And I navigate to the created quote
	And I click stationery button for the quote
	Then the details of the stationery button should be displayed successfully
	
Scenario: 24.Verifying Create booking details inside Quote via Company
	When I select the created opportunity
	And I navigate to quote tab	
	And I navigate to the created quote
	And I click on Create Booking
	Then Qoute Booking details should be displayed

Scenario: 25. Verifying insertions button details
	When I select the created opportunity
	And I navigate to insertions tab
	Then all the details of the insertions tab should be displayed

Scenario: 26.Verifying select issues Quote booking details in list view inside Quote via Company
	When I select the created opportunity
	And I navigate to quote tab	
	And I navigate to the created quote
	And I click on Create Booking
	And I select issue available in the Qoute booking grid for list view
	Then Qoute Issue details in list view should be displayed

Scenario: 27. Verify new booking button functionality under insertions tab
	When I select the created opportunity
	And I navigate to insertions tab
	And I click new booking button under insertions
	Then the new booking pop-up window details should be visible
	And buyer and advertiser name should be set same as the company name

Scenario: 28. Verify cancel button functionality
	When I select the created opportunity
	And I navigate to insertions tab
	And I click new booking button under insertions
	And I cancel bookings from the pop-up
	Then the new booking pop-ups should be closed

Scenario: 29.Verifying select issues Quote booking details in Calender view inside Quote via Company
	When I select the Calender View quote opportunity
	And I navigate to quote tab
	And I navigate to the created quote for calender view
	And I click on Create Booking
	And I select issue available in the Quote booking grid for calender view
	Then Quote Issue details in calender view should be displayed

Scenario: 30.Verifying task button details
	When I select the created opportunity
	And I navigate to tasks tab
	Then all the details of the tasks tab should be displayed

Scenario: 31. Verifying New Task button details
	When I select the created opportunity
	And I navigate to tasks tab
	And I click on the New Task button for the selected opportunity
	Then New Task details should be displayed for the selected opportunity

Scenario: 32. Creating a New Task
	When I select the created opportunity
	And I navigate to tasks tab
	And I click on the New Task button for the selected opportunity
	And I enter the information under new task tab for the selected opportunity
	And I click on save button details for the selected opportunity
	Then all the details of the information tab should be saved successfully for the selected opportunity

Scenario: 33. Verifying notes button details
	When I select the created opportunity
	And I navigate to notes tab under opportunities
	Then all the elements of notes tab should be displayed

Scenario: 34. Creating a note and replying to the created note
	When I select the created opportunity
	And I navigate to notes tab under opportunities
	And I create a note
	And I click post button
	Then I should see the note with date,name and post should be created successfully under notes tab
	When I select the created note
	And I enter a reply note
	And I click reply button
	Then I should see that a reply note has been successfully created

Scenario: 35.Verifying new attachment button functionality
	When I select the created opportunity
	And I navigate to attachments tab under opportunities
	And I click new attachments button
	Then I should be navigated to the new attachment window

Scenario: 36. Verifying attachments button details
	When I select the created opportunity
	And I navigate to attachments tab under opportunities
	Then all the elements of the attachment tab should be visible

Scenario: 37. Uploading and verifying a new attachment
	When I select the created opportunity
	And I navigate to attachments tab under opportunities
	And I click new attachments button
	And I upload a new attachment
	And I save the attachment		 
	And I edit this attachment
	Then Uploaded attachment details should be displayed

Scenario: 38. Deleting an attachment from attachments page
	When I select the created opportunity
	And I navigate to attachments tab under opportunities
	And I click new attachments button
	And I upload a new attachment
	And I save the attachment
	And I select the attachment
	And I delete the attachment
	Then the attachment should be succesfully deleted.
	
Scenario: 39. Deleting an attachment from the pop-up window
	When I select the created opportunity
	And I navigate to attachments tab under opportunities
	And I click new attachments button
	And I upload a new attachment
	And I save the attachment
	And I edit this attachment
	And I delete attachment from pop-up window
	Then the attachment should be succesfully deleted in the previous window.

Scenario: 40. Verifying sales assignment button details
	When I select the created opportunity
	And I navigate to sales assignment tab under opportunities
	Then Contact Sales Assignnment tab details should be displayed

Scenario: 41.Select issue in Quote booking details inside Quote via Company
	#When I click on search button in the header
	#And I search for company as "Musgrave - Group HQ"
	#And I navigate to searched company
	#And I navigate to opportunities Tab
	When I select the created opportunity
	And I navigate to quote tab	
	And I navigate to the created quote
	And I click on Create Booking
	And I select issue available in the Qoute booking grid for list view
	And I select issue available in Issue Selection grid
	Then Select Issue details should be enabled
	When I apply issue details
	Then Next button should be enabled