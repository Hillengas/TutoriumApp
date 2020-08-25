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
            this.SuspendLayout();
            // 
            // button_upload
            // 
            this.button_upload.Location = new System.Drawing.Point(643, 453);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(97, 23);
            this.button_upload.TabIndex = 0;
            this.button_upload.Text = "Frage hochladen";
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // newQuestion_richTextBox
            // 
            this.newQuestion_richTextBox.Location = new System.Drawing.Point(12, 116);
            this.newQuestion_richTextBox.Name = "newQuestion_richTextBox";
            this.newQuestion_richTextBox.Size = new System.Drawing.Size(831, 93);
            this.newQuestion_richTextBox.TabIndex = 1;
            this.newQuestion_richTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frage in Textform hier eingeben";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(746, 453);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(97, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Abbruch";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 488);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newQuestion_richTextBox);
            this.Controls.Add(this.button_upload);
            this.Name = "main_form";
            this.Text = "Tutorium_Fragen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.RichTextBox newQuestion_richTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
    }
}

