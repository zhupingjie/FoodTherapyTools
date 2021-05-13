
namespace FoodTherapyTools
{
    partial class DesktopForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.lstFoods = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colCategory = new System.Windows.Forms.ColumnHeader();
            this.colNature = new System.Windows.Forms.ColumnHeader();
            this.colFlavor = new System.Windows.Forms.ColumnHeader();
            this.colBelong = new System.Windows.Forms.ColumnHeader();
            this.colLastDate = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbxPageSort = new System.Windows.Forms.ComboBox();
            this.cbxPageSize = new System.Windows.Forms.ComboBox();
            this.cbxPageIndex = new System.Windows.Forms.ComboBox();
            this.cbxPageFilter = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(895, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(895, 28);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // tsbNew
            // 
            this.tsbNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(46, 25);
            this.tsbNew.Text = "新品";
            this.tsbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lstFoods
            // 
            this.lstFoods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colCategory,
            this.colNature,
            this.colFlavor,
            this.colBelong,
            this.colLastDate});
            this.lstFoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFoods.HideSelection = false;
            this.lstFoods.Location = new System.Drawing.Point(0, 25);
            this.lstFoods.Name = "lstFoods";
            this.lstFoods.Size = new System.Drawing.Size(298, 432);
            this.lstFoods.TabIndex = 2;
            this.lstFoods.UseCompatibleStateImageBehavior = false;
            this.lstFoods.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "名称";
            this.colName.Width = 80;
            // 
            // colCategory
            // 
            this.colCategory.Text = "类别";
            // 
            // colNature
            // 
            this.colNature.Text = "性";
            this.colNature.Width = 50;
            // 
            // colFlavor
            // 
            this.colFlavor.Text = "味";
            this.colFlavor.Width = 50;
            // 
            // colBelong
            // 
            this.colBelong.Text = "归经";
            this.colBelong.Width = 100;
            // 
            // colLastDate
            // 
            this.colLastDate.Text = "更新";
            this.colLastDate.Width = 120;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstFoods);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 488);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 457);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 31);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtFoodName);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 25);
            this.panel2.TabIndex = 3;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFoodName.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFoodName.Location = new System.Drawing.Point(0, 0);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(129, 25);
            this.txtFoodName.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbxPageSort);
            this.panel4.Controls.Add(this.cbxPageSize);
            this.panel4.Controls.Add(this.cbxPageIndex);
            this.panel4.Controls.Add(this.cbxPageFilter);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(129, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(169, 25);
            this.panel4.TabIndex = 1;
            // 
            // cbxPageSort
            // 
            this.cbxPageSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPageSort.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxPageSort.FormattingEnabled = true;
            this.cbxPageSort.Items.AddRange(new object[] {
            "升序",
            "降序"});
            this.cbxPageSort.Location = new System.Drawing.Point(45, 0);
            this.cbxPageSort.Name = "cbxPageSort";
            this.cbxPageSort.Size = new System.Drawing.Size(44, 24);
            this.cbxPageSort.TabIndex = 3;
            this.cbxPageSort.Text = "降序";
            // 
            // cbxPageSize
            // 
            this.cbxPageSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbxPageSize.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxPageSize.FormattingEnabled = true;
            this.cbxPageSize.Items.AddRange(new object[] {
            "300",
            "200",
            "100",
            "50",
            "0"});
            this.cbxPageSize.Location = new System.Drawing.Point(89, 0);
            this.cbxPageSize.Name = "cbxPageSize";
            this.cbxPageSize.Size = new System.Drawing.Size(42, 24);
            this.cbxPageSize.TabIndex = 1;
            this.cbxPageSize.Text = "100";
            // 
            // cbxPageIndex
            // 
            this.cbxPageIndex.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbxPageIndex.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxPageIndex.FormattingEnabled = true;
            this.cbxPageIndex.Items.AddRange(new object[] {
            "1"});
            this.cbxPageIndex.Location = new System.Drawing.Point(131, 0);
            this.cbxPageIndex.Name = "cbxPageIndex";
            this.cbxPageIndex.Size = new System.Drawing.Size(38, 24);
            this.cbxPageIndex.TabIndex = 2;
            this.cbxPageIndex.Text = "1";
            // 
            // cbxPageFilter
            // 
            this.cbxPageFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxPageFilter.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxPageFilter.FormattingEnabled = true;
            this.cbxPageFilter.Items.AddRange(new object[] {
            "更新",
            "名称",
            "类别",
            "性",
            "味",
            "归经"});
            this.cbxPageFilter.Location = new System.Drawing.Point(0, 0);
            this.cbxPageFilter.Name = "cbxPageFilter";
            this.cbxPageFilter.Size = new System.Drawing.Size(45, 24);
            this.cbxPageFilter.TabIndex = 0;
            this.cbxPageFilter.Text = "更新";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(895, 491);
            this.splitContainer1.SplitterDistance = 298;
            this.splitContainer1.TabIndex = 4;
            // 
            // DesktopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 541);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip1);
            this.Name = "DesktopForm";
            this.Text = "食疗养生学v1.0";
            this.Load += new System.EventHandler(this.DesktopForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ListView lstFoods;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbxPageFilter;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ColumnHeader colNature;
        private System.Windows.Forms.ColumnHeader colFlavor;
        private System.Windows.Forms.ColumnHeader colBelong;
        private System.Windows.Forms.ComboBox cbxPageSize;
        private System.Windows.Forms.ComboBox cbxPageIndex;
        private System.Windows.Forms.ComboBox cbxPageSort;
        private System.Windows.Forms.ColumnHeader colLastDate;
    }
}

