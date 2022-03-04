using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM.Methods
{
    class AdHelper
    {

        private static string AD_NAME = "corporate";

        public static List<string> GetComputers()
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
    }
}
