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
                PollResultList pollResultList = new PollResultList();

                int pollA = 0;
                int pollB = 0;
                int pollC = 0;
                int pollD = 0;
                int pollE = 0;

                int pollA_percent = 0;
                int pollB_percent = 0;
                int pollC_percent = 0;
                int pollD_percent = 0;
                int pollE_percent = 0;

                pollResultList.abstimmung.Add(pollA);
                pollResultList.abstimmung.Add(pollB);
                pollResultList.abstimmung.Add(pollC);
                pollResultList.abstimmung.Add(pollD);
                pollResultList.abstimmung.Add(pollE);

                pollResultList.abstimmungProzent.Add(pollA_percent);
                pollResultList.abstimmungProzent.Add(pollB_percent);
                pollResultList.abstimmungProzent.Add(pollC_percent);
                pollResultList.abstimmungProzent.Add(pollD_percent);
                pollResultList.abstimmungProzent.Add(pollE_percent);

                double total_answers_given = 0;


                foreach (var abstimmung in onlineAbstimmungen)
                {
                    if (!string.IsNullOrWhiteSpace(abstimmung))
                    {
                        total_answers_given += 1;
                        pollResultList.abstimmung[Int32.Parse(abstimmung) - 1] += 1;
                    }
                }

                // Abstimmungsergebnisse anzeigen
                AbstimmungChart abstimmungChart = new AbstimmungChart();
                abstimmungChart.A = pollResultList.abstimmung[0];
                abstimmungChart.B = pollResultList.abstimmung[1];
                abstimmungChart.C = pollResultList.abstimmung[2];
                abstimmungChart.D = pollResultList.abstimmung[3];
                abstimmungChart.E = pollResultList.abstimmung[4];

                //abstimmungChart
                abstimmungChart.A_p = ((pollResultList.abstimmung[0] / total_answers_given) * 100);
                abstimmungChart.B_p = ((pollResultList.abstimmung[1] / total_answers_given) * 100);
                abstimmungChart.C_p = ((pollResultList.abstimmung[2] / total_answers_given) * 100);
                abstimmungChart.D_p = ((pollResultList.abstimmung[3] / total_answers_given) * 100);
                abstimmungChart.E_p = ((pollResultList.abstimmung[4] / total_answers_given) * 100);


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
