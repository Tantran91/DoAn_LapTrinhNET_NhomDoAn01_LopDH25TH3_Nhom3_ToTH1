namespace QuanLiSanBong
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.txtTraCuu = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboThoiGian = new System.Windows.Forms.ComboBox();
            this.dtpNgayChon = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSanC = new System.Windows.Forms.Label();
            this.lblSanD = new System.Windows.Forms.Label();
            this.lblSanE = new System.Windows.Forms.Label();
            this.lblSanB = new System.Windows.Forms.Label();
            this.lblSanA = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTraCuu);
            this.groupBox2.Controls.Add(this.txtTraCuu);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1059, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tra cứu đặt sân:";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTraCuu.Location = new System.Drawing.Point(895, 26);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(129, 56);
            this.btnTraCuu.TabIndex = 1;
            this.btnTraCuu.Text = " Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // txtTraCuu
            // 
            this.txtTraCuu.Location = new System.Drawing.Point(25, 36);
            this.txtTraCuu.Multiline = true;
            this.txtTraCuu.Name = "txtTraCuu";
            this.txtTraCuu.Size = new System.Drawing.Size(841, 41);
            this.txtTraCuu.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.Location = new System.Drawing.Point(925, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(129, 50);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboThoiGian
            // 
            this.cboThoiGian.FormattingEnabled = true;
            this.cboThoiGian.Items.AddRange(new object[] {
            "7:00 - 8:00",
            "8:00 - 9:00",
            "9:00 - 10:00"});
            this.cboThoiGian.Location = new System.Drawing.Point(630, 41);
            this.cboThoiGian.Name = "cboThoiGian";
            this.cboThoiGian.Size = new System.Drawing.Size(250, 27);
            this.cboThoiGian.TabIndex = 4;
            // 
            // dtpNgayChon
            // 
            this.dtpNgayChon.Location = new System.Drawing.Point(186, 41);
            this.dtpNgayChon.Name = "dtpNgayChon";
            this.dtpNgayChon.Size = new System.Drawing.Size(245, 27);
            this.dtpNgayChon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn thời gian:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn ngày:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.cboThoiGian);
            this.groupBox1.Controls.Add(this.dtpNgayChon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 112);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lí sân:";
            // 
            // lblSanC
            // 
            this.lblSanC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSanC.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanC.Image = ((System.Drawing.Image)(resources.GetObject("lblSanC.Image")));
            this.lblSanC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSanC.Location = new System.Drawing.Point(443, 120);
            this.lblSanC.Name = "lblSanC";
            this.lblSanC.Size = new System.Drawing.Size(203, 333);
            this.lblSanC.TabIndex = 2;
            this.lblSanC.Click += new System.EventHandler(this.lblSanC_Click);
            // 
            // lblSanD
            // 
            this.lblSanD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSanD.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanD.Image = ((System.Drawing.Image)(resources.GetObject("lblSanD.Image")));
            this.lblSanD.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSanD.Location = new System.Drawing.Point(657, 120);
            this.lblSanD.Name = "lblSanD";
            this.lblSanD.Size = new System.Drawing.Size(203, 333);
            this.lblSanD.TabIndex = 2;
            this.lblSanD.Click += new System.EventHandler(this.lblSanD_Click);
            // 
            // lblSanE
            // 
            this.lblSanE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSanE.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanE.Image = ((System.Drawing.Image)(resources.GetObject("lblSanE.Image")));
            this.lblSanE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSanE.Location = new System.Drawing.Point(870, 120);
            this.lblSanE.Name = "lblSanE";
            this.lblSanE.Size = new System.Drawing.Size(203, 333);
            this.lblSanE.TabIndex = 2;
            this.lblSanE.Click += new System.EventHandler(this.lblSanE_Click);
            // 
            // lblSanB
            // 
            this.lblSanB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSanB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanB.Image = ((System.Drawing.Image)(resources.GetObject("lblSanB.Image")));
            this.lblSanB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSanB.Location = new System.Drawing.Point(228, 120);
            this.lblSanB.Name = "lblSanB";
            this.lblSanB.Size = new System.Drawing.Size(203, 333);
            this.lblSanB.TabIndex = 2;
            this.lblSanB.Click += new System.EventHandler(this.lblSanB_Click);
            // 
            // lblSanA
            // 
            this.lblSanA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSanA.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanA.Image = ((System.Drawing.Image)(resources.GetObject("lblSanA.Image")));
            this.lblSanA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSanA.Location = new System.Drawing.Point(14, 120);
            this.lblSanA.Name = "lblSanA";
            this.lblSanA.Size = new System.Drawing.Size(203, 333);
            this.lblSanA.TabIndex = 2;
            this.lblSanA.Click += new System.EventHandler(this.lblSanA_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSanC);
            this.panel1.Controls.Add(this.lblSanD);
            this.panel1.Controls.Add(this.lblSanE);
            this.panel1.Controls.Add(this.lblSanB);
            this.panel1.Controls.Add(this.lblSanA);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(23, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 463);
            this.panel1.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.MenuTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1136, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTrangChu,
            this.MenuThongKe,
            this.MenuDangXuat});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // MenuTrangChu
            // 
            this.MenuTrangChu.Name = "MenuTrangChu";
            this.MenuTrangChu.Size = new System.Drawing.Size(127, 22);
            this.MenuTrangChu.Text = "Trang chủ";
            // 
            // MenuThongKe
            // 
            this.MenuThongKe.Name = "MenuThongKe";
            this.MenuThongKe.Size = new System.Drawing.Size(127, 22);
            this.MenuThongKe.Text = "Thống kê";
            this.MenuThongKe.Click += new System.EventHandler(this.MenuThongKe_Click);
            // 
            // MenuDangXuat
            // 
            this.MenuDangXuat.Name = "MenuDangXuat";
            this.MenuDangXuat.Size = new System.Drawing.Size(127, 22);
            this.MenuDangXuat.Text = "Đăng xuất";
            this.MenuDangXuat.Click += new System.EventHandler(this.MenuDangXuat_Click);
            // 
            // MenuTroGiup
            // 
            this.MenuTroGiup.Name = "MenuTroGiup";
            this.MenuTroGiup.Size = new System.Drawing.Size(63, 20);
            this.MenuTroGiup.Text = "Trợ giúp";
            this.MenuTroGiup.Click += new System.EventHandler(this.MenuTroGiup_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1136, 631);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.Text = "Quản lí dịch vụ cho thuê sân bóng";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.TextBox txtTraCuu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboThoiGian;
        private System.Windows.Forms.DateTimePicker dtpNgayChon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSanC;
        private System.Windows.Forms.Label lblSanD;
        private System.Windows.Forms.Label lblSanE;
        private System.Windows.Forms.Label lblSanB;
        private System.Windows.Forms.Label lblSanA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem MenuTrangChu;
        private System.Windows.Forms.ToolStripMenuItem MenuThongKe;
        private System.Windows.Forms.ToolStripMenuItem MenuDangXuat;
    }
}