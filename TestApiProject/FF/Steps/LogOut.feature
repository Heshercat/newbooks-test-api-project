Feature: LogOut
	In order to logOut from NewBook
	As a client of NewBook
	I want to be LogOut

@mytag
Scenario: Log Out client
	Given I create client using API
	And Sign in page is opened
	And I successfully logged using API
	When I click profile Settings Button
	And I click Log Out reference
	Then Client is successfully Log Out from NewBook
