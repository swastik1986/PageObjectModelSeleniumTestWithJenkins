using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMUnitTestProject
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        #region Objects
        private IWebElement EmailText
        {
            get
            {

                return driver.FindElement(By.Id("Email"));
            }
        }
        #endregion Objects
        #region Methods
        public void Register(string userName)
        {
            EmailText.SendKeys(userName);

        }
        #endregion Methods
    }
}
