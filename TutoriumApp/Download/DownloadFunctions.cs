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
using System.Reflection;

namespace TutoriumApp.Download
{
    public class DownloadFunctions
    {
        private static int _answersCount = 0;

        public static bool DownloadAnswersCount()
        {
            const string filename = "questions_count.txt";

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
                _answersCount = Int32.Parse(reader.ReadToEnd());

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim Auslesen der Anzahl der Antwortmöglichkeiten!", "Fehler 221220211022", MessageBoxButtons.OK);
                return false;
            }
        }

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
                string[] onlineAbstimmungWithSpace = reader.ReadToEnd().Split(',');
                var onlineAbstimmung = onlineAbstimmungWithSpace.Take(onlineAbstimmungWithSpace.Length - 1).ToArray();

                // initialize pollList
                PollResultList pollResultList = new PollResultList();

                for (int i = 0; i < _answersCount; i++)
                {
                    pollResultList.abstimmung.Add(0);
                    pollResultList.abstimmungProzent.Add(0);
                }

                double totalAnswersGiven = 0;


                foreach (var abstimmung in onlineAbstimmung)
                {
                    if (!string.IsNullOrWhiteSpace(abstimmung))
                    {
                        totalAnswersGiven += 1;
                        pollResultList.abstimmung[Int32.Parse(abstimmung) - 1] += 1;
                    }
                }

                // TODO: Anzahl Antworten ausgeben

                // Abstimmungsergebnisse anzeigen
                AbstimmungChart abstimmungChart = new AbstimmungChart();

                PropertyInfo[] properties = typeof(AbstimmungChart).GetProperties();
                var propertiesList = properties.ToList().Take(_answersCount);
                var propertiesListPercent = properties.ToList().Skip(6).Take(_answersCount);

                var j = 0;
                foreach (var property in propertiesList)
                {
                    property.SetValue(abstimmungChart, pollResultList.abstimmung[j]);
                    j++;
                }

                var k = 0;
                foreach(var propertyPercent in propertiesListPercent)
                {
                    propertyPercent.SetValue(abstimmungChart, Math.Round((pollResultList.abstimmung[k] / totalAnswersGiven) * 100, 2));
                    k++;
                }

                abstimmungChart.FillValuesToChart(_answersCount);

                abstimmungChart.Show();

                reader.Close();
                response.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Keine Antworten bislang abgegeben");
            }
        }
    }
}
