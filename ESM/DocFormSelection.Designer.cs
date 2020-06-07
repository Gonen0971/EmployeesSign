namespace EmployeeManagementSystem
{
    partial class DocFormSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocFormSelection));
            this.label1 = new System.Windows.Forms.Label();
            this.comboDocSelect = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.LinkLabel = new System.Windows.Forms.Label();
            this.linkPdfLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboDocSelect
            // 
            resources.ApplyResources(this.comboDocSelect, "comboDocSelect");
            this.comboDocSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDocSelect.FormattingEnabled = true;
            this.comboDocSelect.Name = "comboDocSelect";
            this.comboDocSelect.Sorted = true;
            this.comboDocSelect.SelectedIndexChanged += new System.EventHandler(this.comboDocSelect_SelectedIndexChanged);
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // LinkLabel
            // 
            resources.ApplyResources(this.LinkLabel, "LinkLabel");
            this.LinkLabel.Name = "LinkLabel";
            // 
            // linkPdfLabel
            // 
            resources.ApplyResources(this.linkPdfLabel, "linkPdfLabel");
            this.linkPdfLabel.Name = "linkPdfLabel";
            this.linkPdfLabel.TabStop = true;
            this.linkPdfLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPdfLabel_LinkClicked);
            // 
            // DocFormSelection
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkPdfLabel);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.comboDocSelect);
            this.Controls.Add(this.label1);
            this.Name = "DocFormSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboDocSelect;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label LinkLabel;
        private System.Windows.Forms.LinkLabel linkPdfLabel;
    }
}