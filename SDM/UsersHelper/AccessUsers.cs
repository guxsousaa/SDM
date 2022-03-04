using Newtonsoft.Json;
using SDM.Methods;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users_DTO;

namespace SDM.AuthUsers
{
    internal class AccessUsers
    {
        private static string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SDM\\";
        private static string UsersFolder = "Users";
        private static string UsersAccessFile = "\\access.json";

        public static string[] canUpdateBase = { "kaualima-mtz", "43333349850-otimtz" };

        public static string[] canAccessTiEmprest = { "kaualima-mtz", "43333349850-otimtz" };


        public static void cretateUsersFile()
        {
            List<UserInfo> docFile = LoadJson();
            List<UserInfo> mainAccessFile = getMainUsersFile();

            Directory.CreateDirectory(Path.Combine(filePath, UsersFolder));

            string json = JsonConvert.SerializeObject(mainAccessFile);

            if(docFile.Count <= 0 || docFile != mainAccessFile)
                File.WriteAllText(filePath + UsersFolder + UsersAccessFile, json);
        }

        public static bool canAccess(string USERNAME)
        {
            List<UserInfo> usersList = LoadJson();
            foreach(UserInfo user in usersList)
            {
                if (user.username.ToLower() == USERNAME.ToLower())
                    return true;
            }
            return false;
        }

        
        /// <summary>
        /// Load Json file that is in user documents
        /// </summary>
        public static List<UserInfo> LoadJson()
        {
            try
            {
                using (StreamReader r = new StreamReader(filePath + "Users\\access.json"))
                {
                    LogHelper.doLog("\nReading Json file...", null);

                    string json = r.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<UserInfo>>(json);
                }
            }
            catch(Exception ex)
            {
                LogHelper.doLog("\nCreate a new Json file for user access\nThere is no current file\n", null);
                return new List<UserInfo>();
            }
        }

        public static List<UserInfo> getMainUsersFile()
        {
            string mainPath = AppDomain.CurrentDomain.BaseDirectory;
            Directory.CreateDirectory(Path.Combine(mainPath, "AppAsset"));
            try
            {
                using (StreamReader r = new StreamReader(mainPath + "AppAsset\\accessUsers.json"))
                {
                    LogHelper.doLog("\nReading main access json file\nIn: " + mainPath + "\n", null);
                    return JsonConvert.DeserializeObject<List<UserInfo>>(r.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                LogHelper.doLog("\nError locating main access file. Trial walk: " + mainPath +
                    "AppAsset" +"\nFatal:\n\n" + ex.ToString(), ErrorHelper.USER_ACCESS_FILE_MISSING);

                MessageBox.Show("There was an error trying to locate an important file. Please contact the system administrator (Kauã Vitorio).\n\n" +
                    "Error code: " + ErrorHelper.USER_ACCESS_FILE_MISSING,
                    "SDM - Critical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Environment.Exit(1);

                return new List<UserInfo>();
            }
        }

    }
}

namespace Users_DTO
{
    public class UserInfo
    {
        public string username { get; set; }
        public int type { get; set; }
        public int access { get; set; }

        public UserInfo(string username, int type, int access)
        {
            this.username = username;
            this.type = type;
            this.access = access;
        }

        public UserInfo() { }
    }

    public class RootObject
    {
        public List<UserInfo> items { get; set; }
    }
}
