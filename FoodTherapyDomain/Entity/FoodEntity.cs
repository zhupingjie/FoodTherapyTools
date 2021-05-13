using FoodTherapyCore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTherapyDomain.Entity
{
    public class FoodEntity : BaseEntity
    {
        [Description("名称")]
        public string Name { get; set; }

        [Description("别名")]
        public string Alias { get; set; }

        [Description("属")]
        public string Category { get; set; }

        [Description("性")]
        public string Nature { get; set; }

        [Description("味")]
        public string Flavor { get; set; }

        [Description("毒")]
        public string Poison { get; set; }

        [Description("归经")]
        public string Belong { get; set; }

        [Description("营养")]
        public string Nutrition { get; set; }

        [Description("药用")]
        public string Officinal { get; set; }

        [Description("宜忌")]
        public string Suitable { get; set; }

        [Description("描述")]
        public string Desc { get; set; }

    }
}
