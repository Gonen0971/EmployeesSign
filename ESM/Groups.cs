

namespace EmployeeManagementSystem
{
    public class Groups
    {
        public Groups(string gtype, string gName, string gdesc)
        {
            GType = gtype;
            GName = gName;
            GDesc = gdesc;
        }

        public string GType { get; set; }
        public string GName { get; set; }
        public string GDesc { get; set; }

    }
}
