using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using Nitro.Simulator.Views;

namespace Nitro.Simulator
{
    static class Program
    {
        private static CompositionContainer _container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            ComposeApplication();
            if (_container != null)
            {
                ExamSelectorView view = _container.GetExport<ExamSelectorView>().Value;
                Application.Run(view);
            }
        }

        private static void ComposeApplication()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            _container = new CompositionContainer(catalog);
            _container.ComposeParts();
        }
    }
}
