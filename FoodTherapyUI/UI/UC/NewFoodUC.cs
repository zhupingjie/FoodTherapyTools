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
    public partial class NewFoodUC : BaseUserControl
    {
        public NewFoodUC()
        {
            InitializeComponent();
        }

        public override BaseEntity GetFormData()
        {
            var food = new FoodEntity()
            {
                Name = this.txtName.Text.Trim(),
                Category = this.txtCategory.Text.Trim(),
                Nature = this.txtNature.Text.Trim(),
                Flavor = this.txtFlavor.Text.Trim(),
                Poison = this.txtPoison.Text.Trim(),
                Belong = this.txtBelong.Text.Trim(),
                Nutrition = this.txtNutrition.Text.Trim(),
                Officinal = this.txtOfficinal.Text.Trim(),
                Suitable = this.txtSuitable.Text.Trim(),
                Desc = this.txtDesc.Text.Trim()
            };
            return food;
        }
    }
}
