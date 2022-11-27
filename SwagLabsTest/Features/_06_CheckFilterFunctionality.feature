Feature: Filter Functionality Test

Background:Login Functionality with valid username and password
	When Confirm you are on the login page
	And Enter valid username and password and click login button
	Then User should login successfully

Scenario:  Check if the Filter functioanility is working correctly
When Select NameAToZ
And Verift that products sorted from A to Z
And Select NameZToZ
And Verift that products sorted from Z to A
And Select LowToHigh
And Verift that products sorted from low to high
And Select HighToLow
Then Verift that products sorted from high to low



