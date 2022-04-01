using Newtonsoft.Json;
using SDM.AuthUsers;
using SDM.DTOs;
using SDM.Methods;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SDM.DTOs.DTO_Loans;

namespace SDM.FRMs_TiEmprest
{
    internal class TiEmprestHelper
    {

        public static List<DTO_Loans> VerifyCurrentFile()
        {
            string mainPath = AppDomain.CurrentDomain.BaseDirectory + "AppAsset\\";
            try
            {
                using (StreamReader r = new StreamReader(mainPath + "TIEMPREST\\Notify\\" + ToolsHelper.NOTIFY_LOAN_FILE_NAME))
                {
                    LogHelper.doLog("\nReading notify loan json file.", null);
                    List<DTO_Loans> loans = JsonConvert.DeserializeObject<List<DTO_Loans>>(r.ReadToEnd());

                    for(int i = 0; i < loans.Count; i++)
                    {

                        try
                        {
                            loans[i].loan_by = AccessUsers.getUser_Name(loans[i].loan_by) + " (" + loans[i].loan_by + ")";
                        }catch (Exception e)
                        {
                            LogHelper.doLog(e.ToString(), null);
                        }
                    }

                    return loans;
                }
            }
            catch (Exception ex)
            {
                if (ex.ToString().Contains("Could not find a part of the path"))
                {
                    Directory.CreateDirectory(Path.Combine(mainPath, "TIEMPREST"));

                    Directory.CreateDirectory(Path.Combine(mainPath, "TIEMPREST\\Notify"));
                }
                return new List<DTO_Loans>();
            }
        }
    }
}
