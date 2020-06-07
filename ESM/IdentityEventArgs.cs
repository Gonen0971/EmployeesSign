using System;

namespace EmployeeManagementSystem
{
    /*******
     * 
     * This class will the values from delegates and return the values through properties.
     * 
     *******/
    public class IdentityEventArgs : EventArgs
    {
        public IdentityEventArgs(string employeeNum, string id, string fullName, string mobile, string email, string department)
        {
            this.EmployeeNum = employeeNum; 
            this.Id = id;
            this.FullName = fullName;
            this.Mobile = mobile;
            this.Email = email;
            this.Department = department;
        }

        public string EmployeeNum { get; }
        public string Id { get; }
        public string FullName { get; }
        public string Mobile { get; }
        public string Contact { get; }
        public string Email { get; }
        public string Department { get; }
        
    }
    public class GrpIdentityEventArgs : EventArgs
    {
        public GrpIdentityEventArgs(string grouptype, string groupname, string groupdesc)
        {
            this.GroupType = grouptype;
            this.GroupName = groupname;
            this.GroupDesc = groupdesc;
        }

        public string GroupType { get; }
        public string GroupName { get; }
        public string GroupDesc { get; }
        }

}
