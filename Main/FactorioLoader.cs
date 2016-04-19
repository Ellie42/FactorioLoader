using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using FactorioLoader.Main.Database;
using FactorioLoader.Main.Forms;
using FactorioLoader.Main.Models.Config;
using FactorioLoader.Main.Models.Profile;
using FactorioLoader.Main.Services;

namespace FactorioLoader.Main
{
    public class FactorioLoader
    {
        public ModProfileService Profiles;
        public LoaderConfig Config;
        public ModService Mods;
        public DatabaseFacade Db;
        public MainForm MainForm;

        public FactorioLoader()
        {
            SetupDb();

            Profiles = new ModProfileService();
            Mods = new ModService();
            Config = new LoaderConfig();
        }

        /// <summary>
        /// Run the initial Migrations if the DB does not exist
        /// </summary>
        private void SetupDb()
        {
            Db = new DatabaseFacade("./Db/fml-Db.sqlite");

            if (!File.Exists("./Db/fml-Db.sqlite"))
            {
                Db.Setup(new ModDatabaseSetup());
            }
        }

//        public void Run()
//        {
//            MainForm = new MainForm();
//
//            Application.Run(MainForm);
//        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm = new MainForm();

            bool created;
            var sEvent = new EventWaitHandle(false,
                EventResetMode.ManualReset, "factorioLoader", out created);

            //If Event already created
            if (created)
            {
                Application.Run(MainForm);
            }
            else
            {
                Process current = Process.GetCurrentProcess();

                foreach (Process process in Process.GetProcessesByName("FactorioLoader"))
                {
                    if (process.Id != current.Id)
                    {
                        process.Refresh();
                        var windows = GetProcessWindows(process.Id);

                        SetForegroundWindow(windows[0]);
                        break;
                    }
                }
                Application.Exit();
            }
        }

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindowEx(IntPtr parentWindow, IntPtr previousChildWindow, string windowClass, string windowTitle);

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowThreadProcessId(IntPtr window, out int process);

        private IntPtr[] GetProcessWindows(int process)
        {
            IntPtr[] apRet = (new IntPtr[256]);
            int iCount = 0;
            IntPtr pLast = IntPtr.Zero;
            do
            {
                pLast = FindWindowEx(IntPtr.Zero, pLast, null, null);
                int iProcess_;
                GetWindowThreadProcessId(pLast, out iProcess_);
                if (iProcess_ == process) apRet[iCount++] = pLast;
            } while (pLast != IntPtr.Zero);
            System.Array.Resize(ref apRet, iCount);
            return apRet;
        }

        public void RunApp()
        {
            Config.Load();

            //Check if the directories are set and request them if they are not
            Config.RequestUnsetPaths();
            Config.SaveChanges();

            //Load and prepare all mod data
            Mods.Init();

            //Load and prepare profile data
            Profiles.Init();
        }
    }
}