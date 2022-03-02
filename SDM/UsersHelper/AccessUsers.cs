using Newtonsoft.Json;
using SDM.Methods;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users_DTO;

namespace SDM.AuthUsers
{
    internal class AccessUsers
    {
        public static string[] canAccess = { "kauav", "kaualima-mtz", "Administrator" };

        private static string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SDM\\";
        private static string UsersFolder = "Users";
        private static string UsersAccessFile = "\\access.json";


        public static void cretateUsersFile()
        {
            List<UserInfo> test =  LoadJson();

            Directory.CreateDirectory(Path.Combine(filePath, UsersFolder));

            string json = JsonConvert.SerializeObject(new List<UserInfo>
                          {
                             new UserInfo { username = "kauav", type = 2, access = 2 },
                             new UserInfo { username = "kaualima-mtz", type = 2, access = 2 }
                          });


            File.WriteAllText(filePath + UsersFolder + UsersAccessFile, json);
        }


        public static List<UserInfo> LoadJson()
        {
            try
            {
                using (StreamReader r = new StreamReader(filePath + "Users\\access.json"))
                {
                    LogHelper.doLog("\nReading Json file...");

                    string json = r.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<UserInfo>>(json);
                }
            }
            catch(Exception ex)
            {
                LogHelper.doLog("\nCreate a new Json file for user access\nThere is no current file\n\n" + ex.ToString());
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
