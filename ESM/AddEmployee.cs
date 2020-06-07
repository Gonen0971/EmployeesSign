
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Utilities;

namespace EmployeeManagementSystem
{

    public partial class AddEmployee : Form
    {
        
        private bool bEdit = false;
        //Delegate has been added
        public delegate void IdentityHandler(object sender, IdentityEventArgs e);

        
        //Event of the delegate type has been added. i.e. Object of delegate created
        public event IdentityHandler IdentityUpdated;

        public AddEmployee()
        {
            InitializeComponent();
            
        }

        //This method will set the values on controls received from the selected row.
        public void LoadData(string employeeNum, string id, string name, string mobile, string email, string department)
        {
            bEdit = true;
            txtEmpNum.Text = employeeNum;
            txtEmpNum.Enabled = false;
            txtIdNo.Text = id;
            txtFullName.Text = name;
            txtMobile.Text = mobile;
            txtEmail.Text = email;
            comboBoxDepartment.Text = department;
            
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            //_dragging = true;
            //_startPoint = new Point(e.X, e.Y);
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            //if (!_dragging) return;
            //var p = PointToScreen(e.Location);
            //Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            //_dragging = false;
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var employeeNum = txtEmpNum.Text;
            var id = txtIdNo.Text;
            var name = txtFullName.Text;
            var mobile = txtMobile.Text;
            var email = txtEmail.Text;
            var department = comboBoxDepartment.Text;
            
            Employee emp = new Employee(employeeNum, id, name, mobile, email, department);
            if (!bEdit)
            {
                var myItem = DBUtility.GetEmployees().Find(item => item.EmployeeNum == employeeNum);
                if (myItem == null)
                {
                    DBUtility.AddEmployee(emp);
                }
                else
                {
                    string message, caption;
                    string language = ChangeLanguage.ReadConfigValue("language");
                    if (language == "he-IL")
                    {
                        message = "עובד עם מספר זהה קיים במערכת";
                        caption = "שגיאה";
                    }
                    else
                    {
                        message = "Employee with this ID allready exsits in data base";
                        caption = "Error";
                    }
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    return;
                }
            }
            else
                DBUtility.EditEmployee(emp);
            
            //instance event args and value has been passed 
            var args = new IdentityEventArgs(employeeNum, id, name, mobile, email, department);

            //Event has be raised with update arguments of delegate
            IdentityUpdated?.Invoke(this, args);

            this.Hide();
        }

      
        private bool Validation(TextBox t)
        {
            int n;
            bool error = false;

            if (int.TryParse(t.Text, out n))
            {
                error = true;
                string message,caption;
                string language = ChangeLanguage.ReadConfigValue("language");
                if (language == "he-IL")
                {
                    message = "תו לא חוקי";
                    caption = "שגיאה";
                }
                else
                {
                    message = "Invalid character";
                    caption = "Error";
                }
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                
            return error;

        }
        private void TxtFullName_TextChanged(object sender, EventArgs e)
        {
            Validation(txtFullName);
        }

        private void LblContact_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            GetGroupsName();
            //comboBoxDepartment.Items.Clear();
            //con.open();
            //cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT NAME FROM GROUPS ORDER BY NAME ASC";
            //cmd.ExecuteQuery();

        }
        private void GetGroupsName()
        {
            try
            {
                List<Group> groups = DBUtility.GetGroups();
                string[] GNames = new string[groups.Count];
                if (groups.Count >= 1)
                    if (comboBoxDepartment.SelectedIndex == -1)
                    for (int i = 0; i < groups.Count; i++)
                    {
                        GNames[i] = groups[i].GName;
                    }
                comboBoxDepartment.DataSource = GNames;

            }
            catch (System.Exception ex)
            {
                Log.Write2Log(ex.Message);
            }
        }
        
    }
}
