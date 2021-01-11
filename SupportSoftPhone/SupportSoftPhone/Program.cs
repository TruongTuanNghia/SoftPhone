using SupportSoftPhone.GUI;
using SupportSoftPhone.SoftPhone;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportSoftPhone
{
    static class Program
    {
        private static Mutex mutex;
        private static bool IsAlreadyRuning()
        {
            bool flag;
            FileSystemInfo info = new FileInfo(Assembly.GetExecutingAssembly().Location);
            string name = info.Name;
            mutex = new Mutex(true, @"Global\" + name, out flag);
            if (flag)
                mutex.ReleaseMutex();
            return !flag;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new frmMain());
                SoftPhoneEngine softPhoneEngine = SoftPhoneEngine.Instance;
                Application.Run(new frmMain(softPhoneEngine));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Application.Exit();
            }
        }
    }
}
