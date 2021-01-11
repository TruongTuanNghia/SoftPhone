using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportSoftPhone.Helpers
{
    public class ThreadHelperClass
    {
        public bool ControlInvokeRequired(Control c, Action a)
        {
            if (c.InvokeRequired) c.Invoke(new MethodInvoker(delegate { a(); }));
            else return false;
            return true;
        }
        public void UpdateVisibleControl(Control control, bool check)
        {
            if (ControlInvokeRequired(control, () => UpdateVisibleControl(control, check))) return;
            control.Visible = check;
        }
        public void UpdateTextControl(Control control, string text)
        {
            if (ControlInvokeRequired(control, () => UpdateTextControl(control, text))) return;
            control.Text = text;
        }
        public void FocusControl(Control control)
        {
            if (ControlInvokeRequired(control, () => FocusControl(control))) return;
            control.Focus();
        }
    }
}
