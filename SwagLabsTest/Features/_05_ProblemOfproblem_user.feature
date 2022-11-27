Feature: Discover what is wrong with the problem_user

Scenario Outline: Login with problem_user username
    Given Navigate To basqar
	When Confirm you are on the login page
	And Enter "<Username>" and password and click login button
	Then User should login successfully
	Given Click below buttons
	| ButtonName   |
	| AddBackpack  |
	| AddBikeLight |
	| Cart         |
	| CheckOut     |
	
When Fill the form with "<FirstName>", "<LastName>" and "<Zipcode>"

And Click below buttons

| ButtonName  |
| Continue    |

When Take the screenshot if user is able to fill the form

Then Verify the problem of problem_user

Examples: 
| FirstName | LastName | Zipcode | Username     |
| John      | Smith    | 555     | problem_user |





