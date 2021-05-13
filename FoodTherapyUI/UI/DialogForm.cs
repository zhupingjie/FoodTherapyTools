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
    public partial class DialogForm : Form
    {
        BaseUserControl mainUC;

        Action<BaseEntity> okFunc;

        public DialogForm(BaseUserControl uc, Action<BaseEntity> action)
        {
            InitializeComponent();

            mainUC = uc;

            okFunc = action;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var data = mainUC.GetFormData();
            
            okFunc(data);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
