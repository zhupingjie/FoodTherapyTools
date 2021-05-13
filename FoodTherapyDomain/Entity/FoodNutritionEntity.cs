using FoodTherapyCore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTherapyDomain.Entity
{
    public class FoodNutritionEntity : BaseEntity
    {
        [Description("食物名称")]
        public string FoodName { get; set; }

        [Description("营养素")]
        public string Nutrient { get; set; }

        [Description("含量")]
        public decimal Qty { get; set; }

        [Description("单位")]
        public string UM { get; set; }
    }
}
