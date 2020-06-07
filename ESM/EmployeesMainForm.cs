using EmployeeManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace EmployeeManagementSystem
{

    public partial class EmployeeSysMainForm : Form
    {
        private int _row;
        //readonly SqlDataAdapter pagingAdapter;
        //readonly DataSet pagingDS;
        

        public static string language = ConfigurationManager.AppSettings["language"];             
        public static string _DocSelectedAbsulutePath;

        public EmployeeSysMainForm()
        {
            
            InitializeComponent();
            
            try
            {
                PrepareApprovals.Enabled = false;
                btnGenerateReport.Enabled = true;
                DBUtility.CreateTables();
                GetEmployees();
                DataGridStyle.DataGridDesign(dataGridView);
            }
            catch (System.Exception ex)
            {
                Log.Write2Log(ex.Message);
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
           
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
           
        }


        private void addEmployee_Click(object sender, EventArgs e)
        {
            ButtonMarker.Top = addEmployee.Top +60;
            var addEmp = new AddEmployee();
            addEmp.IdentityUpdated += this.SaveRecord;
            addEmp.ShowDialog();
        }

        private void SaveRecord(object sender, IdentityEventArgs e)
        {
            try
            {
                var count = dataGridView.Rows.Count;
                dataGridView.Rows.Add();
                dataGridView.Rows[count].Cells[0].Value = e.EmployeeNum;
                dataGridView.Rows[count].Cells[1].Value = e.Id;
                dataGridView.Rows[count].Cells[2].Value = e.FullName;
                dataGridView.Rows[count].Cells[3].Value = e.Mobile;
                dataGridView.Rows[count].Cells[4].Value = e.Email;
                dataGridView.Rows[count].Cells[5].Value = e.Department;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void importEmployees_Click(object sender, EventArgs e)
        {
            ImportEmployeeFromCsv();
        }

        private void exportData_Click(object sender, EventArgs e)
        {
            ExportDataToCSV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message, caption;
            if (language == "he-IL")
            {
                message = "?האם אתה בטוח שברצונך למחוק את הרשומה";
                caption = "מחיקת עובד";
            }
            else
            {
                message = "Are you sure you want to delete this record?";
                caption = "Delete employee";
            }
                if (MessageBox.Show(message,caption , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DBUtility.RemoveEmployee(Convert.ToString(dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[0].Value));
                    dataGridView.Rows.RemoveAt(dataGridView.CurrentCell.RowIndex);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dataGridView.CurrentCell.RowIndex;
                var employeeNum = Convert.ToString(dataGridView.Rows[row].Cells[0].Value); 
                var id = Convert.ToString(dataGridView.Rows[row].Cells[1].Value);
                var name = Convert.ToString(dataGridView.Rows[row].Cells[2].Value);
                var mobile = Convert.ToString(dataGridView.Rows[row].Cells[3].Value);
                var email = Convert.ToString(dataGridView.Rows[row].Cells[4].Value);
                var department = Convert.ToString(dataGridView.Rows[row].Cells[5].Value);
                _row = row;

                var addEmp = new AddEmployee();
                
                addEmp.LoadData(employeeNum, id, name, mobile, email, department);
                addEmp.IdentityUpdated += this.UpdateRecord;
                addEmp.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateRecord(object sender, IdentityEventArgs e)
        {
            dataGridView.Rows[_row].Cells[0].Value = e.EmployeeNum;
            dataGridView.Rows[_row].Cells[1].Value = e.Id;
            dataGridView.Rows[_row].Cells[2].Value = e.FullName;
            dataGridView.Rows[_row].Cells[3].Value = e.Mobile;
            dataGridView.Rows[_row].Cells[4].Value = e.Email;
            dataGridView.Rows[_row].Cells[5].Value = e.Department;
           
        }

       

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            ButtonMarker.Top = btnGenerateReport.Top +60;
            Form report = new Report();
            report.ShowDialog();
        }
        

        public void ImportEmployeeFromCsv()
        {
            using (var openFileDialog1 = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false })
            {
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

                const char sepChar = ',';
                const char quoteChar = '"';
                var employeeList = new List<string[]>();
                try
                {
                    using (Stream stream = null)
                    {
                        var rows = File.ReadAllLines(openFileDialog1.FileName);
                        foreach (var csvRow in rows)
                        {
                            var inQuotes = false;
                            var fields = new List<string>();
                            var field = "";
                            for (var i = 0; i < csvRow.Length; i++)
                            {
                                if (inQuotes)
                                {
                                    if (i < csvRow.Length - 1 && csvRow[i] == quoteChar && csvRow[i + 1] == quoteChar)
                                    {
                                        i = i++;
                                        field += quoteChar;
                                    }
                                    else if (csvRow[i] == quoteChar)
                                    {
                                        inQuotes = false;
                                    }
                                    else
                                    {
                                        if (csvRow[i - 1] == quoteChar)
                                        {
                                            field = "";
                                            field += csvRow[i];
                                        }
                                        else
                                        {
                                            field += csvRow[i];
                                        }
                                    }
                                }
                                else
                                {
                                    if (csvRow[i] == quoteChar)
                                    {
                                        inQuotes = true;
                                    }
                                    if (csvRow[i] == sepChar)
                                    {
                                        fields.Add(field);
                                        field = "";
                                    }
                                    else
                                    {
                                        field += csvRow[i];
                                    }
                                }
                            }
                            if (!string.IsNullOrEmpty(field))
                            {
                                fields.Add(field);
                                field = "";
                            }
                            employeeList.Add(fields.ToArray());
                        }
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                foreach (var value in employeeList)
                {
                    {
                        dataGridView.Rows.Add(value[0], value[1], value[2], value[3], value[4], value[5]);
                        
                        try
                        {
                            Employee emp = new Employee(value[0], value[1], value[2], value[3], value[4], value[5]);
                            DBUtility.AddEmployee(emp);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }

        }

        public void ExportDataToCSV()
        {
            var csv = new System.Text.StringBuilder();

            for (var i = 0; i < dataGridView.Rows.Count; i++)
            {
                string employeeNum = Convert.ToString(dataGridView.Rows[i].Cells[0].Value);
                string id = Convert.ToString(dataGridView.Rows[i].Cells[1].Value.ToString());
                string fullName = Convert.ToString(dataGridView.Rows[i].Cells[2].Value);
                string mobile = Convert.ToString(dataGridView.Rows[i].Cells[3].Value);
                string email = Convert.ToString(dataGridView.Rows[i].Cells[4].Value);
                string department = Convert.ToString(dataGridView.Rows[i].Cells[5].Value);
                
                var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6}", employeeNum, id, fullName, mobile, email, department, _DocSelectedAbsulutePath);

                csv.AppendLine(newLine);

                // Create List of Event to save to DB
                var myDate = GetDateWithoutMilliseconds(DateTime.Now);
                var defaultDateTimeValue = default(DateTime);
                List<SignEvents> Event = new List<SignEvents>();

                SignEvents data = new SignEvents(int.Parse(id), employeeNum, myDate, true, _DocSelectedAbsulutePath, defaultDateTimeValue);
                DBUtility.AddEvent(data);
                // id, string employeeid, DateTime date, bool marked, string document, DateTime signdate
            }

            string CurDateTime = DateTime.Now.ToString(@"MM\_dd\_yyyy hh\:mm T");
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Employee Data";
            saveFileDialog.Filter = "CSV file(*.csv)|*.csv";
            saveFileDialog.Filter = "HealthList_" + CurDateTime;

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, csv.ToString(), Encoding.Unicode);
                
            }

        }

        public void GetEmployees()
        {
            try
            {

                    List<Employee> employees = DBUtility.GetEmployees();
                    if (employees.Count >= 1)
                    {
                        int count = 0;
                        foreach (Employee emp in employees)
                        {
                            //count = dataGridView.Rows.Count - 1; if (count < 0) { count = 0; }
                            dataGridView.Rows.Add();
                            dataGridView.Rows[count].Cells[0].Value = emp.EmployeeNum;
                            dataGridView.Rows[count].Cells[1].Value = emp.EmployeeID;
                            dataGridView.Rows[count].Cells[2].Value = emp.FullName;
                            dataGridView.Rows[count].Cells[3].Value = emp.Mobile;
                            dataGridView.Rows[count].Cells[4].Value = emp.Email;
                            dataGridView.Rows[count].Cells[5].Value = emp.Department;
                            count++;
                        }

                    }
            }
            catch (System.Exception ex)
            {
                Log.Write2Log(ex.Message);
            }
        }

        public void GenerateSignList()
        {
            List<ShortEmps> empSignList = new List<ShortEmps>();
            try
            {

                for (var i = 0; i < dataGridView.Rows.Count ; i++)
                {
                    string employeeNum = Convert.ToString(dataGridView.Rows[i].Cells[0].Value);
                    string id = Convert.ToString(dataGridView.Rows[i].Cells[1].Value.ToString());
                    string fullName = Convert.ToString(dataGridView.Rows[i].Cells[2].Value);
                    string mobile = Convert.ToString(dataGridView.Rows[i].Cells[3].Value);
                    string email = Convert.ToString(dataGridView.Rows[i].Cells[4].Value);


                    ShortEmps data = new ShortEmps();
                    data.EmployeeNum = employeeNum;
                    data.Id = id;
                    data.FullName = fullName;
                    data.Mobile = mobile;
                    data.NeedsToSign = false;
                    data.Email = email;
                    data.DocSelected = _DocSelectedAbsulutePath;

                    empSignList.Add(data);
                }

                HealthSignForm Health = new HealthSignForm(empSignList);
                
                Health.ShowDialog();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static DateTime GetDateWithoutMilliseconds(DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, d.Second);
        }

        private void header_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PrepareApprovals_Click(object sender, EventArgs e)
        {
           ButtonMarker.Top = PrepareApprovals.Top + 60;
            //Open new HealthSignForm FORM dialog 
            GenerateSignList();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message, caption;
            if (language == "he-IL")
            {
                message = "האם אתה בטוח שברצונך לצאת מהאפליקיה";
                caption = "אישור סגירה";
            }
            else
            {
                message = "Are you sure you want to exit the application?";
            }
            caption = "Confirm close";
            var result = MessageBox.Show(message, caption,
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void EmployeeSysMainForm_Load(object sender, EventArgs e)
        {
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            ButtonMarker.Top = btn_about.Top + 60;
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void עבריתToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ChangeLanguage = new ChangeLanguage();
            ChangeLanguage.UpdateConfig("language", "he-IL");
                        
            Application.Restart();
           
        }

        
        private void אנגליתToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ChangeLanguage = new ChangeLanguage();
            ChangeLanguage.UpdateConfig("language", "en-US");
                     
            Application.Restart();
           
        }

        
        private void GroupSaveRecord(object sender, GroupIdentityEventArgs e)
        {
            try
            {
                var count = dataGridView.Rows.Count;
                dataGridView.Rows.Add();
                dataGridView.Rows[count].Cells[0].Value = e.GType;
                dataGridView.Rows[count].Cells[1].Value = e.GName;
                dataGridView.Rows[count].Cells[2].Value = e.GDesc;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AddGroup_Click_1(object sender, EventArgs e)
        {
            ButtonMarker.Top = btn_AddGroup.Top + 60;
            var addgrp = new AddGroup();
            addgrp.GroupIdentityUpdated += this.GroupSaveRecord;
            addgrp.ShowDialog();
        }

        private void btn_SelectForm_Click(object sender, EventArgs e)
        {
            ButtonMarker.Top = btn_SelectForm.Top + 60;
            var DocSelect = new DocFormSelection();
             DocSelect.ShowDialog();
            _DocSelectedAbsulutePath = DocSelect.DocSelectedAbsulutePath;
           if (_DocSelectedAbsulutePath.EndsWith(".pdf"))
            {
                //Open new HealthSignForm FORM dialog 
                PrepareApprovals.Enabled = true;
                GenerateSignList();
            }
            

        }

        private void sideBarPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
