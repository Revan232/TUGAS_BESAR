namespace Tugas_Besar_PBO.View
{
    partial class Form_Konfirmasi
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
            this.Konfirmasi = new System.Windows.Forms.GroupBox();
            this.cdproses = new System.Windows.Forms.ComboBox();
            this.cjproses = new System.Windows.Forms.ComboBox();
            this.datatranjok = new System.Windows.Forms.DataGridView();
            this.datatrandi = new System.Windows.Forms.DataGridView();
            this.bdproses = new System.Windows.Forms.Button();
            this.bjproses = new System.Windows.Forms.Button();
            this.Konfirmasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatranjok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatrandi)).BeginInit();
            this.SuspendLayout();
            // 
            // Konfirmasi
            // 
            this.Konfirmasi.Controls.Add(this.cdproses);
            this.Konfirmasi.Controls.Add(this.cjproses);
            this.Konfirmasi.Controls.Add(this.datatranjok);
            this.Konfirmasi.Controls.Add(this.datatrandi);
            this.Konfirmasi.Controls.Add(this.bdproses);
            this.Konfirmasi.Controls.Add(this.bjproses);
            this.Konfirmasi.Location = new System.Drawing.Point(12, 16);
            this.Konfirmasi.Name = "Konfirmasi";
            this.Konfirmasi.Size = new System.Drawing.Size(776, 419);
            this.Konfirmasi.TabIndex = 11;
            this.Konfirmasi.TabStop = false;
            this.Konfirmasi.Text = "Data Transaksi";
            // 
            // cdproses
            // 
            this.cdproses.FormattingEnabled = true;
            this.cdproses.Items.AddRange(new object[] {
            "Transaksi Berhasil"});
            this.cdproses.Location = new System.Drawing.Point(610, 87);
            this.cdproses.Name = "cdproses";
            this.cdproses.Size = new System.Drawing.Size(121, 28);
            this.cdproses.TabIndex = 14;
            // 
            // cjproses
            // 
            this.cjproses.FormattingEnabled = true;
            this.cjproses.Items.AddRange(new object[] {
            "Transaksi Berhasil"});
            this.cjproses.Location = new System.Drawing.Point(610, 271);
            this.cjproses.Name = "cjproses";
            this.cjproses.Size = new System.Drawing.Size(121, 28);
            this.cjproses.TabIndex = 13;
            // 
            // datatranjok
            // 
            this.datatranjok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datatranjok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatranjok.Location = new System.Drawing.Point(6, 209);
            this.datatranjok.Name = "datatranjok";
            this.datatranjok.RowHeadersWidth = 62;
            this.datatranjok.RowTemplate.Height = 28;
            this.datatranjok.Size = new System.Drawing.Size(551, 145);
            this.datatranjok.TabIndex = 12;
            this.datatranjok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datatranjok_CellClick);
            // 
            // datatrandi
            // 
            this.datatrandi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datatrandi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatrandi.Location = new System.Drawing.Point(6, 25);
            this.datatrandi.Name = "datatrandi";
            this.datatrandi.RowHeadersWidth = 62;
            this.datatrandi.RowTemplate.Height = 28;
            this.datatrandi.Size = new System.Drawing.Size(551, 145);
            this.datatrandi.TabIndex = 11;
            this.datatrandi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datatrandi_CellClick);
            // 
            // bdproses
            // 
            this.bdproses.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdproses.Location = new System.Drawing.Point(610, 25);
            this.bdproses.Name = "bdproses";
            this.bdproses.Size = new System.Drawing.Size(121, 56);
            this.bdproses.TabIndex = 9;
            this.bdproses.Text = "Proses";
            this.bdproses.UseVisualStyleBackColor = true;
            this.bdproses.Click += new System.EventHandler(this.bdproses_Click);
            // 
            // bjproses
            // 
            this.bjproses.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bjproses.Location = new System.Drawing.Point(610, 209);
            this.bjproses.Name = "bjproses";
            this.bjproses.Size = new System.Drawing.Size(121, 56);
            this.bjproses.TabIndex = 8;
            this.bjproses.Text = "Proses";
            this.bjproses.UseVisualStyleBackColor = true;
            this.bjproses.Click += new System.EventHandler(this.bjproses_Click);
            // 
            // Form_Konfirmasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Konfirmasi);
            this.Name = "Form_Konfirmasi";
            this.Text = "Form_Konfirmasi";
            this.Load += new System.EventHandler(this.Form_Konfirmasi_Load);
            this.Konfirmasi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datatranjok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatrandi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Konfirmasi;
        private System.Windows.Forms.ComboBox cdproses;
        private System.Windows.Forms.ComboBox cjproses;
        private System.Windows.Forms.DataGridView datatranjok;
        private System.Windows.Forms.DataGridView datatrandi;
        private System.Windows.Forms.Button bdproses;
        private System.Windows.Forms.Button bjproses;
    }
}