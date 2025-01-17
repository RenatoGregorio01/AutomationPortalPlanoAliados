using OpenQA.Selenium;
using AutomationTest.Utilities;


namespace AutomationTest.Pages
{
    public class LoginPlanoAliadosPage
    {
        private readonly IWebDriver _driver;

        public LoginPlanoAliadosPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement UsernameField => _driver.FindElement(By.XPath("//input[contains(@name,'Login')]"));
        private IWebElement PasswordField => _driver.FindElement(By.XPath("//input[contains(@name,'Password')]"));
        private IWebElement LoginButton => _driver.FindElement(By.XPath("//span[contains(.,'Login')]"));
        private IWebElement SucessMessage => _driver.FindElement(By.XPath("//div[@role='status'][contains(.,'Enviado com sucesso!')]"));

        public void OpenSite()
        {
            _driver.Navigate().GoToUrl("https://planoaliados.com.br/portal/");
        }
        
        public bool FillUsername()
        {
            for (int i = 0; i < 2; i++)
            {
                try
                {
                    var usernameField = UsernameField;

                    if (WaitUtils.WaitForElementToBeVisible(_driver, UsernameField, 10))
                    {
                        UsernameField.SendKeys("057.484.723-50");
                        return true;
                    }
                }
                catch (Exception)
                {
                    Thread.Sleep(5000);
                    continue;
                }
            }
            return false;
        }

        public bool FillPassword()
        {
            for (int i = 0; i < 2; i++)
            {
                try
                {
                    var passwordField = PasswordField;

                    if (WaitUtils.WaitForElementToBeVisible(_driver, PasswordField, 10))
                    {
                        PasswordField.SendKeys("654321");
                        return true;
                    }
                }
                catch (Exception)
                {
                    Thread.Sleep(5000);
                    continue;
                }
            }
            return false;
        }        
    
    public bool ClickLogin()
        {
            for (int i = 0; i < 2; i++)
            {
                try
                {
                    var loginButton = LoginButton;

                    if (WaitUtils.WaitForElementToBeVisible(_driver, LoginButton, 10))
                    {
                        LoginButton.Click();
                        return true;
                    }
                }
                catch (Exception)
                {
                    Thread.Sleep(5000);
                    continue;
                }
            }
            return false;
        }     
        
        public bool WaitElementSucessMessage()
        {
            for (int i = 0; i < 2; i++)
            {
                try
                {
                    var sucessMessage = SucessMessage;

                    if (WaitUtils.WaitForElementToBeVisible(_driver, SucessMessage, 10))
                    {
                        return true;
                    }
                }
                catch (Exception)
                {
                    Thread.Sleep(5000);
                    continue;
                }
            }
            return false;
        }
    }
}
