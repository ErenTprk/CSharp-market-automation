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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        Db_projeEntities0 db = new Db_projeEntities0();
        main m = new main();
        

        public int kid;

        //giriş kontrol
        public bool login(string kullaniciad, string ksifre)
        {
            var kullanici = (from x in db.tblkullanici where x.kullanici_ad == kullaniciad && x.kullanici_sifre == ksifre select x).FirstOrDefault();
            if (kullanici != null) 
            {
                kid = kullanici.kullanici_id;
                Properties.Settings.Default.remember = true;
                return true;
            }
            return false;
        }
        //Yönlendirme ve veri göndereme
        private void girisbtn_Click(object sender, EventArgs e)
        {
            if (kaditb.Text != "" & sifretb.Text != "") {
                var kadi = kaditb.Text;
                var ksifre = sifretb.Text;
                var loginstate = login(kadi,ksifre);
                if (loginstate && Properties.Settings.Default.remember)
                {
                    Properties.Settings.Default.id = kid;
                    Properties.Settings.Default.Save();
                    m.Show();
                    this.Hide();
                }
                else
                    
                    MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre Girdiniz.");
            }
        }
        public static int kullaniciid()
        {
            giris g =new giris();
            return g.kid;
        }


        private void geribtn_Click(object sender, EventArgs e)
        {
            m.Show();
            this.Hide();
        }

        private void giris_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.id = 0;
        }
    }
}
