namespace buoi_5
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
            GroupBox thongtinhocvien;
            GroupBox groupBox1;
            email = new Label();
            nhanemail = new CheckBox();
            ngaysinh = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            sdt = new TextBox();
            hoten = new TextBox();
            tonghocphi = new Label();
            khoahoc = new ComboBox();
            tonghp = new Label();
            thanghoc = new NumericUpDown();
            offline = new RadioButton();
            online = new RadioButton();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dangki = new Button();
            lammoi = new Button();
            button3 = new Button();
            thongtinhocvien = new GroupBox();
            groupBox1 = new GroupBox();
            thongtinhocvien.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)thanghoc).BeginInit();
            SuspendLayout();
            // 
            // thongtinhocvien
            // 
            thongtinhocvien.Controls.Add(email);
            thongtinhocvien.Controls.Add(nhanemail);
            thongtinhocvien.Controls.Add(ngaysinh);
            thongtinhocvien.Controls.Add(label3);
            thongtinhocvien.Controls.Add(label2);
            thongtinhocvien.Controls.Add(label1);
            thongtinhocvien.Controls.Add(sdt);
            thongtinhocvien.Controls.Add(hoten);
            thongtinhocvien.Location = new Point(12, 12);
            thongtinhocvien.Name = "thongtinhocvien";
            thongtinhocvien.Size = new Size(436, 173);
            thongtinhocvien.TabIndex = 0;
            thongtinhocvien.TabStop = false;
            thongtinhocvien.Tag = "";
            thongtinhocvien.Text = "thông tin học viên";
            thongtinhocvien.Enter += thongtinhocvien_Enter;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(188, 129);
            email.Name = "email";
            email.Size = new Size(155, 20);
            email.TabIndex = 8;
            email.Text = "nhận email thông báo";
            // 
            // nhanemail
            // 
            nhanemail.AutoSize = true;
            nhanemail.Location = new Point(155, 132);
            nhanemail.Name = "nhanemail";
            nhanemail.Size = new Size(18, 17);
            nhanemail.TabIndex = 7;
            nhanemail.UseVisualStyleBackColor = true;
            // 
            // ngaysinh
            // 
            ngaysinh.Location = new Point(155, 99);
            ngaysinh.Name = "ngaysinh";
            ngaysinh.Size = new Size(250, 27);
            ngaysinh.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 99);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 5;
            label3.Text = "ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 66);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 4;
            label2.Text = "số điện thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 3;
            label1.Text = "họ và tên";
            label1.Click += label1_Click;
            // 
            // sdt
            // 
            sdt.Location = new Point(155, 59);
            sdt.Name = "sdt";
            sdt.Size = new Size(125, 27);
            sdt.TabIndex = 1;
            // 
            // hoten
            // 
            hoten.Location = new Point(155, 26);
            hoten.Name = "hoten";
            hoten.Size = new Size(125, 27);
            hoten.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tonghocphi);
            groupBox1.Controls.Add(khoahoc);
            groupBox1.Controls.Add(tonghp);
            groupBox1.Controls.Add(thanghoc);
            groupBox1.Controls.Add(offline);
            groupBox1.Controls.Add(online);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(12, 191);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 173);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Tag = "";
            groupBox1.Text = "thông tin khóa học";
            // 
            // tonghocphi
            // 
            tonghocphi.AutoSize = true;
            tonghocphi.Location = new Point(159, 132);
            tonghocphi.Name = "tonghocphi";
            tonghocphi.Size = new Size(52, 20);
            tonghocphi.TabIndex = 15;
            tonghocphi.Text = "0 VNĐ";
            tonghocphi.Click += label9_Click;
            // 
            // khoahoc
            // 
            khoahoc.FormattingEnabled = true;
            khoahoc.Location = new Point(155, 26);
            khoahoc.Name = "khoahoc";
            khoahoc.Size = new Size(275, 28);
            khoahoc.TabIndex = 13;
            khoahoc.SelectedIndexChanged += khoahoc_SelectedIndexChanged_1;
            // 
            // tonghp
            // 
            tonghp.AutoSize = true;
            tonghp.Location = new Point(23, 132);
            tonghp.Name = "tonghp";
            tonghp.Size = new Size(129, 20);
            tonghp.TabIndex = 12;
            tonghp.Text = "tổng tiền học phí :";
            tonghp.Click += tonghp_Click;
            // 
            // thanghoc
            // 
            thanghoc.Location = new Point(158, 97);
            thanghoc.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            thanghoc.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            thanghoc.Name = "thanghoc";
            thanghoc.Size = new Size(150, 27);
            thanghoc.TabIndex = 11;
            thanghoc.Value = new decimal(new int[] { 1, 0, 0, 0 });
            thanghoc.ValueChanged += thanghoc_ValueChanged;
            // 
            // offline
            // 
            offline.AutoSize = true;
            offline.Location = new Point(272, 62);
            offline.Name = "offline";
            offline.Size = new Size(73, 24);
            offline.TabIndex = 10;
            offline.TabStop = true;
            offline.Text = "offline";
            offline.UseVisualStyleBackColor = true;
            // 
            // online
            // 
            online.AutoSize = true;
            online.Location = new Point(158, 62);
            online.Name = "online";
            online.Size = new Size(71, 24);
            online.TabIndex = 9;
            online.TabStop = true;
            online.Text = "online";
            online.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 99);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 5;
            label6.Text = "số tháng đăng ký";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 66);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 4;
            label7.Text = "hình thức học";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 29);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 3;
            label8.Text = "chọn khóa học";
            label8.Click += label8_Click;
            // 
            // dangki
            // 
            dangki.Location = new Point(625, 121);
            dangki.Name = "dangki";
            dangki.Size = new Size(94, 29);
            dangki.TabIndex = 2;
            dangki.Text = "Đăng ký";
            dangki.UseVisualStyleBackColor = true;
            dangki.Click += button1_Click;
            // 
            // lammoi
            // 
            lammoi.Location = new Point(625, 191);
            lammoi.Name = "lammoi";
            lammoi.Size = new Size(94, 29);
            lammoi.TabIndex = 3;
            lammoi.Text = "Làm mới";
            lammoi.UseVisualStyleBackColor = true;
            lammoi.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(625, 257);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(lammoi);
            Controls.Add(dangki);
            Controls.Add(groupBox1);
            Controls.Add(thongtinhocvien);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            thongtinhocvien.ResumeLayout(false);
            thongtinhocvien.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)thanghoc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox thongtinhocvien;
        private TextBox sdt;
        private TextBox hoten;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label email;
        private CheckBox nhanemail;
        private DateTimePicker ngaysinh;
        private RadioButton offline;
        private RadioButton online;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox khoahoc;
        private Label tonghp;
        private NumericUpDown thanghoc;
        private Button dangki;
        private Button lammoi;
        private Button button3;
        private Label tonghocphi;
    }
}
