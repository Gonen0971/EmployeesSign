using System;

namespace EmployeeManagementSystem
{
    /*******
     * 
     * This class will the values from delegates and return the values through properties.
     * 
     *******/
    public class DocIdentityEventArgs : EventArgs
    {
        public DocIdentityEventArgs(string employeeNum, string id, string fullName, string mobile, string email, string department)
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
}
