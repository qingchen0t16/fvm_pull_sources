namespace GetMeiShiSource
{
    partial class Main
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.DownloadConfig = new System.Windows.Forms.Button();
            this.DownloadStart = new System.Windows.Forms.Button();
            this.DownloadPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 30);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(0, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "作者 : 轻辰 BUG反馈群 : 793948166";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.DownloadConfig);
            this.panel1.Controls.Add(this.DownloadStart);
            this.panel1.Controls.Add(this.DownloadPath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 101);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(642, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DownloadConfig
            // 
            this.DownloadConfig.Location = new System.Drawing.Point(3, 72);
            this.DownloadConfig.Name = "DownloadConfig";
            this.DownloadConfig.Size = new System.Drawing.Size(85, 26);
            this.DownloadConfig.TabIndex = 3;
            this.DownloadConfig.Text = "详细配置";
            this.DownloadConfig.UseVisualStyleBackColor = true;
            this.DownloadConfig.Click += new System.EventHandler(this.DownloadConfig_Click);
            // 
            // DownloadStart
            // 
            this.DownloadStart.Location = new System.Drawing.Point(685, 25);
            this.DownloadStart.Name = "DownloadStart";
            this.DownloadStart.Size = new System.Drawing.Size(94, 29);
            this.DownloadStart.TabIndex = 2;
            this.DownloadStart.Text = "开始下载";
            this.DownloadStart.UseVisualStyleBackColor = true;
            // 
            // DownloadPath
            // 
            this.DownloadPath.Location = new System.Drawing.Point(94, 27);
            this.DownloadPath.Name = "DownloadPath";
            this.DownloadPath.Size = new System.Drawing.Size(542, 27);
            this.DownloadPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "下载位置:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 200);
            this.panel3.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 331);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Main";
            this.Text = "获取美食大战老鼠资源";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private Button DownloadStart;
        private TextBox DownloadPath;
        private Label label1;
        private Panel panel3;
        private Button button2;
        private Button DownloadConfig;
    }
}