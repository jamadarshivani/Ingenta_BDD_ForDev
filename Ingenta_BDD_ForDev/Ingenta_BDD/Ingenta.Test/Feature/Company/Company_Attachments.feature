Feature: Company_attachments


Background:
Given I am logged in Ingenta application and user is redirected to dashboard	

Scenario: 1.Verify attachment button functionality
	When I navigate to Companies from dashboard
	And I search for company as "testcompany"
	And I navigate to searched company
	And I navigate to attachments tab
	Then all the elements of the attachment tab should be visible

Scenario: 2.Verifying new attachment button functionality
	When I navigate to Companies from dashboard
	And I search for company as "testcompany"
	And I navigate to searched company
	And I navigate to attachments tab
	And I click new attachments button
	Then I should be navigated to the new attachment window

Scenario: 3. Uploading and verifying a new attachment
	When I navigate to Companies from dashboard
	And I search for company as "testcompany"
	And I navigate to searched company
	And I navigate to attachments tab
	And I click new attachments button
	And I upload a new attachment
	And I save the attachment		
	When I edit this attachment 
	Then Uploaded attachment details should be displayed

Scenario: 4. Deleting an attachment from attachment page
	When I navigate to Companies from dashboard
	And I search for company as "testcompany"	
	And I navigate to searched company
	And I navigate to attachments tab
	And I click new attachments button
	And I upload a new attachment
	And I save the attachment
	And I select the attachment
	And I delete the attachment
	Then the attachment should be succesfully deleted.	

Scenario: 5. Deleting an attachment from the pop-up window
	When I navigate to Companies from dashboard
	And I search for company as "testcompany"	
	And I navigate to searched company
	And I navigate to attachments tab
	And I click new attachments button
	And I upload a new attachment
	And I save the attachment
	And I edit this attachment
	And I delete attachment from pop-up window
	Then the attachment should be succesfully deleted in the previous window.
	