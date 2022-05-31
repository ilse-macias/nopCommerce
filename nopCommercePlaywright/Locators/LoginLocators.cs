using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nopCommercePlaywright.Locators
{
    public static class LoginLocators
    {
        //By Id
        public const string EmailId = "#Email";
        public const string PasswordId = "#Password";
        public const string RememberMeId = "#RememberMe";

        //By Class
        public const string ForgotPasswordClass = ".forgot-password";
        public const string LoginClass = ".button-1.login-button";
    }
}
