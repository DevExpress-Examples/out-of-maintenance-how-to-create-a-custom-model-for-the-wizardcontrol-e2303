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
    public class MyWizardControl : WizardControl
    {
        protected internal MyNextButton btnNext;

        public MyWizardControl()
        {
            btnNext = CreateNextButton();
            btnNext.Click += new EventHandler(btnNext_Click);
            SubsribeChanges();
            RefreshNextButtonState();
        }

        void btnNext_Click(object sender, EventArgs e)
        {
            if (!ValidatePageControls(SelectedPage)) return;
            if (RaiseNextClick(SelectedPage)) return;
            SetNextPage();
        }

        MyNextButton CreateNextButton()
        {
            MyNextButton button = new MyNextButton(this);
            button.Parent = this;
            button.LookAndFeel.ParentLookAndFeel = LookAndFeel;
            button.MouseMove += new MouseEventHandler(OnChildControlMouseMove);
            return button;
        }
        void OnChildControlMouseMove(object sender, MouseEventArgs e)
        {
            Point pt = e.Location;
            Control child = sender as Control;
            pt.Offset(child.Left, child.Top);
            OnMouseMove(new MouseEventArgs(e.Button, e.Clicks, pt.X, pt.Y, e.Delta));
        }

        protected override WizardViewInfo CreateViewInfo()
        {
          return new MyWizardViewInfo(this); ;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            btnNext.Click -= btnNext_Click;
        }
        private void SubsribeChanges()
        {
            foreach (Control c in Controls)
            {
                c.EnabledChanged += new EventHandler(c_EnabledChanged);
            }
        }

        void c_EnabledChanged(object sender, EventArgs e)
        {
            RefreshNextButtonState();
        }

        public void RefreshNextButtonState()
        {
            btnNext.Enabled = SelectedPageIndex < Pages.Count - 1 && (SelectedPage.AllowNext || DesignMode);
        }
    }
}