namespace Tugas_Besar_PBO.View
{
    partial class Data_transaksi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataTraDiamond = new System.Windows.Forms.DataGridView();
            this.dataTraJoki = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTraDiamond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTraJoki)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataTraJoki);
            this.groupBox1.Controls.Add(this.dataTraDiamond);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 525);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Transaksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "JOKI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "DIAMOND";
            // 
            // dataTraDiamond
            // 
            this.dataTraDiamond.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataTraDiamond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTraDiamond.Location = new System.Drawing.Point(19, 58);
            this.dataTraDiamond.Name = "dataTraDiamond";
            this.dataTraDiamond.RowHeadersWidth = 62;
            this.dataTraDiamond.RowTemplate.Height = 28;
            this.dataTraDiamond.Size = new System.Drawing.Size(731, 145);
            this.dataTraDiamond.TabIndex = 5;
            // 
            // dataTraJoki
            // 
            this.dataTraJoki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataTraJoki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTraJoki.Location = new System.Drawing.Point(19, 238);
            this.dataTraJoki.Name = "dataTraJoki";
            this.dataTraJoki.RowHeadersWidth = 62;
            this.dataTraJoki.RowTemplate.Height = 28;
            this.dataTraJoki.Size = new System.Drawing.Size(731, 145);
            this.dataTraJoki.TabIndex = 6;
            // 
            // Data_transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1095, 549);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Data_transaksi";
            this.Text = "Data_transaksi";
            this.Load += new System.EventHandler(this.Data_transaksi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTraDiamond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTraJoki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataTraJoki;
        private System.Windows.Forms.DataGridView dataTraDiamond;
    }
}