using CoreProject.Core;
using CoreProject.Helpers.Configuration;
using NUnit.Framework;

[assembly: Parallelizable(ParallelScope.Fixtures)]

namespace AdvancedSpecFlowProject.Hooks;

[Binding]
public class Hooks
{
    private readonly Browser _browser;

    public Hooks(Browser browser)
    {
        _browser = browser;
    }

    [BeforeScenario("GUI")]
    public void BeforeGUIScenario()
    {
        _browser.SetUpDriver();
        _browser.Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }
    
    [AfterScenario("GUI")]
    public void AfterScenario()
    {
        _browser.Driver.Quit();
    }
}