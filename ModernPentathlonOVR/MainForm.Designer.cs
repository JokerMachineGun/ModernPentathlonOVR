namespace ModernPentathlonOVR
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.基础信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportAthelteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSwimming = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFencing = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHorsemanship = new System.Windows.Forms.ToolStripButton();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.MainTabPageSwimming = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MainFormMenuStrip.SuspendLayout();
            this.MainFormToolStrip.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础信息ToolStripMenuItem});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.MainFormMenuStrip.Size = new System.Drawing.Size(1924, 34);
            this.MainFormMenuStrip.TabIndex = 0;
            this.MainFormMenuStrip.Text = "MainFormMenuStrip";
            // 
            // 基础信息ToolStripMenuItem
            // 
            this.基础信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportAthelteToolStripMenuItem});
            this.基础信息ToolStripMenuItem.Name = "基础信息ToolStripMenuItem";
            this.基础信息ToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.基础信息ToolStripMenuItem.Text = "【基础信息】";
            // 
            // ImportAthelteToolStripMenuItem
            // 
            this.ImportAthelteToolStripMenuItem.Name = "ImportAthelteToolStripMenuItem";
            this.ImportAthelteToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.ImportAthelteToolStripMenuItem.Text = "导入运动员";
            this.ImportAthelteToolStripMenuItem.Click += new System.EventHandler(this.ImportAthelteToolStripMenuItem_Click);
            // 
            // MainFormToolStrip
            // 
            this.MainFormToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.MainFormToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSwimming,
            this.toolStripButtonFencing,
            this.toolStripButtonHorsemanship});
            this.MainFormToolStrip.Location = new System.Drawing.Point(0, 34);
            this.MainFormToolStrip.Name = "MainFormToolStrip";
            this.MainFormToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.MainFormToolStrip.Size = new System.Drawing.Size(1924, 53);
            this.MainFormToolStrip.TabIndex = 1;
            this.MainFormToolStrip.Text = "MainFormToolStrip";
            // 
            // toolStripButtonSwimming
            // 
            this.toolStripButtonSwimming.AutoSize = false;
            this.toolStripButtonSwimming.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.toolStripButtonSwimming.Image = global::ModernPentathlonOVR.Properties.Resources.SwimingLogo;
            this.toolStripButtonSwimming.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSwimming.Name = "toolStripButtonSwimming";
            this.toolStripButtonSwimming.Size = new System.Drawing.Size(100, 50);
            this.toolStripButtonSwimming.Text = "游泳";
            this.toolStripButtonSwimming.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButtonSwimming.Click += new System.EventHandler(this.toolStripButtonSwimming_Click);
            // 
            // toolStripButtonFencing
            // 
            this.toolStripButtonFencing.AutoSize = false;
            this.toolStripButtonFencing.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.toolStripButtonFencing.Image = global::ModernPentathlonOVR.Properties.Resources.FencingLogo;
            this.toolStripButtonFencing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFencing.Name = "toolStripButtonFencing";
            this.toolStripButtonFencing.Size = new System.Drawing.Size(100, 50);
            this.toolStripButtonFencing.Text = "击剑";
            this.toolStripButtonFencing.Click += new System.EventHandler(this.toolStripButtonFencing_Click);
            // 
            // toolStripButtonHorsemanship
            // 
            this.toolStripButtonHorsemanship.AutoSize = false;
            this.toolStripButtonHorsemanship.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.toolStripButtonHorsemanship.Image = global::ModernPentathlonOVR.Properties.Resources.HorsemanshipLogo;
            this.toolStripButtonHorsemanship.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHorsemanship.Name = "toolStripButtonHorsemanship";
            this.toolStripButtonHorsemanship.Size = new System.Drawing.Size(100, 50);
            this.toolStripButtonHorsemanship.Text = "马术";
            this.toolStripButtonHorsemanship.Click += new System.EventHandler(this.toolStripButtonHorsemanship_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.MainTabPageSwimming);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Location = new System.Drawing.Point(0, 106);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1924, 941);
            this.tabControlMain.TabIndex = 2;
            // 
            // MainTabPageSwimming
            // 
            this.MainTabPageSwimming.Location = new System.Drawing.Point(4, 28);
            this.MainTabPageSwimming.Name = "MainTabPageSwimming";
            this.MainTabPageSwimming.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabPageSwimming.Size = new System.Drawing.Size(1916, 909);
            this.MainTabPageSwimming.TabIndex = 0;
            this.MainTabPageSwimming.Text = "游泳";
            this.MainTabPageSwimming.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1916, 909);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1916, 947);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.MainFormToolStrip);
            this.Controls.Add(this.MainFormMenuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "现代五项 | Modern Pentathlon";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.MainFormToolStrip.ResumeLayout(false);
            this.MainFormToolStrip.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStrip MainFormToolStrip;
        private System.Windows.Forms.ToolStripMenuItem 基础信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportAthelteToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonSwimming;
        private System.Windows.Forms.ToolStripButton toolStripButtonFencing;
        private System.Windows.Forms.ToolStripButton toolStripButtonHorsemanship;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage MainTabPageSwimming;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

