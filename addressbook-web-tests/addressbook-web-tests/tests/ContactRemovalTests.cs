using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            if (app.Contacts.IsContactExists() is false)
            {
                ContactData contact = new ContactData("firstname", "lastname");
                app.Contacts.Create(contact);
            }

            List<GroupData> oldGroups = app.Groups.GetGroupsList();
            app.Contacts.Remove(0);
            List<GroupData> newGroups = app.Groups.GetGroupsList();
            oldGroups.RemoveAt(0);
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
