using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSync
{
    public partial class Form1 : Form
    {

        public bool folder1Selected = false;
        public bool folder2Selected = false;
        public FolderBrowserDialog fbd1 = new FolderBrowserDialog();
        public FolderBrowserDialog fbd2 = new FolderBrowserDialog();
        public Form1()
        {
            InitializeComponent();
        }

        // Returns true if file f should be updated in folder fol, returns false otherwise.
        // Currently, this method only returns true if the file f is not in folder fol.
        // In the future, there will be other criteria as to why a file should be updated.
        private bool should_Update(string f, string fol)
        {
            // Get all files in folder fol.
            string[] folder_files = Directory.GetFiles(fol, "*", SearchOption.AllDirectories);
            foreach (string file in folder_files)
            {
                // If the file f is in folder fol, return false.
                //if (fol + '\\' + f == file) - EV,OB alt method of combining 
                if (System.IO.Path.Combine(fol, f) == file)
                {
                    return false;
                }
            }
            return true;
        }

        // Syncs folder fol1 with folder fol2.
        private void sync_Folders(string fol1, string fol2)
        {
            // Get all files in both folders.
            string[] folder1_files = Directory.GetFiles(fol1, "*", SearchOption.AllDirectories);    
            string[] folder2_files = Directory.GetFiles(fol2, "*", SearchOption.AllDirectories);

            foreach (string file in folder1_files)
            {
                // Remove the path leading up to the filename.
                // This leaves just the filename, which is necessary for syncing with the other folder.
                string f = file.Remove(0, fol1.Length+1);

                string sourceFile = file;
                string destFile = System.IO.Path.Combine(fol2, f);

                if (should_Update(f, fol2))
                {
                    System.Diagnostics.Debug.WriteLine(f + " syncs to " + fol2 + ".");
                    System.IO.File.Copy(sourceFile, destFile, true);
                }
            }
            System.Diagnostics.Debug.WriteLine("--------------");
            System.Diagnostics.Debug.WriteLine("Folder 2 Files");
            System.Diagnostics.Debug.WriteLine("--------------");
            foreach (string file in folder2_files)
            {
                System.Diagnostics.Debug.WriteLine(file);
            }
        }

        private void folder1button_Click(object sender, EventArgs e)
        {
            if (fbd1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                folder1label.Text = "Folder 1 is " + fbd1.SelectedPath;
                folder1Selected = true;
            }
            else
            {
                folder1label.Text = "Something bad happened.";
                folder1Selected = false;
            }
        }

        private void folder2button_Click(object sender, EventArgs e)
        {
            if (fbd2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                folder2label.Text = "Folder 2 is " + fbd2.SelectedPath;
                folder2Selected = true;
            }
            else
            {
                folder2label.Text = "Something bad happened.";
                folder2Selected = false;
            }
        }

        private void syncbutton_Click(object sender, EventArgs e)
        {
            if (!folder1Selected || !folder2Selected)
            {
                syncnowlabel.Text = "One of the folders has not been properly selected.";
            }
            else
            {
                syncnowlabel.Text = "This should now sync the contents of the two folders.";
                sync_Folders(fbd1.SelectedPath, fbd2.SelectedPath);
            }
        }
    }
}
