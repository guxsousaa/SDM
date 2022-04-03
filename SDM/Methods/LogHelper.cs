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
    /**
     * 
     *  Copyright (c) 2022 Kauã Vitório
     *  Official repository https://github.com/Kauavitorio/SDM
     *  Responsible developer: https://github.com/Kauavitorio
     *  @author Kaua Vitorio
     *
     */
    internal class LogHelper
    {
        private static string mainPath = AppDomain.CurrentDomain.BaseDirectory + "AppAsset\\";
        private static string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SDM\\Logs\\";
        private static string MARK = "\n=============================================\n";

        public static void doLog(string msg, string ERROR_CODE)
        {
            //  Get current day and time
            DateTime today = DateTime.Today;
            string _date = today.ToString("dd-MM-yyyy");
            string _time = MARK + string.Format("{0:HH:mm:ss tt}", DateTime.Now) + " - IP: " + NetworkHelper.GetLocalIPAddress() + "\n";

            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SDM\\Logs"));

            StringBuilder sb = new StringBuilder();
            sb.Append(_time);
            sb.Append("User: " + Environment.UserName);
            sb.Append(msg);

            if(ERROR_CODE != null)
                sb.Append("\nError code: " + ERROR_CODE);

            sb.Append(MARK);

            CreateLogInMain(_date, sb.ToString());

            File.AppendAllText(filePath + _date + ".log", sb.ToString());

            sb.Clear();
        }

        static void CreateLogInMain(string _date, string log)
        {
            string _user = Environment.UserName.ToUpper();

            Directory.CreateDirectory(Path.Combine(mainPath, "Logs"));
            Directory.CreateDirectory(Path.Combine(mainPath + "Logs\\", _user));


            File.AppendAllText(mainPath + "Logs\\" + _user + "\\" + _date + ".log", log);
        }
    }
}
