using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutoriumApp.Upload
{
    class UploadFunctions
    {
        public static void UploadQuestion(Question question)
        {
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://www.tutorium.bplaced.net/index");

            request.UseBinary = true;
            request.UsePassive = true;
            request.KeepAlive = true;

            request.Method = WebRequestMethods.Ftp.UploadFile;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential("tutorium", "kcN9lsyxqcKHRMeJ"); 

            // Copy the contents of the file to the request stream.
            byte[] fileContents;

            using (StreamReader sourceStream = new StreamReader("C:/Users/Alex/Desktop/wallpaper/bigsur.jpeg"))
            {
                fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            }

            request.ContentLength = fileContents.Length;

            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(fileContents, 0, fileContents.Length);
            }

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                MessageBox.Show($"Upload File Complete, status {response.StatusDescription}");
            }
        }
    }
}
