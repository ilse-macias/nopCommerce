using Microsoft.Playwright;
using System.Threading.Tasks;

namespace nopCommercePlaywright.POM
{
    public class Login
    {
        private IPage _page;
        private ILocator _registerButton;

        public Login(IPage page)
        {
            _page = page;
            _registerButton = _page.Locator("button", new PageLocatorOptions 
            { 
                HasTextString = "Register"
            });
        }

        public async Task ClickOnRegisterButton() => await _registerButton.ClickAsync();
    }
}
