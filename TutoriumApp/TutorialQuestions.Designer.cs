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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_upload
            // 
            this.button_upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_upload.Location = new System.Drawing.Point(964, 697);
            this.button_upload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(146, 35);
            this.button_upload.TabIndex = 0;
            this.button_upload.Text = "Frage hochladen";
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // newQuestion_richTextBox
            // 
            this.newQuestion_richTextBox.BackColor = System.Drawing.Color.White;
            this.newQuestion_richTextBox.Location = new System.Drawing.Point(63, 78);
            this.newQuestion_richTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newQuestion_richTextBox.Name = "newQuestion_richTextBox";
            this.newQuestion_richTextBox.Size = new System.Drawing.Size(493, 306);
            this.newQuestion_richTextBox.TabIndex = 1;
            this.newQuestion_richTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frage in Textform hier eingeben";
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Location = new System.Drawing.Point(1119, 697);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(146, 35);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Abbruch";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownloadButton.Location = new System.Drawing.Point(758, 697);
            this.DownloadButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(198, 35);
            this.DownloadButton.TabIndex = 4;
            this.DownloadButton.Text = "Ergebnis herunterladen";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TutoriumApp.Properties.Resources.Choose_picture2;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(622, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 308);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Choose_Picture_Button
            // 
            this.Choose_Picture_Button.BackColor = System.Drawing.Color.Transparent;
            this.Choose_Picture_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Choose_Picture_Button.Location = new System.Drawing.Point(878, 38);
            this.Choose_Picture_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Choose_Picture_Button.Name = "Choose_Picture_Button";
            this.Choose_Picture_Button.Size = new System.Drawing.Size(112, 35);
            this.Choose_Picture_Button.TabIndex = 7;
            this.Choose_Picture_Button.Text = "Bild wählen";
            this.Choose_Picture_Button.UseVisualStyleBackColor = false;
            this.Choose_Picture_Button.Click += new System.EventHandler(this.Choose_Picture_Button_Click);
            // 
            // Add_Question_To_Question_List_Button
            // 
            this.Add_Question_To_Question_List_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Question_To_Question_List_Button.Location = new System.Drawing.Point(1029, 400);
            this.Add_Question_To_Question_List_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_Question_To_Question_List_Button.Name = "Add_Question_To_Question_List_Button";
            this.Add_Question_To_Question_List_Button.Size = new System.Drawing.Size(194, 35);
            this.Add_Question_To_Question_List_Button.TabIndex = 8;
            this.Add_Question_To_Question_List_Button.Text = "Frage in Liste speichern";
            this.Add_Question_To_Question_List_Button.UseVisualStyleBackColor = true;
            this.Add_Question_To_Question_List_Button.Click += new System.EventHandler(this.Add_Question_To_Question_List_Button_Click);
            // 
            // Delete_Question_Online_Button
            // 
            this.Delete_Question_Online_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_Question_Online_Button.Location = new System.Drawing.Point(844, 400);
            this.Delete_Question_Online_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete_Question_Online_Button.Name = "Delete_Question_Online_Button";
            this.Delete_Question_Online_Button.Size = new System.Drawing.Size(176, 35);
            this.Delete_Question_Online_Button.TabIndex = 9;
            this.Delete_Question_Online_Button.Text = "Online Frage löschen";
            this.Delete_Question_Online_Button.UseVisualStyleBackColor = true;
            this.Delete_Question_Online_Button.Click += new System.EventHandler(this.Delete_Question_Online_Button_Click);
            // 
            // Question_Upload_Success_Label
            // 
            this.Question_Upload_Success_Label.AutoSize = true;
            this.Question_Upload_Success_Label.Location = new System.Drawing.Point(1040, 672);
            this.Question_Upload_Success_Label.Name = "Question_Upload_Success_Label";
            this.Question_Upload_Success_Label.Size = new System.Drawing.Size(225, 20);
            this.Question_Upload_Success_Label.TabIndex = 10;
            this.Question_Upload_Success_Label.Text = "Frage erfolgreich hochgeladen";
            this.Question_Upload_Success_Label.Visible = false;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 751);
            this.Controls.Add(this.Question_Upload_Success_Label);
            this.Controls.Add(this.Delete_Question_Online_Button);
            this.Controls.Add(this.Add_Question_To_Question_List_Button);
            this.Controls.Add(this.Choose_Picture_Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newQuestion_richTextBox);
            this.Controls.Add(this.button_upload);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main_form";
            this.Text = "Tutorium_Fragen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

