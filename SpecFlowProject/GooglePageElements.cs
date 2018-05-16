using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;



namespace SpecFlowProject
{
    public class GooglePageElements : BrowserOpenFunctionality
    {       
        By searchTextBox = By.XPath("//input[@name='q']");
        By searchIconClick = By.XPath("//button[@name='submit']");
                
        public void SearchKeyword(String keyword)
        {
            driver.FindElement(searchTextBox).SendKeys(keyword);
            
        }
        public void SearchBtnClick()
        {
            Actions btnclick = new Actions(driver);
            btnclick.SendKeys(Keys.Enter).Build().Perform();
        }
        
        public void VerifySearchPageWithLinkCount()
        {
            IList elementList = new ArrayList();
            elementList = driver.FindElements(By.TagName("a"));
            Console.WriteLine("Total number of links are:" + elementList.Count);
                       
        }
        public void PrintLinkText(String elementText)
        {
            String elementTextVerify = driver.FindElement(By.LinkText("Aviva Life Insurance - Login")).Text;
            Assert.AreEqual(elementTextVerify, elementText);
            Console.WriteLine(elementText);

        }


    }
}

    

