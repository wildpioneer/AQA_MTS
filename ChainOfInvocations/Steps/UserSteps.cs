using OpenQA.Selenium;
using PageObjectSteps.Pages;

namespace PageObjectSteps.Steps;

public class UserSteps : BaseSteps
{
    private LoginPage _loginPage;
    
    public UserSteps(IWebDriver driver) : base(driver)
    {
        _loginPage = new LoginPage(Driver);
    }


}