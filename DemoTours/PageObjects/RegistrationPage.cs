using Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Framework;
using Test.Framework.Helpers;

namespace DemoTours.PageObjects
{
    class RegistrationPage
    {
        #region Variables

        #region Registration Objects

        private const string RegisterLink = "/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[2]/td/table/tbody/tr/td[2]/a";
        private const string FirstName = "firstName";
        private const string LastName = "lastName";
        private const string Phone = "phone";
        private const string EmailID = "userName";
        private const string Address1 = "address1";
        private const string Address2 = "address2";
        private const string City = "city";
        private const string State = "state";
        private const string PostCode = "postalCode";
        private const string Country = "country";
        private const string UserNameID = "email";
        private const string Password = "password";
        private const string ConfirmPassword = "confirmPassword";
        private const string Submit = "register";

        #endregion

        #endregion

        #region Methods

        #region Registration Sucess

        public static void RegisterLinkClick()
        {
            Browser.Click(BySelection.XPath, RegisterLink);
        }

        public static void DemoEnterFirstName( string firstName = "")
        {
            if (firstName == "")
            {
                firstName = Faker.NameFaker.FirstName();
            }

            Browser.EnterText(BySelection.Name, FirstName, firstName);
        }

        public static void DemoEnterLastName(string lastName = "")
        {
            if (lastName == "")
            {
                lastName = Faker.NameFaker.LastName();
            }

            Browser.EnterText(BySelection.Name, LastName, lastName);
        }

        public static void DemoEnterPhone(string phone = "")
        {
            if (phone == "")
            {
                phone = Faker.StringFaker.Numeric(10);
            }

            Browser.EnterText(BySelection.Name, Phone, phone);
        }

        public static void DemoEnterEMail(string email = "")
        {
            if (email == "")
            {
                email = Faker.NameFaker.FirstName() + NumberFaker.Number(99) + "@yopmail.com";
            }

            Browser.EnterText(BySelection.Name, EmailID, email);
        }

        public static void DemoEnterAddress1(string address1 = "")
        {
            if (address1 == "")
            {
                address1 = Faker.LocationFaker.Street();
            }

            Browser.EnterText(BySelection.Name, Address1, address1);
        }

        public static void DemoEnterAddress2(string address2 = "")
        {
            if (address2 == "")
            {
                address2 = Faker.LocationFaker.StreetName();
            }

            Browser.EnterText(BySelection.Name, Address2, address2);
        }

        public static void DemoEnterCity(string city = "")
        {
            if (city == "")
            {
                city = Faker.LocationFaker.City();
            }

            Browser.EnterText(BySelection.Name, City, city);
        }

        public static void DemoEnterState(string state = "")
        {
            if (state == "")
            {
                state = Faker.LocationFaker.City();
            }

            Browser.EnterText(BySelection.Name, State, state);
        }

        public static void DemoEnterPostCode(string postCode = "")
        {
            if (postCode == "")
            {
                postCode = Faker.LocationFaker.ZipCode();
            }

            Browser.EnterText(BySelection.Name, PostCode, postCode);
        }

        public static void DemoEnterCountry(int country = 260)
        {
            country = Randomizer.RandomNumber(1, country);
            Browser.SelectDropDownByIndex(By.Name(Country), country);
        }

        public static void DemoEnterUserName(string userName = "")
        {
            if (userName == "")
            {
                userName = Faker.NameFaker.Name();
            }

            Browser.EnterText(BySelection.Id, UserNameID, userName);
        }

        public static void DemoEnterPassword(string password = "")
        {
            if (password == "")
            {
                password = Faker.NameFaker.Name();
            }

            Browser.EnterText(BySelection.Name, Password, password);
        }

        public static void DemoEnterConfirmPassword(string cpassword = "")
        {
            if (cpassword == "")
            {
                cpassword = Faker.NameFaker.Name();
            }

            Browser.EnterText(BySelection.Name, ConfirmPassword, cpassword);
        }

        public static void DemoRegSubmit()
        {
            Browser.Click(BySelection.Name, Submit);
        }

        #endregion

        #endregion



    }
}
