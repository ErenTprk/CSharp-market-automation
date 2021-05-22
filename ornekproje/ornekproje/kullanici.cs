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
    public partial class kullanici : Form
    {
        public kullanici()
        {
            InitializeComponent();
        }
        Db_projeEntities0 db = new Db_projeEntities0();
        int gid = Properties.Settings.Default.id;

        private void kullanici_Load(object sender, EventArgs e)
        {
            vericek();
        }

        private void duzeltbtn_Click(object sender, EventArgs e)
        {
            tblkullanici m = new tblkullanici();
            if (textBox1.Text.ToString() == "" || textBox2.Text.ToString() == "" || textBox3.Text.ToString() == "" || textBox4.Text.ToString() == "" || textBox5.Text.ToString() == "" || textBox6.Text.ToString() == "")
                MessageBox.Show("Boş Bırakılamaz.");
            else
            {
                if (textBox4.Text == textBox5.Text)
                {
                    var request = db.tblkullanici.Where(z => z.kullanici_id == gid).FirstOrDefault();
                    if (request != null)
                    {
                        var gnc = db.tblkullanici.Find(gid);
                        gnc.kullanici_id = gid;
                        gnc.kullanıci_isim = textBox1.Text.ToString();
                        gnc.kullanici_soyad = textBox2.Text.ToString();
                        gnc.kullanici_ad = textBox3.Text.ToString();
                        gnc.kullanici_sifre = textBox4.Text.ToString();
                        gnc.kullanici_adres = textBox6.Text.ToString();
                        db.SaveChanges();
                        MessageBox.Show("Bilgiler Güncellendi.");
                        vericek();

                    }
                }
                else
                    MessageBox.Show("Şifreler Birbiriyle Aynı Olmalıdır.");

            }
        }

        private void anabtn_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Hide();
        }
        public void vericek()
        {
            var request = db.tblkullanici.Where(z => z.kullanici_id == gid).FirstOrDefault();
            if (request != null)
            {
                var gnc = db.tblkullanici.Find(gid);
                textBox1.Text = gnc.kullanici_ad.ToString();
                textBox2.Text = gnc.kullanici_soyad.ToString();
                textBox3.Text = gnc.kullanici_ad.ToString();
                textBox4.Text = gnc.kullanici_sifre.ToString();
                textBox6.Text = gnc.kullanici_adres.ToString();
            }
        }
    }
}
