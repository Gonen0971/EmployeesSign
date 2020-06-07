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
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.PrepareApprovals = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.addEmployee = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Label();
            this.importEmployees = new System.Windows.Forms.Button();
            this.exportData = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MaindataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfSign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.employeeDBDataSet = new EmployeeManagementSystem.EmployeeDBDataSet();
            this.employeeDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sideBarPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.containerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaindataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.Silver;
            this.sideBarPanel.Controls.Add(this.PrepareApprovals);
            this.sideBarPanel.Controls.Add(this.btnGenerateReport);
            this.sideBarPanel.Controls.Add(this.addEmployee);
            this.sideBarPanel.Controls.Add(this.logoPanel);
            this.sideBarPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sideBarPanel.Location = new System.Drawing.Point(1032, 0);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(190, 555);
            this.sideBarPanel.TabIndex = 0;
            this.sideBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.sideBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.sideBarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // PrepareApprovals
            // 
            this.PrepareApprovals.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PrepareApprovals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PrepareApprovals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrepareApprovals.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.PrepareApprovals.FlatAppearance.BorderSize = 0;
            this.PrepareApprovals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrepareApprovals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrepareApprovals.ForeColor = System.Drawing.Color.White;
            this.PrepareApprovals.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrepareApprovals.Location = new System.Drawing.Point(0, 112);
            this.PrepareApprovals.Name = "PrepareApprovals";
            this.PrepareApprovals.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PrepareApprovals.Size = new System.Drawing.Size(185, 40);
            this.PrepareApprovals.TabIndex = 3;
            this.PrepareApprovals.Text = "הכן אישורים לשליחה";
            this.PrepareApprovals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrepareApprovals.UseVisualStyleBackColor = true;
            this.PrepareApprovals.Click += new System.EventHandler(this.PrepareApprovals_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateReport.Enabled = false;
            this.btnGenerateReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateReport.Location = new System.Drawing.Point(15, 165);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGenerateReport.Size = new System.Drawing.Size(170, 40);
            this.btnGenerateReport.TabIndex = 2;
            this.btnGenerateReport.Text = "דוחות";
            this.btnGenerateReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // addEmployee
            // 
            this.addEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.addEmployee.FlatAppearance.BorderSize = 0;
            this.addEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee.ForeColor = System.Drawing.Color.White;
            this.addEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addEmployee.Location = new System.Drawing.Point(12, 59);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addEmployee.Size = new System.Drawing.Size(173, 40);
            this.addEmployee.TabIndex = 1;
            this.addEmployee.Text = "הוסף עובד";
            this.addEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logoPanel.Controls.Add(this.menu);
            this.logoPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(190, 53);
            this.logoPanel.TabIndex = 0;
            this.logoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.logoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.logoPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Location = new System.Drawing.Point(11, 9);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(167, 33);
            this.menu.TabIndex = 0;
            this.menu.Text = "תפריט ראשי";
            this.menu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.menu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // importEmployees
            // 
            this.importEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.importEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.importEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importEmployees.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.importEmployees.FlatAppearance.BorderSize = 0;
            this.importEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importEmployees.ForeColor = System.Drawing.Color.White;
            this.importEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importEmployees.Location = new System.Drawing.Point(395, 587);
            this.importEmployees.Name = "importEmployees";
            this.importEmployees.Size = new System.Drawing.Size(134, 40);
            this.importEmployees.TabIndex = 1;
            this.importEmployees.Text = "יבא נתונים";
            this.importEmployees.UseVisualStyleBackColor = false;
            this.importEmployees.Click += new System.EventHandler(this.importEmployees_Click);
            this.importEmployees.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.importEmployees.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.importEmployees.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // exportData
            // 
            this.exportData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.exportData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exportData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.exportData.FlatAppearance.BorderSize = 0;
            this.exportData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportData.ForeColor = System.Drawing.Color.White;
            this.exportData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportData.Location = new System.Drawing.Point(246, 587);
            this.exportData.Name = "exportData";
            this.exportData.Size = new System.Drawing.Size(134, 40);
            this.exportData.TabIndex = 1;
            this.exportData.Text = "יצא נתונים";
            this.exportData.UseVisualStyleBackColor = false;
            this.exportData.Click += new System.EventHandler(this.exportData_Click);
            this.exportData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.exportData.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.exportData.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.header);
            this.headerPanel.Controls.Add(this.lblMinimize);
            this.headerPanel.Controls.Add(this.lblClose);
            this.headerPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.headerPanel.Location = new System.Drawing.Point(176, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1046, 53);
            this.headerPanel.TabIndex = 1;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.header.Location = new System.Drawing.Point(229, 8);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(261, 33);
            this.header.TabIndex = 2;
            this.header.Text = "ניהול חתימות עובדים";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.header.Click += new System.EventHandler(this.header_Click);
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.Location = new System.Drawing.Point(995, 3);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(19, 25);
            this.lblMinimize.TabIndex = 1;
            this.lblMinimize.Text = "-";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.lblMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.lblMinimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(1018, 3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 25);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.lblClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.lblClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.panel1);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1222, 649);
            this.containerPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MaindataGridView);
            this.panel1.Controls.Add(this.exportData);
            this.panel1.Controls.Add(this.sideBarPanel);
            this.panel1.Controls.Add(this.importEmployees);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 649);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(48)))), ((int)(((byte)(44)))));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(12, 587);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(120, 40);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "יציאה";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(347, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "מערכת ניהול חתימות עובדים";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MaindataGridView
            // 
            this.MaindataGridView.AllowUserToAddRows = false;
            this.MaindataGridView.AllowUserToDeleteRows = false;
            this.MaindataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MaindataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaindataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.MaindataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.MaindataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaindataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FullName,
            this.Mobile,
            this.Email,
            this.Department,
            this.dateOfSign});
            this.MaindataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.MaindataGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaindataGridView.Location = new System.Drawing.Point(0, 50);
            this.MaindataGridView.Name = "MaindataGridView";
            this.MaindataGridView.ReadOnly = true;
            this.MaindataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MaindataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.MaindataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MaindataGridView.Size = new System.Drawing.Size(1034, 505);
            this.MaindataGridView.TabIndex = 4;
            this.MaindataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.MaindataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.MaindataGridView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.MaindataGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // Id
            // 
            this.Id.FillWeight = 30F;
            this.Id.HeaderText = "ת.ז.";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.FillWeight = 83.94669F;
            this.FullName.HeaderText = "שם העובד";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.FillWeight = 83.94669F;
            this.Mobile.HeaderText = "טלפון ניד";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.FillWeight = 83.94669F;
            this.Email.HeaderText = "כתובת אימייל";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.FillWeight = 83.94669F;
            this.Department.HeaderText = "מחלקה";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // dateOfSign
            // 
            this.dateOfSign.HeaderText = "תאריך חתימה";
            this.dateOfSign.Name = "dateOfSign";
            this.dateOfSign.ReadOnly = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(756, 587);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 40);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "ערוך";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnEdit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.btnEdit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(48)))), ((int)(((byte)(44)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(889, 587);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "מחק";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnDelete.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.btnDelete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // employeeDBDataSet
            // 
            this.employeeDBDataSet.DataSetName = "EmployeeDBDataSet";
            this.employeeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDBDataSetBindingSource
            // 
            this.employeeDBDataSetBindingSource.DataSource = this.employeeDBDataSet;
            this.employeeDBDataSetBindingSource.Position = 0;
            // 
            // EmployeeSysMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1222, 649);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.headerPanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeSysMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management System";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            this.sideBarPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.containerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaindataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button importEmployees;
        private System.Windows.Forms.Button exportData;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView MaindataGridView;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfSign;
        private System.Windows.Forms.Button PrepareApprovals;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.BindingSource employeeDBDataSetBindingSource;
        private EmployeeDBDataSet employeeDBDataSet;
    }
}

