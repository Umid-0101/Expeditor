namespace Expeditor
{
    partial class Marka
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
            this.txtmrkelvet = new System.Windows.Forms.TextBox();
            this.mrkkdngrn = new System.Windows.Forms.Label();
            this.btntsdq = new System.Windows.Forms.Button();
            this.txtexpelvet = new System.Windows.Forms.TextBox();
            this.lblexp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtmrkelvet
            // 
            this.txtmrkelvet.Location = new System.Drawing.Point(228, 17);
            this.txtmrkelvet.Name = "txtmrkelvet";
            this.txtmrkelvet.Size = new System.Drawing.Size(123, 20);
            this.txtmrkelvet.TabIndex = 0;
            // 
            // mrkkdngrn
            // 
            this.mrkkdngrn.AutoSize = true;
            this.mrkkdngrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.mrkkdngrn.Location = new System.Drawing.Point(30, 12);
            this.mrkkdngrn.Name = "mrkkdngrn";
            this.mrkkdngrn.Size = new System.Drawing.Size(192, 25);
            this.mrkkdngrn.TabIndex = 1;
            this.mrkkdngrn.Text = "Marka Kodunu Girin:";
            this.mrkkdngrn.Click += new System.EventHandler(this.label1_Click);
            // 
            // btntsdq
            // 
            this.btntsdq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btntsdq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btntsdq.Location = new System.Drawing.Point(699, 402);
            this.btntsdq.Name = "btntsdq";
            this.btntsdq.Size = new System.Drawing.Size(89, 36);
            this.btntsdq.TabIndex = 2;
            this.btntsdq.Text = "Təsdiqlə";
            this.btntsdq.UseVisualStyleBackColor = true;
            this.btntsdq.Click += new System.EventHandler(this.btntsdq_Click);
            // 
            // txtexpelvet
            // 
            this.txtexpelvet.Location = new System.Drawing.Point(228, 75);
            this.txtexpelvet.Name = "txtexpelvet";
            this.txtexpelvet.Size = new System.Drawing.Size(123, 20);
            this.txtexpelvet.TabIndex = 3;
            // 
            // lblexp
            // 
            this.lblexp.AutoSize = true;
            this.lblexp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblexp.Location = new System.Drawing.Point(132, 70);
            this.lblexp.Name = "lblexp";
            this.lblexp.Size = new System.Drawing.Size(90, 25);
            this.lblexp.TabIndex = 4;
            this.lblexp.Text = "Təmsilçi:";
            // 
            // Marka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblexp);
            this.Controls.Add(this.txtexpelvet);
            this.Controls.Add(this.btntsdq);
            this.Controls.Add(this.mrkkdngrn);
            this.Controls.Add(this.txtmrkelvet);
            this.Name = "Marka";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmrkelvet;
        private System.Windows.Forms.Label mrkkdngrn;
        private System.Windows.Forms.Button btntsdq;
        private System.Windows.Forms.TextBox txtexpelvet;
        private System.Windows.Forms.Label lblexp;
    }
}