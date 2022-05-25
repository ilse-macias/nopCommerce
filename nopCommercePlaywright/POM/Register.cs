using Microsoft.Playwright;
using System.Threading.Tasks;

namespace nopCommercePlaywright.POM
{
    public class Register
    {
        private IPage _page;
        private ILocator _firstNameField;
        private ILocator _lastNameField;
        private ILocator _emailField;
        private ILocator _registerButton;

        private ILocator _dayBirth;
        private ILocator _monthBirth;
        private ILocator _newsletterCheckbox;

        public Register(IPage page)
        {
            _page = page;
            _firstNameField = _page.Locator("#FirstName");
            _lastNameField = _page.Locator("#LastName");
            _emailField = _page.Locator("#Email");

            _dayBirth = _page.Locator("//select[@name='DateOfBirthDay']");
            _monthBirth = _page.Locator("select", new PageLocatorOptions { HasTextString = "Month" });

            _newsletterCheckbox = _page.Locator("#Newsletter");
            _registerButton = _page.Locator("#register-button");
        }

        public async Task FillUpRegisterFields(string firstName, string lastName, string email)
        {
            await _firstNameField.FillAsync(firstName);
            await _lastNameField.FillAsync(lastName);
        
            await _dayBirth.SelectOptionAsync(new[] {new SelectOptionValue() { Value = "3" } });
            await _emailField.FillAsync(email);
            await _newsletterCheckbox.UncheckAsync();
            await _registerButton.ClickAsync();
        }
    }
}
