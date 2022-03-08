using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    internal class ErrorHelper
    {
        public static string NOT_ADM_EXECUTE = "NADMEX";

        public static string ACCESS_DENIED = "ACCDEx01";

        public static string ACCESS_DENIED_TIEMPREST = "ACCDExTIEM";

        public static string ACCESS_DENIED_MANAGE_USER = "ACCDExMNU";

        public static string ACCESS_DENIEDUPDATE_ADBASE = "ACCDExAD";

        public static string NO_INTERNET = "NNET";

        public static string USER_ACCESS_FILE_MISSING = "UCFM-M";

        public static string CREATING_NEW_COMPUTER_AD = "CNC-EX";

        public static string GET_COMPUTER_IN_AD = "GC-ADex";

        public static string CREATE_AD_BASE_FILE = "CADBF";

        public static string CREATE_CONFIG_FILE = "CCF";

        public static string PING_OTHER_COMPUTER = "POC";
    }
}
