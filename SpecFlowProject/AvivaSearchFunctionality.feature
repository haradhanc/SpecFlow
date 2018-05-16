Feature: Aviva Search Functionality

@mytag
Scenario: Search Keyword in Aviva Application

	Given Open browser and start application
	When I click on search button
	When I enter keyword
	| Keyword |
	|Aviva|
	When I click on search icon
    Then Search result is displayed with number of links
	And I want to print the fifth link 