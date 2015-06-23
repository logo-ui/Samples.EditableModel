Feature: AutomationEditing
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Integration
Scenario: Edit Proxy - undo restores state
	Given I am an authenticated user with username 'Vasya'	
	And Login request succeeds
	And Server returns 1 proxy record with ip address '192.168.0.1'
	And Server returns any number of compliance records
	When I open the application
	And I press the login button
	And I access the automation screen
	And I set proxy ip address value to '192.168.0.2'
	And I press undo proxy changes button 
	Then proxy address should be '192.168.0.1'
