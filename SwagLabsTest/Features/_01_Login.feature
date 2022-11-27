Feature: Login Functionality Test with different usernames


Scenario: Login Functionality with valid username and password
	When Confirm you are on the login page
	And Enter valid username and password and click login button
	Then User should login successfully


Scenario: Login Functionality with invalid username and valid password
	When Confirm you are on the login page
	And Enter invalid username and valid password and click login button
	Then User cannot be login successfully

Scenario: Login Functionality with valid username and invalid password
	When Confirm you are on the login page
	And Enter valid username and invalid password and click login button
	Then User cannot be login successfully

Scenario: Login Functionality with invalid username and invalid password
	When Confirm you are on the login page
	And Enter invalid username and invalid password and click login button
	Then User cannot be login successfully

Scenario: Login Functionality with empty username and password
	When Confirm you are on the login page
	And Do not enter any username and password and click login button
	Then Verify empty username warning
