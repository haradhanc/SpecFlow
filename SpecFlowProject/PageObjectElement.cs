using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;



namespace SpecFlowProject
{
    public class PageObjectElement : BrowserOpen
    {
        By searchBtn = By.XPath("//a[@href='#search']");
        By searchTextBox = By.XPath("//input[@name='q']");
        By searchIconClick = By.XPath("//button[@name='submit']");
        //By searchResultVerify = By.XPath("//span/span[text()='results']");




        public void SearchBtnClick()
        {
            driver.FindElement(searchBtn).Click();
        }

        public void SearchTextBox(Table table)
        {
            SearchProperty search = table.CreateInstance<SearchProperty>();
            Console.WriteLine(search.Keyword);
            Thread.Sleep(2000);
            driver.FindElement(searchTextBox).SendKeys(search.Keyword);
        }
        public void ClickSearchIcon()
        {
            driver.FindElement(searchIconClick).Click();
        }
        public void VerifySearchPageWithLinkCount()
        {
            String searchResult = driver.FindElement(By.XPath("//div[@class='u-js']/span/span")).Text;
            Assert.AreEqual(searchResult, "7,542 results");

            IList elementList = new ArrayList();
            elementList = driver.FindElements(By.TagName("a"));
            Console.WriteLine("Total number of links are:" + elementList.Count);

            foreach (IWebElement eleList in elementList)
            {
                /* If user wants detail of link text then below code will ne needed */
                //Console.WriteLine("Total number of links detail:"+ eleList.Text);




            }

        }
        public void PrintLinkText()
        {
            IList elementList = new ArrayList();
            elementList = driver.FindElements(By.TagName("a"));
            for (int i = 0; i < elementList.Count; i++)
            {
                if (i == 5)
                {

                 Console.WriteLine("Element text is:" + elementList[5]);

                }
            }


        }


    }
}

    

