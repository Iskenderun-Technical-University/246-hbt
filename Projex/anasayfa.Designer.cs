namespace Projex
{
    partial class anasayfa
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
            this.btnçlşbil = new System.Windows.Forms.Button();
            this.btnçlşkydt = new System.Windows.Forms.Button();
            this.btntop = new System.Windows.Forms.Button();
            this.btnasis = new System.Windows.Forms.Button();
            this.btngörev = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnçlşbil
            // 
            this.btnçlşbil.Location = new System.Drawing.Point(12, 55);
            this.btnçlşbil.Name = "btnçlşbil";
            this.btnçlşbil.Size = new System.Drawing.Size(226, 54);
            this.btnçlşbil.TabIndex = 0;
            this.btnçlşbil.Text = "ÇALIŞAN BİLGİLERİ";
            this.btnçlşbil.UseVisualStyleBackColor = true;
            this.btnçlşbil.Click += new System.EventHandler(this.btnçlşbil_Click);
            // 
            // btnçlşkydt
            // 
            this.btnçlşkydt.Location = new System.Drawing.Point(12, 138);
            this.btnçlşkydt.Name = "btnçlşkydt";
            this.btnçlşkydt.Size = new System.Drawing.Size(226, 54);
            this.btnçlşkydt.TabIndex = 0;
            this.btnçlşkydt.Text = "ÇALIŞAN İŞLEMLERİ";
            this.btnçlşkydt.UseVisualStyleBackColor = true;
            this.btnçlşkydt.Click += new System.EventHandler(this.btnçlşkydt_Click);
            // 
            // btntop
            // 
            this.btntop.Location = new System.Drawing.Point(12, 222);
            this.btntop.Name = "btntop";
            this.btntop.Size = new System.Drawing.Size(226, 54);
            this.btntop.TabIndex = 0;
            this.btntop.Text = "TOPLANTI DÜZENLE";
            this.btntop.UseVisualStyleBackColor = true;
            this.btntop.Click += new System.EventHandler(this.btntop_Click);
            // 
            // btnasis
            // 
            this.btnasis.Location = new System.Drawing.Point(519, 272);
            this.btnasis.Name = "btnasis";
            this.btnasis.Size = new System.Drawing.Size(247, 54);
            this.btnasis.TabIndex = 0;
            this.btnasis.Text = "ASİSTANA MESAJ GÖNDER";
            this.btnasis.UseVisualStyleBackColor = true;
            this.btnasis.Click += new System.EventHandler(this.btnasis_Click);
            // 
            // btngörev
            // 
            this.btngörev.Location = new System.Drawing.Point(12, 301);
            this.btngörev.Name = "btngörev";
            this.btngörev.Size = new System.Drawing.Size(226, 54);
            this.btngörev.TabIndex = 0;
            this.btngörev.Text = "GÖREV VER";
            this.btngörev.UseVisualStyleBackColor = true;
            this.btngörev.Click += new System.EventHandler(this.btngörev_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(519, 138);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(247, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btngörev);
            this.Controls.Add(this.btnasis);
            this.Controls.Add(this.btntop);
            this.Controls.Add(this.btnçlşkydt);
            this.Controls.Add(this.btnçlşbil);
            this.Name = "anasayfa";
            this.Text = "d";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnçlşbil;
        private System.Windows.Forms.Button btnçlşkydt;
        private System.Windows.Forms.Button btntop;
        private System.Windows.Forms.Button btnasis;
        private System.Windows.Forms.Button btngörev;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}