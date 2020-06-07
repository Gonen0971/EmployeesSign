using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Windows.Forms;
using Utilities;

namespace EmployeeManagementSystem.Properties
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowGridSignedList()
        {
            List<Events> bindingList = new List<Events>();
            try
            {
                bindingList = DBUtility.GetSignedList();
                
                var source = new BindingSource(bindingList, null);
                //dataGridView.DataSource = source;

                if (bindingList.Count >= 1)
                {
                    int count = 0;
                    foreach (Events list in bindingList)
                    {
                        dataGridView.Rows.Add();
                        dataGridView.Rows[count].Cells[0].Value = list.ID;
                        dataGridView.Rows[count].Cells[1].Value = list.EmployeeId;
                        dataGridView.Rows[count].Cells[2].Value = list.FullName;
                        dataGridView.Rows[count].Cells[3].Value = list.Date;
                        dataGridView.Rows[count].Cells[4].Value = list.Marked;
                        dataGridView.Rows[count].Cells[5].Value = list.Document;
                        dataGridView.Rows[count].Cells[6].Value = list.SignDate;
                        count++;
                    }

                }





            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ShowSignedList Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static DateTime GetDateWithoutMilliseconds(DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, d.Second);
        }

        public void FillEmployeesToCombo()
        {
            try
            {

                List<Employee> employees = DBUtility.FillComboBoxEmpName();
                if (employees.Count >= 1)
                {
                    if (comboBox_EmpName.Items.Count == 0)
                        foreach (Employee emp in employees)
                        {
                        comboBox_EmpName.Items.Add(emp.FullName);
                        }
                }
            }catch(Exception ex)
            {
                Log.Write2Log(ex.Message);
            }

        }

        public void FillDocumentsToCombo()
        {
            try
            {

                List<Document> documents = DBUtility.FillComboBoxDocName();
                if (documents.Count >= 1)
                {
                    if (comboBoxDocName.Items.Count == 0)
                        foreach (Document doc in documents)
                        {
                            comboBoxDocName.Items.Add(doc.DocName);
                        }
                }
            }
            catch (Exception ex)
            {
                Log.Write2Log(ex.Message);
            }


        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string DateSelected = null;
            string EmployeeSelected = null;
            string DocumentName = null;
            string data1,data2,data3 = null;
            

            if (checkBoxDate.Checked)
                DateSelected = dateTimePicker1.Value.ToString();
            if (checkBoxEName.Checked)
                EmployeeSelected = comboBox_EmpName.GetItemText(this.comboBox_EmpName.SelectedItem);
            if (checkBoxDocName.Checked)
                DocumentName = comboBoxDocName.GetItemText(this.comboBoxDocName.SelectedItem);

            // Check if field is null 
            if (!string.IsNullOrWhiteSpace(EmployeeSelected))
            {
                data1 = EmployeeSelected + "%";
            }

            if (!string.IsNullOrWhiteSpace(DateSelected))
            {
                data2 = DateSelected + "%";
            }
            
            if (!string.IsNullOrWhiteSpace(DocumentName))
            {
                data3 = DocumentName + "%";
            }

            //string Query = @"SELECT S.EmployeeID, E.FullName, S.Date, S.Document FROM SignEvents AS S
            //     INNER JOIN Employees AS E ON S.EmployeeID = E.EmployeeID 
            //     WHERE S.Date = '" + data1 + "' LIKE IFNULL(@data1, data1) AND E.FullName = '" + data2 LIKE IFNULL(@data2, data2) AND + "'";


            //OleDbCommand cmd = new OleDbCommand(SqlString, cn);
            //OleDbParameter parData1 = new OleDbParameter("@data1", (object)data1 ?? DBNull.Value);
            //cmd.Parameters.Add(parData1);
            //OleDbParameter parData2 = new OleDbParameter("@data2", (object)data2 ?? DBNull.Value);
            //cmd.Parameters.Add(parData2);
            //OleDbParameter parData3 = new OleDbParameter("@data3", (object)data3 ?? DBNull.Value);
            //cmd.Parameters.Add(parData3);







            RunQuery("", EmployeeSelected, DocumentName);
        }

        private void RunQuery(string mydate, string employee, string doc )
        {
            // Filtering Query 
            
        }


        private void Report_Load(object sender, EventArgs e)
        {
            checkBoxDate.Checked = false;
            checkBoxDocName.Checked = false;
            checkBoxEName.Checked = false;
            dateTimePicker1.Enabled = false;
            comboBox_EmpName.Enabled = false;
            comboBoxDocName.Enabled = false;
            dateTimePicker1.Value = GetDateWithoutMilliseconds(DateTime.Now);
            FillEmployeesToCombo();
            FillDocumentsToCombo();
            ShowGridSignedList();
            DataGridStyle.DataGridDesign(dataGridView);
        }

        private void fillByEmployeeNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.emploeesTableAdapter.FillByEmployeeName(this.empSignDBDataSet.Emploees);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox_EmpName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillEmployeesToCombo();
            if (checkBoxEName.Checked)
            {
                BindingSource BS = new BindingSource();
                BS.DataSource = dataGridView.DataSource;
                BS.Filter = "ID like %" + comboBox_EmpName.Text + "%";
                dataGridView.DataSource = BS;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (checkBoxDate.Checked)
            {
                BindingSource BS = new BindingSource();
                BS.DataSource = dataGridView.DataSource;
                BS.Filter = "Date like %" + dateTimePicker1.Value + "%";
                dataGridView.DataSource = BS;
            }


        }

        private void comboBoxDocName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBoxDocName.Checked)
            {
                BindingSource BS = new BindingSource();
                BS.DataSource = dataGridView.DataSource;
                BS.Filter = "Document like %" + comboBoxDocName.Text + "%";
                dataGridView.DataSource = BS;
            }

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDate.Checked)
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
            }
        }

        private void checkBoxEName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEName.Checked)
            {
                comboBox_EmpName.Enabled = true;
            }
            else
            {
                comboBox_EmpName.Enabled = false;
            }
        }

        private void checkBoxDocName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDocName.Checked)
            {
                comboBoxDocName.Enabled = true;
            }
            else
            {
                comboBoxDocName.Enabled = false;
            }
        }
    }



}
