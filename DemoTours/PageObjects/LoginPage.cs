using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Framework;

namespace DemoTours.PageObjects
{
    class LoginPage
    {
        #region Variables
        #region Login

        public const string UserName = "userName";
        public const string Password = "password";
        public const string LoginBtn = "login";

        #endregion
        #endregion

        #region Methods

        public static void DemoEnterUserName()
        {
            Browser.EnterText(BySelection.Name, UserName, "avnfact");
        }

        public static void DemoEnterPassword()
        {
            Browser.EnterText(BySelection.Name, Password, "avnfact");
        }

        public static void DemoEnterLoginBtn()
        {
            Browser.Click(BySelection.Name, LoginBtn);
        }

        #endregion

    }
}
