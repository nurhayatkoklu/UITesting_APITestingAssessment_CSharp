Feature: Shopping Test with standard_user

Background: Login Functionality with valid username and password
	Given Navigate To basqar
	When Confirm you are on the login page
	And Enter valid username and password and click login button
	Then User should login successfully

Scenario Outline:  Add Product To The Cart
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

When Take the screenshot of payment information

And Verify total payment amount is correct

And Click below buttons

| ButtonName  |
| Finish      |

Then Confirm order is dispatched

Examples: 
| FirstName | LastName | Zipcode |
| John      | Smith    | 555     |
| Maria     | Johnson  | 444     |











