namespace EmployeeManagementSystem
{
    partial class AddGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGroup));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_EmployeeNum = new System.Windows.Forms.Label();
            this.comboBoxGroupType = new System.Windows.Forms.ComboBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empSignDB1DataSet = new EmployeeManagementSystem.EmpSignDB1DataSet();
            this.groupsEmployeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupsEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_GroupName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblIdNo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupsEmployeesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupsTableAdapter = new EmployeeManagementSystem.EmpSignDB1DataSetTableAdapters.GroupsTableAdapter();
            this.employeesTableAdapter = new EmployeeManagementSystem.EmpSignDB1DataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empSignDB1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsEmployeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsEmployeesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_EmployeeNum
            // 
            resources.ApplyResources(this.lbl_EmployeeNum, "lbl_EmployeeNum");
            this.lbl_EmployeeNum.Name = "lbl_EmployeeNum";
            // 
            // comboBoxGroupType
            // 
            resources.ApplyResources(this.comboBoxGroupType, "comboBoxGroupType");
            this.comboBoxGroupType.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxGroupType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.groupsBindingSource, "GType", true));
            this.comboBoxGroupType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroupType.FormattingEnabled = true;
            this.comboBoxGroupType.Items.AddRange(new object[] {
            resources.GetString("comboBoxGroupType.Items"),
            resources.GetString("comboBoxGroupType.Items1"),
            resources.GetString("comboBoxGroupType.Items2"),
            resources.GetString("comboBoxGroupType.Items3"),
            resources.GetString("comboBoxGroupType.Items4")});
            this.comboBoxGroupType.Name = "comboBoxGroupType";
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
            // groupsEmployeesBindingSource1
            // 
            this.groupsEmployeesBindingSource1.DataMember = "Groups_Employees";
            this.groupsEmployeesBindingSource1.DataSource = this.groupsBindingSource;
            // 
            // groupsEmployeesBindingSource
            // 
            this.groupsEmployeesBindingSource.DataMember = "Groups_Employees";
            this.groupsEmployeesBindingSource.DataSource = this.groupsBindingSource;
            // 
            // textBox_GroupName
            // 
            resources.ApplyResources(this.textBox_GroupName, "textBox_GroupName");
            this.textBox_GroupName.BackColor = System.Drawing.Color.LightGray;
            this.textBox_GroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_GroupName.Name = "textBox_GroupName";
            this.textBox_GroupName.ShortcutsEnabled = false;
            // 
            // lblFullName
            // 
            resources.ApplyResources(this.lblFullName, "lblFullName");
            this.lblFullName.Name = "lblFullName";
            // 
            // lblIdNo
            // 
            resources.ApplyResources(this.lblIdNo, "lblIdNo");
            this.lblIdNo.Name = "lblIdNo";
            this.lblIdNo.Click += new System.EventHandler(this.LblIdNo_Click);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(157)))), ((int)(((byte)(68)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnSave_Click);
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
            // 
            // dataGridView
            // 
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EmployeeNum,
            this.FullName});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView.RowTemplate.Height = 28;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "GType";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Id.DefaultCellStyle = dataGridViewCellStyle3;
            this.Id.FillWeight = 30F;
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            // 
            // EmployeeNum
            // 
            this.EmployeeNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeNum.DataPropertyName = "GName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EmployeeNum.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.EmployeeNum, "EmployeeNum");
            this.EmployeeNum.Name = "EmployeeNum";
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.DataPropertyName = "GDesc";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FullName.DefaultCellStyle = dataGridViewCellStyle5;
            this.FullName.FillWeight = 83.94669F;
            resources.ApplyResources(this.FullName, "FullName");
            this.FullName.Name = "FullName";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Description);
            this.groupBox1.Controls.Add(this.lbl_EmployeeNum);
            this.groupBox1.Controls.Add(this.textBox_GroupName);
            this.groupBox1.Controls.Add(this.lblIdNo);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.comboBoxGroupType);
            this.groupBox1.Controls.Add(this.lblFullName);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox_Description
            // 
            resources.ApplyResources(this.textBox_Description, "textBox_Description");
            this.textBox_Description.BackColor = System.Drawing.Color.LightGray;
            this.textBox_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.ShortcutsEnabled = false;
            // 
            // btn_Save
            // 
            resources.ApplyResources(this.btn_Save, "btn_Save");
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(157)))), ((int)(((byte)(68)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupsEmployeesBindingSource2
            // 
            this.groupsEmployeesBindingSource2.DataMember = "Groups_Employees";
            this.groupsEmployeesBindingSource2.DataSource = this.groupsBindingSource;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // AddGroup
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "AddGroup";
            this.Load += new System.EventHandler(this.AddGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empSignDB1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsEmployeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsEmployeesBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EmpSignDB1DataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private EmpSignDB1DataSet empSignDB1DataSet;
        private System.Windows.Forms.Label lbl_EmployeeNum;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private System.Windows.Forms.ComboBox comboBoxGroupType;
        private System.Windows.Forms.TextBox textBox_GroupName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblIdNo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource groupsEmployeesBindingSource;
        private EmpSignDB1DataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource groupsEmployeesBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource groupsEmployeesBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.Button btn_Save;
    }
}