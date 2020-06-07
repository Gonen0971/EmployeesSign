using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Documents;
using System.Windows.Forms;
using Utilities;


namespace EmployeeManagementSystem
{
    public partial class AddGroup : Form
    {
        private bool bEdit = false;
        private int _row;
        public delegate void IdentityHandler(object sender, GroupIdentityEventArgs e);
        //Event of the delegate type has been added. i.e. Object of delegate created
        public event IdentityHandler GroupIdentityUpdated;

        public AddGroup()
        {
            InitializeComponent();
        }

        public void LoadData(string gtype, string gname, string gdesc )
        {
            bEdit = true;
            comboBoxGroupType.Text = gtype;
            textBox_GroupName.Text = gname;
            textBox_Description.Text = gdesc;
        }

        private void LblIdNo_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var gtype = comboBoxGroupType.Text;
            var gname = textBox_GroupName.Text;
            var gdesc = textBox_Description.Text;

            Group grp = new Group(gtype, gname, gdesc);
            grp.GType = gtype;
            grp.GName = gname;
            grp.GDesc = gdesc;

            if (bEdit)
            {
                var myItem = DBUtility.GetGroups().Find(item => item.GName == gname);
                if (myItem == null && gname !="")
                {
                    DBUtility.AddGroup(grp);
                    GetGroups();
                }
                else
                {
                    string message, caption;
                    string language = ChangeLanguage.ReadConfigValue("language");
                    if (language == "he-IL")
                    {
                        message = "שם הקבוצה קיים במערכת";
                        caption = "שגיאה";
                    }
                    else
                    {
                        message = "Department name allready exsits in the system";
                        caption = "Error";
                    }
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    return;
                }
            }
            else
            DBUtility.EditGroup(grp);
            textBox_GroupName.Text = "";
            textBox_Description.Text = "";
            comboBoxGroupType.Text = "";
            //instance event args and value has been passed 
            var args = new GroupIdentityEventArgs(gtype, gname, gdesc);

            //Event has be raised with update arguments of delegate
            GroupIdentityUpdated?.Invoke(this, args);

            this.Hide();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddGroup_Load(object sender, EventArgs e)
        {
            bEdit = true;
            comboBoxGroupType.Text = "מחלקה";
            btn_Save.Visible = true;
            btnAdd.Enabled = true;
            GetGroups();
            DataGridStyle.DataGridDesign(dataGridView);
           
        }

        public void GetGroups()
        {
            try
            {

                List<Group> bindingList = DBUtility.GetGroups();
                if (bindingList.Count >= 1)
                {
                    // var source = new BindingSource(bindingList,null);
                    dataGridView.DataSource = bindingList;
                }
            }
            catch (System.Exception ex)
            {
                Log.Write2Log(ex.Message);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dataGridView.SelectedRows.Count > 0)
                try
                {
                    var row = dataGridView.CurrentCell.RowIndex;
                    var gtype = Convert.ToString(dataGridView.Rows[row].Cells[0].Value);
                    var gname = Convert.ToString(dataGridView.Rows[row].Cells[1].Value);
                    var gdesc = Convert.ToString(dataGridView.Rows[row].Cells[2].Value);

                    _row = row;

                    var addGrp = new AddGroup();

                    addGrp.LoadData(gtype, gname, gdesc);
                    addGrp.GroupIdentityUpdated += this.UpdateRecord;
                    addGrp.btnEdit.Visible = false;
                    addGrp.btnAdd.Visible = false;
                    addGrp.dataGridView.Hide();
                    addGrp.Size = new Size(addGrp.Size.Width, 270);
                    addGrp.btn_Save.Visible = true;



                    addGrp.ShowDialog();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.Write2Log(exception.Message.ToString());
                }
            else
            {
                string message, caption;
                string language = ChangeLanguage.ReadConfigValue("language");
                if (language == "he-IL")
                {
                    message = "אנא בחר/י רשומה מהטבלה לעריכה";
                    caption = "קבוצה";
                }
                else
                {
                    message = "Please select a record for editing";
                    caption = "Department";
                }
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var gtype = comboBoxGroupType.Text;
            var gname = textBox_GroupName.Text;
            var gdesc = textBox_Description.Text;     
            
            Group grp = new Group(gtype, gname, gdesc);
            if (!bEdit)
            {
                DBUtility.AddGroup(grp);
                //var myItem = DBUtility.GetGroups().Find(item => item.GName == gname);
                //if (myItem == null)
                //{
                //    DBUtility.AddGroup(grp);
                //}
                //else
                //{
                //    MessageBox.Show("מחלקה בשם זה קיימת במערכת");
                //    return;
                //}
            }
            else
                DBUtility.EditGroup(grp);

            //instance event args and value has been passed 
            var grpargs = new GroupIdentityEventArgs(gtype, gname, gdesc);

            //Event has be raised with update arguments of delegate
            GroupIdentityUpdated?.Invoke(this, grpargs);

            this.Hide();
            this.Close();
        }

        private void UpdateRecord(object sender, GroupIdentityEventArgs e)
        {
            dataGridView.Rows[_row].Cells[0].Value = e.GType;
            dataGridView.Rows[_row].Cells[1].Value = e.GName;
            dataGridView.Rows[_row].Cells[2].Value = e.GDesc;
        }
    }
}


