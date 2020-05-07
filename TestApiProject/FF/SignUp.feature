Feature: SignUp
	In order to Sign Up NewBook
	As a client of NewBook
	I want to be Signed Up

@mytag
Scenario: It is possible to Sign Up with valid data
	Given Sign Up page is opened
	When I input email in email field
	And I input default password in password field
	And I input password in confirmPassword field
	And I input first name in firstName field
	And I input last name in lastName field
	And I input mobile in mobile field
	And I click Sign up button
	Then Client is successfully Signed Up as a client
