namespace EmployeeManagementSystem.Properties
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.checkBoxEName = new System.Windows.Forms.CheckBox();
            this.checkBoxDocName = new System.Windows.Forms.CheckBox();
            this.comboBox_EmpName = new System.Windows.Forms.ComboBox();
            this.emploeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empSignDBDataSet = new EmployeeManagementSystem.EmpSignDBDataSet();
            this.comboBoxDocName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signEventsDocumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.signEventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empSignDB1DataSet = new EmployeeManagementSystem.EmpSignDB1DataSet();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Signed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsTableAdapter = new EmployeeManagementSystem.EmpSignDB1DataSetTableAdapters.DocumentsTableAdapter();
            this.emploeesTableAdapter = new EmployeeManagementSystem.EmpSignDBDataSetTableAdapters.EmploeesTableAdapter();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.Lbl_MainMenu = new System.Windows.Forms.Label();
            this.ButtonMarker = new System.Windows.Forms.Panel();
            this.Btn_ResendDoc = new System.Windows.Forms.Button();
            this.btn_SelectForm = new System.Windows.Forms.Button();
            this.Btn_MissingDocs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.emploeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empSignDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signEventsDocumentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signEventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empSignDB1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.sideBarPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnSelect
            // 
            resources.ApplyResources(this.btnSelect, "btnSelect");
            this.btnSelect.BackColor = System.Drawing.Color.Green;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // checkBoxDate
            // 
            resources.ApplyResources(this.checkBoxDate, "checkBoxDate");
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
            // 
            // checkBoxEName
            // 
            resources.ApplyResources(this.checkBoxEName, "checkBoxEName");
            this.checkBoxEName.Name = "checkBoxEName";
            this.checkBoxEName.UseVisualStyleBackColor = true;
            this.checkBoxEName.CheckedChanged += new System.EventHandler(this.checkBoxEName_CheckedChanged);
            // 
            // checkBoxDocName
            // 
            resources.ApplyResources(this.checkBoxDocName, "checkBoxDocName");
            this.checkBoxDocName.Name = "checkBoxDocName";
            this.checkBoxDocName.UseVisualStyleBackColor = true;
            this.checkBoxDocName.CheckedChanged += new System.EventHandler(this.checkBoxDocName_CheckedChanged);
            // 
            // comboBox_EmpName
            // 
            resources.ApplyResources(this.comboBox_EmpName, "comboBox_EmpName");
            this.comboBox_EmpName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.emploeesBindingSource, "FullName", true));
            this.comboBox_EmpName.FormattingEnabled = true;
            this.comboBox_EmpName.Name = "comboBox_EmpName";
            this.comboBox_EmpName.SelectedIndexChanged += new System.EventHandler(this.comboBox_EmpName_SelectedIndexChanged);
            // 
            // emploeesBindingSource
            // 
            this.emploeesBindingSource.DataMember = "Emploees";
            this.emploeesBindingSource.DataSource = this.empSignDBDataSet;
            // 
            // empSignDBDataSet
            // 
            this.empSignDBDataSet.DataSetName = "EmpSignDBDataSet";
            this.empSignDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxDocName
            // 
            resources.ApplyResources(this.comboBoxDocName, "comboBoxDocName");
            this.comboBoxDocName.FormattingEnabled = true;
            this.comboBoxDocName.Name = "comboBoxDocName";
            this.comboBoxDocName.SelectedIndexChanged += new System.EventHandler(this.comboBoxDocName_SelectedIndexChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // signEventsDocumentsBindingSource
            // 
            this.signEventsDocumentsBindingSource.DataMember = "SignEvents_Documents";
            this.signEventsDocumentsBindingSource.DataSource = this.signEventsBindingSource;
            // 
            // signEventsBindingSource
            // 
            this.signEventsBindingSource.DataMember = "SignEvents";
            this.signEventsBindingSource.DataSource = this.empSignDB1DataSet;
            // 
            // empSignDB1DataSet
            // 
            this.empSignDB1DataSet.DataSetName = "EmpSignDB1DataSet";
            this.empSignDB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 138.5389F;
            resources.ApplyResources(this.ID, "ID");
            this.ID.MaxInputLength = 50;
            this.ID.Name = "ID";
            // 
            // EmployeeNum
            // 
            this.EmployeeNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeNum.FillWeight = 29.95847F;
            resources.ApplyResources(this.EmployeeNum, "EmployeeNum");
            this.EmployeeNum.MaxInputLength = 50;
            this.EmployeeNum.Name = "EmployeeNum";
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.FillWeight = 184.3456F;
            resources.ApplyResources(this.FullName, "FullName");
            this.FullName.MaxInputLength = 150;
            this.FullName.Name = "FullName";
            // 
            // Mobile
            // 
            this.Mobile.FillWeight = 111.0056F;
            resources.ApplyResources(this.Mobile, "Mobile");
            this.Mobile.Name = "Mobile";
            // 
            // Signed
            // 
            resources.ApplyResources(this.Signed, "Signed");
            this.Signed.Name = "Signed";
            // 
            // Email
            // 
            resources.ApplyResources(this.Email, "Email");
            this.Email.Name = "Email";
            // 
            // documentsTableAdapter
            // 
            this.documentsTableAdapter.ClearBeforeFill = true;
            // 
            // emploeesTableAdapter
            // 
            this.emploeesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView
            // 
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Department,
            this.Link});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Alef", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Alef", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            // 
            // sideBarPanel
            // 
            resources.ApplyResources(this.sideBarPanel, "sideBarPanel");
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sideBarPanel.Controls.Add(this.logoPanel);
            this.sideBarPanel.Controls.Add(this.ButtonMarker);
            this.sideBarPanel.Controls.Add(this.Btn_ResendDoc);
            this.sideBarPanel.Controls.Add(this.btn_SelectForm);
            this.sideBarPanel.Controls.Add(this.Btn_MissingDocs);
            this.sideBarPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sideBarPanel.Name = "sideBarPanel";
            // 
            // logoPanel
            // 
            resources.ApplyResources(this.logoPanel, "logoPanel");
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logoPanel.Controls.Add(this.Lbl_MainMenu);
            this.logoPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.logoPanel.Name = "logoPanel";
            // 
            // Lbl_MainMenu
            // 
            resources.ApplyResources(this.Lbl_MainMenu, "Lbl_MainMenu");
            this.Lbl_MainMenu.ForeColor = System.Drawing.Color.White;
            this.Lbl_MainMenu.Name = "Lbl_MainMenu";
            // 
            // ButtonMarker
            // 
            resources.ApplyResources(this.ButtonMarker, "ButtonMarker");
            this.ButtonMarker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonMarker.Name = "ButtonMarker";
            // 
            // Btn_ResendDoc
            // 
            resources.ApplyResources(this.Btn_ResendDoc, "Btn_ResendDoc");
            this.Btn_ResendDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ResendDoc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Btn_ResendDoc.FlatAppearance.BorderSize = 0;
            this.Btn_ResendDoc.ForeColor = System.Drawing.Color.White;
            this.Btn_ResendDoc.Name = "Btn_ResendDoc";
            this.Btn_ResendDoc.UseVisualStyleBackColor = true;
            // 
            // btn_SelectForm
            // 
            resources.ApplyResources(this.btn_SelectForm, "btn_SelectForm");
            this.btn_SelectForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_SelectForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SelectForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btn_SelectForm.FlatAppearance.BorderSize = 0;
            this.btn_SelectForm.ForeColor = System.Drawing.Color.White;
            this.btn_SelectForm.Name = "btn_SelectForm";
            this.btn_SelectForm.UseVisualStyleBackColor = false;
            // 
            // Btn_MissingDocs
            // 
            resources.ApplyResources(this.Btn_MissingDocs, "Btn_MissingDocs");
            this.Btn_MissingDocs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Btn_MissingDocs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_MissingDocs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Btn_MissingDocs.FlatAppearance.BorderSize = 0;
            this.Btn_MissingDocs.ForeColor = System.Drawing.Color.White;
            this.Btn_MissingDocs.Name = "Btn_MissingDocs";
            this.Btn_MissingDocs.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.comboBoxDocName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBoxDocName);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // EventID
            // 
            this.EventID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EventID.DataPropertyName = "ID";
            this.EventID.FillWeight = 258.4812F;
            resources.ApplyResources(this.EventID, "EventID");
            this.EventID.Name = "EventID";
            this.EventID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.FillWeight = 140.4128F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.FillWeight = 127.1789F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.FillWeight = 16.30418F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.FillWeight = 2.473201F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 18.63307F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Department.FillWeight = 2.303246F;
            resources.ApplyResources(this.Department, "Department");
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // Link
            // 
            this.Link.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.Link, "Link");
            this.Link.Name = "Link";
            this.Link.ReadOnly = true;
            // 
            // Report
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sideBarPanel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_EmpName);
            this.Controls.Add(this.checkBoxEName);
            this.Controls.Add(this.checkBoxDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emploeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empSignDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signEventsDocumentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signEventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empSignDB1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.sideBarPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource signEventsBindingSource;
        private EmpSignDB1DataSet empSignDB1DataSet;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.CheckBox checkBoxEName;
        private System.Windows.Forms.CheckBox checkBoxDocName;
        private System.Windows.Forms.ComboBox comboBox_EmpName;
        private System.Windows.Forms.ComboBox comboBoxDocName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource signEventsDocumentsBindingSource;
        private EmpSignDB1DataSetTableAdapters.DocumentsTableAdapter documentsTableAdapter;
        private EmpSignDBDataSet empSignDBDataSet;
        private System.Windows.Forms.BindingSource emploeesBindingSource;
        private EmpSignDBDataSetTableAdapters.EmploeesTableAdapter emploeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Signed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label Lbl_MainMenu;
        private System.Windows.Forms.Panel ButtonMarker;
        private System.Windows.Forms.Button Btn_ResendDoc;
        private System.Windows.Forms.Button btn_SelectForm;
        private System.Windows.Forms.Button Btn_MissingDocs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link;
    }
}