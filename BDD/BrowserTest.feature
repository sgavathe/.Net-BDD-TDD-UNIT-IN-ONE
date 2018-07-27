Feature: Login Action
 
Scenario: Successful Login with Valid Credentials and Logout
	Given User is on "http://www.store.demoqa.com"
	When User Navigate to LogIn Page "http://store.demoqa.com/products-page/your-account/"
	And User enters UserName and Password
	Then Message displayed Login Successfully
	When User LogOut from the Application
	Then Message displayed LogOut Successfully

