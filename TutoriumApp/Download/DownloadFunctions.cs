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
            const string filename = "answers.txt";

            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://www.tutorium.bplaced.net/" + filename);
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential("tutorium_23", "4BWhRhAEJyKTcNbv");

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            //var fileContents = Encoding.UTF8.GetBytes(reader.ReadToEnd());
            string[] onlineAbstimmungen = reader.ReadToEnd().Split(',');

            foreach (var abstimmung in onlineAbstimmungen)
            {
                if (!string.IsNullOrWhiteSpace(abstimmung))
                {
                    MessageBox.Show(abstimmung);
                    var original = chart1.Series.Add("Original");
                    var modified = chart1.Series.Add("Modified");
                    chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                    chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
                    chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                    chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;

                    original.Points.AddXY("CPU", 7.6);
                    modified.Points.AddXY("CPU", 1.6);
                }
                
            }


            //MessageBox.Show(reader.ReadToEnd());

            //MessageBox.Show($"Download Complete, status {response.StatusDescription}");

            reader.Close();
            response.Close();
        }


    }
}
