Feature: Registration

As a user In order to benefit from the website i will need to first sign up or register

@tag1
Scenario: Valid Registration
	Given I naviage to the website
	And I click on sign up
	And I enter Username
	And I enter Email
	And I Enter password
	When I click on the sign up button
	Then I should be able to register successfully
