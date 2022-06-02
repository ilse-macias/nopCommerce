namespace nopCommercePlaywright.Locators
{
    public static class RegisterLocators
    {
        //Find element by ID
        public const string FirstNameId = "#FirstName";
        public const string LastNameId = "#LastName";
        public const string EmailId = "#Email";
        public const string NewsletterCheckboxId = "#Newsletter";
        public const string Password = "#Password";
        public const string ConfirmPassword = "#ConfirmPassword";
        public const string RegisterButtonId = "#register-button";

        //Find element by xPath relative
        public const string DayBirthXpath = "//select[@name='DateOfBirthDay']";

        //Find element by Text
        public const string MonthBirthText = "Month";
        public const string DayBirthOptionValue = "3";
    }
}
