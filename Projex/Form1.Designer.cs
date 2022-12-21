namespace Projex
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btngiris = new System.Windows.Forms.Button();
            this.lblkul = new System.Windows.Forms.Label();
            this.lblşif = new System.Windows.Forms.Label();
            this.txtkul = new System.Windows.Forms.TextBox();
            this.txtşif = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btngiris
            // 
            this.btngiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.Location = new System.Drawing.Point(208, 254);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(375, 56);
            this.btngiris.TabIndex = 3;
            this.btngiris.Text = "GİRİŞ YAP";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // lblkul
            // 
            this.lblkul.AutoSize = true;
            this.lblkul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkul.Location = new System.Drawing.Point(204, 133);
            this.lblkul.Name = "lblkul";
            this.lblkul.Size = new System.Drawing.Size(169, 24);
            this.lblkul.TabIndex = 1;
            this.lblkul.Text = "KULLANICI ADI : ";
            // 
            // lblşif
            // 
            this.lblşif.AutoSize = true;
            this.lblşif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblşif.Location = new System.Drawing.Point(204, 174);
            this.lblşif.Name = "lblşif";
            this.lblşif.Size = new System.Drawing.Size(81, 24);
            this.lblşif.TabIndex = 1;
            this.lblşif.Text = "ŞİFRE :";
            // 
            // txtkul
            // 
            this.txtkul.Location = new System.Drawing.Point(434, 133);
            this.txtkul.Name = "txtkul";
            this.txtkul.Size = new System.Drawing.Size(149, 20);
            this.txtkul.TabIndex = 1;
            // 
            // txtşif
            // 
            this.txtşif.Location = new System.Drawing.Point(434, 174);
            this.txtşif.Name = "txtşif";
            this.txtşif.Size = new System.Drawing.Size(149, 20);
            this.txtşif.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtşif);
            this.Controls.Add(this.txtkul);
            this.Controls.Add(this.lblşif);
            this.Controls.Add(this.lblkul);
            this.Controls.Add(this.btngiris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label lblkul;
        private System.Windows.Forms.Label lblşif;
        private System.Windows.Forms.TextBox txtkul;
        private System.Windows.Forms.TextBox txtşif;
    }
}

