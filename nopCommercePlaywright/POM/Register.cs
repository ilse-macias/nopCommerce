using Microsoft.Playwright;
using nopCommercePlaywright.Locators;
using System.Threading.Tasks;

namespace nopCommercePlaywright.POM
{
    public class Register
    {
        private IPage _page;


        public Register(IPage page)
        {
            _page = page;
        }
        //Locators
        private ILocator _firstNameField => _page.Locator(RegisterLocators.FirstNameId);
        private ILocator _lastNameField => _page.Locator(RegisterLocators.LastNameId);
        private ILocator _emailField => _page.Locator(RegisterLocators.EmailId);
       // private ILocator _registerButton 

        private ILocator _dayBirth => _page.Locator(RegisterLocators.DayBirthXpath);
        private ILocator _monthBirth => _page.Locator("select", new PageLocatorOptions 
        { 
            HasTextString = RegisterLocators.MonthBirthText 
        });
        private ILocator _newsletterCheckbox => _page.Locator(RegisterLocators.NewsletterCheckboxId);
        private ILocator _passwordField => _page.Locator(RegisterLocators.Password);
        private ILocator _confirmPasswordField => _page.Locator(RegisterLocators.ConfirmPassword);
        private ILocator _registerButton => _page.Locator(RegisterLocators.RegisterButtonId);

        public async Task FillUpRegisterFields(string firstName, string lastName, string email, string password, string confirmPassword)
        {
            await _firstNameField.FillAsync(firstName);
            await _lastNameField.FillAsync(lastName);
        
            await _dayBirth.SelectOptionAsync(new[] {new SelectOptionValue() 
            { 
                Value = RegisterLocators.DayBirthOptionValue } 
            });
            
            await _emailField.FillAsync(email);
            await _newsletterCheckbox.UncheckAsync();
            await _passwordField.FillAsync(password);
            await _confirmPasswordField.FillAsync(confirmPassword);
            await _registerButton.ClickAsync();
        }
    }
}
