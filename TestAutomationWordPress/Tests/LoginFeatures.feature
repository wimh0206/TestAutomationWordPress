Feature: LoginFeatures
	login into wordpress

@login
Scenario: Login Succesfull
	Given I am in Login page
	And I enter username 'wimh0206'
	And I enter password 'kiss261990'
	When I click Login
	Then My page displays successfully
