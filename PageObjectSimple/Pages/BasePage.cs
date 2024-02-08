using OpenQA.Selenium;
using SeleniumBasic.Helpers;
using SeleniumBasic.Helpers.Configuration;

namespace SeleniumBasic.Pages;

public class BasePage
{
    public BasePage(IWebDriver driver)
    {
        Driver = driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
    }

    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }
}