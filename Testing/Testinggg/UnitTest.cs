using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Testinggg.PageObjects;

namespace TestingAutomation
{
    
    [TestClass]
    public class Inregistrare
    {
        private ChromeDriver driver;
        private ConsentCookiePage consentCookiePage;

        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            consentCookiePage = new ConsentCookiePage(driver);
        }

        [TestMethod]
        public void Test_Inregistrare()
        {
            // var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Accesează pagina principală
            driver.Navigate().GoToUrl("https://papetarie-asp.ro/");

            // Acceptare cookies
            consentCookiePage.ConsentCookies();

            // Elementul butonului de cont folosind selectorul CSS
            IWebElement contButton = driver.FindElement(By.CssSelector("button.expand-more.btn-unstyle"));
            contButton.Click();

            Thread.Sleep(1000);

            // Elementul linkului autentificare folosind selectorul CSS
            IWebElement autentificareLink = driver.FindElement(By.CssSelector("a[title='Conecteaza-te la contul de client']"));
            autentificareLink.Click();

           Thread.Sleep(1000);

            // Elementul link-ului pentru crearea unui cont nou folosind selectorul CSS
            IWebElement createAccountLink = driver.FindElement(By.CssSelector("a[data-link-action='display-register-form']"));
            createAccountLink.Click();

            // Completarea câmpurilor cu gen, prenume, nume, email și parolă
            IWebElement genderRadioButton = driver.FindElement(By.CssSelector("input[name='id_gender'][value='2']"));
            genderRadioButton.Click();

            IWebElement firstNameInput = driver.FindElement(By.CssSelector("input[name='firstname']"));
            firstNameInput.SendKeys("Antonia");

            IWebElement lastNameInput = driver.FindElement(By.CssSelector("input[name='lastname']"));
            lastNameInput.SendKeys("Goriuc");

            IWebElement emailInput = driver.FindElement(By.CssSelector("input[name='email']"));
            emailInput.SendKeys("antoniagor27@yahoo.com");

            IWebElement passwordInput = driver.FindElement(By.CssSelector("input[name='password']"));
            passwordInput.SendKeys("Antonia12343");

            Thread.Sleep(1000);
            
            // Salavrea datelor
            IWebElement saveButton = driver.FindElement(By.CssSelector("button[data-link-action='save-customer']"));
            saveButton.Click();

            Thread.Sleep(5000);

        }
        [TestCleanup]
        public void TestCleanup()
        {
            driver.Quit();
        }
    }

    [TestClass]
    public class Cautare
    {
        private ChromeDriver driver;
        private ConsentCookiePage consentCookiePage;

        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            consentCookiePage = new ConsentCookiePage(driver);
        }

        [TestMethod]
        public void Test_Cautare()
        {
            // var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Accesează pagina principală
            driver.Navigate().GoToUrl("https://papetarie-asp.ro/");

            // Acceptare cookies
            consentCookiePage.ConsentCookies();

            // Elementul butonului de cont folosind selectorul CSS
            IWebElement contButton = driver.FindElement(By.CssSelector("button.expand-more.btn-unstyle"));
            contButton.Click();

            // Caută și dă click pe opțiunea "Autentificare"
            IWebElement myAccountLink = driver.FindElement(By.CssSelector("a[href='https://papetarie-asp.ro/contul-meu']"));
            myAccountLink.Click();

            Thread.Sleep(1000);

            // Completeaza campul cu emailul corespunzator contului creat
            IWebElement emailInput = driver.FindElement(By.CssSelector("input[name='email']"));
            emailInput.SendKeys("antoniagoriuc27@yahoo.com");

            // Completeaza campul cu parola corespunzatoare contului creat 
            IWebElement passwordInput = driver.FindElement(By.CssSelector("input[name='password']"));
            passwordInput.SendKeys("Antonia12343");

            Thread.Sleep(1000);

            // Autentificare
            IWebElement autentificareButton = driver.FindElement(By.CssSelector("#submit-login"));
            autentificareButton.Click();

            // Găsirea elementului pentru bara de căutare și introducerea textului "creion"
            IWebElement searchInput = driver.FindElement(By.CssSelector("#pos_query_top"));
            searchInput.SendKeys("creion");

            Thread.Sleep(1000);

            // Execută comanda de căutare apăsând tasta Enter
            Actions action = new Actions(driver);
            action.SendKeys(Keys.Enter).Perform();

            Thread.Sleep(5000);
        }
        [TestCleanup]
        public void TestCleanup()
        {
            driver.Quit();
        }
    }


    [TestClass]
    public class AddToCart
    {
        private ChromeDriver driver;
        private ConsentCookiePage consentCookiePage;

        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            consentCookiePage = new ConsentCookiePage(driver);
        }

        [TestMethod]
        public void Cart()
        {
            // var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Accesează pagina principală
            driver.Navigate().GoToUrl("https://papetarie-asp.ro/");

            // Acceptare cookies
            consentCookiePage.ConsentCookies();

            // Elementul butonului de cont folosind selectorul CSS
            IWebElement contButton = driver.FindElement(By.CssSelector("button.expand-more.btn-unstyle"));
            contButton.Click();

            // Caută și dă click pe opțiunea "Autentificare"
            IWebElement myAccountLink = driver.FindElement(By.CssSelector("a[href='https://papetarie-asp.ro/contul-meu']"));
            myAccountLink.Click();

            Thread.Sleep(1000);

            // Completeaza campul cu emailul corespunzator contului creat
            IWebElement emailInput = driver.FindElement(By.CssSelector("input[name='email']"));
            emailInput.SendKeys("antoniagoriuc27@yahoo.com");

            // Completeaza campul cu parola corespunzatoare contului creat 
            IWebElement passwordInput = driver.FindElement(By.CssSelector("input[name='password']"));
            passwordInput.SendKeys("Antonia12343");

            Thread.Sleep(1000);

            // Autentificare
            IWebElement autentificareButton = driver.FindElement(By.CssSelector("#submit-login"));
            autentificareButton.Click();

            // Găsirea elementului pentru bara de căutare și introducerea textului "creion"
            IWebElement searchInput = driver.FindElement(By.CssSelector("#pos_query_top"));
            searchInput.SendKeys("acuarele");

            Thread.Sleep(1000);

            // Execută comanda de căutare apăsând tasta Enter
            Actions action = new Actions(driver);
            action.SendKeys(Keys.Enter).Perform();

            Thread.Sleep(2000);

            // Adăugarea in coș
            IWebElement addToCartButton = driver.FindElement(By.CssSelector("article[data-id-product='14969'] button[data-button-action='add-to-cart']"));
            addToCartButton.Click();

            Thread.Sleep(2000);

            // Selectarea continuării cumpărăturilor
            IWebElement continuaCumparaturileButton = driver.FindElement(By.CssSelector("button[data-dismiss='modal']"));
            continuaCumparaturileButton.Click();

            Thread.Sleep(5000);
        }
        [TestCleanup]
        public void TestCleanup()
        {
            driver.Quit();
        }
    }

    [TestClass]
    public class AddAddress
    {
        private ChromeDriver driver;
        private ConsentCookiePage consentCookiePage;

        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            consentCookiePage = new ConsentCookiePage(driver);
        }

        [TestMethod]
        public void Address()
        {
            // var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Accesează pagina principală
            driver.Navigate().GoToUrl("https://papetarie-asp.ro/");

            // Acceptare cookies
            consentCookiePage.ConsentCookies();

            // Elementul butonului de cont folosind selectorul CSS
            IWebElement contButton = driver.FindElement(By.CssSelector("button.expand-more.btn-unstyle"));
            contButton.Click();

            // Caută și dă click pe opțiunea "Autentificare"
            IWebElement myAccountLink = driver.FindElement(By.CssSelector("a[href='https://papetarie-asp.ro/contul-meu']"));
            myAccountLink.Click();

            Thread.Sleep(1000);

            // Completeaza campul cu emailul corespunzator contului creat
            IWebElement emailInput = driver.FindElement(By.CssSelector("input[name='email']"));
            emailInput.SendKeys("antoniagoriuc27@yahoo.com");

            // Completeaza campul cu parola corespunzatoare contului creat 
            IWebElement passwordInput = driver.FindElement(By.CssSelector("input[name='password']"));
            passwordInput.SendKeys("Antonia12343");

            Thread.Sleep(1000);

            // Autentificare
            IWebElement autentificareButton = driver.FindElement(By.CssSelector("#submit-login"));
            autentificareButton.Click();

            Thread.Sleep(2000);

            // Căutarea și click pe link-ul cu textul "Adauga prima adresa" și icon-ul material-icons
            IWebElement addAddressLink = driver.FindElement(By.CssSelector("a#address-link .material-icons"));
            addAddressLink.Click();

            Thread.Sleep(2000);

            // Completează câmpul "address1"
            IWebElement addressInput = driver.FindElement(By.CssSelector("input[name='address1']"));
            addressInput.SendKeys("Strada Exemplu 123");

            // Completează câmpul "postcode"
            IWebElement postalCodeInput = driver.FindElement(By.CssSelector("input[name='postcode']"));
            postalCodeInput.SendKeys("123456");

            // Completează câmpul "city"
            IWebElement cityInput = driver.FindElement(By.CssSelector("input[name='city']"));
            cityInput.SendKeys("Orasul Meu");

            // Selectează "Iasi" din dropdown-ul de state
            IWebElement stateDropdown = driver.FindElement(By.CssSelector("select[name='id_state']"));
            SelectElement selectElement = new SelectElement(stateDropdown);
            selectElement.SelectByText("Iasi");

            // Completează câmpul "phone"
            IWebElement phoneInput = driver.FindElement(By.CssSelector("input[name='phone']"));
            phoneInput.SendKeys("0712345678");

            // Apasă pe butonul "Salveaza"
            IWebElement saveAddressButton = driver.FindElement(By.CssSelector("button.btn.btn-primary.float-xs-right[type='submit']"));
            saveAddressButton.Click();

            Thread.Sleep(5000);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            driver.Quit();
        }
    }
    
    [TestClass]
    public class NewsLetter
    {
        private ChromeDriver driver;
        private ConsentCookiePage consentCookiePage;

        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            consentCookiePage = new ConsentCookiePage(driver);
        }

        [TestMethod]
        public void Test_NewsLetter()
        {
            driver.Manage().Window.Maximize();

            // Accesează pagina principală
            driver.Navigate().GoToUrl("https://papetarie-asp.ro/");

            // Acceptare cookies
            consentCookiePage.ConsentCookies();

            // Completeaza campul cu emailul corespunzator pentru NewsLetter
            IWebElement emailInput = driver.FindElement(By.CssSelector("input[name='email']"));
            emailInput.SendKeys("centric27@yahoo.com");

            Thread.Sleep(1000);

            // Abonare NewsLetter
            IWebElement abonareButton = driver.FindElement(By.CssSelector("input.btn.btn-primary.float-xs-right.hidden-xs-down[name='submitNewsletter']"));
            abonareButton.Click();

            Thread.Sleep(5000);
        }
        [TestCleanup]
        public void TestCleanup()
        {
            driver.Quit();
        }
    }
}
