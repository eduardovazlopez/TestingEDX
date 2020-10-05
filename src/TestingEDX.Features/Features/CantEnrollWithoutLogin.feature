Feature: CantEnrollWithoutLogin
	Check that a user can not enroll in a course without login

@mytag
Scenario: Enroll in a course without login
	Given I am at the url https://www.edx.org/search?tab=course
	And enter in the first course
	When click on the Enroll button
	Then the site redirects me to the register page