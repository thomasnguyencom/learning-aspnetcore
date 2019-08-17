using FyrSoft.WaaS.ConfigManRepository;
using NUnit.Framework;
using System;

namespace ConfigManRepository.Tests
{
    [TestFixture]
    public class SccmUserTests
    {
        [Test]
        public void Constructor()
        {
            var foo = new SccmUser();

            Assert.AreEqual(0, foo.ResourceID);
            Assert.AreEqual(null, foo.ResourceType);
            Assert.AreEqual(null, foo.AADTenantID);
            Assert.AreEqual(null, foo.AADUserID);
            Assert.AreEqual(null, foo.AD_Object_Creation_Time0);
            Assert.AreEqual(null, foo.CloudUserId);
            Assert.AreEqual(null, foo.Creation_Date0);
            Assert.AreEqual(null, foo.department0);
            Assert.AreEqual(null, foo.Distinguished_Name0);
            Assert.AreEqual(null, foo.employeeID0);
            Assert.AreEqual(null, foo.Full_Domain_Name0);
            Assert.AreEqual(null, foo.Full_User_Name0);
            Assert.AreEqual(null, foo.givenName0);
            Assert.AreEqual(null, foo.Mail0);
            Assert.AreEqual(null, foo.manager0);
            Assert.AreEqual(null, foo.middleName0);
            Assert.AreEqual(null, foo.Name0);
            Assert.AreEqual(null, foo.Network_Operating_System0);
            Assert.AreEqual(null, foo.physicalDeliveryOfficeNam0);
            Assert.AreEqual(null, foo.Primary_Group_ID0);
            Assert.AreEqual(null, foo.SID0);
            Assert.AreEqual(null, foo.sn0);
            Assert.AreEqual(null, foo.title0);
            Assert.AreEqual(null, foo.Unique_User_Name0);
            Assert.AreEqual(null, foo.User_Account_Control0);
            Assert.AreEqual(null, foo.User_Name0);
            Assert.AreEqual(null, foo.User_Principal_Name0);
            Assert.AreEqual(null, foo.Windows_NT_Domain0);
        }

        [Test]
        public void EqualsGetHashCode()
        {
            var foo = new SccmUser();

            foo.ResourceID = 42;
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.ResourceType = 42;
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.AADTenantID = Guid.NewGuid();
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.AADUserID = Guid.NewGuid();
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.AD_Object_Creation_Time0 = DateTime.Parse("1910-01-01");
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.CloudUserId = Guid.NewGuid();
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.Creation_Date0 = DateTime.Parse("1910-01-01");
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());
            foo.department0 = "foobarbaz";
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.Distinguished_Name0 = "foobarbaz";
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.employeeID0 = "foobarbaz";
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.Full_Domain_Name0 = "foobarbaz";
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.Full_User_Name0 = "foobarbaz";
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.givenName0 = "foobarbaz";
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.Mail0 = "foobarbaz";
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.manager0 = "foobarbaz";
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.middleName0 = "foobarbaz";
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.Name0 = "foobarbaz";
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.Network_Operating_System0 = "foobarbaz";
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.physicalDeliveryOfficeNam0 = "foobarbaz";
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.Primary_Group_ID0 = 42;
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.SID0 = "foobarbaz";
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.sn0 = "foobarbaz";
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.title0 = "foobarbaz";
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.Unique_User_Name0 = "foobarbaz";
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.User_Account_Control0 = 42;
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.User_Name0 = "foobarbaz";
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.User_Principal_Name0 = "foobarbaz";
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());

            foo.Windows_NT_Domain0 = "foobarbaz";
            Assert.IsFalse(foo.Equals(new SccmUser()));
            Assert.IsFalse(foo.GetHashCode() == new SccmUser().GetHashCode());
        }
    }
}
