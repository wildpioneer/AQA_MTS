using NUnitTest.Pages;
using SeleniumBasic.Helpers.Configuration;
using SeleniumBasic.Pages;

namespace SeleniumBasic.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        // Actions = Действия
        
        
        // Проверка
        Assert.That(
            UserSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
                .TitleLabel.Text.Trim(), 
            Is.EqualTo("All Projects"));
    }

    [Test]
    public void InvalidUsernameLoginTest()
    {
        // Actions = Действия
        var loginPage = new LoginPage(Driver);
        loginPage.Login("ssdd", "");
        
        // Проверка
        Assert.That(loginPage.ErrorLabel.Text, Is.EqualTo("Email/Login or Password is incorrect. Please try again."));
    }
}