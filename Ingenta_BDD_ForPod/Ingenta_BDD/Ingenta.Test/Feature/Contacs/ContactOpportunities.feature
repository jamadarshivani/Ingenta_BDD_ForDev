Feature: ContactOpportunities
Below scenarios will verify the functionality of Opportunities inside Contact Module

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1. Verify Opportunities Tab Details from Contact
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	Then Opportunities tab details should be displayed

Scenario: 2. Verifying New Opportunities button details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I click on new opportunities
	Then Opportunity details should be displayed

Scenario: 3. Creating and verifying new opportunities details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I Create new Opportunity	
	Then Created opportunity should be displayed

Scenario: 4.Verifying relations button details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to Relations tab
	Then Relations tab details should be displayed
	
Scenario: 5.Verifying competitor button details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity	
	And I navigate to competitor tab
	Then Competitor tab details should be displayed

Scenario: 6.Verifying new competitor button details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity	
	And I navigate to competitor tab
	And I Click on new competitor button
	Then New Competitor details should be displayed

Scenario: 7. Creating New Competitor
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity	
	And I navigate to competitor tab	
	And I create new competitor	
	Then New competitor should be displayed
	When I edit competitor
	Then competitor details should be displayed
	When I click on cancel button
	Then competitor window should be closed

Scenario: 8. Deleting a competitor
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity	
	And I navigate to competitor tab	
	And I create new competitor	to be deleted
	And I select the created competitor
	And I delete the competitor
	Then the selected competitor should be deleted

Scenario: 9.Verifying reponsibility button details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity	
	And I navigate to reponsibility tab
	Then Reponsibility tab details should be displayed

Scenario: 10.Verifying new reponsibility button details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity	
	And I navigate to reponsibility tab
	And I Click on new reponsibility button
	Then New Reponsibility details should be displayed

Scenario: 11. Creating and verifying new reponsibility details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity	
	And I navigate to reponsibility tab
	And I create new responsibility	
	Then New responsibility should be displayed
	
Scenario: 12. Deleting a reponsibility
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to reponsibility tab
	And I create new reponsibility to be deleted
	And I select the created reponsibility
	And I delete the reponsibility
	Then the selected reponsibility should be deleted

Scenario: 13.Verifying media button details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity	
	And I navigate to media tab
	Then Media tab details should be displayed

Scenario: 14.Verifying new media button details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity	
	And I navigate to media tab
	And I Click on new media button
	Then New Media details should be displayed

Scenario: 15. Creating and verifying new media details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity	
	And I navigate to media tab
	And I create new media	
	Then New media should be displayed

Scenario: 16. Deleting a media
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity	
	And I navigate to media tab
	And I create new media to be deleted
	And I select the created media
	And I delete the media
	Then the selected media should be deleted

Scenario: 17. Verifying insertions button details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity	
	And I navigate to insertions tab
	Then all the details of the insertions tab should be displayed

Scenario: 18. Verify new booking button functionality under insertions tab
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select created test opportunity
	And I navigate to insertions tab
	And I click new booking button in insertions
	Then the new booking pop-up window details should be displayed
	When I cancel bookings from the pop-up
	Then the new booking pop-ups should be closed

Scenario: 19.Verifying task button details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity		
	And I navigate to tasks tab
	Then all the details of the tasks tab should be displayed


Scenario: 20. Verifying New Task button details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to tasks tab
	And I click on the New Task button for the selected opportunity
	Then New Task details should be displayed for the selected opportunity

Scenario: 21. Creating a New Task in opportunities
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to tasks tab
	And I create new task in opportunites
	Then Task should be created successfully in opportunites

Scenario: 22. Verifying notes button details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to notes tab under opportunities
	Then all the elements of notes tab should be displayed

Scenario: 23. Creating a note and replying to the created note
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to notes tab under opportunities
	And I create a note
	And I click post button
	Then I should see the note with date,name and post should be created successfully under notes tab
	When I select the created note
	And I enter a reply note
	And I click reply button
	Then I should see that a reply note has been successfully created

Scenario: 24. Verifying attachments button details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to attachments tab under opportunities
	Then all the elements of the attachment tab should be visible

Scenario: 25.Verifying new attachment button functionality
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to attachments tab under opportunities
	And I click new attachments button
	Then I should be navigated to the new attachment window

