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
            app.Navigator.GoToContactsPage();
            ContactData contact = new ContactData("firstname", "lastname");
            app.Contacts
                .InitContactCreation()
                .FillContactForm(contact)
                .SubmitContactCreation()
                .ReturnToContactsPage();
        }   
    }
}
