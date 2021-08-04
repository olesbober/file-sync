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

        /**
            Returns true if file f should be updated in folder fol, returns false otherwise.
            Currently, this method only returns true if the file f is not in folder fol.
            In the future, there will be other criteria as to why a file should be updated.
            @params
                f: file name
                fol: the destination folder
         */
        private bool should_Update(string f, string fol, string origDir)
        {
            // Get all files in folder fol.
            string[] folder_files = Directory.GetFiles(fol, "*", SearchOption.AllDirectories);

            foreach (string file in folder_files)
            {
                // If the file f is in folder fol, return false.
                if (fol + f == file)
                {
                    DateTime dt1 = Directory.GetLastWriteTime(fol + f);
                    DateTime dt2 = Directory.GetLastWriteTime(origDir);

                    if (dt1 < dt2)
                    {
                        return true;
                    }
                    return false;
                }
            }
            return true;
        }

        /**
            Syncs folder fol1 with folder fol2.
            @params
                fol1: path of folder 1
                fol2: path of folder 2
         */
        private void sync_Folders(string fol1, string fol2)
        {
            string[] folder1_dirs = Directory.GetDirectories(fol1, "*", SearchOption.AllDirectories);
            string[] folder2_dirs = Directory.GetDirectories(fol2, "*", SearchOption.AllDirectories);
            string[] folder1_files = Directory.GetFiles(fol1, "*", SearchOption.AllDirectories);
            string[] folder2_files = Directory.GetFiles(fol2, "*", SearchOption.AllDirectories);

            foreach (string d in folder1_dirs)
            {
                string f = d.Remove(0, fol1.Length);
                string targetDir = fol2 + f;
                DirectoryInfo di = Directory.CreateDirectory(targetDir);

                sync_Folders(d, targetDir);
            }

            foreach (string f in folder1_files)
            {
                string file = f.Remove(0, fol1.Length);
                string targetDir = fol2 + file;

                if (should_Update(file, fol2, f))
                {
                    System.IO.File.Copy(f, targetDir, true);
                    System.Diagnostics.Debug.WriteLine(f + " syncs to " + fol2 + ".");
                }
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
                folder1label.Text = "No folder selected! Please choose a folder.";
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
                folder2label.Text = "No folder selected! Please choose a folder.";
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
                sync_Folders(fbd2.SelectedPath, fbd1.SelectedPath);
            }
        }
    }
}
