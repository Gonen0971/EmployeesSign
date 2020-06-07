

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;


namespace Utilities
{
    public static class DBUtility
    {

        static public void CreateTables()
        {
            string DBPath = Path.Combine(AssemblyDirectory, "EmpSignDB.mdb");
            String aConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "data source = " + DBPath + ";Jet OLEDB:Database Password = sps";

            OleDbConnection cn = new OleDbConnection(aConnectionString);

            try
            {

                if (cn.State == ConnectionState.Closed)
                    cn.Open();

                OleDbCommand cmd = cn.CreateCommand();
                /// ----  Employee Table   ---///
                cmd.CommandText = "CREATE TABLE Employees(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,EmployeeID VARCHAR(50),EmployeeNum VARCHAR(50),FullName VARCHAR(50),Mobile VARCHAR(50),Email VARCHAR(50),Department VARCHAR(50))";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147217900) return;

            }
            try
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                OleDbCommand cmd = cn.CreateCommand();
                /// ----  Documents Table   ---///
                cmd.CommandText = "CREATE TABLE Documents(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,DocName VARCHAR(50),DocDescription VARCHAR(150),DocFileName VARCHAR(100))";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147217900) return;

            }
            try
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                OleDbCommand cmd = cn.CreateCommand();
                /// ----  Groups Table   ---///
                cmd.CommandText = "CREATE TABLE Groups(ID int IDENTITY(1,1),GType VARCHAR(50),GName VARCHAR(50) PRIMARY KEY NOT NULL,GDesc VARCHAR(150))";
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                if (ex.HResult == -2147217900) return;

            }
            try
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                OleDbCommand cmd = cn.CreateCommand();
                /// ----  Groups Table   ---///
                cmd.CommandText = "CREATE TABLE SignEvents(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,Date DATETIME,Marked BINARY,Document VARCHAR(50))";
                cmd.ExecuteNonQuery();

                cn.Close();
            }

            catch (System.Exception ex)
            {
                if (ex.HResult == -2147217900) return;
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        static public List<Employee> FillComboBoxEmpName()
        {
            List<Employee> employees = new List<Employee>();
            OleDbConnection cn = ConnectToDB();
            try
            {
                string strSQL = "SELECT * FROM Emploees";

                OleDbCommand myCommand = new OleDbCommand(strSQL, cn);

                OleDbDataReader myDataReader;
                myDataReader = myCommand.ExecuteReader();

                while (myDataReader.Read())
                {
                    Employee f = new Employee();
                    f.FullName = myDataReader["FullName"].ToString();
                    employees.Add(f);
                }

                myDataReader.Close();

                return employees;
            }
            catch (System.Exception ex)
            {
                Log.Write2Log(ex.Message);
                throw;
            }
            finally
            {
                cn.Close();

            }
        }

        static public List<Document> FillComboBoxDocName()
        {
            List<Document> documents = new List<Document>();
            OleDbConnection cn = ConnectToDB();
            try
            {
                string strSQL = "SELECT * FROM Documents";

                OleDbCommand myCommand = new OleDbCommand(strSQL, cn);

                OleDbDataReader myDataReader;
                myDataReader = myCommand.ExecuteReader();

                while (myDataReader.Read())
                {
                    Document f = new Document();
                    f.DocName = myDataReader["DocName"].ToString();
                    documents.Add(f);
                }

                myDataReader.Close();

                return documents;
            }
            catch (System.Exception ex)
            {
                Log.Write2Log(ex.Message);
                throw;
            }
            finally
            {
                cn.Close();
            }
        }


        static public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            OleDbConnection cn = ConnectToDB();
            try
            {
                string strSQL = "SELECT * FROM Emploees";

                OleDbCommand myCommand = new OleDbCommand(strSQL, cn);

                OleDbDataReader myDataReader;
                myDataReader = myCommand.ExecuteReader();

                while (myDataReader.Read())
                {
                    Employee f = new Employee();
                    f.EmployeeID = myDataReader["EmployeeID"].ToString();
                    f.EmployeeNum = myDataReader["EmployeeNum"].ToString();
                    f.FullName = myDataReader["FullName"].ToString();
                    f.Department = myDataReader["Department"].ToString();
                    f.Email = myDataReader["Email"].ToString();
                    f.Mobile = myDataReader["Mobile"].ToString();

                    employees.Add(f);
                }

                myDataReader.Close();

                return employees;
            }
            catch (System.Exception ex)
            {
                throw;
                Log.Write2Log(ex.Message);
            }
            finally
            {
                cn.Close();

            }
        }

        static public bool RemoveEmployee(string EmployeeNum)
        {
            OleDbConnection cn = ConnectToDB();
            try
            {
                String delQuery = "DELETE FROM Emploees WHERE [EmployeeNum]= ?";
                OleDbCommand delcmd = new OleDbCommand();
                delcmd.CommandText = delQuery;
                delcmd.Connection = cn;
                delcmd.Parameters.AddWithValue("?", EmployeeNum);
                delcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Log.Write2Log("Failed to Remove Employee with error: " + ex.Message);
                return false;
            }
            finally
            {
                cn.Close();

            }
            return true;
        }

        static public bool EditEmployee(Employee emp)
        {
            OleDbConnection cn = ConnectToDB();
            OleDbDataAdapter oledbAdapter = new OleDbDataAdapter();

            string sql = "update Emploees set EmployeeID = '" + emp.EmployeeID + "'," +
                "FullName = '" + emp.FullName + "'," +
                "Department = '" + emp.Department + "'," +
                "Email = '" + emp.Email + "'," +
                "Mobile = '" + emp.Mobile + "' " +
                "where EmployeeNum = '" + emp.EmployeeNum + "'";
            try
            {

                oledbAdapter.UpdateCommand = cn.CreateCommand();
                oledbAdapter.UpdateCommand.CommandText = sql;
                oledbAdapter.UpdateCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Log.Write2Log("Failed to Edit Employee with error: " + ex.Message);
                return false;
            }
            finally
            {
                cn.Close();

            }
            return true;

        }

        static public bool AddEmployee(Employee emp)
        {
            OleDbConnection cn = ConnectToDB();
            try
            {
                string strSQL = "INSERT INTO Emploees (EmployeeID,EmployeeNum,FullName,Department,Email,Mobile) VALUES (?,?,?,?,?,?)";

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                cmd.Parameters.AddWithValue("@EmployeeID", emp.EmployeeID);
                cmd.Parameters.AddWithValue("@EmployeeNum", emp.EmployeeNum);
                cmd.Parameters.AddWithValue("@FullName", emp.FullName);
                cmd.Parameters.AddWithValue("@Department", emp.Department);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@Mobile", emp.Mobile);

                cmd.Connection = cn;
                int res = cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Log.Write2Log("Failed to Add Employee with error: " + ex.Message);
                return false;

            }
            finally
            {
                cn.Close();

            }
        }



        ///////// <AddGroup>     //////////////////


        static public List<Group> GetGroups()
        {
            List<Group> groups = new List<Group>();
            OleDbConnection cn = ConnectToDB();
            try
            {
                string strSQL = "SELECT * FROM Groups ORDER BY GName";

                OleDbCommand myCommand = new OleDbCommand(strSQL, cn);

                OleDbDataReader myDataReader;
                myDataReader = myCommand.ExecuteReader();


                while (myDataReader.Read())
                {
                    Group grp = new Group();
                    grp.GType = myDataReader["GType"].ToString();
                    grp.GName = myDataReader["GName"].ToString();
                    grp.GDesc = myDataReader["GDesc"].ToString();
                    groups.Add(grp);
                }

                myDataReader.Close();

                return groups;
            }
            catch (System.Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();

            }
        }

        static public bool RemoveGroup(string GroupName)
        {
            OleDbConnection cn = ConnectToDB();
            try
            {
                String delQuery = "DELETE FROM Groups WHERE [GName]= ?";
                OleDbCommand delcmd = new OleDbCommand();
                delcmd.CommandText = delQuery;
                delcmd.Connection = cn;
                delcmd.Parameters.AddWithValue("?", GroupName);
                delcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Log.Write2Log("Failed to Remove Group with error: " + ex.Message);
                return false;
            }
            finally
            {
                cn.Close();

            }
            return true;
        }

        static public bool EditGroup(Group grp)
        {
            OleDbConnection cn = ConnectToDB();
            OleDbDataAdapter oledbAdapter = new OleDbDataAdapter();

            string sql = "update Groups set GName = '" + grp.GName + "'," +
                "GName = '" + grp.GName + "'," +
                "GDesc = '" + grp.GDesc + "'," +
                "where GNmae = '" + grp.GName + "'";
            try
            {

                oledbAdapter.UpdateCommand = cn.CreateCommand();
                oledbAdapter.UpdateCommand.CommandText = sql;
                oledbAdapter.UpdateCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Log.Write2Log("Failed to Edit Group with error: " + ex.Message);
                return false;
            }
            finally
            {
                cn.Close();

            }
            return true;

        }

        static public bool AddGroup(Group grp)
        {
            OleDbConnection cn = ConnectToDB();
            try
            {
                string strSQL = "INSERT INTO Groups ([GType],[GName],[GDesc]) VALUES (?,?,?)";

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                cmd.Parameters.AddWithValue("@GType", grp.GType);
                cmd.Parameters.AddWithValue("@GName", grp.GName);
                cmd.Parameters.AddWithValue("@GDesc", grp.GDesc);

                cmd.Connection = cn;
                int res = cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Log.Write2Log("Failed to Add Group with error: " + ex.Message);
                return false;

            }
            finally
            {
                cn.Close();

            }
        }

        public static bool CheckValidGroupName(string GroupName)
        {

            OleDbConnection cn = ConnectToDB();
            OleDbDataAdapter oledbAdapter = new OleDbDataAdapter();

            string strSQL = "SELECT count (*) from Groups where GName = " + GroupName;
            try
            {
                OleDbCommand myCommand = new OleDbCommand(strSQL, cn);

                OleDbDataReader myDataReader;
                myDataReader = myCommand.ExecuteReader();


                while (myDataReader.Read())
                {
                    var Res = myDataReader[0];

                    return true;
                }

                myDataReader.Close();

                return true;
            }
            catch (Exception ex)
            {
                Log.Write2Log("Failed to load Group types list: " + ex.Message);
                return false;
            }
            finally
            {
                cn.Close();
                // return Typelist;
            }

        }

        ///// </AddGroup>   ///////////

        private static DateTime GetDateWithoutMilliseconds(DateTime d)
        { 
            if (d == default(DateTime))
               return default(DateTime);
            else
            {
                return new DateTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, d.Second);
            }
        }

        // ---------------------    Events Report   ---------------------
        static public bool AddEvent(SignEvents myevent)
        {
            OleDbConnection cn = ConnectToDB();
            try
            {
                string strSQL = "INSERT INTO SignEvents ([EmployeeID],[Date],[Marked],[Document], [SignDate]) VALUES (?,?,?,?,?)";

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                cmd.Parameters.AddWithValue("@EmployeeID", myevent.EmployeeId);
                cmd.Parameters.AddWithValue("Date", GetDateWithoutMilliseconds(DateTime.Now));  
                cmd.Parameters.AddWithValue("@Marked", myevent.Marked);
                cmd.Parameters.AddWithValue("@Document", myevent.Document);
                cmd.Parameters.AddWithValue("@SignDate", default(DateTime));

                cmd.Connection = cn;
                int res = cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Log.Write2Log("Failed to Add Sign event to DB with error: " + ex.Message);
                return false;

            }
            finally
            {
                cn.Close();

            }
        }

        static public List<Events> GetSignedList()
        {
            List<Events> events = new List<Events>();
            OleDbConnection cn = ConnectToDB();
            try
            {
                // string strSQL = "SELECT * FROM SignEvents ORDER BY ID DESC";
                string strSQL = @"SELECT SignEvents.ID, SignEvents.EmployeeID, SignEvents.[Date] AS SentDate, SignEvents.Marked AS Signed, SignEvents.Document, SignEvents.SignDate, Emploees.FullName, Documents.SignedFullPath
                                FROM(SignEvents INNER JOIN Emploees ON SignEvents.EmployeeID = Emploees.EmployeeID
                                INNER JOIN Documents ON SignEvents.ID = Documents.SignID)";

                OleDbCommand myCommand = new OleDbCommand(strSQL, cn);

                OleDbDataReader myDataReader;
                myDataReader = myCommand.ExecuteReader();

                while (myDataReader.Read())
                {
                    Events se = new Events();
                    se.ID = (int)(myDataReader["ID"]);
                    se.EmployeeId = myDataReader["EmployeeID"].ToString();
                    se.Date = GetDateWithoutMilliseconds((DateTime)myDataReader["SentDate"]);
                    se.Marked =(bool) myDataReader["Signed"];
                    se.Document = myDataReader["Document"].ToString();
                    se.SignDate = GetDateWithoutMilliseconds(default(DateTime)); //CheckDate((DateTime)myDataReader["SignDate"])
                    se.FullName = myDataReader["FullName"].ToString();

                    events.Add(se);
                }

                myDataReader.Close();

                return events;
            }
            catch (System.Exception ex)
            {
                string err = "DBUtility- Add event error: " + ex.Message;
                throw;
            }
            finally
            {
                cn.Close();

            }
        }

        private static DateTime CheckDate(DateTime dateTime)
        {
            DateTime? dat = null;

            if (!dat.HasValue)
            {
                return (default(DateTime));
            }
            else
                return dateTime;
        }   

        static public string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        static public OleDbConnection ConnectToDB()
        {
            try
            {
                string DBPath = Path.Combine(AssemblyDirectory, "EmpSignDB.mdb");
                OleDbConnection cn = new OleDbConnection();
                cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "data source = " + DBPath + ";JET OLEDB:Database Password = sps";
                cn.Open();
                return cn;
            }
            catch (System.Exception ex)
            {
                throw;
            }
            finally
            {
                //cn.Close();

            }

        }

        public static int GetLastEventID()
        {
            int _lastID =1;
            OleDbConnection cn = ConnectToDB();
            try
            {
                string strSQL = "SELECT Top 1 ID FROM SignEvents ORDER BY ID DESC";

                OleDbCommand myCommand = new OleDbCommand(strSQL, cn);

                OleDbDataReader myDataReader;
                myDataReader = myCommand.ExecuteReader();
                
                while (myDataReader.Read())
                {
                    _lastID = int.Parse(myDataReader["ID"].ToString());
                }
                myDataReader.Close();
            }
            catch (System.Exception ex)
            {
                
                throw (ex);
            }
            finally
            {
                cn.Close();
            }
            return _lastID;

        }

    }       
}


