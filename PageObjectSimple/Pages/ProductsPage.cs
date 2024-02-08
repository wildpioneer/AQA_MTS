using OpenQA.Selenium;

namespace SeleniumBasic.Pages;

public class ProductsPage : BasePage
{
    // Описание элементов
    private static readonly By TitleLabelBy = By.ClassName("title");

    
    public ProductsPage(IWebDriver driver) : base(driver)
    {
    }
    
    // Атомарные Методы
    public IWebElement TitleLabel => Driver.FindElement(TitleLabelBy);

}