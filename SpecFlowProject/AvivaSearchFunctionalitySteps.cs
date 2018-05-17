using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject
{
    [Binding]
    public class AvivaSearchFunctionalitySteps
    {
        GooglePageElements element = new GooglePageElements();
        [When(@"I click on search button")]
        public void WhenIClickOnSearchButton()
        {            
            element.SearchBtnClick();
        }
        
        [Then(@"Search result is displayed with number of links")]
        public void ThenSearchResultIsDisplayedWithNumberOfLinks()
        {
            element.VerifySearchPageWithLinkCount();
        }
        
        [Then(@"I want to print the (.*) in position fifth")]
        public void ThenIWantToPrintTheFifthLink(int elementPosition)
        {
            element.GetLinkText(elementPosition);
        }
        [Then(@"Search result should display more than fifth number of links")]
        public void SearchResultShouldDisplayMoreThanFifthNumberOfLinks()
        {
            element.VerifySearchPageWithLinkCount();

        }
    }
}
