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
using MySqlConnector;

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

        public static async void DownloadQuestion()
        {
            try
            {
                var builder = new MySqlConnectionStringBuilder
                {
                    Server = "www.tutorium.bplaced.net",
                    Database = "tutorium_mysql",
                    UserID = "tutorium",
                    Password = "94PvHewwWZ8Mqj5t",
                    Port = 3306,
                };

                var tupleAnswerAnzahList = new List<(int answerID, int anzahl)>();
                var numberOfAnswers = 0;

                using (var conn = new MySqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("Opening connection");
                    await conn.OpenAsync();

                    using (var command = conn.CreateCommand())
                    {
                        command.CommandText = "SELECT answerID, COUNT(*) AS anzahl FROM `Answers` AS A GROUP BY A.answerID ORDER BY answerID;";
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                tupleAnswerAnzahList.Add((reader.GetInt32(0), reader.GetInt32(1)));
                            }
                        }

                        command.CommandText = "SELECT MAX(id) FROM Questions;";
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            await reader.ReadAsync();
                            numberOfAnswers = reader.GetInt32(0);
                        }
                    }

                    // connection will be closed by the 'using' block
                    Console.WriteLine("Closing connection");
                }

                // initialize pollList
                var pollResultList = new PollResultList();
                double totalAnswersGiven = 0;

                for (int i = 0; i < numberOfAnswers; i++)
                {
                    pollResultList.abstimmung.Add(0);
                    pollResultList.abstimmungProzent.Add(0);
                }

                foreach (var answerAnzahlTuple in tupleAnswerAnzahList)
                {
                    totalAnswersGiven += answerAnzahlTuple.anzahl;
                    pollResultList.abstimmung[answerAnzahlTuple.answerID - 1] = answerAnzahlTuple.anzahl;
                }

                // TODO: Anzahl Antworten ausgeben

                // AbstimmungsChart mit Werten belegen und anzeigen
                var abstimmungChart = new AbstimmungChart();

                var properties = typeof(AbstimmungChart).GetProperties();
                var propertiesList = properties.ToList().Take(_answersCount);
                var propertiesListPercent = properties.ToList().Skip(6).Take(_answersCount);

                var j = 0;
                foreach (var property in propertiesList)
                {
                    property.SetValue(abstimmungChart, pollResultList.abstimmung[j]);
                    j++;
                }

                var k = 0;
                foreach (var propertyPercent in propertiesListPercent)
                {
                    propertyPercent.SetValue(abstimmungChart, Math.Round((pollResultList.abstimmung[k] / totalAnswersGiven) * 100, 2));
                    k++;
                }

                abstimmungChart.FillValuesToChart(_answersCount);

                abstimmungChart.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show("Keine Antworten bislang abgegeben");
            }
        }
    }
}
