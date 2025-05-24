using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Xunit;
using Allure.Xunit.Attributes;
using Allure.Commons; // Add this import at the top of the file


namespace LoginAutomation
{
    public class LoginTests
    {

        
        public static IEnumerable<object[]> GetTestData()
        {
            using (var reader = new StreamReader("LoginTestData.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                foreach (var record in csv.GetRecords<TestData>())
                {
                    yield return new object[] { record.Username, record.Password };
                }
            }
        }

        [AllureSuite("Login Suite")]
        [AllureSubSuite("Valid Login")]
        [AllureTag("Selenium", "CSV")]
        [AllureSeverity((Allure.Net.Commons.SeverityLevel)SeverityLevel.critical)]
        [Theory]
        [MemberData(nameof(GetTestData))]

        public void Login_WithValidCredentials_ShouldSucceed(string username, string password)
        {
            // Initialize the ChromeDriver
            using (IWebDriver driver = new ChromeDriver())
            {
                // Navigate to the login page
                driver.Navigate().GoToUrl("C:\\Users\\aungk\\source\\repos\\LoginAutomation\\index.html");
                // Find the username and password fields and fill them
                driver.FindElement(By.Id("username")).SendKeys(username);
                driver.FindElement(By.Id("password")).SendKeys(password);
                // Click the login button
                driver.FindElement(By.Id("loginButton")).Click();
                // Add assertions as needed, e.g., check for a successful login message
                // For this example, we'll just wait for a few seconds to simulate the login process
            
                System.Threading.Thread.Sleep(2000);
            }
        }

        public class TestData
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
}