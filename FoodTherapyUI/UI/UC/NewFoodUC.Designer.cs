
namespace FoodTherapyUI.UI
{
    partial class NewFoodUC
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtNature = new System.Windows.Forms.TextBox();
            this.txtFlavor = new System.Windows.Forms.TextBox();
            this.txtPoison = new System.Windows.Forms.TextBox();
            this.txtBelong = new System.Windows.Forms.TextBox();
            this.txtNutrition = new System.Windows.Forms.TextBox();
            this.txtOfficinal = new System.Windows.Forms.TextBox();
            this.txtSuitable = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(27, 22);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "食物名称";
            this.txtName.Size = new System.Drawing.Size(303, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtCategory
            // 
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategory.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCategory.Location = new System.Drawing.Point(352, 22);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.PlaceholderText = "属";
            this.txtCategory.Size = new System.Drawing.Size(303, 22);
            this.txtCategory.TabIndex = 1;
            // 
            // txtNature
            // 
            this.txtNature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNature.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNature.Location = new System.Drawing.Point(27, 50);
            this.txtNature.Name = "txtNature";
            this.txtNature.PlaceholderText = "性";
            this.txtNature.Size = new System.Drawing.Size(303, 22);
            this.txtNature.TabIndex = 2;
            // 
            // txtFlavor
            // 
            this.txtFlavor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFlavor.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFlavor.Location = new System.Drawing.Point(352, 50);
            this.txtFlavor.Name = "txtFlavor";
            this.txtFlavor.PlaceholderText = "味";
            this.txtFlavor.Size = new System.Drawing.Size(303, 22);
            this.txtFlavor.TabIndex = 3;
            // 
            // txtPoison
            // 
            this.txtPoison.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPoison.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPoison.Location = new System.Drawing.Point(27, 78);
            this.txtPoison.Name = "txtPoison";
            this.txtPoison.PlaceholderText = "毒";
            this.txtPoison.Size = new System.Drawing.Size(303, 22);
            this.txtPoison.TabIndex = 4;
            // 
            // txtBelong
            // 
            this.txtBelong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBelong.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBelong.Location = new System.Drawing.Point(352, 78);
            this.txtBelong.Name = "txtBelong";
            this.txtBelong.PlaceholderText = "归经";
            this.txtBelong.Size = new System.Drawing.Size(303, 22);
            this.txtBelong.TabIndex = 5;
            // 
            // txtNutrition
            // 
            this.txtNutrition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNutrition.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNutrition.Location = new System.Drawing.Point(27, 106);
            this.txtNutrition.Multiline = true;
            this.txtNutrition.Name = "txtNutrition";
            this.txtNutrition.PlaceholderText = "营养";
            this.txtNutrition.Size = new System.Drawing.Size(628, 85);
            this.txtNutrition.TabIndex = 6;
            // 
            // txtOfficinal
            // 
            this.txtOfficinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOfficinal.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOfficinal.Location = new System.Drawing.Point(27, 197);
            this.txtOfficinal.Multiline = true;
            this.txtOfficinal.Name = "txtOfficinal";
            this.txtOfficinal.PlaceholderText = "药用";
            this.txtOfficinal.Size = new System.Drawing.Size(628, 85);
            this.txtOfficinal.TabIndex = 7;
            // 
            // txtSuitable
            // 
            this.txtSuitable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuitable.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSuitable.Location = new System.Drawing.Point(27, 288);
            this.txtSuitable.Multiline = true;
            this.txtSuitable.Name = "txtSuitable";
            this.txtSuitable.PlaceholderText = "宜忌";
            this.txtSuitable.Size = new System.Drawing.Size(628, 85);
            this.txtSuitable.TabIndex = 8;
            // 
            // txtDesc
            // 
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDesc.Location = new System.Drawing.Point(27, 379);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PlaceholderText = "描述";
            this.txtDesc.Size = new System.Drawing.Size(628, 85);
            this.txtDesc.TabIndex = 9;
            // 
            // NewFoodUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtSuitable);
            this.Controls.Add(this.txtOfficinal);
            this.Controls.Add(this.txtNutrition);
            this.Controls.Add(this.txtBelong);
            this.Controls.Add(this.txtPoison);
            this.Controls.Add(this.txtFlavor);
            this.Controls.Add(this.txtNature);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtName);
            this.Name = "NewFoodUC";
            this.Size = new System.Drawing.Size(684, 488);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtNature;
        private System.Windows.Forms.TextBox txtFlavor;
        private System.Windows.Forms.TextBox txtPoison;
        private System.Windows.Forms.TextBox txtBelong;
        private System.Windows.Forms.TextBox txtNutrition;
        private System.Windows.Forms.TextBox txtOfficinal;
        private System.Windows.Forms.TextBox txtSuitable;
        private System.Windows.Forms.TextBox txtDesc;
    }
}
