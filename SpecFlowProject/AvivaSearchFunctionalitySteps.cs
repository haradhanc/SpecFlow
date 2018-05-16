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
        public void ThenIWantToPrintTheFifthLink(String elementText)
        {
            element.PrintLinkText(elementText);
        }
    }
}
