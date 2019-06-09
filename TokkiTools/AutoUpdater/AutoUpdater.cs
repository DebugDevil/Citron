using GTA;
using System;
using System.Reflection;

namespace TokkiTools.AutoUpdater
{
    /// <summary>
    /// Auto Updating system for mods created by me (Lemon).
    /// </summary>
    public class AutoUpdater : Script
    {
        /// <summary>
        /// The last time that updates were checked.
        /// </summary>
        public static DateTime LastCheck = new DateTime();
        /// <summary>
        /// A timespan with the value of a single minute.
        /// </summary>
        public static readonly TimeSpan Minute = new TimeSpan(0, 1, 0);

        public AutoUpdater()
        {
            // Over here we subscribe our events
            Tick += OnTick;
            RegisterScript();
        }

        public static void RegisterScript()
        {
            // Store the assembly that called this function
            Assembly Caller = Assembly.GetCallingAssembly();
            // Get the location of the DLL
            string Location = new Uri(Caller.CodeBase).LocalPath;

            // If the we have the debug mode, notify the user about the registered script
            #if DEBUG
            UI.Notify("Script added to Auto Update: " + Caller.FullName);
            #endif
        }

        private void OnTick(object sender, EventArgs e)
        {
            // If the current time is not higher or equal than the last check + one minute, return
            if (!(DateTime.Now >= LastCheck + Minute))
            {
                return;
            }
        }
    }
}
