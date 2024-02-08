using OpenQA.Selenium;

namespace SeleniumBasic.Pages;

public class DashboardPage : BasePage
{
    // Описание элементов
    private static readonly By TitleLabelBy = By.ClassName("page_title");

    
    public DashboardPage(IWebDriver driver) : base(driver)
    {
    }
    
    // Атомарные Методы
    public IWebElement TitleLabel => Driver.FindElement(TitleLabelBy);
}