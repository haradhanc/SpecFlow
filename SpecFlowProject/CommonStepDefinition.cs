using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;





namespace SpecFlowProject
{
    [Binding]
    public class CommonStepDefinition : BrowserOpenFunctionality
    {
        GooglePageElements element = new GooglePageElements();

        [Given(@"Open (.*) and start (.*) now")]
        public void GivenOpenChromeAndStartApplication(String browser,String url)
        {
            OpenApp(browser,url);
        }

        [When(@"I enter (.*)")]
        public void WhenIEnterAviva(String keyword)
        {            
            element.SearchKeyword(keyword);
        }






    }
        
        
    }
