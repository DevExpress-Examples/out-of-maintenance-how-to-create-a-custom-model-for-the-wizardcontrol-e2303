using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWizard;
using DevExpress.XtraEditors.Drawing;
using DevExpress.Skins;

namespace WindowsApplication1
{
    public class MyNextButton : BackButton
    {
        public MyNextButton(WizardControl wizard)
            : base(wizard)
        {
        }

        protected override DevExpress.XtraEditors.ViewInfo.BaseStyleControlViewInfo CreateViewInfo()
        {
            return new MyBackButtonViewInfo(this);
        }

    }

}
