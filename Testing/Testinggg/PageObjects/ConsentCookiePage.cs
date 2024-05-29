using OpenQA.Selenium;
using System;

namespace Testinggg.PageObjects
{
    public class ConsentCookiePage
    {
        private IWebDriver driver;

        public ConsentCookiePage(IWebDriver browser)
        {
            driver = browser;
        }

        private IWebElement ConsentButton => driver.FindElement(By.CssSelector("#InformativaAccetto"));

        public void ConsentCookies()
        {
            // Verifică dacă butonul pentru acordul cu cookie-urile este vizibil înainte de a face clic pe el
            if (ConsentButton.Displayed)
            {
                ConsentButton.Click();
            }
            else
            {
                Console.WriteLine("Butonul pentru acordul cu cookie-urile nu este vizibil.");
            }
        }
    }
}
