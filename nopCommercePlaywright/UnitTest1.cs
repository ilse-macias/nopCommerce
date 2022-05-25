using NUnit.Framework;
using Microsoft.Playwright;
using System.Threading.Tasks;
using nopCommercePlaywright.POM;
using nopCommercePlaywright.Constants;

namespace nopCommercePlaywright
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task RegisterANewUser()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 50
            }
            );

            var page = await browser.NewPageAsync();
            await page.SetViewportSizeAsync(1280, 720); //resolution - find how to create fullscreen
            await page.GotoAsync(CommonConstants.Url);

            HomePage homePage = new HomePage(page);
            await homePage.ClickOnLoginLink();

            Login login = new Login(page);
            await login.ClickOnRegisterButton();

            Register register = new Register(page);
            await register.FillUpRegisterFields(RegisterConstants.FirstName, RegisterConstants.LastName, RegisterConstants.Email);
          
            Assert.Pass();
        }
    }
}