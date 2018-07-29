using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData("firstname", "lastname");

            List<ContactData> oldContacts = app.Contacts.GetContactsList();
            app.Contacts.Create(contact);
            List<ContactData> newContacts = app.Contacts.GetContactsList();
            Assert.AreEqual(oldContacts.Count + 1, newContacts.Count);


        }

        [Test]
        public void EmptyContactCreationTest()
        {
            List<ContactData> oldContacts = app.Contacts.GetContactsList();
            ContactData contact = new ContactData("firstname", "lastname");
            app.Contacts.Create(contact);
            List<ContactData> newContacts = app.Contacts.GetContactsList();
            Assert.AreEqual(oldContacts.Count + 1, newContacts.Count);
        }
    }
}
