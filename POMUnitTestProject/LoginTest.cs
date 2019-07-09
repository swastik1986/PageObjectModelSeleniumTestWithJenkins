using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using POMUnitTestProject;

namespace POMUnitTestProject
{
    [TestClass]
    public class LoginTest
    {     
        IWebDriver driver;
        //public LoginTest(IWebDriver driver)
        //{
        //    this.driver = driver;
        //}

        //[SetUp]
        [TestInitialize]
        public void InitializeBrowser()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://swastikwebapp1.azurewebsites.net/Account/Login?ReturnUrl=%2F");
        }
      
        [TestMethod]
        public void TestRegister()
        {
            LoginPage objlogin = new LoginPage(driver);
            objlogin.Register("situnbehera2@gmail.com");
        }
        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}
