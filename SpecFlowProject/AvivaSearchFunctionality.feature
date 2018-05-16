Feature: Aviva Search Functionality

@mytag
Scenario Outline: Search Keyword in Aviva Application

	Given Open <Browser> and start <Application> now
	When I enter <Keyword>
	And I click on search button
    Then Search result is displayed with number of links
	And I want to print the <Link> in position fifth
	
	Examples: 
	| Browser | Keyword | Application           | Link                         |
	| Chrome  | Aviva   | http://www.google.com | Aviva Life Insurance - Login |