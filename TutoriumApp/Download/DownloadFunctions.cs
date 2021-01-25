using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace TutoriumApp.Download
{
    class DownloadFunctions
    {
        public static void DownloadQuestion()
        {
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://www.tutorium.bplaced.net/index");
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential("tutorium", "kcN9lsyxqcKHRMeJ");

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            MessageBox.Show(reader.ReadToEnd());

            MessageBox.Show($"Download Complete, status {response.StatusDescription}");

            reader.Close();
            response.Close();
        }
    }
}
