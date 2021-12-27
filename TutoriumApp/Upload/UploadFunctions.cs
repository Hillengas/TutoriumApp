using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutoriumApp.Delete;
using TutoriumApp.Upload;

namespace TutoriumApp.Upload
{
    class UploadFunctions
    {
        public static void UploadQuestion(Question question)
        {
            // Get the object used to communicate with the server.
            const string answersTxt = "answers.txt";

            // delete answers file
            DeleteFunctions.DeleteFile(answersTxt);

            // upload 
            UploadQuestionToDb(question.Text);
            UploadPicture(question.PictureBitmap);
            UploadTitle(question.Title);
            UploadText(question.Text);

            //HtmlUploadAbstimmungDone();
            //HtmlUpload();

            // 4BWhRhAEJyKTcNbv <- Passwort tutorium_23
            // kcN9lsyxqcKHRMeJ <- Tutorium Passwort
        }

        private static async void UploadQuestionToDb(string questionString)
        {
            var questions = questionString.Split('-').ToList();
            questions.RemoveAt(0);

            // upload to DB
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "www.tutorium.bplaced.net",
                Database = "tutorium_mysql",
                UserID = "tutorium",
                Password = "94PvHewwWZ8Mqj5t",
                Port = 3306,
            };

            using (var conn = new MySqlConnection(builder.ConnectionString))
            {
                Console.WriteLine("Opening Connection");
                await conn.OpenAsync();

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = "DELETE FROM Questions;";
                    await command.ExecuteNonQueryAsync();
                    command.CommandText = "DELETE FROM Answers;";
                    await command.ExecuteNonQueryAsync();
                    Console.WriteLine("Finished dropping old information");

                    command.CommandText = "ALTER TABLE Questions AUTO_INCREMENT = 1;";
                    await command.ExecuteNonQueryAsync();
                    Console.WriteLine("auto_increment reset to 1");

                    string commandText = "";
                    commandText += "INSERT INTO Questions (name) VALUES ";
                    questions.ForEach(question => commandText += $"(\"{question}\"),");

                    // remove comma
                    commandText = commandText.Remove(commandText.Length - 1);

                    commandText += ";";

                    command.CommandText = commandText;
                    int rowCount = await command.ExecuteNonQueryAsync();
                    Console.WriteLine(String.Format("Number of rows inserted={0}", rowCount));
                }

                // connection will be closed by the 'using' block
                Console.WriteLine("Closing connection");
            }
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

            byte[] fileContentsHtml = File.ReadAllBytes("C:/Users/Alex/Desktop/TutoriumApp/Zusatz/HTML_Request.php");

            requestHTML.ContentLength = fileContentsHtml.Length;

            using (Stream requestStream = requestHTML.GetRequestStream())
            {
                requestStream.Write(fileContentsHtml, 0, fileContentsHtml.Length);
            }

