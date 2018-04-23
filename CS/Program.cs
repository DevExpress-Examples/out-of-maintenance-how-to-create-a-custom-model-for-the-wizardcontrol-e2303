using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Utils.Drawing.Helpers;

namespace DevExpress.XtraWizard.Demos {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            DevExpress.UserSkins.BonusSkins.Register();
            if(!NativeVista.IsVista)
                DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
