using OpenQA.Selenium;

namespace SeleniumBasic.Tests;

public class CssSelectorTest : BaseTest
{
    [Test]
    public void CssSelectorsTest()
    {
        Driver.Navigate().GoToUrl("file:/Users/aleksandr.trostyanko/Documents/Work/TeachMeSkills/Code/CSharp/AQA_MTS/Locators/Resources/index.html");
        
        // Поиск по id
        Assert.That(Driver.FindElement(By.CssSelector("#my-Address")).Displayed);

        // Поиск по class name
        Assert.That(Driver.FindElement(By.CssSelector(".newsletter")).Displayed);

        // Поиск по нескольким значения в аттрибуте class
        Assert.That(Driver.FindElement(By.CssSelector(".noSel.newsletter")).Displayed);

        // Поиск по tag name
        Assert.That(Driver.FindElement(By.CssSelector("h1")).Displayed);

        // Поиск по tag и значению из аттрибута class
        Assert.That(Driver.FindElement(By.CssSelector("div.intro")).Displayed);

        // Поиск по tag и значению из аттрибута class
        Assert.That(Driver.FindElements(By.CssSelector("span .markup")).Count, Is.EqualTo(4));

        // Поиск всех элементов с тэгом h1 или p
        Assert.That(Driver.FindElements(By.CssSelector("h1, p")).Count, Is.EqualTo(8));
        
        // Поиск всех элементов с тэгом p у которых непосредственный родитель с тэгом div
        Assert.That(Driver.FindElements(By.CssSelector("div > p")).Count, Is.EqualTo(6));
    }
}