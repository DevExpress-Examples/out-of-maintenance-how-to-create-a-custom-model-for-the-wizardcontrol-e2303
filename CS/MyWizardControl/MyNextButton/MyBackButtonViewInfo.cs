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
    public class MyBackButtonViewInfo : BackButtonViewInfo
    {
        public MyBackButtonViewInfo(BackButton owner)
            : base(owner)
        {

        }

        protected override EditorButtonPainter GetButtonPainter()
        {
            return new MyButtonPainter(this.LookAndFeel);
        }
    }
}
