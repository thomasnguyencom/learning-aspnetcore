using System;

namespace FyrSoft.WaaS.ConfigManRepository
{
    public class SccmUser
    {
        public virtual int ResourceID { get; set; }
        public virtual int? ResourceType { get; set; }
        public virtual Guid? AADTenantID { get; set; }
        public virtual Guid? AADUserID { get; set; }
        public virtual DateTime? AD_Object_Creation_Time0 { get; set; }
        public virtual Guid? CloudUserId { get; set; }
        public virtual DateTime? Creation_Date0 { get; set; }
        public virtual string department0 { get; set; }
        public virtual string Distinguished_Name0 { get; set; }
        public virtual string employeeID0 { get; set; }
        public virtual string Full_Domain_Name0 { get; set; }
        public virtual string Full_User_Name0 { get; set; }
        public virtual string givenName0 { get; set; }
        public virtual string Mail0 { get; set; }
        public virtual string manager0 { get; set; }
        public virtual string middleName0 { get; set; }
        public virtual string Name0 { get; set; }
        public virtual string Network_Operating_System0 { get; set; }
        public virtual string physicalDeliveryOfficeNam0 { get; set; }
        public virtual int? Primary_Group_ID0 { get; set; }
        public virtual string SID0 { get; set; }
        public virtual string sn0 { get; set; }
        public virtual string title0 { get; set; }
        public virtual string Unique_User_Name0 { get; set; }
        public virtual int? User_Account_Control0 { get; set; }
        public virtual string User_Name0 { get; set; }
        public virtual string User_Principal_Name0 { get; set; }
        public virtual string Windows_NT_Domain0 { get; set; }

        public SccmUser()
        {
            ResourceID = 0;
            ResourceType = null;
            AADTenantID = null;
            AADUserID = null;
            AD_Object_Creation_Time0 = null;
            CloudUserId = null;
            Creation_Date0 = null;
            department0 = null;
            Distinguished_Name0 = null;
            employeeID0 = null;
            Full_Domain_Name0 = null;
            Full_User_Name0 = null;
            givenName0 = null;
            Mail0 = null;
            manager0 = null;
            middleName0 = null;
            Name0 = null;
            Network_Operating_System0 = null;
            physicalDeliveryOfficeNam0 = null;
            Primary_Group_ID0 = null;
            SID0 = null;
            sn0 = null;
            title0 = null;
            Unique_User_Name0 = null;
            User_Account_Control0 = null;
            User_Name0 = null;
            User_Principal_Name0 = null;
            Windows_NT_Domain0 = null;
        }

        public override bool Equals(object obj)
        {
            var foo = obj as SccmUser;
            if (foo == null)
            {
                return false;
            }

            return (foo.ResourceID == this.ResourceID)
                && (foo.ResourceType == this.ResourceType)
                && (foo.AADTenantID == this.AADTenantID)
                && (foo.AADUserID == this.AADUserID)
                && (foo.AD_Object_Creation_Time0 == this.AD_Object_Creation_Time0)
                && (foo.CloudUserId == this.CloudUserId)
                && (foo.Creation_Date0 == this.Creation_Date0)
                && (foo.department0 == this.department0)
                && (foo.Distinguished_Name0 == this.Distinguished_Name0)
                && (foo.employeeID0 == this.employeeID0)
                && (foo.Full_Domain_Name0 == this.Full_Domain_Name0)
                && (foo.Full_User_Name0 == this.Full_User_Name0)
                && (foo.givenName0 == this.givenName0)
                && (foo.Mail0 == this.Mail0)
                && (foo.manager0 == this.manager0)
                && (foo.middleName0 == this.middleName0)
                && (foo.Name0 == this.Name0)
                && (foo.Network_Operating_System0 == this.Network_Operating_System0)
                && (foo.physicalDeliveryOfficeNam0 == this.physicalDeliveryOfficeNam0)
                && (foo.Primary_Group_ID0 == this.Primary_Group_ID0)
                && (foo.SID0 == this.SID0)
                && (foo.sn0 == this.sn0)
                && (foo.title0 == this.title0)
                && (foo.Unique_User_Name0 == this.Unique_User_Name0)
                && (foo.User_Account_Control0 == this.User_Account_Control0)
                && (foo.User_Name0 == this.User_Name0)
                && (foo.User_Principal_Name0 == this.User_Principal_Name0)
                && (foo.Windows_NT_Domain0 == this.Windows_NT_Domain0);
        }

        public override int GetHashCode()
        {
            return new
            {
                ResourceID,
                ResourceType,
                AADTenantID,
                AADUserID,
                AD_Object_Creation_Time0,
                CloudUserId,
                Creation_Date0,
                department0,
                Distinguished_Name0,
                employeeID0,
                Full_Domain_Name0,
                Full_User_Name0,
                givenName0,
                Mail0,
                manager0,
                middleName0,
                Name0,
                Network_Operating_System0,
                physicalDeliveryOfficeNam0,
                Primary_Group_ID0,
                SID0,
                sn0,
                title0,
                Unique_User_Name0,
                User_Account_Control0,
                User_Name0,
                User_Principal_Name0,
                Windows_NT_Domain0,
            }.GetHashCode();
        }
    }
}
