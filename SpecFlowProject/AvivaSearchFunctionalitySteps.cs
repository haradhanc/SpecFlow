using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TechTalk.SpecFlow.Assist;
using System.Threading;

namespace SpecFlowProject
{
    [Binding]
    public class AvivaSearchFunctionalitySteps : BrowserOpen
    {
             
        [When(@"I click on search button")]
        public void WhenIClickOnSearchButton()
        {
            PageObjectElement ele = new PageObjectElement();
            ele.SearchBtnClick();
            
        }

        [When(@"I enter keyword")]
        public void WhenIEnterKeyword(Table table)
        {
            PageObjectElement ele = new PageObjectElement();
            ele.SearchTextBox(table);
        }
        [When (@"I click on search icon")]
        public void WhenIClickSearchIcon()
        {
            PageObjectElement ele = new PageObjectElement();
            ele.ClickSearchIcon();
            Thread.Sleep(7000);

        }

        [Then(@"Search result is displayed with number of links")]
        public void ThenSearchResultIsDisplayedWithNumberOfLinks()
        {
            PageObjectElement ele = new PageObjectElement();
            ele.VerifySearchPageWithLinkCount();

        }
        
        [Then(@"I want to print the fifth link")]
        public void ThenIWantToPrintTheFifthLink()
        {
            PageObjectElement ele = new PageObjectElement();
            ele.PrintLinkText();
        }
    }
}
