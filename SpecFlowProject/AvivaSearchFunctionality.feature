Feature: Aviva Search Functionality

@Positive
Scenario Outline: Search Aviva Keyword in Google Application

	Given Open <Browser> and start <Application> now
	When I enter <Keyword>
	And I click on search button
    Then Search result is displayed with number of links
	And I want to print the <Link> in position fifth
	
	Examples: 
	| Browser | Keyword | Application           | Link |
	| Chrome  | Aviva   | http://www.google.com | 5    |


	@Negative
	Scenario Outline: Search Other Keyword in Google Application

	Given Open <Browser> and start <Application> now
	When I enter <Keyword>
	And I click on search button
    Then Search result should display more than fifth number of links
	And I want to print the <Link> in position fifth
	
	Examples: 
	| Browser | Keyword | Application           | Link |
	| Chrome  | UK      | http://www.google.com | 5    |
