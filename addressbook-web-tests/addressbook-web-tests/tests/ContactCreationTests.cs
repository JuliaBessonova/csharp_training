using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToContactsPage();
            app.Contacts.InitContactCreation();
            ContactData contact = new ContactData("firstname", "lastname");
            app.Contacts.FillContactForm(contact);
            app.Contacts.SubmitContactCreation();
            app.Contacts.ReturnToContactsPage();
            app.Auth.Logout();
        }   
    }
}
