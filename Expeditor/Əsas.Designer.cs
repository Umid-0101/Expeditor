namespace Expeditor
{
    partial class Əsas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.təmsilçilərToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.əməliyyatlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaƏlavəEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anbarƏlavəEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anbarDəyişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notSaleƏlavəEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.malƏlavəEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ffffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.təmsilçilərToolStripMenuItem,
            this.əməliyyatlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // təmsilçilərToolStripMenuItem
            // 
            this.təmsilçilərToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ffffToolStripMenuItem});
            this.təmsilçilərToolStripMenuItem.Name = "təmsilçilərToolStripMenuItem";
            this.təmsilçilərToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.təmsilçilərToolStripMenuItem.Text = "Təmsilçilər";
            this.təmsilçilərToolStripMenuItem.Click += new System.EventHandler(this.təmsilçilərToolStripMenuItem_Click);
            // 
            // əməliyyatlarToolStripMenuItem
            // 
            this.əməliyyatlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markaƏlavəEtToolStripMenuItem,
            this.markaSilToolStripMenuItem,
            this.anbarƏlavəEtToolStripMenuItem,
            this.anbarDəyişToolStripMenuItem,
            this.notSaleƏlavəEtToolStripMenuItem,
            this.malƏlavəEtToolStripMenuItem});
            this.əməliyyatlarToolStripMenuItem.Name = "əməliyyatlarToolStripMenuItem";
            this.əməliyyatlarToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.əməliyyatlarToolStripMenuItem.Text = "Əməliyyatlar";
            // 
            // markaƏlavəEtToolStripMenuItem
            // 
            this.markaƏlavəEtToolStripMenuItem.Name = "markaƏlavəEtToolStripMenuItem";
            this.markaƏlavəEtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.markaƏlavəEtToolStripMenuItem.Text = "Marka Əlavə et";
            this.markaƏlavəEtToolStripMenuItem.Click += new System.EventHandler(this.markaƏlavəEtToolStripMenuItem_Click);
            // 
            // markaSilToolStripMenuItem
            // 
            this.markaSilToolStripMenuItem.Name = "markaSilToolStripMenuItem";
            this.markaSilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.markaSilToolStripMenuItem.Text = "Marka sil";
            this.markaSilToolStripMenuItem.Click += new System.EventHandler(this.markaSilToolStripMenuItem_Click);
            // 
            // anbarƏlavəEtToolStripMenuItem
            // 
            this.anbarƏlavəEtToolStripMenuItem.Name = "anbarƏlavəEtToolStripMenuItem";
            this.anbarƏlavəEtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.anbarƏlavəEtToolStripMenuItem.Text = "Anbar Əlavə et";
            // 
            // anbarDəyişToolStripMenuItem
            // 
            this.anbarDəyişToolStripMenuItem.Name = "anbarDəyişToolStripMenuItem";
            this.anbarDəyişToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.anbarDəyişToolStripMenuItem.Text = "Anbar Dəyiş";
            this.anbarDəyişToolStripMenuItem.Click += new System.EventHandler(this.anbarDəyişToolStripMenuItem_Click);
            // 
            // notSaleƏlavəEtToolStripMenuItem
            // 
            this.notSaleƏlavəEtToolStripMenuItem.Name = "notSaleƏlavəEtToolStripMenuItem";
            this.notSaleƏlavəEtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notSaleƏlavəEtToolStripMenuItem.Text = "NotSale Əlavə et";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 426);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // malƏlavəEtToolStripMenuItem
            // 
            this.malƏlavəEtToolStripMenuItem.Name = "malƏlavəEtToolStripMenuItem";
            this.malƏlavəEtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.malƏlavəEtToolStripMenuItem.Text = "Mal Əlavə et";
            // 
            // ffffToolStripMenuItem
            // 
            this.ffffToolStripMenuItem.Name = "ffffToolStripMenuItem";
            this.ffffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ffffToolStripMenuItem.Text = "Təmsilçi Siyahısı";
            this.ffffToolStripMenuItem.Click += new System.EventHandler(this.ffffToolStripMenuItem_Click);
            // 
            // Əsas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Əsas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Əsas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem təmsilçilərToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem əməliyyatlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaƏlavəEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anbarƏlavəEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anbarDəyişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notSaleƏlavəEtToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem malƏlavəEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ffffToolStripMenuItem;
    }
}

