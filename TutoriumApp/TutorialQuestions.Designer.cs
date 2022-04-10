namespace TutoriumApp
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.button_upload = new System.Windows.Forms.Button();
            this.newQuestion_richTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Choose_Picture_Button = new System.Windows.Forms.Button();
            this.Add_Question_To_Question_List_Button = new System.Windows.Forms.Button();
            this.Delete_Question_Online_Button = new System.Windows.Forms.Button();
            this.Question_Upload_Success_Label = new System.Windows.Forms.Label();
            this.saveFileDialog_Questions = new System.Windows.Forms.SaveFileDialog();
            this.save_Question_List_Button = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox_Questions = new System.Windows.Forms.ListBox();
            this.load_Question_List_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delete_Question_List_in_UI = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel_homepage = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.Question_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_upload
            // 
            this.button_upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_upload.Location = new System.Drawing.Point(882, 299);
            this.button_upload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(255, 63);
            this.button_upload.TabIndex = 0;
            this.button_upload.Text = "Frage hochladen";
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // newQuestion_richTextBox
            // 
            this.newQuestion_richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.newQuestion_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newQuestion_richTextBox.ForeColor = System.Drawing.Color.White;
            this.newQuestion_richTextBox.Location = new System.Drawing.Point(308, 90);
            this.newQuestion_richTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newQuestion_richTextBox.Name = "newQuestion_richTextBox";
            this.newQuestion_richTextBox.Size = new System.Drawing.Size(384, 199);
            this.newQuestion_richTextBox.TabIndex = 1;
            this.newQuestion_richTextBox.Text = "Text hier eingeben";
            this.newQuestion_richTextBox.Enter += new System.EventHandler(this.textBox_entered);
            this.newQuestion_richTextBox.Leave += new System.EventHandler(this.textBox_left);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frage in Textform hier eingeben";
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(1094, 452);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 28);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Beenden";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownloadButton.FlatAppearance.BorderSize = 0;
            this.DownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadButton.ForeColor = System.Drawing.Color.White;
            this.DownloadButton.Image = ((System.Drawing.Image)(resources.GetObject("DownloadButton.Image")));
            this.DownloadButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DownloadButton.Location = new System.Drawing.Point(0, 145);
            this.DownloadButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(261, 77);
            this.DownloadButton.TabIndex = 4;
            this.DownloadButton.Text = "Abstimmungsergebnis herunterladen";
            this.DownloadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(753, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 199);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Choose_Picture_Button
            // 
            this.Choose_Picture_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Choose_Picture_Button.FlatAppearance.BorderSize = 0;
            this.Choose_Picture_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choose_Picture_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose_Picture_Button.ForeColor = System.Drawing.Color.White;
            this.Choose_Picture_Button.Image = ((System.Drawing.Image)(resources.GetObject("Choose_Picture_Button.Image")));
            this.Choose_Picture_Button.Location = new System.Drawing.Point(819, 14);
            this.Choose_Picture_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Choose_Picture_Button.Name = "Choose_Picture_Button";
            this.Choose_Picture_Button.Size = new System.Drawing.Size(260, 71);
            this.Choose_Picture_Button.TabIndex = 7;
            this.Choose_Picture_Button.Text = "Bild laden";
            this.Choose_Picture_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Choose_Picture_Button.UseVisualStyleBackColor = true;
            this.Choose_Picture_Button.Click += new System.EventHandler(this.Choose_Picture_Button_Click);
            // 
            // Add_Question_To_Question_List_Button
            // 
            this.Add_Question_To_Question_List_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Question_To_Question_List_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Question_To_Question_List_Button.Location = new System.Drawing.Point(663, 299);
            this.Add_Question_To_Question_List_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_Question_To_Question_List_Button.Name = "Add_Question_To_Question_List_Button";
            this.Add_Question_To_Question_List_Button.Size = new System.Drawing.Size(211, 63);
            this.Add_Question_To_Question_List_Button.TabIndex = 8;
            this.Add_Question_To_Question_List_Button.Text = "Frage in Liste speichern";
            this.Add_Question_To_Question_List_Button.UseVisualStyleBackColor = true;
            this.Add_Question_To_Question_List_Button.Click += new System.EventHandler(this.Add_Question_To_Question_List_Button_Click);
            // 
            // Delete_Question_Online_Button
            // 
            this.Delete_Question_Online_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_Question_Online_Button.FlatAppearance.BorderSize = 0;
            this.Delete_Question_Online_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Question_Online_Button.ForeColor = System.Drawing.Color.White;
            this.Delete_Question_Online_Button.Image = ((System.Drawing.Image)(resources.GetObject("Delete_Question_Online_Button.Image")));
            this.Delete_Question_Online_Button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Delete_Question_Online_Button.Location = new System.Drawing.Point(0, 232);
            this.Delete_Question_Online_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete_Question_Online_Button.Name = "Delete_Question_Online_Button";
            this.Delete_Question_Online_Button.Size = new System.Drawing.Size(261, 85);
            this.Delete_Question_Online_Button.TabIndex = 9;
            this.Delete_Question_Online_Button.Text = "Online Frage löschen";
            this.Delete_Question_Online_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Delete_Question_Online_Button.UseVisualStyleBackColor = true;
            this.Delete_Question_Online_Button.Click += new System.EventHandler(this.Delete_Question_Online_Button_Click);
            // 
            // Question_Upload_Success_Label
            // 
            this.Question_Upload_Success_Label.AutoSize = true;
            this.Question_Upload_Success_Label.Location = new System.Drawing.Point(886, 367);
            this.Question_Upload_Success_Label.Name = "Question_Upload_Success_Label";
            this.Question_Upload_Success_Label.Size = new System.Drawing.Size(251, 21);
            this.Question_Upload_Success_Label.TabIndex = 10;
            this.Question_Upload_Success_Label.Text = "Frage erfolgreich hochgeladen";
            this.Question_Upload_Success_Label.Visible = false;
            // 
            // saveFileDialog_Questions
            // 
            this.saveFileDialog_Questions.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_Questions_FileOk);
            // 
            // save_Question_List_Button
            // 
            this.save_Question_List_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_Question_List_Button.FlatAppearance.BorderSize = 0;
            this.save_Question_List_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_Question_List_Button.ForeColor = System.Drawing.Color.White;
            this.save_Question_List_Button.Image = ((System.Drawing.Image)(resources.GetObject("save_Question_List_Button.Image")));
            this.save_Question_List_Button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.save_Question_List_Button.Location = new System.Drawing.Point(-3, 646);
            this.save_Question_List_Button.Name = "save_Question_List_Button";
            this.save_Question_List_Button.Size = new System.Drawing.Size(261, 78);
            this.save_Question_List_Button.TabIndex = 12;
            this.save_Question_List_Button.Text = "Liste Speichern";
            this.save_Question_List_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.save_Question_List_Button.UseVisualStyleBackColor = true;
            this.save_Question_List_Button.Click += new System.EventHandler(this.save_Question_List_Click);
            // 
            // listBox_Questions
            // 
            this.listBox_Questions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.listBox_Questions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Questions.ForeColor = System.Drawing.Color.White;
            this.listBox_Questions.FormattingEnabled = true;
            this.listBox_Questions.ItemHeight = 21;
            this.listBox_Questions.Location = new System.Drawing.Point(17, 4);
            this.listBox_Questions.Name = "listBox_Questions";
            this.listBox_Questions.Size = new System.Drawing.Size(911, 231);
            this.listBox_Questions.TabIndex = 13;
            this.listBox_Questions.SelectedIndexChanged += new System.EventHandler(this.listBox_Questions_SelectedIndexChanged);
            this.listBox_Questions.DoubleClick += new System.EventHandler(this.listBox_Questions_DoubleClick);
            // 
            // load_Question_List_Button
            // 
            this.load_Question_List_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load_Question_List_Button.FlatAppearance.BorderSize = 0;
            this.load_Question_List_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_Question_List_Button.ForeColor = System.Drawing.Color.White;
            this.load_Question_List_Button.Image = ((System.Drawing.Image)(resources.GetObject("load_Question_List_Button.Image")));
            this.load_Question_List_Button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.load_Question_List_Button.Location = new System.Drawing.Point(3, 464);
            this.load_Question_List_Button.Name = "load_Question_List_Button";
            this.load_Question_List_Button.Size = new System.Drawing.Size(258, 85);
            this.load_Question_List_Button.TabIndex = 14;
            this.load_Question_List_Button.Text = "Liste Laden";
            this.load_Question_List_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.load_Question_List_Button.UseVisualStyleBackColor = true;
            this.load_Question_List_Button.Click += new System.EventHandler(this.load_Question_List_Button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delete_Question_List_in_UI);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.load_Question_List_Button);
            this.panel1.Controls.Add(this.save_Question_List_Button);
            this.panel1.Controls.Add(this.Delete_Question_Online_Button);
            this.panel1.Controls.Add(this.DownloadButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 727);
            this.panel1.TabIndex = 15;
            // 
            // delete_Question_List_in_UI
            // 
            this.delete_Question_List_in_UI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_Question_List_in_UI.FlatAppearance.BorderSize = 0;
            this.delete_Question_List_in_UI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_Question_List_in_UI.ForeColor = System.Drawing.Color.White;
            this.delete_Question_List_in_UI.Image = ((System.Drawing.Image)(resources.GetObject("delete_Question_List_in_UI.Image")));
            this.delete_Question_List_in_UI.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delete_Question_List_in_UI.Location = new System.Drawing.Point(3, 555);
            this.delete_Question_List_in_UI.Name = "delete_Question_List_in_UI";
            this.delete_Question_List_in_UI.Size = new System.Drawing.Size(258, 85);
            this.delete_Question_List_in_UI.TabIndex = 15;
            this.delete_Question_List_in_UI.Text = "Liste Löschen";
            this.delete_Question_List_in_UI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.delete_Question_List_in_UI.UseVisualStyleBackColor = true;
            this.delete_Question_List_in_UI.Click += new System.EventHandler(this.delete_Question_List_in_UI_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.linkLabel_homepage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 135);
            this.panel3.TabIndex = 0;
            // 
            // linkLabel_homepage
            // 
            this.linkLabel_homepage.AutoSize = true;
            this.linkLabel_homepage.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_homepage.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_homepage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.linkLabel_homepage.Location = new System.Drawing.Point(44, 47);
            this.linkLabel_homepage.Name = "linkLabel_homepage";
            this.linkLabel_homepage.Size = new System.Drawing.Size(157, 38);
            this.linkLabel_homepage.TabIndex = 0;
            this.linkLabel_homepage.TabStop = true;
            this.linkLabel_homepage.Text = "Startseite";
            this.linkLabel_homepage.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.linkLabel_homepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_homepage_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox_Questions);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(261, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 239);
            this.panel2.TabIndex = 16;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(70)))));
            this.panelLeft.Location = new System.Drawing.Point(261, 145);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(10, 100);
            this.panelLeft.TabIndex = 17;
            // 
            // Question_Label
            // 
            this.Question_Label.AutoSize = true;
            this.Question_Label.Location = new System.Drawing.Point(274, 464);
            this.Question_Label.Name = "Question_Label";
            this.Question_Label.Size = new System.Drawing.Size(375, 21);
            this.Question_Label.TabIndex = 19;
            this.Question_Label.Text = "Liste aktueller Fragen (Doppelklick zur Auswahl)";
            // 
            // main_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1202, 727);
            this.Controls.Add(this.Question_Label);
            this.Controls.Add(this.Add_Question_To_Question_List_Button);
            this.Controls.Add(this.Choose_Picture_Button);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Question_Upload_Success_Label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newQuestion_richTextBox);
            this.Controls.Add(this.button_upload);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main_form";
            this.Text = "Tutorium Fragen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.RichTextBox newQuestion_richTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Choose_Picture_Button;
        private System.Windows.Forms.Button Add_Question_To_Question_List_Button;
        private System.Windows.Forms.Button Delete_Question_Online_Button;
        private System.Windows.Forms.Label Question_Upload_Success_Label;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Questions;
        private System.Windows.Forms.Button save_Question_List_Button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ListBox listBox_Questions;
        private System.Windows.Forms.Button load_Question_List_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label Question_Label;
        private System.Windows.Forms.Button delete_Question_List_in_UI;
        private System.Windows.Forms.LinkLabel linkLabel_homepage;
    }
}

