using FoodTherapyCore.Data;
using FoodTherapyDomain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodTherapyUI.UI
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }
        
        protected void InvokeControl(Control control, Action action)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(action);
            }
            else
            {
                action();
            }
        }

        protected DialogResult ShowDialog<T>(DialogOption option, Action<BaseEntity> okFunc) where T : BaseUserControl, new()
        {
            var uc = new T();
            uc.Dock = DockStyle.Fill;

            var dialog = new DialogForm(uc, okFunc);
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.Text = option.Title;
            dialog.Width = option.Width;
            dialog.Height = option.Height;

            var pnlControls = dialog.Controls.Find("pnlControls", true).FirstOrDefault() as Panel;
            if(pnlControls != null)
            {
                pnlControls.Controls.Add(uc);
            }
            return dialog.ShowDialog();
        }
    }
}
