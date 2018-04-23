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
    public class MyButtonPainter : SkinBackButtonPainter
    {
        public MyButtonPainter(DevExpress.Skins.ISkinProvider provider)
            : base(provider)
        {

        }

        protected override void DrawContent(DevExpress.Utils.Drawing.ObjectInfoArgs e)
        {
            base.DrawContent(e);
        }
        protected override RotateFlipType GetRotationAngle(DevExpress.Utils.Drawing.ObjectInfoArgs e)
        {
            return RotateFlipType.Rotate180FlipNone;
        }
    }
}
