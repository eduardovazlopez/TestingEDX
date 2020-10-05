Feature: EDXChangeLanguage
	Verify the language change on the EDX website

@mytag
Scenario: Change language to english
	Given I am at the EDX's Home page
	And the page is displayed in spanish
	When scroll down to the end of the page
	And select english language
	And press the Apply button
	Then the url change to https://www.edx.org/
	And page is displayed now in englsih