Scenario: 26. Uploading and verifying a new attachment
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to attachments tab under opportunities
	And I click new attachments button
	And I upload a new attachment
	And I save the attachment		 	
	And I edit this attachment 
	Then Uploaded attachment details should be displayed

Scenario: 27. Deleting an attachment from attachments page
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to attachments tab under opportunities
	And I click new attachments button
	And I upload a new attachment
	And I save the attachment
	And I select the attachment
	And I delete the attachment
	Then the attachment should be succesfully deleted.

Scenario: 28. Deleting an attachment from the pop-up window
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to attachments tab under opportunities
	And I click new attachments button
	And I upload a new attachment
	And I save the attachment
	And I edit this attachment
	And I delete attachment from pop-up window
	Then the attachment should be succesfully deleted in the previous window.

Scenario: 29. Verifying sales assignment button details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to sales assignment tab under opportunities
	Then Contact Sales Assignnment tab details should be displayed

Scenario: 30. Verifying quote button details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to quote tab
	Then all the details of the quote tab should be displayed

Scenario: 31.Verifying new quote button details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to quote tab
	And I navigate to new quote tab
	Then all the details of the new quote tab should be displayed

Scenario: 32. Creating and verifying new quote details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to quote tab
	And I navigate to new quote tab
	And I create new quote
	And I navigate to the created quote
	And I click edit the quote button
	Then the details of the quote should be displayed successfully

Scenario: 33. Deleting a quote
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to quote tab
	And I navigate to new quote tab
	And I create new quote	
	And I select the created qoute
	And I delete the created quote
	Then the quote should be deleted successfully
	When I cancel the quote creation
	Then all the details of the quote tab should be displayed

Scenario: 34.Editing a quote
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to quote tab
	And I navigate to new quote tab
	And I create new quote	
	And I navigate to the created quote
	And I click edit the quote button
	And I edit the quote
	And I click edit the quote button
	Then the quote should be edited successfully

Scenario: 35.Verifying Create booking details inside Quote via Contact
	When I navigate to Contacts from dashboard	
	And I search for Contact "Pendlebury" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created last opportunity
	And I navigate to quote tab	
	And I navigate to the created quote
	And I click on Create Booking
	Then Qoute Booking details should be displayed

Scenario: 36.Verifying select issues quote booking details in list view inside Quote via Contact
	When I navigate to Contacts from dashboard	
	And I search for Contact "Fox" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to quote tab	
	And I navigate to the created quote
	And I click on Create Booking
	And I select issue available in the Qoute booking grid for list view
	Then Qoute Issue details in list view should be displayed

Scenario: 37.Verifying select issues quote booking details in Calender view inside Quote via Contact
	When I navigate to Contacts from dashboard	
	And I search for Contact "Rogers" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to quote tab
	And I navigate to the created quote
	And I click on Create Booking
	And I select issue available in the Quote booking grid for calender view
	Then Quote Issue details in calender view should be displayed


Scenario: 38.Select issue in qoute booking details inside Quote via Contact
	When I navigate to Contacts from dashboard	
	And I search for Contact "Fox" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to quote tab	
	And I navigate to the created quote
	And I click on Create Booking
	And I select issue available in the Qoute booking grid for list view
	And I select issue available in Issue Selection grid
	Then Select Issue details should be enabled
	When I apply issue details
	Then Next button should be enabled

Scenario: 39. Verifying Price User Form Details
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to Price UserForm tab
	Then Price User Form tab details should be displayed

Scenario: 40. Entering and Verifying The Details For The Price Tab Are Saved Successfully	
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to Price UserForm tab
	And I create Electronics Classification
	Then the details for electronics classification should be saved successfully

Scenario: 41. Verifying Reset Button Functionality For Price User Form
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to Price UserForm tab
	And I create Electronics Classification
	And I enter additional telephone details
	And I reset the details for the electronics classification
	Then the details for electronics classification should be saved successfully

Scenario: 42. Verifying Delete Button Functionality For Price User Form
	When I navigate to Contacts from dashboard	
	And I search for Contact "Baldock" by last name
	And I navigate to searched contact
	And I navigate to opportunites tab from contact
	And I select the created opportunity
	And I navigate to Price UserForm tab
	And I create Electronics Classification
	Then the details for electronics classification should be saved successfully
	When I delete the electronics classification details
	Then the saved details for the electronics classification should be cleared successfully
	