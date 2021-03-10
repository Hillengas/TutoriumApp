using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutoriumApp.Delete;
using TutoriumApp.Download;
using TutoriumApp.Show;
using TutoriumApp.Upload;
using Microsoft.VisualBasic;


namespace TutoriumApp
{

    public partial class main_form : Form
    {
        private Bitmap _bitmap;
        List<KeyValuePair<string, Question>> questionKeyValuePairsList = new List<KeyValuePair<string, Question>>();

        public main_form()
        {
            InitializeComponent();

            // panelLeft anpassen
            panelLeft.Height = DownloadButton.Height;
            panelLeft.Top = DownloadButton.Top;


            //Question_Uploaded_RTextBox.Visible = isChecked;
            //Bitmap bitmap = new Bitmap();

        }

        private void button_upload_Click(object sender, EventArgs e)
        {

            Question question = new Question
            {
                Text = newQuestion_richTextBox.Text,
                PictureBitmap = _bitmap
            };

            Question_Upload_Success_Label.Visible = false;
            UploadFunctions.UploadQuestion(question);

            // show success label
            var successLabelThread = new Thread(show_Success_Label);
            successLabelThread.Start();
        }

        /// <summary>
        /// Das Label mit der Information, dass die Frage erfolgreich hochgeladen wurde wird für 3 Sekunden angezeigt.
        /// Gutes Beispiel für Delegates
        /// </summary>
        public void show_Success_Label()
        {
            if (this.Question_Upload_Success_Label.InvokeRequired)
            {
                this.Question_Upload_Success_Label.BeginInvoke((MethodInvoker) delegate()
                {
                    this.Question_Upload_Success_Label.Visible = true;
                });

                Thread.Sleep(3000);

                this.Question_Upload_Success_Label.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.Question_Upload_Success_Label.Visible = false;
                });
            }
            else
            {
                Question_Upload_Success_Label.Visible = true;
                Thread.Sleep(3000);
                Question_Upload_Success_Label.Visible = false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            // panelLeft anpassen
            panelLeft.Height = DownloadButton.Height;
            panelLeft.Top = DownloadButton.Top;

            DownloadFunctions.DownloadQuestion();
        }

        private void Choose_Picture_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Bild Auswahl";
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                Bitmap imageBitmap = new Bitmap(ofd.FileName);
                Bitmap imageBitmapResized = ResizeImage(imageBitmap, 400, 200);
                _bitmap = imageBitmapResized;

                pictureBox1.Image = imageBitmapResized;
            }
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        /// <summary>
        /// Add question to the list of questions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Question_To_Question_List_Button_Click(object sender, EventArgs e)
        {
            Question question = new Question
            {
                Text = newQuestion_richTextBox.Text,
                PictureBitmap = _bitmap
            };

            var questionName = Interaction.InputBox("Name der Frage eintragen.", "Eingabe des Namens", "Frage");

            if (!listBox_Questions.Items.Contains(questionName))
            {
                listBox_Questions.Items.Add(questionName);
                questionKeyValuePairsList.Add(new KeyValuePair<string, Question>(questionName, question));
            }
            else
            {
                MessageBox.Show("Frage mit selbem Namen bereits verfügbar. Bitte anderen Namen wählen.");
            }
                
        }

        /// <summary>
        /// Delete the current online question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Question_Online_Button_Click(object sender, EventArgs e)
        {
            // panelLeft anpassen
            panelLeft.Height = Delete_Question_Online_Button.Height;
            panelLeft.Top = Delete_Question_Online_Button.Top;

            DeleteFunctions.DeleteFile("index.txt");
            DeleteFunctions.DeleteFile("index.jpg");
            DeleteFunctions.DeleteFile("answers.txt");

            // for debugging purposes
            //DeleteFunctions.DeleteFile("index.php");
        }

        private void saveFileDialog_Questions_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void save_Question_List_Click(object sender, EventArgs e)
        {
            // PanelLeft anpassen 
            panelLeft.Height = save_Question_List_Button.Height;
            panelLeft.Top = save_Question_List_Button.Top;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var folderPath = folderBrowserDialog.SelectedPath;

                for (int i = 0; i < listBox_Questions.Items.Count; i++)
                {
                    var questionName = listBox_Questions.Items[i].ToString();
                    var path = Path.Combine(folderPath, questionName);

                    File.WriteAllText(path + ".txt", questionKeyValuePairsList[i].Value.Text);
                    questionKeyValuePairsList[i].Value.PictureBitmap.Save(path + ".bmp");
                }
            }
        }

        /// <summary>
        /// Questions (bestehend aus .txt und .bmp) aus Ordner laden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void load_Question_List_Button_Click(object sender, EventArgs e)
        {
            // panelLeft anpassen
            panelLeft.Height = load_Question_List_Button.Height;
            panelLeft.Top = load_Question_List_Button.Top;

            const int removeTxtExtension = 4;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var folderPath = folderBrowserDialog.SelectedPath;

                DirectoryInfo d = new DirectoryInfo(folderPath);//Assuming Test is your Folder
                FileInfo[] tFileInfos = d.GetFiles("*.txt"); //Getting Text files
                FileInfo[] bitmFileInfos = d.GetFiles("*.bmp"); //Getting Bitmap files

                listBox_Questions.Items.Clear();
                questionKeyValuePairsList.Clear();

                foreach (var tFileInfo in tFileInfos)
                {
                    using (StreamReader sr = File.OpenText(folderPath + @"\" + tFileInfo))
                    {
                        var text = sr.ReadToEnd();
                        var fileName = tFileInfo.ToString();
                        fileName = fileName.Substring(0, fileName.Length - removeTxtExtension);

                        Bitmap imageBitmap = new Bitmap(folderPath + @"\" + fileName + ".bmp");

                        Question question = new Question
                        {
                            Text = text,
                            PictureBitmap = imageBitmap
                        };

                        listBox_Questions.Items.Add(fileName);
                        questionKeyValuePairsList.Add(new KeyValuePair<string, Question>(fileName, question));
                    }
                }
            }
        }

        private void listBox_Questions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Befüllen des Textfeldes und des Bildes im UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_Questions_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_Questions.SelectedItem != null)
            {
                var result = questionKeyValuePairsList.SingleOrDefault
                    (x => x.Key == listBox_Questions.SelectedItem.ToString());

                pictureBox1.Image = result.Value.PictureBitmap;
                _bitmap = result.Value.PictureBitmap;
                newQuestion_richTextBox.Text = result.Value.Text;
            }
        }

        /// <summary>
        /// löscht lokale Liste an Fragen (nur innerhalb der UI)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_Question_List_in_UI_Click(object sender, EventArgs e)
        {
            // panelLeft anpassen
            panelLeft.Height = delete_Question_List_in_UI.Height;
            panelLeft.Top = delete_Question_List_in_UI.Top;

            listBox_Questions.Items.Clear();
        }

        // open homepage at: http://tutorium.bplaced.net/index.php
        private void linkLabel_homepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to a URL.
            System.Diagnostics.Process.Start("http://tutorium.bplaced.net/index.php");
        }

        private void textBox_entered(object sender, EventArgs e)
        {
            if (newQuestion_richTextBox.Text.Equals("Text hier eingeben"))
            {
                newQuestion_richTextBox.Text = String.Empty;
            }
        }

        private void textBox_left(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(newQuestion_richTextBox.Text))
            {
                newQuestion_richTextBox.Text = "Text hier eingeben";
            }
        }
    }
}
