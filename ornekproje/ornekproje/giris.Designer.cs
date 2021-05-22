namespace ornekproje
{
    partial class giris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kaditb = new System.Windows.Forms.TextBox();
            this.sifretb = new System.Windows.Forms.TextBox();
            this.girisbtn = new System.Windows.Forms.Button();
            this.geribtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // kaditb
            // 
            this.kaditb.Location = new System.Drawing.Point(198, 41);
            this.kaditb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kaditb.Name = "kaditb";
            this.kaditb.Size = new System.Drawing.Size(116, 25);
            this.kaditb.TabIndex = 2;
            // 
            // sifretb
            // 
            this.sifretb.Location = new System.Drawing.Point(198, 75);
            this.sifretb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sifretb.Name = "sifretb";
            this.sifretb.Size = new System.Drawing.Size(116, 25);
            this.sifretb.TabIndex = 3;
            this.sifretb.UseSystemPasswordChar = true;
            // 
            // girisbtn
            // 
            this.girisbtn.Location = new System.Drawing.Point(106, 132);
            this.girisbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.girisbtn.Name = "girisbtn";
            this.girisbtn.Size = new System.Drawing.Size(120, 39);
            this.girisbtn.TabIndex = 4;
            this.girisbtn.Text = "Giriş Yap";
            this.girisbtn.UseVisualStyleBackColor = true;
            this.girisbtn.Click += new System.EventHandler(this.girisbtn_Click);
            // 
            // geribtn
            // 
            this.geribtn.Location = new System.Drawing.Point(14, 162);
            this.geribtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.geribtn.Name = "geribtn";
            this.geribtn.Size = new System.Drawing.Size(44, 44);
            this.geribtn.TabIndex = 5;
            this.geribtn.Text = "Geri";
            this.geribtn.UseVisualStyleBackColor = true;
            this.geribtn.Click += new System.EventHandler(this.geribtn_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 222);
            this.Controls.Add(this.geribtn);
            this.Controls.Add(this.girisbtn);
            this.Controls.Add(this.sifretb);
            this.Controls.Add(this.kaditb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "giris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kaditb;
        private System.Windows.Forms.Button girisbtn;
        private System.Windows.Forms.Button geribtn;
        private System.Windows.Forms.TextBox sifretb;
    }
}