            /*
            requestHTML = (FtpWebRequest)WebRequest.Create("ftp://www.tutorium.bplaced.net/index.html");

            requestHTML.UseBinary = true;
            requestHTML.UsePassive = true;
            requestHTML.KeepAlive = true;

            requestHTML.Method = WebRequestMethods.Ftp.UploadFile;

            requestHTML.Credentials = new NetworkCredential("tutorium_23", "4BWhRhAEJyKTcNbv");

            fileContentsHtml = File.ReadAllBytes("C:/Users/Alex/Desktop/TutoriumApp/Zusatz/HTML_Request.html");

            requestHTML.ContentLength = fileContentsHtml.Length;

            using (Stream requestStream = requestHTML.GetRequestStream())
            {
                requestStream.Write(fileContentsHtml, 0, fileContentsHtml.Length);
            }*/
        }

        /// <summary>
        /// Upload the HTML information for
        /// "http://tutorium.bplaced.net/index.php"
        /// </summary>
        private static void HtmlUploadAbstimmungDone()
        {
            var requestHTML = (FtpWebRequest)WebRequest.Create("ftp://www.tutorium.bplaced.net/abstimmung.php");

            requestHTML.UseBinary = true;
            requestHTML.UsePassive = true;
            requestHTML.KeepAlive = true;

            requestHTML.Method = WebRequestMethods.Ftp.UploadFile;

            requestHTML.Credentials = new NetworkCredential("tutorium_23", "4BWhRhAEJyKTcNbv");

            byte[] fileContentsHtml = File.ReadAllBytes("C:/Users/Alex/Desktop/TutoriumApp/Zusatz/abstimmung_done.php");

            requestHTML.ContentLength = fileContentsHtml.Length;

            using (Stream requestStream = requestHTML.GetRequestStream())
            {
                requestStream.Write(fileContentsHtml, 0, fileContentsHtml.Length);
            }

            /*
            requestHTML = (FtpWebRequest)WebRequest.Create("ftp://www.tutorium.bplaced.net/index.html");

            requestHTML.UseBinary = true;
            requestHTML.UsePassive = true;
            requestHTML.KeepAlive = true;

            requestHTML.Method = WebRequestMethods.Ftp.UploadFile;

            requestHTML.Credentials = new NetworkCredential("tutorium_23", "4BWhRhAEJyKTcNbv");

            fileContentsHtml = File.ReadAllBytes("C:/Users/Alex/Desktop/TutoriumApp/Zusatz/HTML_Request.html");

            requestHTML.ContentLength = fileContentsHtml.Length;

            using (Stream requestStream = requestHTML.GetRequestStream())
            {
                requestStream.Write(fileContentsHtml, 0, fileContentsHtml.Length);
            }*/
        }


        /// <summary>
        /// Upload the text information for
        /// "http://tutorium.bplaced.net/question_title.txt"
        /// </summary>
        /// <param name="title"></param>
        private static void UploadTitle(string title)
        {
            var requestText = (FtpWebRequest) WebRequest.Create("ftp://www.tutorium.bplaced.net/question_title.txt");

            requestText.UseBinary = true;
            requestText.UsePassive = true;
            requestText.KeepAlive = true;

            requestText.Method = WebRequestMethods.Ftp.UploadFile;

            requestText.Credentials = new NetworkCredential("tutorium_23", "4BWhRhAEJyKTcNbv");

            byte[] fileContentsText = Encoding.ASCII.GetBytes(title);

            requestText.ContentLength = fileContentsText.Length;

            // upload
            using (Stream requestStream = requestText.GetRequestStream())
            {
                requestStream.Write(fileContentsText, 0, fileContentsText.Length);
            }
        }

        /// <summary>
        /// Upload the text information for
        /// "http://tutorium.bplaced.net/question_text.txt"
        /// </summary>
        /// <param name="text"></param>
        private static void UploadText(string text)
        {
            var requestText = (FtpWebRequest)WebRequest.Create("ftp://www.tutorium.bplaced.net/question_text.txt");

            requestText.UseBinary = true;
            requestText.UsePassive = true;
            requestText.KeepAlive = true;

            requestText.Method = WebRequestMethods.Ftp.UploadFile;

            requestText.Credentials = new NetworkCredential("tutorium_23", "4BWhRhAEJyKTcNbv");

            byte[] fileContentsText = Encoding.ASCII.GetBytes(text);

            requestText.ContentLength = fileContentsText.Length;

            // upload
            using (Stream requestStream = requestText.GetRequestStream())
            {
                requestStream.Write(fileContentsText, 0, fileContentsText.Length);
            }
        }

        /// <summary>
        /// Upload the picture information for
        /// "http://tutorium.bplaced.net/question_picture.jpg"
        /// </summary>
        private static void UploadPicture(Bitmap bitmap)
        {
            var requestPicture = (FtpWebRequest) WebRequest.Create("ftp://www.tutorium.bplaced.net/question_picture.jpg");

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
