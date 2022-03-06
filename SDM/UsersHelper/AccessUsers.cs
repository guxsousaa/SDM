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

        public static string[] canUpdateBase = { "kauav", "kaualima-mtz", "43333349850-otimtz" };

        public static string[] canAccessTiEmprest = { "kauav", "kaualima-mtz", "43333349850-otimtz" };


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
            foreach (UserInfo user in usersList)
            {
                if (user.username.ToLower() == USERNAME.ToLower())
                    return true;
            }
            return false;
        }

        public static UserInfo getMyAccess()
        {
            string USERNAME = Environment.UserName.ToLower();
            List<UserInfo> usersList = LoadJson();
            foreach (UserInfo user in usersList)
            {
                if (user.username.ToLower() == USERNAME.ToLower())
                {
                    return user;
                }
            }
            return null;
        }

        public static string getUser_Name(string USERNAME)
        {
            List<UserInfo> usersList = LoadJson();
            foreach (UserInfo user in usersList)
            {
                if (user.username.ToLower() == USERNAME.ToLower())
                {
                    if (user.name != null) return user.name;
                }
            }
            return USERNAME.Replace("-otimtz", "");
        }
        public static string getUserImageUrl(string USERNAME)
        {
            List<UserInfo> usersList = LoadJson();
            foreach (UserInfo user in usersList)
            {
                if (user.username.ToLower() == USERNAME.ToLower())
                    return user.imageUrl;
            }
            return null;
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
                LogHelper.doLog("\nCreate a new Json file for user access\nThere is no current file\n\n" + ex.ToString(), null);
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
        public string name { get; set; }
        public bool full { get; set; }
        public bool op { get; set; }
        public bool ti_emprest { get; set; }
        public string imageUrl { get; set; }

        public UserInfo(string name, string username, bool full, bool op, bool ti_emprest, string imageUrl)
        {
            this.name = name;
            this.username = username;
            this.full = full;
            this.op = op;
            this.ti_emprest = ti_emprest;
            this.imageUrl = imageUrl;
        }

        public UserInfo() { }
    }

    public class RootObject
    {
        public List<UserInfo> items { get; set; }
    }
}
