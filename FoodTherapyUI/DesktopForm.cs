using FoodTherapyCore.Data;
using FoodTherapyDomain.Entity;
using FoodTherapyUI.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodTherapyTools
{
    public partial class DesktopForm : BaseForm
    {
        public DesktopForm()
        {
            InitializeComponent();
        }

        private void DesktopForm_Load(object sender, EventArgs e)
        {
            Repository.Instance.InitDataBase();

            this.LoadFoodList();
        }

        #region 页面加载

        void LoadFoodList(bool reload = true)
        {
            var keyword = this.txtFoodName.Text.Trim();
            var foods = Repository.Instance.QueryAll<FoodEntity>($"Name like '%{keyword}%'");

            InvokeControl(this.lstFoods, new Action(() =>
            {
                var showFoods = GetShowFoods(foods);
                 
                this.lstFoods.BeginUpdate();
                if (reload) this.lstFoods.Items.Clear();
                 
                foreach (var item in showFoods)
                {
                    if (this.lstFoods.Items.Count > 0 && !reload)
                    {
                        var listItem = this.lstFoods.FindItemWithText(item.Name);
                        if (listItem != null) continue;
                    } 
                    var subItem = new ListViewItem();
                    subItem.Text = item.Name;
                    subItem.SubItems.Add($"{item.Category}");
                    subItem.SubItems.Add($"{item.Nature}");
                    subItem.SubItems.Add($"{item.Flavor}");
                    subItem.SubItems.Add($"{item.Belong}");
                    subItem.SubItems.Add($"{(item.LastDate.ToString("yyyy/MM/dd HH:mm"))}");
                    subItem.Tag = item;
                    this.lstFoods.Items.Add(subItem);
                }
                this.lstFoods.EndUpdate();
            }));
        }

        FoodEntity[] GetShowFoods(FoodEntity[] foods)
        {
            switch (this.cbxPageFilter.Text)
            {
                case "更新":
                    if (this.cbxPageSort.Text == "降序")
                        foods = foods.OrderByDescending(c => c.LastDate).ToArray();
                    else
                        foods = foods.OrderBy(c => c.LastDate).ToArray();
                    break;
                case "名称":
                    if (this.cbxPageSort.Text == "降序")
                        foods = foods.OrderByDescending(c => c.Name).ToArray();
                    else
                        foods = foods.OrderBy(c => c.Name).ToArray();
                    break;
                case "性":
                    if (this.cbxPageSort.Text == "降序")
                        foods = foods.OrderByDescending(c => c.Nature).ToArray();
                    else
                        foods = foods.OrderBy(c => c.Nature).ToArray();
                    break;
                case "味":
                    if (this.cbxPageSort.Text == "降序")
                        foods = foods.OrderByDescending(c => c.Flavor).ToArray();
                    else
                        foods = foods.OrderBy(c => c.Flavor).ToArray();
                    break;
                case "归经":
                    if (this.cbxPageSort.Text == "降序")
                        foods = foods.OrderByDescending(c => c.Belong).ToArray();
                    else
                        foods = foods.OrderBy(c => c.Belong).ToArray();
                    break;
            }

            var pageSize = 0;
            int.TryParse(this.cbxPageSize.Text, out pageSize);
            var pageIndex = 0;
            int.TryParse(this.cbxPageIndex.Text, out pageIndex);

            return foods.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToArray();
        }

        #endregion

        #region 工具栏事件
        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Text == "新品")
            {
                this.ShowDialog<NewFoodUC>(new DialogOption() { Title = "添加新食物", Width = 690, Height = 550 }, (x) =>
                {
                    var formData = x as FoodEntity;
                    var food = Repository.Instance.QueryFirst<FoodEntity>($"Name='{formData.Name}'");
                    if (food == null)
                    {
                        Repository.Instance.Insert<FoodEntity>(x as FoodEntity);
                    }
                    else
                    {
                        formData.ID = food.ID;
                        Repository.Instance.Update<FoodEntity>(formData);
                    }
                });
            }
        }
        #endregion

    }
}
