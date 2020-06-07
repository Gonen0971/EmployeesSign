namespace EmployeeManagementSystem
{
    partial class AddEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empSignDB1DataSet = new EmployeeManagementSystem.EmpSignDB1DataSet();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtIdNo = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblIdNo = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.txtEmpNum = new System.Windows.Forms.TextBox();
            this.lbl_EmployeeNum = new System.Windows.Forms.Label();
            this.groupsTableAdapter = new EmployeeManagementSystem.EmpSignDB1DataSetTableAdapters.GroupsTableAdapter();
            this.groupsEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new EmployeeManagementSystem.EmpSignDB1DataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empSignDB1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsEmployeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDepartment
            // 
            resources.ApplyResources(this.comboBoxDepartment, "comboBoxDepartment");
            this.comboBoxDepartment.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxDepartment.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.groupsBindingSource, "GName", true));
            this.comboBoxDepartment.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.groupsBindingSource, "GName", true));
            this.comboBoxDepartment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupsBindingSource, "GName", true));
            this.comboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.empSignDB1DataSet;
            // 
            // empSignDB1DataSet
            // 
            this.empSignDB1DataSet.DataSetName = "EmpSignDB1DataSet";
            this.empSignDB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMobile
            // 
            resources.ApplyResources(this.txtMobile, "txtMobile");
            this.txtMobile.BackColor = System.Drawing.Color.LightGray;
            this.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.txtMobile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.txtMobile.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.BackColor = System.Drawing.Color.LightGray;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.txtEmail.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.txtEmail.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // txtFullName
            // 
            resources.ApplyResources(this.txtFullName, "txtFullName");
            this.txtFullName.BackColor = System.Drawing.Color.LightGray;
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.TextChanged += new System.EventHandler(this.TxtFullName_TextChanged);
            this.txtFullName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.txtFullName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.txtFullName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // txtIdNo
            // 
            resources.ApplyResources(this.txtIdNo, "txtIdNo");
            this.txtIdNo.BackColor = System.Drawing.Color.LightGray;
            this.txtIdNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdNo.Name = "txtIdNo";
            this.txtIdNo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.txtIdNo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.txtIdNo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.lblEmail.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.lblEmail.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // lblFullName
            // 
            resources.ApplyResources(this.lblFullName, "lblFullName");
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.lblFullName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.lblFullName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // lblDepartment
            // 
            resources.ApplyResources(this.lblDepartment, "lblDepartment");
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.lblDepartment.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.lblDepartment.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // lblMobile
            // 
            resources.ApplyResources(this.lblMobile, "lblMobile");
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.lblMobile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.lblMobile.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // lblIdNo
            // 
            resources.ApplyResources(this.lblIdNo, "lblIdNo");
            this.lblIdNo.Name = "lblIdNo";
            this.lblIdNo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.lblIdNo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.lblIdNo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(157)))), ((int)(((byte)(68)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            this.btnSave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnSave.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.btnSave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(48)))), ((int)(((byte)(44)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            this.btnCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnCancel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.btnCancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // lblClose
            // 
            resources.ApplyResources(this.lblClose, "lblClose");
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Name = "lblClose";
            this.lblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // txtEmpNum
            // 
            resources.ApplyResources(this.txtEmpNum, "txtEmpNum");
            this.txtEmpNum.BackColor = System.Drawing.Color.LightGray;
            this.txtEmpNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpNum.Name = "txtEmpNum";
            // 
            // lbl_EmployeeNum
            // 
            resources.ApplyResources(this.lbl_EmployeeNum, "lbl_EmployeeNum");
            this.lbl_EmployeeNum.Name = "lbl_EmployeeNum";
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // groupsEmployeesBindingSource
            // 
            this.groupsEmployeesBindingSource.DataMember = "Groups_Employees";
            this.groupsEmployeesBindingSource.DataSource = this.groupsBindingSource;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // AddEmployee
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEmpNum);
            this.Controls.Add(this.lbl_EmployeeNum);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtIdNo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblIdNo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empSignDB1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsEmployeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtIdNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblIdNo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.TextBox txtEmpNum;
        private System.Windows.Forms.Label lbl_EmployeeNum;
        private EmpSignDB1DataSet empSignDB1DataSet;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private EmpSignDB1DataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.BindingSource groupsEmployeesBindingSource;
        private EmpSignDB1DataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
    }
}