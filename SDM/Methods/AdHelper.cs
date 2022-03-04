using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public static void updateAdBaseFile()
        {
            string mainPath = AppDomain.CurrentDomain.BaseDirectory + "AppAsset\\";

            Directory.CreateDirectory(Path.Combine(mainPath, "AD"));


            List<string> adList = GetAllComputers();
            File.WriteAllText(mainPath + "AD\\CompBase.json", JsonConvert.SerializeObject(adList));
        }
    }
}
