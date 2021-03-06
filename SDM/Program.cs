using Microsoft.Win32;
using SDM.AuthUsers;
using SDM.ConfigHelper;
using SDM.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM
{
    /**
     * 
     *  Copyright (c) 2022 Kauã Vitório
     *  Official repository https://github.com/Kauavitorio/SDM
     *  Responsible developer: https://github.com/Kauavitorio
     *  @author Kaua Vitorio
     *
     */
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            enforceAdminPrivilegesWorkaround();

            AccessUsers.cretateUsersFile();

            ConfigurationAss.updateVersion();

            Application.Run(new FRM_Splash());
        }

        public static void enforceAdminPrivilegesWorkaround()
        {
            RegistryKey rk;
            string registryPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\";

            try
            {
                if (Environment.Is64BitOperatingSystem)
                {
                    rk = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                }
                else
                {
                    rk = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
                }

                rk = rk.OpenSubKey(registryPath, true);
            }
            catch (System.Security.SecurityException ex)
            {
                LogHelper.doLog("\nApplication not started as administrator\n\n" + ex.ToString(),
                    ErrorHelper.NOT_ADM_EXECUTE);

                MessageBox.Show("Please run as administrator");
                Environment.Exit(1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
