﻿using Playnite.Common;
using Playnite.SDK;
using Playnite.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Playnite.DesktopApp
{
    public class ProgramEntry
    {        
        [STAThread]
        public static void Main(string[] args)
        {
            var splash = new SplashScreen("SplashScreen.png");
            splash.Show(false);
            PlayniteSettings.ConfigureLogger();
            LogManager.Init(new NLogLogProvider());
            var app = new DesktopApplication(new App(), splash);
            app.Run();
        }
    }
}
