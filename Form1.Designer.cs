﻿
namespace PlayerDataBackupTool_CSharp
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listPlayer = new System.Windows.Forms.ListBox();
            this.listTime = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPlayer
            // 
            this.listPlayer.FormattingEnabled = true;
            this.listPlayer.ItemHeight = 18;
            this.listPlayer.Location = new System.Drawing.Point(40, 26);
            this.listPlayer.Name = "listPlayer";
            this.listPlayer.Size = new System.Drawing.Size(264, 382);
            this.listPlayer.TabIndex = 0;
            this.listPlayer.SelectedIndexChanged += new System.EventHandler(this.listPlayer_SelectedIndexChanged);
            // 
            // listTime
            // 
            this.listTime.FormattingEnabled = true;
            this.listTime.ItemHeight = 18;
            this.listTime.Location = new System.Drawing.Point(310, 26);
            this.listTime.Name = "listTime";
            this.listTime.Size = new System.Drawing.Size(252, 382);
            this.listTime.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "一键备份";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listTime);
            this.Controls.Add(this.listPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listPlayer;
        private System.Windows.Forms.ListBox listTime;
        private System.Windows.Forms.Button button1;
    }
}
