Feature: CheckValidationSignIn
	In order to avoid Sign In with invalid data
	As a client of NewBook
	I want to not sign in with invalid data

@mytag
Scenario Outline: Not Sign In with invalid Data
	Given I am a signed up client of NewBook
	And I am on SignIn page
	When I have filled <email> and <password> fields
	And I have clicked sign in button
	Then I see an error <message>

	Examples: 
	| email          |   password      |   message                                    |
	| jane@smith.com |   JaneSmith123  |   Please enter a correct email and password. |
	| jane@smith.ru  |   JaneSmith123! |   Please enter a correct email and password. |
	|                |   JaneSmith123! |   Required                                   |
	| jane@smith.com |                 |   Required                                   |
