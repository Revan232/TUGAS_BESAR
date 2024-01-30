namespace Tugas_Besar_PBO
{
    partial class Form_Data_Diamond
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Data_Diamond));
            this.bdiamond = new System.Windows.Forms.TextBox();
            this.gbdata = new System.Windows.Forms.GroupBox();
            this.DataDiamond = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.jdiamond = new System.Windows.Forms.TextBox();
            this.hdiamond = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Simpan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbdata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataDiamond)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdiamond
            // 
            this.bdiamond.Location = new System.Drawing.Point(206, 78);
            this.bdiamond.Name = "bdiamond";
            this.bdiamond.Size = new System.Drawing.Size(175, 31);
            this.bdiamond.TabIndex = 1;
            // 
            // gbdata
            // 
            this.gbdata.BackColor = System.Drawing.Color.Transparent;
            this.gbdata.Controls.Add(this.DataDiamond);
            this.gbdata.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdata.Location = new System.Drawing.Point(6, -2);
            this.gbdata.Name = "gbdata";
            this.gbdata.Size = new System.Drawing.Size(708, 451);
            this.gbdata.TabIndex = 3;
            this.gbdata.TabStop = false;
            this.gbdata.Text = "Data Diamond";
            // 
            // DataDiamond
            // 
            this.DataDiamond.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataDiamond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDiamond.Location = new System.Drawing.Point(6, 25);
            this.DataDiamond.Name = "DataDiamond";
            this.DataDiamond.RowHeadersWidth = 62;
            this.DataDiamond.RowTemplate.Height = 28;
            this.DataDiamond.Size = new System.Drawing.Size(696, 417);
            this.DataDiamond.TabIndex = 0;
            this.DataDiamond.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataDiamond_CellClick);
            this.DataDiamond.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataDiamond_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jumlah Diamond";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.jdiamond);
            this.groupBox2.Controls.Add(this.hdiamond);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bdiamond);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(729, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 158);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Diamond";
            // 
            // jdiamond
            // 
            this.jdiamond.Location = new System.Drawing.Point(206, 41);
            this.jdiamond.Name = "jdiamond";
            this.jdiamond.Size = new System.Drawing.Size(175, 31);
            this.jdiamond.TabIndex = 10;
            // 
            // hdiamond
            // 
            this.hdiamond.Location = new System.Drawing.Point(206, 118);
            this.hdiamond.Name = "hdiamond";
            this.hdiamond.Size = new System.Drawing.Size(175, 31);
            this.hdiamond.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bonus Diamond";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Harga Diamond";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(935, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 132);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Form Pencarian";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cari Data";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(10, 66);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(180, 31);
            this.textBox6.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 26);
            this.label9.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.Simpan);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(729, -2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 288);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tombol Action";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(42, 148);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "Ubah";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Ubah_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // Simpan
            // 
            this.Simpan.Location = new System.Drawing.Point(42, 91);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(134, 52);
            this.Simpan.TabIndex = 1;
            this.Simpan.Text = "Simpan";
            this.Simpan.UseVisualStyleBackColor = true;
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Resfresh_Click);
            // 
            // Form_Data_Diamond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1148, 460);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbdata);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Data_Diamond";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form_Data_Diamond_Load);
            this.gbdata.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataDiamond)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox bdiamond;
        private System.Windows.Forms.GroupBox gbdata;
        private System.Windows.Forms.DataGridView DataDiamond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox hdiamond;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Simpan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox jdiamond;
    }
}

