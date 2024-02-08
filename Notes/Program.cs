using Notes.Domain;
using Notes.View;
using System;
using System.Windows.Forms;

namespace Notes
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            var services = ConfigurateServices();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Explorer(services));
        }

        private static Services ConfigurateServices()
        {
            var dataPath = "D:\\Notes\\Notes\\Notes\\Data\\";
            var configPath = "D:\\Notes\\Notes\\Notes\\Config\\";
            var loader = new Loader();
            var settings = loader.LoadSettings(configPath, dataPath);
            var services = new Services(configPath, settings, loader, new Saver());
            return services;
        }
    }
}
