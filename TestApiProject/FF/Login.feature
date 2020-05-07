Feature: Login
	In order to login NewBook Models
	As a client of NewBook
	I want to be logged

@mytag
Scenario: It is possible to login with valid data
	Given Client is criated
	And Sign in page is opened
	When I input email of created lead in email field
	And I input default password of created lead in password field
	And I click Sign in button
	Then Client is successfully logged as created client
