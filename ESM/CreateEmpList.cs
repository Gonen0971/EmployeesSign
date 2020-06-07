using System;
using System.Globalization;

namespace EmployeeManagementSystem
{

     public class EmpBase 
    {
        public string EmpDepartment;
        public string EmpID;
        public string EmpName;
        public bool EmpNeedsToSign;

        public EmpBase(string department, string id, string name, bool needstosign)
        {
            this.EmpDepartment = department;
            this.EmpID = id;
            this.EmpName = name;
            this.EmpNeedsToSign = needstosign;
        }
    }

    public class SignedList
    {
        public string EmpID;
        public DateTime Date;
        public bool Selected;
        public string DocName;

        public SignedList(string empid, DateTime date, bool selected , string docname)
        {
            this.EmpID = empid;
            this.Date = date;
            this.Selected = selected;
            this.DocName = docname;
        }
    }
}
