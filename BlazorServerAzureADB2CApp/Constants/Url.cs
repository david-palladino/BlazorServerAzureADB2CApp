using System;

namespace BlazorServerAzureADB2CApp.Constants
{
    public class Url
    {
        public static class Site
        {
            public static class Account
            {
                public const string SignOut = "/account/signout";
            }

            public const string Error = "/error";
        }

        public static class AzureAdB2C
        {
            public const string SignIn = "MicrosoftIdentity/Account/SignIn";

            public const string SignOut = "MicrosoftIdentity/Account/SignOut";
        }
    }
}
