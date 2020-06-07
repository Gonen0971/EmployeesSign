using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Group
    {
        public Group(string gtype, string gname, string gdesc)
        {
            GType = gtype;
            GName = gname;
            GDesc = gdesc;
        }
        public Group()
        {

        }

        public string GType { get; set; }
        public string GName { get; set; }
        public string GDesc { get; set; }
    }
    public class Document
    {
        public Document(string docname, string docdescription, string docfilename)
        {
            DocName = docname;
            DocDescription = docdescription;
            DocFileName = docfilename;
        }
        public Document()
        {

        }

        public string DocName { get; set; }
        public string DocDescription { get; set; }
        public string DocFileName { get; set; }
    }

    public class Employee
    {
        public Employee()
        {

        }

        public Employee(string employeeNum, string id, string fullName, string mobile, string email, string department)
        {
            this.EmployeeNum = employeeNum;
            this.EmployeeID = id;
            this.FullName = fullName;
            this.Mobile = mobile;
            this.Email = email;
            this.Department = department;
        }

        public string EmployeeNum { get; set; }
        public string EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }

    }

    public class SignEvents
    {
        public SignEvents(string employeeid, DateTime date, bool marked, string document)
        {
            this.EmployeeId = employeeid;
            this.Date = date;
            this.Marked = marked;
            this.Document = document;
        }


        public SignEvents(int id, string employeeid, DateTime date, bool marked, string document, DateTime signdate)
        {
            this.ID = id;
            this.EmployeeId = employeeid;
            this.Date = date;
            this.Marked = marked;
            this.Document = document;
            this.SignDate = signdate;
        }

        public SignEvents()
        {

        }

        public int ID { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? Date { get; set; }
        public bool Marked { get; set; }
        public string Document { get; set; }
        public DateTime? SignDate { get; set; }

    }

    public class Events : SignEvents
    {
        public Events(string employeeid, DateTime date, bool marked, string document, DateTime signdate, string fullname)
        {
            this.EmployeeId = employeeid;
            this.Date = date;
            this.Marked = marked;
            this.Document = document;
            this.SignDate = signdate;
            this.FullName = fullname;
        }


        public Events(int id, string employeeid, DateTime date, bool marked, string document, DateTime signdate, string fullname)
        {
            this.ID = id;
            this.EmployeeId = employeeid;
            this.Date = date;
            this.Marked = marked;
            this.Document = document;
            this.SignDate = signdate;
            this.FullName = fullname;
        }
        public Events()
        {

        }
        public string FullName { get; set; }
    }
}



