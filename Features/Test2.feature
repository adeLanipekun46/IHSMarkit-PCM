Feature: Test2
	As a user of the site
	I want to confirm i can do certin things

Background:
    Given a user navigate to "https://dotnetfiddle.net/"


Scenario:Select Package Name
    When a user enter package name "Nunit"
	And a user select version "3.12.0" 
	Then "nUnit" Nuget Package is added Sucessfully

Scenario:Click Share Button
	When a user click on share button 
	Then  the share link starts with "“https://dotnetfiddle.net/”

Scenario:Hide Option Panel
	When a user click back button on Options panel to hide this panel 
	Then  the Options panel is hidden

Scenario:Click Save Button
	When a user click on save button 
	Then the “Log In” window should appear

Scenario:Click Getting Started
	When a user click on getting started button 
	Then the “Back To Editor” button should appear