using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace Config
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
#if !DEBUG
            Application.ThreadException += Application_ThreadException;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
#endif
             



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new MainForm());
        }
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(string.Format("An exception arose:\r\n{0}\r\n{1}\r\nType: {2}", e.Exception.Message, e.Exception.StackTrace, e.Exception.GetType().ToString()), "Config");
            Environment.Exit(1);
        }


        public static bool IsUserAdministrator()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException)
            {
                isAdmin = false;
            }
            catch (Exception)
            {
                isAdmin = false;
            }
            return isAdmin;
        }

        public static bool CanWriteHere()
        {
            try
            {
                var path = Path.Combine(Environment.CurrentDirectory, new Random().Next(0, int.MaxValue) + ".tmp");
                // Check for writing rights
                using (var sw = new StreamWriter(path))
                {
                    sw.Write(" ");
                    sw.Close();
                    File.Delete(path);
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
