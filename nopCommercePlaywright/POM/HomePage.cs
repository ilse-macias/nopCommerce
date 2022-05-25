using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nopCommercePlaywright.POM
{
    public class HomePage
    {
        private IPage _page;
        private ILocator _loginLink;
        public HomePage(IPage page)
        {
            _page = page;
            _loginLink = _page.Locator("text=Log in");
        }

        public async Task ClickOnLoginLink() => await _loginLink.ClickAsync();
    }
}
