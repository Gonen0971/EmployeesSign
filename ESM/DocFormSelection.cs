using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class DocFormSelection : Form
    {
        public DocFormSelection()
        {
            InitializeComponent();
            ListFilestoCombo();
        }

        //public string dir = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Forms\";
       /// <summary>
        /// DEBUG
        public string dir = @"C:\SPS\EmployeeSignManagment\Forms\";
        /// </summary>
        /// 
        public string DocSelectedAbsulutePath = "";

        public void ListFilestoCombo()
        {
            // Select Form file

            if (!IsDirectoryEmpty(dir))
            {
                string[] files = Directory.GetFiles(dir, "*.pdf", SearchOption.TopDirectoryOnly);
                string selected = "";
                if (comboDocSelect.Items.Count == 0)
                    foreach (string filePath in files)
                        comboDocSelect.Items.Add(Path.GetFileName(filePath));
                    selected = this.comboDocSelect.GetItemText(this.comboDocSelect.SelectedItem);
               
                    DocSelectedAbsulutePath = dir + selected;
                    CreateFileLink(DocSelectedAbsulutePath);
            }
                else
                {
                string message, caption;
                string language = ChangeLanguage.ReadConfigValue("language");
                if (language == "he-IL")
                {
                    message = "תיקיית מסמכים שלך ריקה";
                    caption = "מסמכים";
                }
                else
                {
                    message = "Documents folder is empty";
                    caption = "Documents";
                }
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                }


        }
        void CreateFileLink(string absoluteFilePath)
        {
           linkPdfLabel.Text = Path.GetFileName(absoluteFilePath);
           linkPdfLabel.Links[0].LinkData = absoluteFilePath;
           
        }
        private void linkPdfLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = (string)linkPdfLabel.Links[0].LinkData;
            process.Start();
        }
        public bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }


        private void comboDocSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListFilestoCombo();
            LinkLabel.Visible = true;
           
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DocSelectedAbsulutePath = "";
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string FileSelected = DocSelectedAbsulutePath.ToLower();
            if (!FileSelected.EndsWith(".pdf"))
            {
                string message, caption;
                string language = ChangeLanguage.ReadConfigValue("language");
                if (language == "he-IL")
                {
                    message = "לא נבחר טופס להחתמה";
                    caption = "מסמכים";
                }
                else
                {
                    message = "No document selected for signature";
                    caption = "Documents";
                }
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
            else
                this.Close();

        }
    }
}
