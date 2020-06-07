using EmployeeManagementSystem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Utilities;
//using EmployeeManagementSystem.Data;


namespace EmployeeManagementSystem
{
    
    public partial class HealthSignForm : Form
     {
        //private bool _dragging = false;
        //private Point _start_point = new Point(0, 0);
       
        private List<ShortEmps> list;

        public HealthSignForm(List<ShortEmps> list)
        {
            InitializeComponent();
            this.list = list;
            AddEmployeeToDataGridView();
            AddCheckboxCol();
            DataGridStyle.DataGridDesign(ApprovalDataGridView);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
         public void AddEmployeeToDataGridView()
         {
            try
            {
              
                foreach (ShortEmps employeeList in list)
                {
                    int row = ApprovalDataGridView.Rows.Count ;
                    ApprovalDataGridView.Rows.Add();
                    ApprovalDataGridView.Rows[row].Cells[0].Value = (employeeList.EmployeeNum);
                    ApprovalDataGridView.Rows[row].Cells[1].Value = (employeeList.Id);
                    ApprovalDataGridView.Rows[row].Cells[2].Value = (employeeList.FullName);
                    ApprovalDataGridView.Rows[row].Cells[3].Value = (employeeList.NeedsToSign);
                    ApprovalDataGridView.Rows[row].Cells[4].Value = (employeeList.Mobile);
                    ApprovalDataGridView.Rows[row].Cells[5].Value = (employeeList.Email);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddCheckboxCol()
        {
            
            //Assign Click event to the DataGridView Cell.
            ApprovalDataGridView.CellContentClick += new DataGridViewCellEventHandler(ApprovalDataGridView_CellClick);

        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check to ensure that the row CheckBox is clicked.
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                //Reference the GridView Row.
                DataGridViewRow row = ApprovalDataGridView.Rows[e.RowIndex];

                //Set the CheckBox selection.
                row.Cells["NeedsToSign"].Value = !Convert.ToBoolean(row.Cells["NeedsToSign"].EditedFormattedValue);

                //If CheckBox is checked, display Message Box.
                if (Convert.ToBoolean(row.Cells["NeedsToSign"].Value))
                {
                  
                }
            }
        }

        private void SortByMarkedAscending()
        {
            int row = ApprovalDataGridView.Rows.Count;
            try
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = i + 1; j < row; j++)
                    {
                        DataGridViewCheckBoxCell chkchecking = ApprovalDataGridView.Rows[i].Cells[3] as DataGridViewCheckBoxCell;
                        if ((bool)chkchecking.Value == true)
                        {
                            var tempEmployeeNum = ApprovalDataGridView.Rows[i].Cells[0].Value;
                            var tempId = ApprovalDataGridView.Rows[i].Cells[1].Value;
                            var tempName = ApprovalDataGridView.Rows[i].Cells[2].Value;
                            var tempChecked = ApprovalDataGridView.Rows[i].Cells[3].Value;
                            var tempMobile = ApprovalDataGridView.Rows[i].Cells[4].Value;
                            var tempEmail = ApprovalDataGridView.Rows[i].Cells[5].Value;

                            ApprovalDataGridView.Rows[i].Cells[0].Value = ApprovalDataGridView.Rows[j].Cells[0].Value;
                            ApprovalDataGridView.Rows[i].Cells[1].Value = ApprovalDataGridView.Rows[j].Cells[1].Value;
                            ApprovalDataGridView.Rows[i].Cells[2].Value = ApprovalDataGridView.Rows[j].Cells[2].Value;
                            ApprovalDataGridView.Rows[i].Cells[3].Value = ApprovalDataGridView.Rows[j].Cells[3].Value;
                            ApprovalDataGridView.Rows[i].Cells[4].Value = ApprovalDataGridView.Rows[j].Cells[4].Value;
                            ApprovalDataGridView.Rows[i].Cells[5].Value = ApprovalDataGridView.Rows[j].Cells[5].Value;


                            ApprovalDataGridView.Rows[j].Cells[0].Value = tempEmployeeNum;
                            ApprovalDataGridView.Rows[j].Cells[1].Value = tempId;
                            ApprovalDataGridView.Rows[j].Cells[2].Value = tempName;
                            ApprovalDataGridView.Rows[j].Cells[3].Value = tempChecked;
                            ApprovalDataGridView.Rows[j].Cells[4].Value = tempChecked;
                            ApprovalDataGridView.Rows[j].Cells[5].Value = tempEmail;


                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void SortByMarkedDescending()
        {
            int row = ApprovalDataGridView.Rows.Count - 1;
            try
            {
                if (row < 0) { row = 0; }
                for (int i = 0; i < row; i++)
                {
                    for (int j = i + 1; j < row; j++)
                    {

                        DataGridViewCheckBoxCell chkchecking = ApprovalDataGridView.Rows[i].Cells[3] as DataGridViewCheckBoxCell;
                        if (chkchecking.Value != DBNull.Value)
                            if ((bool)chkchecking.Value == true)
                            {
                                var tempEmployeeNum = ApprovalDataGridView.Rows[i].Cells[0].Value;
                                var tempId = ApprovalDataGridView.Rows[i].Cells[1].Value;
                                var tempName = ApprovalDataGridView.Rows[i].Cells[2].Value;
                                var tempChecked = true;
                                var tempMobile = ApprovalDataGridView.Rows[i].Cells[4].Value;
                                var tempEmail = ApprovalDataGridView.Rows[i].Cells[5].Value;

                                ApprovalDataGridView.Rows[i].Cells[0].Value = ApprovalDataGridView.Rows[j].Cells[0].Value;
                                ApprovalDataGridView.Rows[i].Cells[1].Value = ApprovalDataGridView.Rows[j].Cells[1].Value;
                                ApprovalDataGridView.Rows[i].Cells[2].Value = ApprovalDataGridView.Rows[j].Cells[2].Value;
                                ApprovalDataGridView.Rows[i].Cells[3].Value = ApprovalDataGridView.Rows[j].Cells[3].Value;
                                ApprovalDataGridView.Rows[i].Cells[4].Value = ApprovalDataGridView.Rows[j].Cells[4].Value;
                                ApprovalDataGridView.Rows[i].Cells[5].Value = ApprovalDataGridView.Rows[j].Cells[5].Value;

                                ApprovalDataGridView.Rows[j].Cells[0].Value = tempEmployeeNum;
                                ApprovalDataGridView.Rows[j].Cells[1].Value = tempId;
                                ApprovalDataGridView.Rows[j].Cells[2].Value = tempName;
                                ApprovalDataGridView.Rows[j].Cells[3].Value = tempChecked;
                                ApprovalDataGridView.Rows[j].Cells[4].Value = tempMobile;
                                ApprovalDataGridView.Rows[j].Cells[5].Value = tempEmail;
                            }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void SortByNameAscending()
        {
            int row = ApprovalDataGridView.Rows.Count; 
            try
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = i + 1; j < row; j++)
                    {
                        if (string.Compare(ApprovalDataGridView.Rows[i].Cells[2].Value.ToString(), ApprovalDataGridView.Rows[j].Cells[2].Value.ToString()) > 0)
                        {
                            var tempEmployeeNum = ApprovalDataGridView.Rows[i].Cells[0].Value;
                            var tempId = ApprovalDataGridView.Rows[i].Cells[1].Value;
                            var tempName = ApprovalDataGridView.Rows[i].Cells[2].Value;
                            var tempChecked = ApprovalDataGridView.Rows[i].Cells[3].Value;
                            var tempMobile = ApprovalDataGridView.Rows[i].Cells[4].Value;
                            var tempEmail = ApprovalDataGridView.Rows[i].Cells[5].Value;


                            ApprovalDataGridView.Rows[i].Cells[0].Value = ApprovalDataGridView.Rows[j].Cells[0].Value;
                            ApprovalDataGridView.Rows[i].Cells[1].Value = ApprovalDataGridView.Rows[j].Cells[1].Value;
                            ApprovalDataGridView.Rows[i].Cells[2].Value = ApprovalDataGridView.Rows[j].Cells[2].Value;
                            ApprovalDataGridView.Rows[i].Cells[3].Value = ApprovalDataGridView.Rows[j].Cells[3].Value;
                            ApprovalDataGridView.Rows[i].Cells[4].Value = ApprovalDataGridView.Rows[j].Cells[4].Value;
                            ApprovalDataGridView.Rows[i].Cells[5].Value = ApprovalDataGridView.Rows[j].Cells[5].Value;



                            ApprovalDataGridView.Rows[j].Cells[0].Value = tempEmployeeNum;
                            ApprovalDataGridView.Rows[j].Cells[1].Value = tempId;
                            ApprovalDataGridView.Rows[j].Cells[2].Value = tempName;
                            ApprovalDataGridView.Rows[j].Cells[3].Value = tempChecked;
                            ApprovalDataGridView.Rows[j].Cells[4].Value = tempMobile;
                            ApprovalDataGridView.Rows[j].Cells[5].Value = tempEmail;

                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportEmployeeListToCSV(List<ShortEmps> mylist)
        {
            var csv = new System.Text.StringBuilder();

            try
            {
                int LastID = DBUtility.GetLastEventID();
               
                foreach (ShortEmps employeeList in mylist)
                {
                    LastID = LastID +1;
                    var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6}", employeeList.EmployeeNum, employeeList.Id, employeeList.FullName,
                                                                           employeeList.Mobile, employeeList.Email,employeeList.DocSelected, LastID);
                    csv.AppendLine(newLine);
                }

                string FileName, OutPath;
                string CurDateTime = DateTime.Now.ToString(@"dd\_MM\_yyyy hh\_mm ");
                OutPath = GetWinsertCollectorDir();
                if (!string.IsNullOrEmpty(OutPath))
                {
                    FileName = OutPath + @"\EmployeeList_" + CurDateTime + ".csv";

                    using (StreamWriter sw = new StreamWriter(FileName, false, System.Text.Encoding.Unicode))  //(File.Exists(OutPath)) ? File.AppendText(OutPath) : File.CreateText(OutPath))
                    {
                        sw.Write(csv.ToString());
                        UpdateDBLog(mylist);
                        string language = ChangeLanguage.ReadConfigValue("language");
                        string message, caption;
                        if (language == "he-IL")
                        {
                            message = "נתונים יוצאו בהצלחה";
                            caption = "הפצת  מסמכים לחתימה";
                        }
                        else
                        {
                            message = "Data successfully exported";
                            caption = "Distribute documents for signature";
                        }
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            

        private string GetWinsertCollectorDir()
        {
            string settingsFilePath = @"C:\SPS\Winsert\Settings.ini";
            if (File.Exists(settingsFilePath))
            {
                iniFile inifile = new iniFile(settingsFilePath);
                string ProperyValue = inifile.ReadValue("ServicesCollector", "Folder");

                if (!string.IsNullOrEmpty(ProperyValue))
                {
                    return ProperyValue.Trim();
                }
                else
                    return null;
            }
            return null;
        }

        private void UpdateDBLog(List<ShortEmps> mylist)
        {
            // Update DB for Success Export
            foreach (ShortEmps employeeList in mylist)
            {
                var employeeid = employeeList.Id;
                DateTime localdate = DateTime.Now;
                //var defaultDateTimeValue = default(DateTime);
                var marked = false;
                var document = Path.GetFileName(employeeList.DocSelected);

                SignEvents myevent = new SignEvents(employeeid, localdate, marked, document);

                DBUtility.AddEvent(myevent);
            }
        }
    
        private void SortByNameDescending()
        {
            int row = ApprovalDataGridView.Rows.Count;// - 1;
            if (row < 0) { row = 0; }
            try
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = i + 1; j < row; j++)
                    {
                        if (string.Compare(ApprovalDataGridView.Rows[i].Cells[2].Value.ToString(), ApprovalDataGridView.Rows[j].Cells[2].Value.ToString()) < 0)
                        {

                            var tempEmployeeNum = ApprovalDataGridView.Rows[i].Cells[0].Value;
                            var tempId = ApprovalDataGridView.Rows[i].Cells[1].Value;
                            var tempName = ApprovalDataGridView.Rows[i].Cells[2].Value;
                            var tempChecked = ApprovalDataGridView.Rows[i].Cells[3].Value;
                            var tempMobile = ApprovalDataGridView.Rows[i].Cells[4].Value;
                            var tempEmail = ApprovalDataGridView.Rows[i].Cells[5].Value;


                            ApprovalDataGridView.Rows[i].Cells[0].Value = ApprovalDataGridView.Rows[j].Cells[0].Value;
                            ApprovalDataGridView.Rows[i].Cells[1].Value = ApprovalDataGridView.Rows[j].Cells[1].Value;
                            ApprovalDataGridView.Rows[i].Cells[2].Value = ApprovalDataGridView.Rows[j].Cells[2].Value;
                            ApprovalDataGridView.Rows[i].Cells[3].Value = ApprovalDataGridView.Rows[j].Cells[3].Value;
                            ApprovalDataGridView.Rows[i].Cells[4].Value = ApprovalDataGridView.Rows[j].Cells[4].Value;
                            ApprovalDataGridView.Rows[i].Cells[5].Value = ApprovalDataGridView.Rows[j].Cells[5].Value;



                            ApprovalDataGridView.Rows[j].Cells[0].Value = tempEmployeeNum;
                            ApprovalDataGridView.Rows[j].Cells[1].Value = tempId;
                            ApprovalDataGridView.Rows[j].Cells[2].Value = tempName;
                            ApprovalDataGridView.Rows[j].Cells[3].Value = tempChecked;
                            ApprovalDataGridView.Rows[j].Cells[4].Value = tempMobile;
                            ApprovalDataGridView.Rows[j].Cells[5].Value = tempEmail;

                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MarkAllCheckboxs()
        {
            bool NewValue;
            if ((bool)ApprovalDataGridView.Rows[0].Cells[3].Value == true)
                NewValue = false;
            else
                NewValue = true;

            foreach (DataGridViewRow row in ApprovalDataGridView.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[3];
                chk.Value = NewValue;
            }
            ApprovalDataGridView.EndEdit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void sortByMarkedEmpAsc_Click(object sender, EventArgs e)
        {
            SortByMarkedAscending();
        }

        private void sortByMarkedEmpDsc_Click(object sender, EventArgs e)
        {
            SortByMarkedDescending();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            //_dragging = true;
            //_start_point = new Point(e.X, e.Y);
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            //if (_dragging)
            //{
            //    Point p = PointToScreen(e.Location);
            //    Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            //}
        }
        private void OnMouseUp(object sender, MouseEventArgs e)
        {
           // _dragging = false;
        }

        private void btnNameAsc_Click(object sender, EventArgs e)
        {
            SortByNameAscending();
        }

        private void btnNameDsc_Click(object sender, EventArgs e)
        {
            SortByNameDescending();
        }

        private void header_Click(object sender, EventArgs e)
        {

        }

        
        private void exportData_Click(object sender, EventArgs e)
        {
            //if (DataGridView[5].Value != false)
            List<ShortEmps> selected = new List<ShortEmps>();
            try
            {
                for (var i = 0; i < ApprovalDataGridView.Rows.Count ; i++)
                {
                    bool needsToSign = (bool)ApprovalDataGridView.Rows[i].Cells[3].Value;
                    if ((bool)ApprovalDataGridView.Rows[i].Cells[3].Value == true)
                    {
                        string employeeNum = Convert.ToString(ApprovalDataGridView.Rows[i].Cells[0].Value);
                        string id = Convert.ToString(ApprovalDataGridView.Rows[i].Cells[1].Value);
                        string fullName = Convert.ToString(ApprovalDataGridView.Rows[i].Cells[2].Value);
                        string mobile = Convert.ToString(ApprovalDataGridView.Rows[i].Cells[4].Value);
                        string email = Convert.ToString(ApprovalDataGridView.Rows[i].Cells[5].Value);
                        string docSelected = EmployeeSysMainForm._DocSelectedAbsulutePath;
                        // ****To Add - Add Document to DB list***

                        var data = new ShortEmps();
                        data.EmployeeNum = employeeNum;
                        data.Id = id;
                        data.FullName = fullName;
                        data.Mobile = mobile;
                        data.NeedsToSign = true;
                        data.Email = email;
                        data.DocSelected =  docSelected;

                        selected.Add(data);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ExportEmployeeListToCSV(selected);
            this.Close();
        }

        private void ApprovalDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                //Add Color Background to row

            }
        }

        private void HealthSignForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MarkAllCheckboxs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SortByMarkedAscending();
        }

        private void logoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ApprovalDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNameAsc_Click_1(object sender, EventArgs e)
        {
            SortByNameAscending();
        }

        private void btnNameDsc_Click_1(object sender, EventArgs e)
        {
            SortByNameDescending();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SortByMarkedAscending();
        }

        private void btn_Markall_Click(object sender, EventArgs e)
        {
            MarkAllCheckboxs();
        }
    }
}
