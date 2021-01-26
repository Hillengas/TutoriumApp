using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
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
        private Bitmap _bitmap;

        public main_form()
        {
            InitializeComponent();
            //Bitmap bitmap = new Bitmap();
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            Question question = new Question
            {
                Text = newQuestion_richTextBox.Text
            };

            UploadFunctions.UploadQuestion(question, _bitmap);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
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

        }

        /// <summary>
        /// Delete the current online question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Question_Online_Button_Click(object sender, EventArgs e)
        {
            DeleteFunctions.DeleteFile("index.txt");
            DeleteFunctions.DeleteFile("index.jpg");
        }
    }
}
