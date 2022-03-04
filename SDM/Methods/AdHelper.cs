using DTO_AD;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM.Methods
{
    class AdHelper
    {

        private static string AD_NAME = "corporate";

        public static List<string> GetComputersTest()
        {
            List<string> ComputerNames = new List<string>();

            //DirectoryEntry entry = new DirectoryEntry("LDAP://" + AD_NAME);
            DirectoryEntry entry = new DirectoryEntry("LDAP://OU=OU Notebook, OU=Matriz,DC=" + AD_NAME + ",DC=ad");
            DirectorySearcher mySearcher = new DirectorySearcher(entry);
            mySearcher.Filter = ("(objectClass=computer)");
            mySearcher.SizeLimit = int.MaxValue;
            mySearcher.PageSize = int.MaxValue;

            foreach (SearchResult resEnt in mySearcher.FindAll())
            {
                //"OU=SGSVG007DC"
                string ComputerName = resEnt.GetDirectoryEntry().Name;
                if (ComputerName.StartsWith("OU="))
                    ComputerName = ComputerName.Remove(0, "OU=".Length);
                ComputerNames.Add(ComputerName);
            }

            mySearcher.Dispose();
            entry.Dispose();

            return ComputerNames;
        }

        public static List<string> GetAllComputers()
        {
            List<string> ComputerPath = new List<string>();

            DirectoryEntry entry = new DirectoryEntry("LDAP://corporate.ad");
            DirectorySearcher mySearcher = new DirectorySearcher(entry);
            mySearcher.Filter = ("(objectClass=computer)");
            mySearcher.SizeLimit = int.MaxValue;
            mySearcher.PageSize = int.MaxValue;

            foreach (SearchResult resEnt in mySearcher.FindAll())
            {
                string ComputerName = resEnt.Path;
                ComputerPath.Add(ComputerName.Replace("LDAP://corporate.ad/", ""));
            }

            mySearcher.Dispose();
            entry.Dispose();

            return ComputerPath;
        }


        public static bool updateAdBaseFile()
        {
            DateTime today = DateTime.Today;
            string Date = today.ToString("dd-MM-yyyy");
            string mainPath = AppDomain.CurrentDomain.BaseDirectory + "AppAsset\\";


            Directory.CreateDirectory(Path.Combine(mainPath, "AD"));

            Directory.CreateDirectory(Path.Combine(mainPath, "AD\\Base-Backup"));


            //List<string> adList = GetAllComputers();
            string backBackupFileName = "CompBase-" + Date + ".json";
            //File.WriteAllText(mainPath + "AD\\Base-Backup\\" + backBackupFileName, JsonConvert.SerializeObject(adList));


            try
            {
                List<ADInfo> allItems = new List<ADInfo>();
                using (StreamReader r = new StreamReader(mainPath + "AD\\Base-Backup\\" + backBackupFileName))
                {
                    string json = r.ReadToEnd();
                    string[] stringSeparators = new string[] { "\r\n" };
                    string[] lines = json.Split(stringSeparators, StringSplitOptions.None);
                    lines = lines.Skip(1).ToArray();
                    foreach (string s in lines)
                    {
                        string[] comp = s.Replace(@"\", string.Empty).Replace(" ", string.Empty).Split(',');

                        ADInfo adItem = new ADInfo();
                        foreach(string item in comp)
                        {
                            if (adItem.OU == null) adItem.OU = new List<string>();
                            if (adItem.DC == null) adItem.DC = new List<string>();

                            if (item.Contains("CN=")) adItem.CN = item.Remove(0, 1).Replace("CN=", "");
                            else if (item.Contains("OU=")) adItem.OU.Add(item.Replace("OU=", ""));
                            else if (item.Contains("DC="))
                            {
                                // Length == 6 because the original string is "DC=ad\"
                                if (item.Length == 6)
                                    adItem.DC.Add(item.Remove(item.Length - 1, 1).Replace("DC=", ""));
                                else
                                    adItem.DC.Add(item.Replace(@"\", string.Empty).Replace("DC=", ""));
                            }
                        }
                        allItems.Add(adItem);
                    }
                }
                File.WriteAllText(mainPath + "AD\\CompBase.json", JsonConvert.SerializeObject(allItems));
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Fatal Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

namespace DTO_AD
{
    public class ADInfo
    {
        public string CN { get; set; }
        public List<string> OU { get; set; }
        public List<string> DC { get; set; }

        public ADInfo() { }
    }

    public class RootObject
    {
        public List<ADInfo> items { get; set; }
    }
}
