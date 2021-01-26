using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutoriumApp.Delete
{

    class DeleteFunctions
    {
        public static void DeleteFile(string fileName)
        {

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://www.tutorium.bplaced.net/" + fileName);
            request.Method = WebRequestMethods.Ftp.DeleteFile;
            request.Credentials = new NetworkCredential("tutorium_23", "4BWhRhAEJyKTcNbv");

            try
            {
                using (FtpWebResponse response = (FtpWebResponse) request.GetResponse())
                {
                    // zeige Textfeld "erfolgreich gelöscht"

                }
            }
            catch (Exception exception)
            {
                var exceptionHandler = Directory.GetCurrentDirectory() + "/ExceptionHandler.txt";
                if (!File.Exists(exceptionHandler))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(exceptionHandler))
                    {
                        sw.WriteLine("DeleteFunctions.cs - 161625012021: No \"answers.txt\" was found online to be deleted. " + exception);
                    }
                }
            }
            
        }
    }
}
