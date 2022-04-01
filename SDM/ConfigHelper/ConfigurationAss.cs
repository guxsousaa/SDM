using Config_DTO;
using Microsoft.Win32;
using Newtonsoft.Json;
using SDM.Methods;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM.ConfigHelper
{
    internal class ConfigurationAss
    {
        public static string[] canAccess = { "kauav", "kaualima-mtz", "Administrator" };

        private static string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SDM\\";
        private static string ConfigFile = "\\config.json";


        public static void updateVersion()
        {
            var VERSION = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            var CODE_BASE = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            dynamic jsonObj;


            try
            {
                using (StreamReader r = new StreamReader(filePath + ConfigFile))
                {
                    //  Review it later
                    LogHelper.doLog("\nReading Config Json file...", null);

                    jsonObj = JsonConvert.DeserializeObject(r.ReadToEnd());
                }

                string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
                File.WriteAllText(filePath + ConfigFile, output);
            }
            catch (Exception ex)
            {
                LogHelper.doLog("\nMethod: updateVersion()\nThere is a error\n\n" + ex.ToString(),
                    ErrorHelper.CREATE_CONFIG_FILE);

                var obj = new
                {
                    Main = new
                    {
                        version = VERSION.ToString(),
                        CodeBase = CODE_BASE,
                        SV_operator = Environment.UserName.ToLower()
                    },
                    System = new
                    {
                        MachineName = Environment.MachineName,
                        OSVersion = Environment.OSVersion,
                        Is64BitOperatingSystem = Environment.Is64BitOperatingSystem,
                        Version = Environment.Version,
                        cpu = getProcessorInfo()
                    }
                };

                var jsonData = JsonConvert.SerializeObject(obj);

                File.WriteAllText(filePath + ConfigFile, jsonData);
            }

        }

        public static string getProcessorInfo()
        {
            RegistryKey processor_name = Registry.LocalMachine.OpenSubKey(@"Hardware\Description\System\CentralProcessor\0", RegistryKeyPermissionCheck.ReadSubTree);   //This registry entry contains entry for processor info.

            if (processor_name != null)
            {
                if (processor_name.GetValue("ProcessorNameString") != null)
                {
                    return processor_name.GetValue("ProcessorNameString").ToString();
                }
            }
            return "";
        }


        /*public static List<ConfigInfo> LoadJson()
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
            catch (Exception ex)
            {
                LogHelper.doLog("\nCreate a new Json file for user access\nThere is no current file\n\n" + ex.ToString());
                return new List<UserInfo>();
            }
        }*/
    }
}

namespace Config_DTO
{
    public class ConfigInfo
    {
        public string version { get; set; }
        public string CodeBase { get; set; }
        public string SV_operator { get; set; }

        public ConfigInfo(string version, string CodeBase, string SV_operator)
        {
            this.version = version;
            this.CodeBase = CodeBase;
            this.SV_operator = SV_operator;
        }

        public ConfigInfo() { }
    }

    public class RootObject
    {
        public List<ConfigInfo> Configitems { get; set; }
    }
}

