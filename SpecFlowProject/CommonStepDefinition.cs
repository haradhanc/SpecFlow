using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;





namespace SpecFlowProject
{
    [Binding]
    public class CommonStepDefinition : BrowserOpen
    {


        [Given(@"Open browser and start application")]
        public void GivenOpenBrowserAndStartApplication()
        {
            OpenApp("CH", "https://aviva.com");
        }
        
        

        



        }
        
        
    }
