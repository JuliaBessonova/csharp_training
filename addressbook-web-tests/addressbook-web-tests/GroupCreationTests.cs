﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            navigationHelper.OpenHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigationHelper.GoToGroupsPage();
            groupHelper.InitGroupCreation();
            GroupData group = new GroupData("name");
            group.Header = "header";
            group.Footer = "footer";
            groupHelper.FillGroupForm(group);
            groupHelper.SubmitGroupCreation();
            groupHelper.ReturnToGroupsPage();
            loginHelper.Logout();
        }                  
    }
}
