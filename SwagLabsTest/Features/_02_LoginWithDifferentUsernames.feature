Feature: Login with Different Usernames

Scenario Outline: Login Functionality with different usernames
	When Confirm you are on the login page
	And Enter "<Username>" and password and click login button
	Then Check if the user can login with different usernames

Examples: 
| Username                |
| problem_user            |
| performance_glitch_user |


Scenario: Login Functionality with locked_user
	When Confirm you are on the login page
	And Enter locked_user username and password and click login button
	Then User cannot be login successfully


