namespace Expeditor
{
    partial class Anbar
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
            this.lblanbrno = new System.Windows.Forms.Label();
            this.txtanbarno = new System.Windows.Forms.TextBox();
            this.txtexpno = new System.Windows.Forms.TextBox();
            this.lblanbrexp = new System.Windows.Forms.Label();
            this.lblanbrdeyisbasliq = new System.Windows.Forms.Label();
            this.btnanbrdystsdq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblanbrno
            // 
            this.lblanbrno.AutoSize = true;
            this.lblanbrno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblanbrno.Location = new System.Drawing.Point(217, 100);
            this.lblanbrno.Name = "lblanbrno";
            this.lblanbrno.Size = new System.Drawing.Size(123, 25);
            this.lblanbrno.TabIndex = 0;
            this.lblanbrno.Text = "Anbar Kodu:";
            // 
            // txtanbarno
            // 
            this.txtanbarno.Location = new System.Drawing.Point(358, 104);
            this.txtanbarno.Name = "txtanbarno";
            this.txtanbarno.Size = new System.Drawing.Size(108, 20);
            this.txtanbarno.TabIndex = 1;
            // 
            // txtexpno
            // 
            this.txtexpno.Location = new System.Drawing.Point(358, 168);
            this.txtexpno.Name = "txtexpno";
            this.txtexpno.Size = new System.Drawing.Size(108, 20);
            this.txtexpno.TabIndex = 2;
            // 
            // lblanbrexp
            // 
            this.lblanbrexp.AutoSize = true;
            this.lblanbrexp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblanbrexp.Location = new System.Drawing.Point(250, 162);
            this.lblanbrexp.Name = "lblanbrexp";
            this.lblanbrexp.Size = new System.Drawing.Size(90, 25);
            this.lblanbrexp.TabIndex = 3;
            this.lblanbrexp.Text = "Təmsilçi:";
            // 
            // lblanbrdeyisbasliq
            // 
            this.lblanbrdeyisbasliq.AutoSize = true;
            this.lblanbrdeyisbasliq.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblanbrdeyisbasliq.Location = new System.Drawing.Point(158, 24);
            this.lblanbrdeyisbasliq.Name = "lblanbrdeyisbasliq";
            this.lblanbrdeyisbasliq.Size = new System.Drawing.Size(430, 39);
            this.lblanbrdeyisbasliq.TabIndex = 4;
            this.lblanbrdeyisbasliq.Text = "Anbar Dəyişikliyi Pəncərəsi";
            // 
            // btnanbrdystsdq
            // 
            this.btnanbrdystsdq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnanbrdystsdq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnanbrdystsdq.Location = new System.Drawing.Point(659, 385);
            this.btnanbrdystsdq.Name = "btnanbrdystsdq";
            this.btnanbrdystsdq.Size = new System.Drawing.Size(115, 32);
            this.btnanbrdystsdq.TabIndex = 5;
            this.btnanbrdystsdq.Text = "Təsdiqlə";
            this.btnanbrdystsdq.UseVisualStyleBackColor = true;
            this.btnanbrdystsdq.Click += new System.EventHandler(this.btnanbrdystsdq_Click);
            // 
            // Anbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnanbrdystsdq);
            this.Controls.Add(this.lblanbrdeyisbasliq);
            this.Controls.Add(this.lblanbrexp);
            this.Controls.Add(this.txtexpno);
            this.Controls.Add(this.txtanbarno);
            this.Controls.Add(this.lblanbrno);
            this.Name = "Anbar";
            this.Text = "Anbar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblanbrno;
        private System.Windows.Forms.TextBox txtanbarno;
        private System.Windows.Forms.TextBox txtexpno;
        private System.Windows.Forms.Label lblanbrexp;
        private System.Windows.Forms.Label lblanbrdeyisbasliq;
        private System.Windows.Forms.Button btnanbrdystsdq;
    }
}