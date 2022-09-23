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
            this.MainFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonFencing = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSwimming = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Size = new System.Drawing.Size(1350, 24);
            this.MainFormMenuStrip.TabIndex = 0;
            this.MainFormMenuStrip.Text = "MainFormMenuStrip";
            // 
            // MainFormToolStrip
            // 
            this.MainFormToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.MainFormToolStrip.Location = new System.Drawing.Point(0, 24);
            this.MainFormToolStrip.Name = "MainFormToolStrip";
            this.MainFormToolStrip.Size = new System.Drawing.Size(1350, 25);
            this.MainFormToolStrip.TabIndex = 1;
            this.MainFormToolStrip.Text = "MainFormToolStrip";
            // 
            // toolStripButtonFencing
            // 
            this.toolStripButtonFencing.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFencing.Image")));
            this.toolStripButtonFencing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFencing.Name = "toolStripButtonFencing";
            this.toolStripButtonFencing.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonFencing.Text = "击剑";
            this.toolStripButtonFencing.Click += new System.EventHandler(this.toolStripButtonFencing_Click);
            // 
            // toolStripButtonSwimming
            // 
            this.toolStripButtonSwimming.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSwimming.Image")));
            this.toolStripButtonSwimming.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSwimming.Name = "toolStripButtonSwimming";
            this.toolStripButtonSwimming.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonSwimming.Text = "游泳";
            this.toolStripButtonSwimming.Click += new System.EventHandler(this.toolStripButtonSwimming_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(18, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 64);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(0, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 345);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainFormToolStrip);
            this.Controls.Add(this.MainFormMenuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.Name = "MainForm";
            this.Text = "现代五项 | Modern Pentathlon";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStrip MainFormToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonFencing;
        private System.Windows.Forms.ToolStripButton toolStripButtonSwimming;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

