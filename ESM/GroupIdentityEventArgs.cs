using System;

namespace EmployeeManagementSystem
{
    /*******
     * 
     * This class will the values from delegates and return the values through properties.
     * 
     *******/
    public class GroupIdentityEventArgs : EventArgs
    {
        public GroupIdentityEventArgs(string gtype, string gname, string gdesc)
        {
            this.GType = gdesc;
            this.GName = gname;
            this.GDesc = gdesc;
        }

        public string GType { get; set; }
        public string GName { get; set; }
        public string GDesc { get; set; }

    }
}
