﻿namespace GUI
{
    partial class QuảnLý
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐọcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMượnSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTrảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhiếuPhạtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblThoat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýĐọcGiảToolStripMenuItem,
            this.quảnLýSáchToolStripMenuItem,
            this.quảnLýTácGiảToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.menuStrip1_Paint);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            // 
            // quảnLýĐọcGiảToolStripMenuItem
            // 
            this.quảnLýĐọcGiảToolStripMenuItem.Name = "quảnLýĐọcGiảToolStripMenuItem";
            this.quảnLýĐọcGiảToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.quảnLýĐọcGiảToolStripMenuItem.Text = "Quản Lý Đọc Giả";
            this.quảnLýĐọcGiảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐọcGiảToolStripMenuItem_Click);
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.quảnLýSáchToolStripMenuItem.Text = "Quản Lý Sách";
            this.quảnLýSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSáchToolStripMenuItem_Click);
            // 
            // quảnLýTácGiảToolStripMenuItem
            // 
            this.quảnLýTácGiảToolStripMenuItem.Name = "quảnLýTácGiảToolStripMenuItem";
            this.quảnLýTácGiảToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.quảnLýTácGiảToolStripMenuItem.Text = "Quản Lý Tác Giả";
            this.quảnLýTácGiảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTácGiảToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýMượnSáchToolStripMenuItem,
            this.quảnLýTrảSáchToolStripMenuItem,
            this.quảnLýPhiếuPhạtToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý Mượn Trả";
            // 
            // quảnLýMượnSáchToolStripMenuItem
            // 
            this.quảnLýMượnSáchToolStripMenuItem.Name = "quảnLýMượnSáchToolStripMenuItem";
            this.quảnLýMượnSáchToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.quảnLýMượnSáchToolStripMenuItem.Text = "Quản Lý Mượn Sách";
            // 
            // quảnLýTrảSáchToolStripMenuItem
            // 
            this.quảnLýTrảSáchToolStripMenuItem.Name = "quảnLýTrảSáchToolStripMenuItem";
            this.quảnLýTrảSáchToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.quảnLýTrảSáchToolStripMenuItem.Text = "Quản Lý Trả Sách";
            // 
            // quảnLýPhiếuPhạtToolStripMenuItem
            // 
            this.quảnLýPhiếuPhạtToolStripMenuItem.Name = "quảnLýPhiếuPhạtToolStripMenuItem";
            this.quảnLýPhiếuPhạtToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.quảnLýPhiếuPhạtToolStripMenuItem.Text = "Quản Lý Phiếu Phạt";
            // 
            // lblThoat
            // 
            this.lblThoat.AutoSize = true;
            this.lblThoat.Location = new System.Drawing.Point(764, 9);
            this.lblThoat.Name = "lblThoat";
            this.lblThoat.Size = new System.Drawing.Size(42, 16);
            this.lblThoat.TabIndex = 6;
            this.lblThoat.Text = "Thoát";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.anhnentv;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(888, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // QuảnLý
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 508);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblThoat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuảnLý";
            this.Text = "QuảnLý";
            this.Load += new System.EventHandler(this.QuảnLý_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐọcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMượnSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTrảSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhiếuPhạtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.Label lblThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}