using OpenQA.Selenium;
using SeleniumBasic.Pages;

namespace NUnitTest.Pages
{
    public class LoginPage : BasePage
    {
        // Описание элементов
        private static readonly By EmailInputBy = By.Id("name");
        private static readonly By PswInputBy = By.Id("password");
        private static readonly By RememberMeCheckboxBy = By.Id("rememberme");
        private static readonly By LoginInButtonBy = By.Id("button_primary");
        private static readonly By ErrorLabelBy = By.CssSelector("[data-testid='loginErrorText']");
        
        // Инициализация класса
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        
        // Методы
        public IWebElement EmailInput => Driver.FindElement(EmailInputBy);  
        public IWebElement ErrorLabel => Driver.FindElement(ErrorLabelBy);  

        public IWebElement PswInput()
        {
            return Driver.FindElement(PswInputBy);
        }

        public IWebElement RememberMeCheckbox()
        {
            return Driver.FindElement(RememberMeCheckboxBy);  
        }

        public IWebElement LoginInButton()
        {
           return Driver.FindElement(LoginInButtonBy);
        }

        public void Login(string username, string password)
        {
        }
    }
}