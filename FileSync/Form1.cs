using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void folder1button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd1 = new FolderBrowserDialog();
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
            FolderBrowserDialog fbd2 = new FolderBrowserDialog();
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
            }
        }
    }
}
