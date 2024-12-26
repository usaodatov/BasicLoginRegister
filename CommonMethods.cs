using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicLoginRegister
{
    internal class CommonMethods
    {
        public static string  GetCredentialsFilePath()
        {
            // Define a relative path, like a 'Data' folder in the same location as the executable
            string folderPath = Path.Combine(Application.StartupPath, "Data");

            // Check if the 'Data' directory exists and create it if it doesn't
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Define a file name for the credentials
            string fileName = "userCredentials.xml";

            // Combine the directory path with the filename to get the full path
            return Path.Combine(folderPath, fileName);
        }
    }
}
