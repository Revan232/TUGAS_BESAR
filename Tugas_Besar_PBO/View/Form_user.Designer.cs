namespace Tugas_Besar_PBO.View
{
    partial class Form_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_user));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diamondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jasaJokiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diamondDanJasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.gameStoreToolStripMenuItem,
            this.dataTransaksiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(905, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // gameStoreToolStripMenuItem
            // 
            this.gameStoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diamondToolStripMenuItem,
            this.jasaJokiToolStripMenuItem,
            this.diamondDanJasaToolStripMenuItem});
            this.gameStoreToolStripMenuItem.Name = "gameStoreToolStripMenuItem";
            this.gameStoreToolStripMenuItem.Size = new System.Drawing.Size(91, 21);
            this.gameStoreToolStripMenuItem.Text = "Game Store";
            // 
            // dataTransaksiToolStripMenuItem
            // 
            this.dataTransaksiToolStripMenuItem.Name = "dataTransaksiToolStripMenuItem";
            this.dataTransaksiToolStripMenuItem.Size = new System.Drawing.Size(110, 21);
            this.dataTransaksiToolStripMenuItem.Text = "Data Transaksi";
            this.dataTransaksiToolStripMenuItem.Click += new System.EventHandler(this.dataTransaksiToolStripMenuItem_Click);
            // 
            // diamondToolStripMenuItem
            // 
            this.diamondToolStripMenuItem.Name = "diamondToolStripMenuItem";
            this.diamondToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.diamondToolStripMenuItem.Text = "Diamond";
            this.diamondToolStripMenuItem.Click += new System.EventHandler(this.diamondToolStripMenuItem_Click);
            // 
            // jasaJokiToolStripMenuItem
            // 
            this.jasaJokiToolStripMenuItem.Name = "jasaJokiToolStripMenuItem";
            this.jasaJokiToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.jasaJokiToolStripMenuItem.Text = "Jasa Joki";
            this.jasaJokiToolStripMenuItem.Click += new System.EventHandler(this.jasaJokiToolStripMenuItem_Click);
            // 
            // diamondDanJasaToolStripMenuItem
            // 
            this.diamondDanJasaToolStripMenuItem.Name = "diamondDanJasaToolStripMenuItem";
            this.diamondDanJasaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.diamondDanJasaToolStripMenuItem.Text = "Diamond dan Jasa";
            this.diamondDanJasaToolStripMenuItem.Click += new System.EventHandler(this.diamondDanJasaToolStripMenuItem_Click);
            // 
            // Form_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(905, 551);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_user";
            this.Text = "Form Pembeli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_user_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTransaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diamondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jasaJokiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diamondDanJasaToolStripMenuItem;
    }
}