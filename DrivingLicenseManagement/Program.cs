using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace DrivingLicenseManagement
{
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

            if (!Directory.Exists("Images"))
                Directory.CreateDirectory("Images");

            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\DrivingLicenseManagement");
            if (key.GetValue("RememberMe") == null)
                key.SetValue("RememberMe", 0, RegistryValueKind.DWord);
            if (key.GetValue("UserName") == null)
                key.SetValue("UserName", "", RegistryValueKind.String);
            if (key.GetValue("Password") == null)
                key.SetValue("Password", "", RegistryValueKind.String);
            key.Dispose();
            Application.Run(new LOGIN());
        }
    }
}