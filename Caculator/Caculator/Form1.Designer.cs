namespace Calculator
{
    partial class Form1
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
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();

            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelKetQua = new System.Windows.Forms.Label();

            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();

            this.SuspendLayout();

            // 
            // btnCong
            // 
            this.btnCong.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                18F
            );
            this.btnCong.Location = new System.Drawing.Point(845, 100);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(149, 102);
            this.btnCong.TabIndex = 0;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);

            // 
            // btnTru
            // 
            this.btnTru.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                18F
            );
            this.btnTru.Location = new System.Drawing.Point(1061, 100);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(149, 102);
            this.btnTru.TabIndex = 1;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);

            // 
            // btnNhan
            // 
            this.btnNhan.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                18F
            );
            this.btnNhan.Location = new System.Drawing.Point(845, 244);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(149, 102);
            this.btnNhan.TabIndex = 2;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);

            // 
            // btnChia
            // 
            this.btnChia.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                18F
            );
            this.btnChia.Location = new System.Drawing.Point(1061, 244);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(149, 102);
            this.btnChia.TabIndex = 3;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);

            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                18F
            );
            this.labelA.Location = new System.Drawing.Point(42, 100);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(101, 40);
            this.labelA.TabIndex = 4;
            this.labelA.Text = "Số a";

            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                18F
            );
            this.labelB.Location = new System.Drawing.Point(42, 162);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(91, 40);
            this.labelB.TabIndex = 5;
            this.labelB.Text = "Số b";

            // 
            // labelKetQua
            // 
            this.labelKetQua.AutoSize = true;
            this.labelKetQua.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                18F
            );
            this.labelKetQua.Location = new System.Drawing.Point(42, 244);
            this.labelKetQua.Name = "labelKetQua";
            this.labelKetQua.Size = new System.Drawing.Size(141, 40);
            this.labelKetQua.TabIndex = 6;
            this.labelKetQua.Text = "Kết quả";

            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(200, 114);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(300, 26);
            this.txtA.TabIndex = 7;

            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(200, 176);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(300, 26);
            this.txtB.TabIndex = 8;

            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(200, 244);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(300, 26);
            this.txtKetQua.TabIndex = 9;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 450);

            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);

            this.Controls.Add(this.labelKetQua);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);

            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);

            this.Name = "Form1";
            this.Text = "Calculator";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelKetQua;

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}