using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VisualUIAVerify.Forms
{
    public partial class FileCreator : Form
    {
        string fileDirPath = @"C:\CFW";
        public string xmlLocation ;
        string strSearchDirectory;
        public FileCreator()
        {
            InitializeComponent();
            FileLocation.Text = fileDirPath;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
               //check Folder 
              if (!Directory.Exists(FileLocation.Text + "\\" + FolderName.Text))
              {
                  Directory.CreateDirectory(FileLocation.Text + "\\" + FolderName.Text);

                  // check File not created
                  if (!File.Exists(FileLocation.Text + "\\" + FolderName.Text + "\\" + FileName.Text))
                  {
                      //create xml file 
                      File.Create(FileLocation.Text + "\\" + FolderName.Text + "\\" + FileName.Text);
                      //Strore file location
                      xmlLocation = FileLocation.Text + "\\" + FolderName.Text + "\\" + FileName.Text;

                     MessageBox.Show("Folder " + FolderName.Text + " File " + FileName.Text + " Created ");

                  }
                  

              }
                else
                {
                    MessageBox.Show("Folder/File already Exists");
                    xmlLocation = FileLocation.Text + "\\" + FolderName.Text + "\\" + FileName.Text;
                }

            }
            catch
            {
                MessageBox.Show("Error creating file .Cannot Access Location");
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                               
                if (!Directory.Exists(fileDirPath))
                {
                    Directory.CreateDirectory(fileDirPath);
                }
                //F

             FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
                
                if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    strSearchDirectory = folderBrowser.SelectedPath;
                    FileLocation.Text = strSearchDirectory;
                }
            }
            catch
            {
                MessageBox.Show("Error Cannot Access Location");
            }
        }

        private void FolderName_Leave(object sender, EventArgs e)
        {
            FileName.Text = FolderName.Text+".xml";
            FileName.Enabled = false;

        }
    }
}
