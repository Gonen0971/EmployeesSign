namespace EmployeeManagementSystem
{
    partial class EmployeeSysMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSysMainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.Lbl_MainMenu = new System.Windows.Forms.Label();
            this.btn_about = new System.Windows.Forms.Button();
            this.ButtonMarker = new System.Windows.Forms.Panel();
            this.btn_AddGroup = new System.Windows.Forms.Button();
            this.PrepareApprovals = new System.Windows.Forms.Button();
            this.btn_SelectForm = new System.Windows.Forms.Button();
            this.addEmployee = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.importEmployees = new System.Windows.Forms.Button();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.שפהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.עבריתToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.אנגליתToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSignDB1DataSet = new EmployeeManagementSystem.EmpSignDB1DataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new EmployeeManagementSystem.EmpSignDB1DataSetTableAdapters.EmployeesTableAdapter();
            this.sideBarPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.containerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empSignDB1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            resources.ApplyResources(this.sideBarPanel, "sideBarPanel");
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sideBarPanel.Controls.Add(this.logoPanel);
            this.sideBarPanel.Controls.Add(this.btn_about);
            this.sideBarPanel.Controls.Add(this.ButtonMarker);
            this.sideBarPanel.Controls.Add(this.btn_AddGroup);
            this.sideBarPanel.Controls.Add(this.PrepareApprovals);
            this.sideBarPanel.Controls.Add(this.btn_SelectForm);
            this.sideBarPanel.Controls.Add(this.addEmployee);
            this.sideBarPanel.Controls.Add(this.btnGenerateReport);
            this.sideBarPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sideBarPanel_Paint);
            this.sideBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.sideBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.sideBarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // logoPanel
            // 
            resources.ApplyResources(this.logoPanel, "logoPanel");
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logoPanel.Controls.Add(this.Lbl_MainMenu);
            this.logoPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.logoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.logoPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // Lbl_MainMenu
            // 
            resources.ApplyResources(this.Lbl_MainMenu, "Lbl_MainMenu");
            this.Lbl_MainMenu.ForeColor = System.Drawing.Color.White;
            this.Lbl_MainMenu.Name = "Lbl_MainMenu";
            this.Lbl_MainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.Lbl_MainMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.Lbl_MainMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // btn_about
            // 
            resources.ApplyResources(this.btn_about, "btn_about");
            this.btn_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_about.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.ForeColor = System.Drawing.Color.White;
            this.btn_about.Name = "btn_about";
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonMarker
            // 
            resources.ApplyResources(this.ButtonMarker, "ButtonMarker");
            this.ButtonMarker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonMarker.Name = "ButtonMarker";
            // 
            // btn_AddGroup
            // 
            resources.ApplyResources(this.btn_AddGroup, "btn_AddGroup");
            this.btn_AddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_AddGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btn_AddGroup.FlatAppearance.BorderSize = 0;
            this.btn_AddGroup.ForeColor = System.Drawing.Color.White;
            this.btn_AddGroup.Name = "btn_AddGroup";
            this.btn_AddGroup.UseVisualStyleBackColor = false;
            this.btn_AddGroup.Click += new System.EventHandler(this.btn_AddGroup_Click_1);
            // 
            // PrepareApprovals
            // 
            resources.ApplyResources(this.PrepareApprovals, "PrepareApprovals");
            this.PrepareApprovals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrepareApprovals.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.PrepareApprovals.FlatAppearance.BorderSize = 0;
            this.PrepareApprovals.ForeColor = System.Drawing.Color.White;
            this.PrepareApprovals.Name = "PrepareApprovals";
            this.PrepareApprovals.UseVisualStyleBackColor = true;
            this.PrepareApprovals.Click += new System.EventHandler(this.PrepareApprovals_Click);
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
            this.btn_SelectForm.Click += new System.EventHandler(this.btn_SelectForm_Click);
            // 
            // addEmployee
            // 
            resources.ApplyResources(this.addEmployee, "addEmployee");
            this.addEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.addEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.addEmployee.FlatAppearance.BorderSize = 0;
            this.addEmployee.ForeColor = System.Drawing.Color.White;
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.UseVisualStyleBackColor = false;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // btnGenerateReport
            // 
            resources.ApplyResources(this.btnGenerateReport, "btnGenerateReport");
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // importEmployees
            // 
            resources.ApplyResources(this.importEmployees, "importEmployees");
            this.importEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.importEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importEmployees.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.importEmployees.FlatAppearance.BorderSize = 0;
            this.importEmployees.ForeColor = System.Drawing.Color.White;
            this.importEmployees.Name = "importEmployees";
            this.importEmployees.UseVisualStyleBackColor = false;
            this.importEmployees.Click += new System.EventHandler(this.importEmployees_Click);
            this.importEmployees.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.importEmployees.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.importEmployees.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // containerPanel
            // 
            resources.ApplyResources(this.containerPanel, "containerPanel");
            this.containerPanel.Controls.Add(this.panel1);
            this.containerPanel.Name = "containerPanel";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.importEmployees);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.sideBarPanel);
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(48)))), ((int)(((byte)(44)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnEdit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnEdit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.btnEdit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(48)))), ((int)(((byte)(44)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnDelete.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.btnDelete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.שפהToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // שפהToolStripMenuItem
            // 
            resources.ApplyResources(this.שפהToolStripMenuItem, "שפהToolStripMenuItem");
            this.שפהToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.עבריתToolStripMenuItem,
            this.אנגליתToolStripMenuItem});
            this.שפהToolStripMenuItem.Name = "שפהToolStripMenuItem";
            // 
            // עבריתToolStripMenuItem
            // 
            resources.ApplyResources(this.עבריתToolStripMenuItem, "עבריתToolStripMenuItem");
            this.עבריתToolStripMenuItem.Name = "עבריתToolStripMenuItem";
            this.עבריתToolStripMenuItem.Click += new System.EventHandler(this.עבריתToolStripMenuItem_Click);
            // 
            // אנגליתToolStripMenuItem
            // 
            resources.ApplyResources(this.אנגליתToolStripMenuItem, "אנגליתToolStripMenuItem");
            this.אנגליתToolStripMenuItem.Name = "אנגליתToolStripMenuItem";
            this.אנגליתToolStripMenuItem.Click += new System.EventHandler(this.אנגליתToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeNum,
            this.Id,
            this.FullName,
            this.Mobile,
            this.Email,
            this.Department});
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
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.dataGridView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.dataGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // EmployeeNum
            // 
            this.EmployeeNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeNum.FillWeight = 45.78157F;
            resources.ApplyResources(this.EmployeeNum, "EmployeeNum");
            this.EmployeeNum.Name = "EmployeeNum";
            this.EmployeeNum.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.FillWeight = 109.3804F;
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.FillWeight = 127.5051F;
            resources.ApplyResources(this.FullName, "FullName");
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mobile.FillWeight = 56.09378F;
            resources.ApplyResources(this.Mobile, "Mobile");
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.FillWeight = 70.93198F;
            resources.ApplyResources(this.Email, "Email");
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.FillWeight = 56.09378F;
            resources.ApplyResources(this.Department, "Department");
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // empSignDB1DataSet
            // 
            this.empSignDB1DataSet.DataSetName = "EmpSignDB1DataSet";
            this.empSignDB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.empSignDB1DataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeSysMainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.containerPanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmployeeSysMainForm";
            this.Load += new System.EventHandler(this.EmployeeSysMainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            this.sideBarPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empSignDB1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Button importEmployees;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label Lbl_MainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PrepareApprovals;
        private System.Windows.Forms.Button btnExit;
        private EmpSignDB1DataSet empSignDB1DataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmpSignDB1DataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem שפהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem עבריתToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem אנגליתToolStripMenuItem;
        private System.Windows.Forms.Button btn_AddGroup;
        private System.Windows.Forms.Button btn_SelectForm;
        private System.Windows.Forms.Panel ButtonMarker;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
    }
}

