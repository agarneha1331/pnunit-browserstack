﻿using NUnit.Framework;
using OpenQA.Selenium;

namespace BrowserStack
{
  public class SingleTest : BrowserStackPNUnitTest
  {
    [Test]
    public void SearchGoogle()
    {
      driver.Navigate().GoToUrl("https://www.google.com/ncr");
      IWebElement query = driver.FindElement(By.Name("q"));
      query.SendKeys("BrowserStack");
      query.Submit();
      System.Threading.Thread.Sleep(5000);
      Assert.AreEqual("BrowserStack - Google Search", driver.Title);
    }
  }
}
