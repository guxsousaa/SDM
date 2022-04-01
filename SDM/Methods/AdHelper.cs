using DTO_AD;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    class AdHelper
    {
        public static List<ADInfo> AD = new List<ADInfo>();
        public static Thread updateThread;
        public static bool SECTION_LOCKED = false;
        private static string AD_NAME = "corporate";
        private static string DC_AD_NAME = "DC=corporate,DC=ad";
        public static string OU_HOSTNAME_BLOCK = "OU=Bloqueio,OU=Hostname,OU=Quarentena" + "," + DC_AD_NAME;
        public static string OU_NOTEBOOK_MTZ = "OU=OU Notebook,OU=Matriz" + "," + DC_AD_NAME;
        public static string OU_NOTEBOOK_EMPREST = "OU=OU TI,OU=Matriz" + "," + DC_AD_NAME;
        public static string OU_COMPUETRS_MTZ = "OU=OU Computers,OU=Matriz" + "," + DC_AD_NAME;
        public static string OU_WSUS_WIN10_MTZ = "OU=Valida Win10,OU=Wsus,OU=Matriz" + "," + DC_AD_NAME;
        public static string OU_NTB_SMT = "OU=Notebook,OU=SEARA ALIMENTOS - MATRIZ - SMT,OU=ESCRITORIO,OU=CORPORATIVO,OU=BR,OU=SEARA ALIMENTOS LTDA" + "," + DC_AD_NAME;
        public static string OU_DSK_SMT = "OU=Computers,OU=SEARA ALIMENTOS - MATRIZ - SMT,OU=ESCRITORIO,OU=CORPORATIVO,OU=BR,OU=SEARA ALIMENTOS LTDA" + "," + DC_AD_NAME;

        public static ADInfo searchComputer(string COMPUTER_NAME)
        {
            string mainPath = AppDomain.CurrentDomain.BaseDirectory + "AppAsset\\";
            ADInfo comp = null;

            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;

            using (StreamReader r = new StreamReader(mainPath + "AD\\CompBase.json"))
            {
                List<ADInfo> allInfo = JsonConvert.DeserializeObject<List<ADInfo>>(r.ReadToEnd());
                foreach (ADInfo info in allInfo)
                {
                    if (info.CN != null)
                    {
                        if (info.CN.ToUpper() == COMPUTER_NAME.ToUpper())
                        {

                            // Set cursor as default arrow
                            Cursor.Current = Cursors.Default;
                            return info;
                        }
                    }
                }
            }

            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;
            return comp;

        }

        internal static string buildOu(ADInfo computerInfo)
        {
            if (computerInfo != null)
            {
                string[] OUs = computerInfo.OU.ToArray();
                Array.Reverse(OUs);

                StringBuilder generatedOu = new StringBuilder();
                foreach (string OU in OUs)
                {
                    if (generatedOu.Length > 0)
                        generatedOu.Append(", " + OU);
                    else
                        generatedOu.Append(OU);
                }
                return generatedOu.ToString();
            }
            else return null;
        }

        public static long[] getStatus()
        {
            string mainPath = AppDomain.CurrentDomain.BaseDirectory + "AppAsset\\";

            long bloked = 0;
            long relocation = 0;
            long TIEMPREST = 0;
            long MTZNTB = 0;

            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;

            foreach (ADInfo info in AD)
            {
                foreach (string ou in info.OU)
                {
                    if (ou == "Bloqueio") bloked++;
                    else if (ou == "Realocacao") relocation++;
                }

                if (info.CN != null && info.CN.Length > 8 && info.CN.Contains("TIEMPREST")) TIEMPREST++;
                else if (info.CN != null && info.CN.Length > 5 && info.CN.Contains("MTZNTB")) MTZNTB++;
            }

            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;

            long[] result = { MTZNTB, TIEMPREST, bloked, relocation };
            return result;
        }

        public static string getNextComputerName(string input)
        {
            string mainPath = AppDomain.CurrentDomain.BaseDirectory + "AppAsset\\";
            List<string> allComp = new List<string>();

            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;

            using (StreamReader r = new StreamReader(mainPath + "AD\\CompBase.json"))
            {
                List<ADInfo> allInfo = JsonConvert.DeserializeObject<List<ADInfo>>(r.ReadToEnd());
                foreach (ADInfo info in allInfo)
                {
                    string compName = info.CN;
                    if (compName != null && compName.Length >= 3 && compName.Contains(input))
                        allComp.Add(compName.ToUpper());
                }
            }

            //  Returns 1 because there is no computer with the given name
            if (allComp.Count <= 0) return "1";
            else
            {
                List<int> numberList = new List<int>();
                foreach (string comp in allComp)
                {
                    string str2 = string.Empty;
                    int val = 0;
                    for (int i = 0; i < comp.Length; i++)
                    {
                        if (Char.IsDigit(comp[i]))
                            str2 += comp[i];
                    }
                    if (str2.Length > 0)
                        val = int.Parse(str2);

                    numberList.Add(val);
                }

                return getMissingNumber(numberList.ToArray()).ToString();
            }
        }

        public static int getMissingNumber(int[] selectedNumbers)
        {
            Array.Sort(selectedNumbers);

            int firstNumber = selectedNumbers.OrderBy(i => i).First();
            int lastNumber = selectedNumbers.OrderBy(i => i).Last();

            List<int> allNumbers = Enumerable.Range(firstNumber, lastNumber - firstNumber + 1).ToList();

            List<int> missingNumbers = allNumbers.Except(selectedNumbers).ToList();

            foreach (int i in missingNumbers)
            {
                return i;
            }

            return lastNumber + 1;
        }

        internal static string buildOuPath(ADInfo computerInfo)
        {
            string[] OUs = computerInfo.OU.ToArray();
            Array.Reverse(OUs);

            StringBuilder generatedOu = new StringBuilder();
            foreach (string OU in OUs)
            {
                if (generatedOu.Length > 0)
                    generatedOu.Append(",OU= " + OU);
                else
                    generatedOu.Append("OU=" + OU);
            }
            return generatedOu.ToString();
        }

        public static List<string> GetAllUsers(bool isTest)
        {
            Cursor.Current = Cursors.WaitCursor;
            List<string> ComputerPath = new List<string>();

            try
            {
                LogHelper.doLog("\nGetting all Users from AD", null);

                DirectoryEntry entry = new DirectoryEntry("LDAP://corporate.ad");
                DirectorySearcher mySearcher = new DirectorySearcher(entry);
                mySearcher.Filter = ("(&(objectCategory=person)(objectClass=user)((userAccountControl:1.2.840.113556.1.4.803:=2)))");
                mySearcher.SizeLimit = int.MaxValue;
                mySearcher.PageSize = int.MaxValue;

                foreach (SearchResult resEnt in mySearcher.FindAll())
                {
                    string ComputerName = resEnt.Path;
                    if (ComputerName.ToLower().Contains("Fernanda da Silva de Oliveira".ToLower()))
                    {
                        
                        ComputerPath.Add(ComputerName.Replace("LDAP://corporate.ad/", ""));
                    }
                }

                mySearcher.Dispose();
                entry.Dispose();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                LogHelper.doLog("\nError getting all machines from AD\n\n" + ex.ToString(), ErrorHelper.GET_COMPUTER_IN_AD);

                if (!isTest)
                    MessageBox.Show(ex.ToString(), "Fatal Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ComputerPath;
            }

            return ComputerPath;
        }
        public static List<string> GetAllComputers(bool isTest)
        {
            List<string> ComputerPath = new List<string>();

            try
            {
                LogHelper.doLog("\nGetting all machines from AD", null);

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
            }
            catch (Exception ex)
            {
                LogHelper.doLog("\nError getting all machines from AD\n\n" + ex.ToString(), ErrorHelper.GET_COMPUTER_IN_AD);

                if (!isTest)
                    MessageBox.Show(ex.ToString(), "Fatal Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ComputerPath;
            }

            return ComputerPath;
        }

        public static void initList()
        {
            string mainPath = AppDomain.CurrentDomain.BaseDirectory + "AppAsset\\";

            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                using (StreamReader r = new StreamReader(mainPath + "AD\\CompBase.json"))
                {
                    var json = r.ReadToEnd();
                    AD = JsonConvert.DeserializeObject<List<ADInfo>>(json.Replace("=", ":"));
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public static bool updateAdBaseFile()
        {
            DateTime today = DateTime.Today;
            string Date = today.ToString("dd-MM-yyyy");
            string mainPath = AppDomain.CurrentDomain.BaseDirectory + "AppAsset\\";


            Directory.CreateDirectory(Path.Combine(mainPath, "AD"));

            Directory.CreateDirectory(Path.Combine(mainPath, "AD\\Base-Backup"));


            List<string> adList = GetAllComputers(false);

            //  If it returns, there is an error communicating with the server
            if (adList.Count <= 0) return false;

            string backBackupFileName = "CompBase-" + Date + ".json";
            File.WriteAllText(mainPath + "AD\\Base-Backup\\" + backBackupFileName, JsonConvert.SerializeObject(adList));

            try
            {
                List<ADInfo> allItems = new List<ADInfo>();
                using (StreamReader r = new StreamReader(mainPath + "AD\\Base-Backup\\" + backBackupFileName))
                {
                    List<string> json = JsonConvert.DeserializeObject<List<string>>(r.ReadToEnd());
                    foreach (string s in json)
                    {
                        string[] comp = s.Replace(@"\", string.Empty).Replace(" ", string.Empty).Split(',');

                        ADInfo adItem = new ADInfo();
                        foreach (string item in comp)
                        {
                            if (adItem.OU == null) adItem.OU = new List<string>();
                            if (adItem.DC == null) adItem.DC = new List<string>();

                            if (item.Contains("CN=")) adItem.CN = item.Replace("CN=", "");
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
                        if (adItem.CN != null)
                            allItems.Add(adItem);
                    }
                }

                List<ADInfo> finalItems = new List<ADInfo>();
                foreach (ADInfo item in allItems)
                {
                    if (item.CN != null)
                    {
                        item.CN = item.CN.ToUpper();
                        finalItems.Add(item);
                    }
                }
                File.WriteAllText(mainPath + "AD\\CompBase.json", JsonConvert.SerializeObject(finalItems));
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.doLog("\nError creating AD base file\n\n" + ex.ToString(), ErrorHelper.CREATE_AD_BASE_FILE);

                //MessageBox.Show("Base file AS - \n" +ex.ToString(), "Fatal Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void requestUpdateBaseFile()
        {
            if (updateThread == null || !updateThread.IsAlive)
            {
                updateThread = new Thread(delegate ()
                {
                    AdHelper.updateAdBaseFile();
                    return;
                });
                updateThread.IsBackground = true;
                updateThread.Start();
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
