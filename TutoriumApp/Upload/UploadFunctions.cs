using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutoriumApp.Delete;
using TutoriumApp.Upload;

namespace TutoriumApp.Upload
{
    class UploadFunctions
    {
        public static void UploadQuestion(Question question, Bitmap bitmap)
        {
            // Get the object used to communicate with the server.
            const string filename = "answers.txt";

            // delete answers file
            DeleteFunctions.DeleteFile(filename);
            UploadPicture(bitmap);
            UploadText(question);
            HtmlUpload();



            // 4BWhRhAEJyKTcNbv <- PAsswort tutorium_23
            // kcN9lsyxqcKHRMeJ <- Tutorium Passwort
        }


        /// <summary>
        /// Upload the HTML information for
        /// "http://tutorium.bplaced.net/index.php"
        /// </summary>
        private static void HtmlUpload()
        {
            var requestHTML = (FtpWebRequest) WebRequest.Create("ftp://www.tutorium.bplaced.net/index.php");

            requestHTML.UseBinary = true;
            requestHTML.UsePassive = true;
            requestHTML.KeepAlive = true;

            requestHTML.Method = WebRequestMethods.Ftp.UploadFile;

            requestHTML.Credentials = new NetworkCredential("tutorium_23", "4BWhRhAEJyKTcNbv");

            byte[] fileContentsHtml = File.ReadAllBytes("C:/Users/Alex/Desktop/TutoriumApp/Zusatz/PHP_Request.php");

            requestHTML.ContentLength = fileContentsHtml.Length;

            using (Stream requestStream = requestHTML.GetRequestStream())
            {
                requestStream.Write(fileContentsHtml, 0, fileContentsHtml.Length);
            }
        }


        /// <summary>
        /// Upload the text information for
        /// "http://tutorium.bplaced.net/index.txt"
        /// </summary>
        /// <param name="question"></param>
        private static void UploadText(Question question)
        {
            var requestText = (FtpWebRequest) WebRequest.Create("ftp://www.tutorium.bplaced.net/index.txt");

            requestText.UseBinary = true;
            requestText.UsePassive = true;
            requestText.KeepAlive = true;

            requestText.Method = WebRequestMethods.Ftp.UploadFile;

            requestText.Credentials = new NetworkCredential("tutorium_23", "4BWhRhAEJyKTcNbv");

            byte[] fileContentsText = Encoding.ASCII.GetBytes(question.Text);

            requestText.ContentLength = fileContentsText.Length;

            // upload
            using (Stream requestStream = requestText.GetRequestStream())
            {
                requestStream.Write(fileContentsText, 0, fileContentsText.Length);
            }
        }

        /// <summary>
        /// Upload the picture information for
        /// "http://tutorium.bplaced.net/index.jpg"
        /// </summary>
        private static void UploadPicture(Bitmap bitmap)
        {
            var requestPicture = (FtpWebRequest) WebRequest.Create("ftp://www.tutorium.bplaced.net/index.jpg");

            requestPicture.UseBinary = true;
            requestPicture.UsePassive = true;
            requestPicture.KeepAlive = true;

            requestPicture.Method = WebRequestMethods.Ftp.UploadFile;

            requestPicture.Credentials = new NetworkCredential("tutorium_23", "4BWhRhAEJyKTcNbv");

            //byte[] fileContentsPicture = File.ReadAllBytes(imagePath);

            byte[] fileContentsPicture = ImageToByte(bitmap);

            requestPicture.ContentLength = fileContentsPicture.Length;

            using (Stream requestStream = requestPicture.GetRequestStream())
            {
                requestStream.Write(fileContentsPicture, 0, fileContentsPicture.Length);
            }
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}
