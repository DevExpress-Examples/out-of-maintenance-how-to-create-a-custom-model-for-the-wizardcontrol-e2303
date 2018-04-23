using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWizard;

namespace WindowsApplication1
{
    public class MyWizardViewInfo : WizardViewInfo
    {

        public MyNextButton NextButton { get { return (WizardControl as MyWizardControl).btnNext; } }

        public MyWizardViewInfo(WizardControl control)
            : base(control)
        {
            
        }

        protected override void CreateButtonsInfo()
        {
            base.CreateButtonsInfo();
        }

        protected override WizardModelBase CreateWizardModelCore(WizardStyle style)
        {
            if (style == WizardStyle.WizardAero) return new MyWizardAeroModel(this);
            return base.CreateWizardModelCore(style);
        }


    }
}
