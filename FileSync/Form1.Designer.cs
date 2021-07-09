
namespace FileSync
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folder1button = new System.Windows.Forms.Button();
            this.folder1label = new System.Windows.Forms.Label();
            this.folder2button = new System.Windows.Forms.Button();
            this.folder2label = new System.Windows.Forms.Label();
            this.syncbutton = new System.Windows.Forms.Button();
            this.syncnowlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folder1button
            // 
            this.folder1button.Location = new System.Drawing.Point(12, 12);
            this.folder1button.Name = "folder1button";
            this.folder1button.Size = new System.Drawing.Size(133, 34);
            this.folder1button.TabIndex = 0;
            this.folder1button.Text = "Pick Folder 1";
            this.folder1button.UseVisualStyleBackColor = true;
            this.folder1button.Click += new System.EventHandler(this.folder1button_Click);
            // 
            // folder1label
            // 
            this.folder1label.AutoSize = true;
            this.folder1label.Location = new System.Drawing.Point(151, 19);
            this.folder1label.Name = "folder1label";
            this.folder1label.Size = new System.Drawing.Size(0, 25);
            this.folder1label.TabIndex = 1;
            // 
            // folder2button
            // 
            this.folder2button.Location = new System.Drawing.Point(12, 57);
            this.folder2button.Name = "folder2button";
            this.folder2button.Size = new System.Drawing.Size(133, 34);
            this.folder2button.TabIndex = 2;
            this.folder2button.Text = "Pick Folder 2";
            this.folder2button.UseVisualStyleBackColor = true;
            this.folder2button.Click += new System.EventHandler(this.folder2button_Click);
            // 
            // folder2label
            // 
            this.folder2label.AutoSize = true;
            this.folder2label.Location = new System.Drawing.Point(151, 62);
            this.folder2label.Name = "folder2label";
            this.folder2label.Size = new System.Drawing.Size(0, 25);
            this.folder2label.TabIndex = 1;
            // 
            // syncbutton
            // 
            this.syncbutton.Location = new System.Drawing.Point(12, 404);
            this.syncbutton.Name = "syncbutton";
            this.syncbutton.Size = new System.Drawing.Size(112, 34);
            this.syncbutton.TabIndex = 3;
            this.syncbutton.Text = "Sync Now";
            this.syncbutton.UseVisualStyleBackColor = true;
            this.syncbutton.Click += new System.EventHandler(this.syncbutton_Click);
            // 
            // syncnowlabel
            // 
            this.syncnowlabel.AutoSize = true;
            this.syncnowlabel.Location = new System.Drawing.Point(130, 409);
            this.syncnowlabel.Name = "syncnowlabel";
            this.syncnowlabel.Size = new System.Drawing.Size(0, 25);
            this.syncnowlabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.syncnowlabel);
            this.Controls.Add(this.syncbutton);
            this.Controls.Add(this.folder2label);
            this.Controls.Add(this.folder2button);
            this.Controls.Add(this.folder1label);
            this.Controls.Add(this.folder1button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileSync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button folder1button;
        private System.Windows.Forms.Label folder1label;
        private System.Windows.Forms.Button folder2button;
        private System.Windows.Forms.Label folder2label;
        private System.Windows.Forms.Button syncbutton;
        private System.Windows.Forms.Label syncnowlabel;
    }
}