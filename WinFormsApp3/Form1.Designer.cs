namespace WinFormsApp3
{
    partial class Form1
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
            label1 = new Label();
            txtMaSV = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtHoTen = new TextBox();
            label5 = new Label();
            txtSdt = new TextBox();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label7 = new Label();
            nudDiem = new NumericUpDown();
            dptNgaysinh = new DateTimePicker();
            label8 = new Label();
            cpoTrangthai = new Label();
            cboLop = new ComboBox();
            cboTrangthai = new ComboBox();
            groupBox2 = new GroupBox();
            txtTongso = new TextBox();
            label12 = new Label();
            dgvSinhvien = new DataGridView();
            groupBox3 = new GroupBox();
            btnHienthi = new Button();
            btnThem = new Button();
            btnTimkiem = new Button();
            btnSua = new Button();
            cboDiemtu = new ComboBox();
            btnXoa = new Button();
            cboLophoc = new ComboBox();
            btnLammoi = new Button();
            label11 = new Label();
            cboLoptimkiem = new TextBox();
            label10 = new Label();
            label9 = new Label();
            pnlHeader = new Panel();
            lblCam = new Label();
            lblHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDiem).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhvien).BeginInit();
            groupBox3.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 99);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên*";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(164, 96);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(150, 31);
            txtMaSV.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI", 15F);
            groupBox1.Location = new Point(23, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1096, 232);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 143);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 2;
            label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 192);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 3;
            label3.Text = "Email*";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(117, 192);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(370, 102);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 5;
            label4.Text = "Họ tên*";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(454, 99);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(234, 31);
            txtHoTen.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(370, 198);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 7;
            label5.Text = "Điện thoại";
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(493, 195);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(150, 31);
            txtSdt.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(370, 146);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 9;
            label6.Text = "Giới tính";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(493, 146);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 29);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(597, 146);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(61, 29);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(717, 148);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 14;
            label7.Text = "Điểm";
            // 
            // nudDiem
            // 
            nudDiem.DecimalPlaces = 1;
            nudDiem.Location = new Point(777, 146);
            nudDiem.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDiem.Name = "nudDiem";
            nudDiem.Size = new Size(180, 31);
            nudDiem.TabIndex = 15;
            // 
            // dptNgaysinh
            // 
            dptNgaysinh.Format = DateTimePickerFormat.Custom;
            dptNgaysinh.Location = new Point(138, 143);
            dptNgaysinh.Name = "dptNgaysinh";
            dptNgaysinh.Size = new Size(226, 31);
            dptNgaysinh.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(717, 99);
            label8.Name = "label8";
            label8.Size = new Size(76, 25);
            label8.TabIndex = 17;
            label8.Text = "Lớp học";
            // 
            // cpoTrangthai
            // 
            cpoTrangthai.AutoSize = true;
            cpoTrangthai.Location = new Point(717, 201);
            cpoTrangthai.Name = "cpoTrangthai";
            cpoTrangthai.Size = new Size(94, 25);
            cpoTrangthai.TabIndex = 18;
            cpoTrangthai.Text = "Trạng thái ";
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(799, 99);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(182, 33);
            cboLop.TabIndex = 19;
            // 
            // cboTrangthai
            // 
            cboTrangthai.FormattingEnabled = true;
            cboTrangthai.Location = new Point(814, 192);
            cboTrangthai.Name = "cboTrangthai";
            cboTrangthai.Size = new Size(182, 33);
            cboTrangthai.TabIndex = 20;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTongso);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(dgvSinhvien);
            groupBox2.Font = new Font("Segoe UI", 15F);
            groupBox2.Location = new Point(23, 443);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1096, 330);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sinh viên";
            // 
            // txtTongso
            // 
            txtTongso.Font = new Font("Segoe UI", 9F);
            txtTongso.Location = new Point(916, 46);
            txtTongso.Name = "txtTongso";
            txtTongso.Size = new Size(150, 31);
            txtTongso.TabIndex = 35;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F);
            label12.Location = new Point(836, 52);
            label12.Name = "label12";
            label12.Size = new Size(77, 25);
            label12.TabIndex = 35;
            label12.Text = "Tổng số";
            // 
            // dgvSinhvien
            // 
            dgvSinhvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhvien.Location = new Point(32, 87);
            dgvSinhvien.Name = "dgvSinhvien";
            dgvSinhvien.RowHeadersWidth = 62;
            dgvSinhvien.Size = new Size(1037, 225);
            dgvSinhvien.TabIndex = 35;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnHienthi);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Controls.Add(btnTimkiem);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(cboDiemtu);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(cboLophoc);
            groupBox3.Controls.Add(btnLammoi);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(cboLoptimkiem);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(23, 262);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1291, 170);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            // 
            // btnHienthi
            // 
            btnHienthi.BackColor = Color.MediumSeaGreen;
            btnHienthi.Location = new Point(1119, 108);
            btnHienthi.Name = "btnHienthi";
            btnHienthi.Size = new Size(112, 34);
            btnHienthi.TabIndex = 46;
            btnHienthi.Text = "Hiển thị tất";
            btnHienthi.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumSeaGreen;
            btnThem.Location = new Point(732, 44);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 35;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnTimkiem
            // 
            btnTimkiem.BackColor = Color.MediumSeaGreen;
            btnTimkiem.Location = new Point(990, 110);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(112, 34);
            btnTimkiem.TabIndex = 45;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.MediumSeaGreen;
            btnSua.Location = new Point(860, 44);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 36;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // cboDiemtu
            // 
            cboDiemtu.FormattingEnabled = true;
            cboDiemtu.Location = new Point(775, 110);
            cboDiemtu.Name = "cboDiemtu";
            cboDiemtu.Size = new Size(182, 33);
            cboDiemtu.TabIndex = 44;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.MediumSeaGreen;
            btnXoa.Location = new Point(991, 44);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 37;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // cboLophoc
            // 
            cboLophoc.FormattingEnabled = true;
            cboLophoc.Location = new Point(513, 112);
            cboLophoc.Name = "cboLophoc";
            cboLophoc.Size = new Size(174, 33);
            cboLophoc.TabIndex = 43;
            // 
            // btnLammoi
            // 
            btnLammoi.BackColor = Color.MediumSeaGreen;
            btnLammoi.Location = new Point(1126, 44);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(112, 34);
            btnLammoi.TabIndex = 38;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(431, 118);
            label11.Name = "label11";
            label11.Size = new Size(76, 25);
            label11.TabIndex = 42;
            label11.Text = "Lớp học";
            // 
            // cboLoptimkiem
            // 
            cboLoptimkiem.Location = new Point(104, 113);
            cboLoptimkiem.Name = "cboLoptimkiem";
            cboLoptimkiem.PlaceholderText = "Mã, họ tên, email, điện thoại";
            cboLoptimkiem.Size = new Size(289, 31);
            cboLoptimkiem.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(693, 118);
            label10.Name = "label10";
            label10.Size = new Size(76, 25);
            label10.TabIndex = 41;
            label10.Text = "Điểm từ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 116);
            label9.Name = "label9";
            label9.Size = new Size(76, 25);
            label9.TabIndex = 39;
            label9.Text = "Từ khóa";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SlateGray;
            pnlHeader.Controls.Add(lblCam);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1406, 42);
            pnlHeader.TabIndex = 27;
            pnlHeader.Paint += pnlHeader_Paint;
            // 
            // lblCam
            // 
            lblCam.AutoSize = true;
            lblCam.BackColor = Color.DarkOrange;
            lblCam.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCam.ForeColor = Color.White;
            lblCam.Location = new Point(27, 6);
            lblCam.Name = "lblCam";
            lblCam.Size = new Size(27, 32);
            lblCam.TabIndex = 28;
            lblCam.Text = "S";
            lblCam.TextAlign = ContentAlignment.MiddleCenter;
            lblCam.Click += label13_Click_1;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(69, 3);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(350, 36);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Ứng dụng quản lý sinh viên\n";
            lblHeader.Click += label13_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 795);
            Controls.Add(pnlHeader);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(cboTrangthai);
            Controls.Add(cboLop);
            Controls.Add(cpoTrangthai);
            Controls.Add(label8);
            Controls.Add(dptNgaysinh);
            Controls.Add(nudDiem);
            Controls.Add(label7);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtSdt);
            Controls.Add(label4);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtMaSV);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudDiem).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhvien).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaSV;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtHoTen;
        private Label label5;
        private TextBox txtSdt;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label7;
        private NumericUpDown nudDiem;
        private DateTimePicker dptNgaysinh;
        private Label label8;
        private Label cpoTrangthai;
        private ComboBox cboLop;
        private ComboBox cboTrangthai;
        private GroupBox groupBox2;
        private DataGridView dgvSinhvien;
        private Label label12;
        private TextBox txtTongso;
        private GroupBox groupBox3;
        private Button btnHienthi;
        private Button btnThem;
        private Button btnTimkiem;
        private Button btnSua;
        private ComboBox cboDiemtu;
        private Button btnXoa;
        private ComboBox cboLophoc;
        private Button btnLammoi;
        private Label label11;
        private TextBox cboLoptimkiem;
        private Label label10;
        private Label label9;
        private Panel pnlHeader;
        private Label lblHeader;
        private Label lblCam;
    }
}
