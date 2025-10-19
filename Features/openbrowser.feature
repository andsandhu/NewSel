Feature: openbrowser
open https://practicetestautomation.com/practice-test-login/

@smoke_test
Scenario: Login to sample site
	Given open browser with url as  https://practicetestautomation.com/practice-test-login/
	When enter username and password and click on Submit button
	Then logged in successfully page should be displayed
