Feature: Login Functionality with Positive and Negative Scenarious


Scenario: Login Functionality with valid username and password
	Given Navigate to basqar
	When Enter username and password and click login button
	Then User should login successfully

Scenario: Login Functionality with invalid username and valid password
	Given Navigate to basqar
	When Enter invalid username and valid password and click login button
	Then User should login successfully

Scenario: Login Functionality with valid username and invalid password
	Given Navigate to basqar
	When Enter valid username and invalid password and click login button
	Then User should login successfully