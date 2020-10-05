Feature: EDXIncorrectLogin
	Verify no one can login with a wrong user and password

@mytag
Scenario: Login with a wrong user and password
	Given I am at the EDX's login page
	When enter a wrong user
	And enter a wrong password
	And click on the sign in button
	Then wrong user cant login