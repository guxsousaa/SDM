using log4net;
using log4net.Appender;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace SDM.Methods
{
    internal class LogHelper
    {
        private static string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SDM\\Logs\\";
        private static string MARK = "\n=============================================\n";

        public static void doLog(string msg, string ERROR_CODE)
        {
            //  Get current day and time
            DateTime today = DateTime.Today;
            string Date = today.ToString("dd-MM-yyyy");
            string Time = MARK + string.Format("{0:HH:mm:ss tt}", DateTime.Now) + " - IP: " + NetworkHelper.GetLocalIPAddress() + "\n";

            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SDM\\Logs"));

            StringBuilder sb = new StringBuilder();
            sb.Append(Time);
            sb.Append("User: " + Environment.UserName);
            sb.Append(msg);

            if(ERROR_CODE != null)
                sb.Append("\nError code: " + ERROR_CODE);
            sb.Append(MARK);

            // flush every 20 seconds as you do it
            File.AppendAllText(filePath + Date + ".log", sb.ToString());

            sb.Clear();
        }
    }
}
