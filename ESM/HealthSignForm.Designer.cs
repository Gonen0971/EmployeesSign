namespace EmployeeManagementSystem
{
    partial class HealthSignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HealthSignForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exportData = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.btn_Markall = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNameDsc = new System.Windows.Forms.Button();
            this.btnNameAsc = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ApprovalDataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NeedsToSign = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSignDB1DataSet = new EmployeeManagementSystem.EmpSignDB1DataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new EmployeeManagementSystem.EmpSignDB1DataSetTableAdapters.EmployeesTableAdapter();
            this.headerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sideBarPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApprovalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empSignDB1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            resources.ApplyResources(this.headerPanel, "headerPanel");
            this.headerPanel.BackColor = System.Drawing.Color.Silver;
            this.headerPanel.Controls.Add(this.header);
            this.headerPanel.Controls.Add(this.lblMinimize);
            this.headerPanel.Controls.Add(this.lblClose);
            this.headerPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // header
            // 
            resources.ApplyResources(this.header, "header");
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Name = "header";
            this.header.Click += new System.EventHandler(this.header_Click);
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // lblMinimize
            // 
            resources.ApplyResources(this.lblMinimize, "lblMinimize");
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.lblMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.lblMinimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // lblClose
            // 
            resources.ApplyResources(this.lblClose, "lblClose");
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Name = "lblClose";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.lblClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.lblClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.exportData);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Name = "panel1";
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // exportData
            // 
            resources.ApplyResources(this.exportData, "exportData");
            this.exportData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.exportData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.exportData.FlatAppearance.BorderSize = 0;
            this.exportData.ForeColor = System.Drawing.Color.White;
            this.exportData.Name = "exportData";
            this.exportData.UseVisualStyleBackColor = false;
            this.exportData.Click += new System.EventHandler(this.exportData_Click);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.btnClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.sideBarPanel);
            this.panel2.Controls.Add(this.ApprovalDataGridView);
            this.panel2.Name = "panel2";
            // 
            // sideBarPanel
            // 
            resources.ApplyResources(this.sideBarPanel, "sideBarPanel");
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sideBarPanel.Controls.Add(this.btn_Markall);
            this.sideBarPanel.Controls.Add(this.button1);
            this.sideBarPanel.Controls.Add(this.btnNameDsc);
            this.sideBarPanel.Controls.Add(this.btnNameAsc);
            this.sideBarPanel.Controls.Add(this.panel3);
            this.sideBarPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sideBarPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sideBarPanel.Name = "sideBarPanel";
            // 
            // btn_Markall
            // 
            resources.ApplyResources(this.btn_Markall, "btn_Markall");
            this.btn_Markall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Markall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btn_Markall.FlatAppearance.BorderSize = 0;
            this.btn_Markall.ForeColor = System.Drawing.Color.White;
            this.btn_Markall.Name = "btn_Markall";
            this.btn_Markall.UseVisualStyleBackColor = true;
            this.btn_Markall.Click += new System.EventHandler(this.btn_Markall_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnNameDsc
            // 
            resources.ApplyResources(this.btnNameDsc, "btnNameDsc");
            this.btnNameDsc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNameDsc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnNameDsc.FlatAppearance.BorderSize = 0;
            this.btnNameDsc.ForeColor = System.Drawing.Color.White;
            this.btnNameDsc.Name = "btnNameDsc";
            this.btnNameDsc.UseVisualStyleBackColor = true;
            this.btnNameDsc.Click += new System.EventHandler(this.btnNameDsc_Click_1);
            // 
            // btnNameAsc
            // 
            resources.ApplyResources(this.btnNameAsc, "btnNameAsc");
            this.btnNameAsc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNameAsc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnNameAsc.FlatAppearance.BorderSize = 0;
            this.btnNameAsc.ForeColor = System.Drawing.Color.White;
            this.btnNameAsc.Name = "btnNameAsc";
            this.btnNameAsc.UseVisualStyleBackColor = true;
            this.btnNameAsc.Click += new System.EventHandler(this.btnNameAsc_Click_1);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.panel3.Controls.Add(this.lblMainMenu);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Name = "panel3";
            // 
            // lblMainMenu
            // 
            resources.ApplyResources(this.lblMainMenu, "lblMainMenu");
            this.lblMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.lblMainMenu.ForeColor = System.Drawing.Color.White;
            this.lblMainMenu.Name = "lblMainMenu";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // ApprovalDataGridView
            // 
            resources.ApplyResources(this.ApprovalDataGridView, "ApprovalDataGridView");
            this.ApprovalDataGridView.AllowUserToAddRows = false;
            this.ApprovalDataGridView.AllowUserToDeleteRows = false;
            this.ApprovalDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ApprovalDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ApprovalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ApprovalDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApprovalDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.ApprovalDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ApprovalDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ApprovalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeNum,
            this.ID,
            this.FullName,
            this.NeedsToSign,
            this.Mobile,
            this.Email});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ApprovalDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.ApprovalDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.ApprovalDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.ApprovalDataGridView.MultiSelect = false;
            this.ApprovalDataGridView.Name = "ApprovalDataGridView";
            this.ApprovalDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ApprovalDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ApprovalDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.ApprovalDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ApprovalDataGridView.ShowEditingIcon = false;
            this.ApprovalDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ApprovalDataGridView_CellContentClick);
            // 
            // EmployeeNum
            // 
            this.EmployeeNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EmployeeNum.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeNum.FillWeight = 29.95847F;
            resources.ApplyResources(this.EmployeeNum, "EmployeeNum");
            this.EmployeeNum.MaxInputLength = 50;
            this.EmployeeNum.Name = "EmployeeNum";
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle4;
            this.ID.FillWeight = 138.5389F;
            resources.ApplyResources(this.ID, "ID");
            this.ID.MaxInputLength = 50;
            this.ID.Name = "ID";
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FullName.DefaultCellStyle = dataGridViewCellStyle5;
            this.FullName.FillWeight = 184.3456F;
            resources.ApplyResources(this.FullName, "FullName");
            this.FullName.MaxInputLength = 150;
            this.FullName.Name = "FullName";
            // 
            // NeedsToSign
            // 
            this.NeedsToSign.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.NullValue = false;
            this.NeedsToSign.DefaultCellStyle = dataGridViewCellStyle6;
            this.NeedsToSign.DividerWidth = 2;
            this.NeedsToSign.FillWeight = 10.31788F;
            resources.ApplyResources(this.NeedsToSign, "NeedsToSign");
            this.NeedsToSign.Name = "NeedsToSign";
            this.NeedsToSign.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Mobile
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Mobile.DefaultCellStyle = dataGridViewCellStyle7;
            this.Mobile.FillWeight = 111.0056F;
            resources.ApplyResources(this.Mobile, "Mobile");
            this.Mobile.Name = "Mobile";
            // 
            // Email
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Email.DefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.Email, "Email");
            this.Email.Name = "Email";
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
            // HealthSignForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HealthSignForm";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.sideBarPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApprovalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empSignDB1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ApprovalDataGridView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button exportData;
        private EmpSignDB1DataSet empSignDB1DataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmpSignDB1DataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Button btn_Markall;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNameDsc;
        private System.Windows.Forms.Button btnNameAsc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NeedsToSign;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}