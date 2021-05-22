using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ornekproje
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        int login = 0;

        ToolTip Aciklama = new ToolTip();

        Db_projeEntities0 db = new Db_projeEntities0();

        private void Form1_Load(object sender, EventArgs e)
        {


            giris g = new giris();

            if (Properties.Settings.Default.id != 0 && Properties.Settings.Default.remember)
            {
                EnableControls(satisbtn);
                EnableControls(musteribtn);
                EnableControls(kullanicibtn);
                EnableControls(gecmisbtn);
                EnableControls(urunbtn);
                EnableControls(kcikisbtn);
                DisableControls(kayitbtn);
                DisableControls(girisbtn);
                Aciklama.SetToolTip(satisbtn, "Satış işlemlerini Gerçekleştirmeniz İçin Sizi Satış Sayfasına Yönlendirir.");
                Aciklama.SetToolTip(musteribtn, "Müşteri İşlemlerinizi Gerçekleştirmek İçin Yönlendirme Yapar.(Gösterim,Ekleme,Düzenleme,Silme)");
                Aciklama.SetToolTip(kullanicibtn, "Kullanıcı Bilgilerinizi Kontrol Etmek ve Düzenlemek.");
                Aciklama.SetToolTip(gecmisbtn, "Yapılan Satışları Listele ve Arama Yap.");
                Aciklama.SetToolTip(urunbtn, "Ürünler Hakkında Kapsamlı Bilgi İçerir.");
                Aciklama.SetToolTip(kcikisbtn, "Hesapdan Çıkış Yapmak.");
                Properties.Settings.Default.remember = false;
                Properties.Settings.Default.Save();

            }




        }
        private void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableControls(c);
            }
            con.Enabled = false;
        }


        private void EnableControls(Control con)
        {
            if (con != null)
            {
                con.Enabled = true;
                EnableControls(con.Parent);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris g = new giris();
            g.Show();
            this.Hide();
        }

        private void musteribtn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void kcikisbtn_Click(object sender, EventArgs e)
        {
            cikisyap();

        }


        public void cikisyap()
        {
            Properties.Settings.Default.id = 0;
            Properties.Settings.Default.remember = false;
            Properties.Settings.Default.Save();
            DisableControls(satisbtn);
            DisableControls(musteribtn);
            DisableControls(kullanicibtn);
            DisableControls(gecmisbtn);
            DisableControls(urunbtn);
            DisableControls(kcikisbtn);
            EnableControls(kayitbtn);
            EnableControls(girisbtn);
        }

        private void kayitbtn_Click(object sender, EventArgs e)
        {
            kayit k = new kayit();
            Properties.Settings.Default.remember = true;
            k.ShowDialog();
            this.Hide();

        }

        private void satisbtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.remember = true;
            satis s = new satis();
            s.Show();
            this.Hide();

        }

        private void musteribtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.remember = true;
            musteri m = new musteri();
            m.Show();
            this.Hide();
        }

        private void kullanicibtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.remember = true;
            kullanici ku = new kullanici();
            ku.Show();
            this.Hide();
        }

        private void alimbtn_Click(object sender, EventArgs e)
        {

        }

        private void urunbtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.remember = true;
            urunler u = new urunler();
            u.Show();
            this.Hide();
        }

        private void gecmisbtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.remember = true;
            gecmis ge = new gecmis();
            ge.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
