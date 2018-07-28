﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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

            app.Contacts.Remove(1); 
        }
    }
}
