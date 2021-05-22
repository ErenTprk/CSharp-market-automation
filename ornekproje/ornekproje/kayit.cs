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
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        
        Db_projeEntities0 db = new Db_projeEntities0();
        main m = new main();

        private void kayitbtn_Click(object sender, EventArgs e)
        {
            //kontroller
            tblkullanici k = new tblkullanici();
            if (kadtb.Text.ToString() == "" || adrestb.Text.ToString() == "" || adtb.Text.ToString() == "" || sifretb.Text.ToString() == "" || sadtb.Text.ToString() == "" || sdogrutb.ToString() == "")
                MessageBox.Show("Boş Alan Bırakmayınız.");
            else if (sifretb.Text != sdogrutb.Text)
                MessageBox.Show("Şifreler Birbiriyle Eşleşmiyor.");

            //veritabanına ekleme
            else
            {
                var request = db.tblkullanici.Where(x => x.kullanici_ad == kadtb.Text.ToString()).FirstOrDefault();
                if (request == null)
                {
                    k.kullanici_ad = kadtb.Text;
                    k.kullanici_adres = adrestb.Text;
                    k.kullanıci_isim = adtb.Text;
                    k.kullanici_sifre = sifretb.Text;
                    k.kullanici_soyad = sadtb.Text;
                    db.tblkullanici.Add(k);
                    db.SaveChanges();
                    m.Show();
                    this.Hide();
                    Properties.Settings.Default.remember = false;
                }
                else
                {
                    MessageBox.Show("Bu Kullanıcı Adı Alınmış.");
                }

            }
        }

        private void kayit_Load(object sender, EventArgs e)
        {

        }

        private void geribtn_Click(object sender, EventArgs e)
        {
            m.Show();
            this.Hide();
            Properties.Settings.Default.remember = false;
        }
    }
}
