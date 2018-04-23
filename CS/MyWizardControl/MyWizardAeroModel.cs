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
    public class MyWizardAeroModel : WizardViewInfo.WizardAeroModel
    {
        public MyWizardAeroModel(WizardViewInfo viewInfo)
            : base(viewInfo)
        {

        }


        public override Rectangle GetTitleBarTitleTextBounds(bool iconVisible)
        {
            return Rectangle.Empty; ;
        }


        public override void UpdateButtonsLocation()
        {
            base.UpdateButtonsLocation();
            (ViewInfo as MyWizardViewInfo).NextButton.Bounds = GetNextButtonBounds();
        }

        private Rectangle GetNextButtonBounds()
        {
            Rectangle backButtonBounds = GetBackButtonBounds();
            backButtonBounds.Offset(backButtonBounds.Width, 0);
            return backButtonBounds;
        }

    }
}
