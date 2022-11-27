Feature: Remove Product Test with standard_user

Background:Login Functionality with valid username and password
	When Confirm you are on the login page
	And Enter valid username and password and click login button
	Then User should login successfully

Scenario Outline:  Remove Product From The Cart
Given Click below buttons

| ButtonName      |
| AddBackpack     |
| AddBikeLight    |
| Cart            |
| RemoveBackpack  |

When Verify product is removed from the cart

