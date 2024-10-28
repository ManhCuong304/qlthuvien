namespace GUI
{
    partial class Quản_Lý_Tác_Giả
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTk = new System.Windows.Forms.Button();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQue = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.btnTv = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.dtgTacGia = new System.Windows.Forms.DataGridView();
            this.clMtg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTk);
            this.groupBox1.Controls.Add(this.dtpNgay);
            this.groupBox1.Controls.Add(this.lblSearch);
            this.groupBox1.Controls.Add(this.txtTk);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtQue);
            this.groupBox1.Controls.Add(this.lblTen);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.lblNgay);
            this.groupBox1.Controls.Add(this.btnTv);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.lblMa);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1243, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tác Giả";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnTk
            // 
            this.btnTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTk.Location = new System.Drawing.Point(954, 104);
            this.btnTk.Name = "btnTk";
            this.btnTk.Size = new System.Drawing.Size(112, 51);
            this.btnTk.TabIndex = 37;
            this.btnTk.Text = "🔎Tìm Kiếm";
            this.btnTk.UseVisualStyleBackColor = true;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(500, 42);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(252, 22);
            this.dtpNgay.TabIndex = 36;
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(822, 16);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(367, 57);
            this.lblSearch.TabIndex = 35;
            this.lblSearch.Text = "Tìm Kiếm Tác Giả Theo Tên";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTk
            // 
            this.txtTk.Location = new System.Drawing.Point(911, 76);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(202, 22);
            this.txtTk.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Quê Quán:";
            // 
            // txtQue
            // 
            this.txtQue.Location = new System.Drawing.Point(500, 97);
            this.txtQue.Name = "txtQue";
            this.txtQue.Size = new System.Drawing.Size(252, 22);
            this.txtQue.TabIndex = 32;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(73, 102);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(82, 16);
            this.lblTen.TabIndex = 31;
            this.lblTen.Text = "Tên TácGiả:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(162, 97);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(184, 22);
            this.txtTen.TabIndex = 30;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(411, 47);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(72, 16);
            this.lblNgay.TabIndex = 29;
            this.lblNgay.Text = "Ngày Sinh:";
            // 
            // btnTv
            // 
            this.btnTv.Location = new System.Drawing.Point(1162, 196);
            this.btnTv.Name = "btnTv";
            this.btnTv.Size = new System.Drawing.Size(75, 23);
            this.btnTv.TabIndex = 27;
            this.btnTv.Text = "Trở Về";
            this.btnTv.UseVisualStyleBackColor = true;
            this.btnTv.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(540, 153);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(80, 46);
            this.btnsua.TabIndex = 26;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(362, 153);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 46);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(192, 153);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 46);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(73, 42);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(80, 16);
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "Mã Tác Giả:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(162, 37);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(184, 22);
            this.txtMa.TabIndex = 0;
            // 
            // dtgTacGia
            // 
            this.dtgTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMtg,
            this.clTen,
            this.clNgay,
            this.clQue});
            this.dtgTacGia.Location = new System.Drawing.Point(89, 242);
            this.dtgTacGia.Name = "dtgTacGia";
            this.dtgTacGia.ReadOnly = true;
            this.dtgTacGia.RowHeadersWidth = 51;
            this.dtgTacGia.RowTemplate.Height = 24;
            this.dtgTacGia.Size = new System.Drawing.Size(1037, 290);
            this.dtgTacGia.TabIndex = 1;
            // 
            // clMtg
            // 
            this.clMtg.HeaderText = "Mã Tác Giả";
            this.clMtg.MinimumWidth = 6;
            this.clMtg.Name = "clMtg";
            this.clMtg.ReadOnly = true;
            this.clMtg.Width = 125;
            // 
            // clTen
            // 
            this.clTen.HeaderText = "Tên Tác Giả";
            this.clTen.MinimumWidth = 6;
            this.clTen.Name = "clTen";
            this.clTen.ReadOnly = true;
            this.clTen.Width = 200;
            // 
            // clNgay
            // 
            this.clNgay.HeaderText = "Ngày Sinh";
            this.clNgay.MinimumWidth = 6;
            this.clNgay.Name = "clNgay";
            this.clNgay.ReadOnly = true;
            this.clNgay.Width = 200;
            // 
            // clQue
            // 
            this.clQue.HeaderText = "Quê Quán";
            this.clQue.MinimumWidth = 6;
            this.clQue.Name = "clQue";
            this.clQue.ReadOnly = true;
            this.clQue.Width = 200;
            // 
            // Quản_Lý_Tác_Giả
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 544);
            this.Controls.Add(this.dtgTacGia);
            this.Controls.Add(this.groupBox1);
            this.Name = "Quản_Lý_Tác_Giả";
            this.Text = "Quản_Lý_Tác_Giả";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Quản_Lý_Tác_Giả_FormClosing);
            this.Load += new System.EventHandler(this.Quản_Lý_Tác_Giả_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTacGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Button btnTv;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTk;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQue;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DataGridView dtgTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQue;
    }
}