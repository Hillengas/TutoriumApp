using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Windows.Forms;
using TutoriumApp.Parameter;
using TutoriumApp.Charts;

namespace TutoriumApp.Download
{
    public class DownloadFunctions
    {

        public static void DownloadQuestion()
        {
            const string filename = "answers.txt";

            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://www.tutorium.bplaced.net/" + filename);
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential("tutorium_23", "4BWhRhAEJyKTcNbv");

            try
            {
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);

                //var fileContents = Encoding.UTF8.GetBytes(reader.ReadToEnd());
                string[] onlineAbstimmungen = reader.ReadToEnd().Split(',');

                // initialize pollList
                List<int> pollResultList = new List<int>();

                int pollA = 0;
                int pollB = 0;
                int pollC = 0;
                int pollD = 0;
                int pollE = 0;

                pollResultList.Add(pollA);
                pollResultList.Add(pollB);
                pollResultList.Add(pollC);
                pollResultList.Add(pollD);
                pollResultList.Add(pollE);


                foreach (var abstimmung in onlineAbstimmungen)
                {
                    if (!string.IsNullOrWhiteSpace(abstimmung))
                    {
                        pollResultList[Int32.Parse(abstimmung) - 1] += 1;
                    }
                }

                // Abstimmungsergebnisse anzeigen
                AbstimmungChart abstimmungChart = new AbstimmungChart();
                abstimmungChart.A = pollResultList[0];
                abstimmungChart.B = pollResultList[1];
                abstimmungChart.C = pollResultList[2];
                abstimmungChart.D = pollResultList[3];
                abstimmungChart.E = pollResultList[4];

                abstimmungChart.FillValuesToChart();

                abstimmungChart.Show();

                reader.Close();
                response.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("DownloadFunctions.cs - 250120212000 - Keine Antworten bislang abgegeben" + Environment.NewLine + Environment.NewLine + e);
            }

            

        }


    }
}
