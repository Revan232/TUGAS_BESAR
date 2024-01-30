namespace Tugas_Besar_PBO.View
{
    partial class Form_jasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_jasa));
            this.gbsb = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.cb_jumlah = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_hargabintang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_bintang = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbjpr = new System.Windows.Forms.RadioButton();
            this.rbjpb = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbakun = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmp = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbtelepon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.batal = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rbjoki2 = new System.Windows.Forms.RadioButton();
            this.rbjoki = new System.Windows.Forms.RadioButton();
            this.resfresh_all = new System.Windows.Forms.Button();
            this.cb_diinginkan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_diinginkan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbsr = new System.Windows.Forms.GroupBox();
            this.gbsb.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.gbsr.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbsb
            // 
            this.gbsb.Controls.Add(this.label14);
            this.gbsb.Controls.Add(this.tbtotal);
            this.gbsb.Controls.Add(this.cb_jumlah);
            this.gbsb.Controls.Add(this.label13);
            this.gbsb.Controls.Add(this.label3);
            this.gbsb.Controls.Add(this.tb_hargabintang);
            this.gbsb.Controls.Add(this.label2);
            this.gbsb.Controls.Add(this.cb_bintang);
            this.gbsb.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsb.Location = new System.Drawing.Point(185, 8);
            this.gbsb.Name = "gbsb";
            this.gbsb.Size = new System.Drawing.Size(253, 144);
            this.gbsb.TabIndex = 0;
            this.gbsb.TabStop = false;
            this.gbsb.Text = "Jasa Per Bintang";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 16);
            this.label14.TabIndex = 9;
            this.label14.Text = "Total Harga";
            // 
            // tbtotal
            // 
            this.tbtotal.Location = new System.Drawing.Point(115, 97);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.ReadOnly = true;
            this.tbtotal.Size = new System.Drawing.Size(121, 20);
            this.tbtotal.TabIndex = 8;
            this.tbtotal.TextChanged += new System.EventHandler(this.tbtotal_TextChanged);
            // 
            // cb_jumlah
            // 
            this.cb_jumlah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_jumlah.FormattingEnabled = true;
            this.cb_jumlah.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_jumlah.Location = new System.Drawing.Point(115, 47);
            this.cb_jumlah.Name = "cb_jumlah";
            this.cb_jumlah.Size = new System.Drawing.Size(121, 24);
            this.cb_jumlah.TabIndex = 7;
            this.cb_jumlah.TextChanged += new System.EventHandler(this.cbbintang_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "Jumlah Bintang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rank Per Bintang";
            // 
            // tb_hargabintang
            // 
            this.tb_hargabintang.Location = new System.Drawing.Point(115, 73);
            this.tb_hargabintang.Name = "tb_hargabintang";
            this.tb_hargabintang.ReadOnly = true;
            this.tb_hargabintang.Size = new System.Drawing.Size(121, 20);
            this.tb_hargabintang.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Harga";
            // 
            // cb_bintang
            // 
            this.cb_bintang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_bintang.FormattingEnabled = true;
            this.cb_bintang.Location = new System.Drawing.Point(115, 23);
            this.cb_bintang.Name = "cb_bintang";
            this.cb_bintang.Size = new System.Drawing.Size(121, 24);
            this.cb_bintang.TabIndex = 1;
            this.cb_bintang.SelectedIndexChanged += new System.EventHandler(this.cb_bintang_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbjpr);
            this.groupBox3.Controls.Add(this.rbjpb);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 98);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jenis Jasa";
            // 
            // rbjpr
            // 
            this.rbjpr.AutoSize = true;
            this.rbjpr.Location = new System.Drawing.Point(30, 45);
            this.rbjpr.Name = "rbjpr";
            this.rbjpr.Size = new System.Drawing.Size(100, 20);
            this.rbjpr.TabIndex = 1;
            this.rbjpr.TabStop = true;
            this.rbjpr.Text = "Jasa per Rank";
            this.rbjpr.UseVisualStyleBackColor = true;
            this.rbjpr.CheckedChanged += new System.EventHandler(this.rbjpr_CheckedChanged);
            // 
            // rbjpb
            // 
            this.rbjpb.AutoSize = true;
            this.rbjpb.Location = new System.Drawing.Point(30, 19);
            this.rbjpb.Name = "rbjpb";
            this.rbjpb.Size = new System.Drawing.Size(111, 20);
            this.rbjpb.TabIndex = 0;
            this.rbjpb.TabStop = true;
            this.rbjpb.Text = "Jasa Per Bintang";
            this.rbjpb.UseVisualStyleBackColor = true;
            this.rbjpb.CheckedChanged += new System.EventHandler(this.rbjpb_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbakun);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.tbpassword);
            this.groupBox4.Controls.Add(this.tbemail);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(9, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(429, 110);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detail Akun";
            // 
            // tbakun
            // 
            this.tbakun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbakun.FormattingEnabled = true;
            this.tbakun.Items.AddRange(new object[] {
            "Google play",
            "Moonton",
            "Facebook"});
            this.tbakun.Location = new System.Drawing.Point(278, 45);
            this.tbakun.Name = "tbakun";
            this.tbakun.Size = new System.Drawing.Size(121, 24);
            this.tbakun.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Jenis Akun";
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(148, 46);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(121, 20);
            this.tbpassword.TabIndex = 8;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(9, 45);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(121, 20);
            this.tbemail.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email / Username";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.cbmp);
            this.groupBox5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(185, 159);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(253, 98);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Metode Pembayaraan";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(197, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Brimo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(124, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Gopay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "OVO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dana";
            // 
            // cbmp
            // 
            this.cbmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmp.FormattingEnabled = true;
            this.cbmp.Items.AddRange(new object[] {
            "DANA",
            "OVO",
            "GOPAY",
            "BRIMO"});
            this.cbmp.Location = new System.Drawing.Point(51, 29);
            this.cbmp.Name = "cbmp";
            this.cbmp.Size = new System.Drawing.Size(127, 24);
            this.cbmp.TabIndex = 6;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbtelepon);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(449, 158);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(286, 99);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "No Telepon";
            // 
            // tbtelepon
            // 
            this.tbtelepon.Location = new System.Drawing.Point(94, 35);
            this.tbtelepon.Name = "tbtelepon";
            this.tbtelepon.Size = new System.Drawing.Size(121, 20);
            this.tbtelepon.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "No Whatsapp";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.submit.Location = new System.Drawing.Point(461, 287);
            this.submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(90, 29);
            this.submit.TabIndex = 9;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // batal
            // 
            this.batal.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.batal.Location = new System.Drawing.Point(549, 330);
            this.batal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.batal.Name = "batal";
            this.batal.Size = new System.Drawing.Size(90, 29);
            this.batal.TabIndex = 10;
            this.batal.Text = "Batal";
            this.batal.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbjoki2);
            this.groupBox7.Controls.Add(this.rbjoki);
            this.groupBox7.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(9, 113);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(103, 80);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Penjoki";
            // 
            // rbjoki2
            // 
            this.rbjoki2.AutoSize = true;
            this.rbjoki2.Location = new System.Drawing.Point(9, 45);
            this.rbjoki2.Name = "rbjoki2";
            this.rbjoki2.Size = new System.Drawing.Size(88, 20);
            this.rbjoki2.TabIndex = 3;
            this.rbjoki2.TabStop = true;
            this.rbjoki2.Text = "Revan Yuda";
            this.rbjoki2.UseVisualStyleBackColor = true;
            // 
            // rbjoki
            // 
            this.rbjoki.AutoSize = true;
            this.rbjoki.Location = new System.Drawing.Point(9, 18);
            this.rbjoki.Name = "rbjoki";
            this.rbjoki.Size = new System.Drawing.Size(72, 20);
            this.rbjoki.TabIndex = 2;
            this.rbjoki.TabStop = true;
            this.rbjoki.Text = "Irgi Fauzi";
            this.rbjoki.UseVisualStyleBackColor = true;
            // 
            // resfresh_all
            // 
            this.resfresh_all.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resfresh_all.ForeColor = System.Drawing.SystemColors.Desktop;
            this.resfresh_all.Location = new System.Drawing.Point(639, 287);
            this.resfresh_all.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resfresh_all.Name = "resfresh_all";
            this.resfresh_all.Size = new System.Drawing.Size(90, 29);
            this.resfresh_all.TabIndex = 11;
            this.resfresh_all.Text = "Refresh";
            this.resfresh_all.UseVisualStyleBackColor = true;
            this.resfresh_all.Click += new System.EventHandler(this.resfresh_all_Click);
            // 
            // cb_diinginkan
            // 
            this.cb_diinginkan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_diinginkan.FormattingEnabled = true;
            this.cb_diinginkan.Location = new System.Drawing.Point(143, 36);
            this.cb_diinginkan.Name = "cb_diinginkan";
            this.cb_diinginkan.Size = new System.Drawing.Size(121, 24);
            this.cb_diinginkan.TabIndex = 1;
            this.cb_diinginkan.SelectedIndexChanged += new System.EventHandler(this.cb_diinginkan_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Harga";
            // 
            // tb_diinginkan
            // 
            this.tb_diinginkan.Location = new System.Drawing.Point(143, 71);
            this.tb_diinginkan.Name = "tb_diinginkan";
            this.tb_diinginkan.ReadOnly = true;
            this.tb_diinginkan.Size = new System.Drawing.Size(121, 20);
            this.tb_diinginkan.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rank yang diinginkan";
            // 
            // gbsr
            // 
            this.gbsr.Controls.Add(this.label4);
            this.gbsr.Controls.Add(this.tb_diinginkan);
            this.gbsr.Controls.Add(this.label5);
            this.gbsr.Controls.Add(this.cb_diinginkan);
            this.gbsr.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsr.Location = new System.Drawing.Point(449, 7);
            this.gbsr.Name = "gbsr";
            this.gbsr.Size = new System.Drawing.Size(286, 144);
            this.gbsr.TabIndex = 6;
            this.gbsr.TabStop = false;
            this.gbsr.Text = "jasa per Rank";
            // 
            // Form_jasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(745, 378);
            this.Controls.Add(this.resfresh_all);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.batal);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbsr);
            this.Controls.Add(this.gbsb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_jasa";
            this.Text = "Jasa Joki";
            this.Load += new System.EventHandler(this.Form_jasa_Load);
            this.gbsb.ResumeLayout(false);
            this.gbsb.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.gbsr.ResumeLayout(false);
            this.gbsr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbsb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_hargabintang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbjpr;
        private System.Windows.Forms.RadioButton rbjpb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox tbakun;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbtelepon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button batal;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button resfresh_all;
        private System.Windows.Forms.RadioButton rbjoki2;
        private System.Windows.Forms.RadioButton rbjoki;
        private System.Windows.Forms.ComboBox cb_bintang;
        private System.Windows.Forms.ComboBox cb_diinginkan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_diinginkan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbsr;
        private System.Windows.Forms.ComboBox cbmp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_jumlah;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbtotal;
    }
}