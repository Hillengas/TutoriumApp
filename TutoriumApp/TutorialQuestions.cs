using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutoriumApp.Delete;
using TutoriumApp.Download;
using TutoriumApp.Show;
using TutoriumApp.Upload;

namespace TutoriumApp
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            Question question = new Question
            {
                Text = newQuestion_richTextBox.Text
            };

            UploadFunctions.UploadQuestion(question);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            DownloadFunctions.DownloadQuestion();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            ShowFunctions.ShowAll();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteFunctions.DeleteFile("macOS light.jpeg");
        }
    }
}
