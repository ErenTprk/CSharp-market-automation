namespace ornekproje
{
    partial class musteri
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
            this.musteriid = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tcaratb = new System.Windows.Forms.TextBox();
            this.istekcb = new System.Windows.Forms.ComboBox();
            this.silbtn = new System.Windows.Forms.Button();
            this.duzenlebtn = new System.Windows.Forms.Button();
            this.eklebtn = new System.Windows.Forms.Button();
            this.madrestb = new System.Windows.Forms.TextBox();
            this.mtctb = new System.Windows.Forms.TextBox();
            this.msaditb = new System.Windows.Forms.TextBox();
            this.maditb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteri_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanici_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ürünbtn = new System.Windows.Forms.Button();
            this.anabtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.musteriid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tcaratb);
            this.groupBox1.Controls.Add(this.istekcb);
            this.groupBox1.Controls.Add(this.silbtn);
            this.groupBox1.Controls.Add(this.duzenlebtn);
            this.groupBox1.Controls.Add(this.eklebtn);
            this.groupBox1.Controls.Add(this.madrestb);
            this.groupBox1.Controls.Add(this.mtctb);
            this.groupBox1.Controls.Add(this.msaditb);
            this.groupBox1.Controls.Add(this.maditb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // musteriid
            // 
            this.musteriid.AutoSize = true;
            this.musteriid.Location = new System.Drawing.Point(548, 238);
            this.musteriid.Name = "musteriid";
            this.musteriid.Size = new System.Drawing.Size(0, 17);
            this.musteriid.TabIndex = 16;
            this.musteriid.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Müşteri Ara (TC) :";
            // 
            // tcaratb
            // 
            this.tcaratb.Location = new System.Drawing.Point(422, 32);
            this.tcaratb.Name = "tcaratb";
            this.tcaratb.Size = new System.Drawing.Size(126, 25);
            this.tcaratb.TabIndex = 14;
            this.tcaratb.TextChanged += new System.EventHandler(this.tcaratb_TextChanged);
            this.tcaratb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcaratb_KeyPress);
            // 
            // istekcb
            // 
            this.istekcb.FormattingEnabled = true;
            this.istekcb.Location = new System.Drawing.Point(136, 207);
            this.istekcb.Name = "istekcb";
            this.istekcb.Size = new System.Drawing.Size(125, 25);
            this.istekcb.TabIndex = 13;
            // 
            // silbtn
            // 
            this.silbtn.Location = new System.Drawing.Point(331, 194);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(129, 38);
            this.silbtn.TabIndex = 12;
            this.silbtn.Text = "Sil";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // duzenlebtn
            // 
            this.duzenlebtn.Location = new System.Drawing.Point(331, 139);
            this.duzenlebtn.Name = "duzenlebtn";
            this.duzenlebtn.Size = new System.Drawing.Size(129, 38);
            this.duzenlebtn.TabIndex = 11;
            this.duzenlebtn.Text = "Düzenle";
            this.duzenlebtn.UseVisualStyleBackColor = true;
            this.duzenlebtn.Click += new System.EventHandler(this.duzenlebtn_Click);
            // 
            // eklebtn
            // 
            this.eklebtn.Location = new System.Drawing.Point(331, 86);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(129, 38);
            this.eklebtn.TabIndex = 10;
            this.eklebtn.Text = "Ekle";
            this.eklebtn.UseVisualStyleBackColor = true;
            this.eklebtn.Click += new System.EventHandler(this.eklebtn_Click);
            // 
            // madrestb
            // 
            this.madrestb.Location = new System.Drawing.Point(136, 161);
            this.madrestb.Name = "madrestb";
            this.madrestb.Size = new System.Drawing.Size(125, 25);
            this.madrestb.TabIndex = 8;
            // 
            // mtctb
            // 
            this.mtctb.Location = new System.Drawing.Point(136, 117);
            this.mtctb.Name = "mtctb";
            this.mtctb.Size = new System.Drawing.Size(125, 25);
            this.mtctb.TabIndex = 7;
            this.mtctb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtctb_KeyPress);
            // 
            // msaditb
            // 
            this.msaditb.Location = new System.Drawing.Point(136, 74);
            this.msaditb.Name = "msaditb";
            this.msaditb.Size = new System.Drawing.Size(125, 25);
            this.msaditb.TabIndex = 6;
            // 
            // maditb
            // 
            this.maditb.Location = new System.Drawing.Point(136, 32);
            this.maditb.Name = "maditb";
            this.maditb.Size = new System.Drawing.Size(125, 25);
            this.maditb.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "İstek :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Müşteri Adres :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Müşteri TC :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteri_id,
            this.kullanici_id,
            this.musteri_tc,
            this.musteri_ad,
            this.musteri_soyad,
            this.musteri_adres});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(12, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 213);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // musteri_id
            // 
            this.musteri_id.DataPropertyName = "musteri_id";
            this.musteri_id.HeaderText = "id";
            this.musteri_id.Name = "musteri_id";
            this.musteri_id.Visible = false;
            // 
            // kullanici_id
            // 
            this.kullanici_id.DataPropertyName = "kullanici_id";
            this.kullanici_id.HeaderText = "kid";
            this.kullanici_id.Name = "kullanici_id";
            this.kullanici_id.Visible = false;
            // 
            // musteri_tc
            // 
            this.musteri_tc.DataPropertyName = "musteri_tc";
            this.musteri_tc.HeaderText = "Müşteri TC";
            this.musteri_tc.Name = "musteri_tc";
            // 
            // musteri_ad
            // 
            this.musteri_ad.DataPropertyName = "musteri_ad";
            this.musteri_ad.HeaderText = "Müşteri Ad";
            this.musteri_ad.Name = "musteri_ad";
            // 
            // musteri_soyad
            // 
            this.musteri_soyad.DataPropertyName = "musteri_soyad";
            this.musteri_soyad.HeaderText = "Müşteri Soyad";
            this.musteri_soyad.Name = "musteri_soyad";
            // 
            // musteri_adres
            // 
            this.musteri_adres.DataPropertyName = "musteri_adres";
            this.musteri_adres.HeaderText = "Müşteri Adresi";
            this.musteri_adres.Name = "musteri_adres";
            this.musteri_adres.Width = 300;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ürünbtn);
            this.groupBox2.Controls.Add(this.anabtn);
            this.groupBox2.Location = new System.Drawing.Point(581, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 258);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yönlendirme";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ürünbtn
            // 
            this.ürünbtn.Location = new System.Drawing.Point(53, 139);
            this.ürünbtn.Name = "ürünbtn";
            this.ürünbtn.Size = new System.Drawing.Size(101, 52);
            this.ürünbtn.TabIndex = 4;
            this.ürünbtn.Text = "Ürün";
            this.ürünbtn.UseVisualStyleBackColor = true;
            this.ürünbtn.Click += new System.EventHandler(this.ürünbtn_Click);
            // 
            // anabtn
            // 
            this.anabtn.Location = new System.Drawing.Point(53, 69);
            this.anabtn.Name = "anabtn";
            this.anabtn.Size = new System.Drawing.Size(101, 52);
            this.anabtn.TabIndex = 3;
            this.anabtn.Text = "Anasayfa";
            this.anabtn.UseVisualStyleBackColor = true;
            this.anabtn.Click += new System.EventHandler(this.anabtn_Click);
            // 
            // musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "musteri";
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.musteri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox istekcb;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.Button duzenlebtn;
        private System.Windows.Forms.Button eklebtn;
        private System.Windows.Forms.TextBox madrestb;
        private System.Windows.Forms.TextBox mtctb;
        private System.Windows.Forms.TextBox msaditb;
        private System.Windows.Forms.TextBox maditb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tcaratb;
        private System.Windows.Forms.Button ürünbtn;
        private System.Windows.Forms.Button anabtn;
        private System.Windows.Forms.Label musteriid;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanici_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_adres;
    }
}