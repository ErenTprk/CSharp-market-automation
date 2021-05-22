namespace ornekproje
{
    partial class main
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
            this.girisbtn = new System.Windows.Forms.Button();
            this.kayitbtn = new System.Windows.Forms.Button();
            this.satisbtn = new System.Windows.Forms.Button();
            this.musteribtn = new System.Windows.Forms.Button();
            this.kullanicibtn = new System.Windows.Forms.Button();
            this.urunbtn = new System.Windows.Forms.Button();
            this.gecmisbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kcikisbtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // girisbtn
            // 
            this.girisbtn.Location = new System.Drawing.Point(35, 101);
            this.girisbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.girisbtn.Name = "girisbtn";
            this.girisbtn.Size = new System.Drawing.Size(124, 63);
            this.girisbtn.TabIndex = 0;
            this.girisbtn.Text = "Giriş Yap ";
            this.girisbtn.UseVisualStyleBackColor = true;
            this.girisbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // kayitbtn
            // 
            this.kayitbtn.Location = new System.Drawing.Point(35, 205);
            this.kayitbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kayitbtn.Name = "kayitbtn";
            this.kayitbtn.Size = new System.Drawing.Size(124, 63);
            this.kayitbtn.TabIndex = 1;
            this.kayitbtn.Text = "Kayıt Ol";
            this.kayitbtn.UseVisualStyleBackColor = true;
            this.kayitbtn.Click += new System.EventHandler(this.kayitbtn_Click);
            // 
            // satisbtn
            // 
            this.satisbtn.Enabled = false;
            this.satisbtn.Location = new System.Drawing.Point(19, 51);
            this.satisbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.satisbtn.Name = "satisbtn";
            this.satisbtn.Size = new System.Drawing.Size(124, 63);
            this.satisbtn.TabIndex = 2;
            this.satisbtn.Text = "Satış Yap";
            this.satisbtn.UseVisualStyleBackColor = true;
            this.satisbtn.Click += new System.EventHandler(this.satisbtn_Click);
            // 
            // musteribtn
            // 
            this.musteribtn.Enabled = false;
            this.musteribtn.Location = new System.Drawing.Point(190, 51);
            this.musteribtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.musteribtn.Name = "musteribtn";
            this.musteribtn.Size = new System.Drawing.Size(124, 63);
            this.musteribtn.TabIndex = 7;
            this.musteribtn.Text = "Müşteriler";
            this.musteribtn.UseVisualStyleBackColor = true;
            this.musteribtn.Click += new System.EventHandler(this.musteribtn_Click);
            this.musteribtn.MouseEnter += new System.EventHandler(this.musteribtn_MouseEnter);
            // 
            // kullanicibtn
            // 
            this.kullanicibtn.Enabled = false;
            this.kullanicibtn.Location = new System.Drawing.Point(351, 51);
            this.kullanicibtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kullanicibtn.Name = "kullanicibtn";
            this.kullanicibtn.Size = new System.Drawing.Size(124, 63);
            this.kullanicibtn.TabIndex = 6;
            this.kullanicibtn.Text = "Kullanıcı Bilgileri";
            this.kullanicibtn.UseVisualStyleBackColor = true;
            this.kullanicibtn.Click += new System.EventHandler(this.kullanicibtn_Click);
            // 
            // urunbtn
            // 
            this.urunbtn.Enabled = false;
            this.urunbtn.Location = new System.Drawing.Point(19, 155);
            this.urunbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.urunbtn.Name = "urunbtn";
            this.urunbtn.Size = new System.Drawing.Size(124, 63);
            this.urunbtn.TabIndex = 5;
            this.urunbtn.Text = "Ürünler";
            this.urunbtn.UseVisualStyleBackColor = true;
            this.urunbtn.Click += new System.EventHandler(this.urunbtn_Click);
            // 
            // gecmisbtn
            // 
            this.gecmisbtn.Enabled = false;
            this.gecmisbtn.Location = new System.Drawing.Point(190, 155);
            this.gecmisbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gecmisbtn.Name = "gecmisbtn";
            this.gecmisbtn.Size = new System.Drawing.Size(124, 63);
            this.gecmisbtn.TabIndex = 4;
            this.gecmisbtn.Text = "Geçmiş";
            this.gecmisbtn.UseVisualStyleBackColor = true;
            this.gecmisbtn.Click += new System.EventHandler(this.gecmisbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.girisbtn);
            this.groupBox1.Controls.Add(this.kayitbtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 352);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güvenlik";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kcikisbtn);
            this.groupBox2.Controls.Add(this.musteribtn);
            this.groupBox2.Controls.Add(this.satisbtn);
            this.groupBox2.Controls.Add(this.gecmisbtn);
            this.groupBox2.Controls.Add(this.kullanicibtn);
            this.groupBox2.Controls.Add(this.urunbtn);
            this.groupBox2.Location = new System.Drawing.Point(221, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 352);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı İşlemleri";
            // 
            // kcikisbtn
            // 
            this.kcikisbtn.Enabled = false;
            this.kcikisbtn.Location = new System.Drawing.Point(351, 283);
            this.kcikisbtn.Name = "kcikisbtn";
            this.kcikisbtn.Size = new System.Drawing.Size(124, 63);
            this.kcikisbtn.TabIndex = 8;
            this.kcikisbtn.Text = "Kullanıcı Çıkışı";
            this.kcikisbtn.UseVisualStyleBackColor = true;
            this.kcikisbtn.Click += new System.EventHandler(this.kcikisbtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 398);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Anasayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button girisbtn;
        private System.Windows.Forms.Button kayitbtn;
        private System.Windows.Forms.Button satisbtn;
        private System.Windows.Forms.Button musteribtn;
        private System.Windows.Forms.Button kullanicibtn;
        private System.Windows.Forms.Button urunbtn;
        private System.Windows.Forms.Button gecmisbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button kcikisbtn;
    }
}

