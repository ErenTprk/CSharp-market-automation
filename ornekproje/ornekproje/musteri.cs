using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornekproje
{
    public partial class musteri : Form
    {
        public musteri()
        {
            InitializeComponent();
        }

        Db_projeEntities0 db = new Db_projeEntities0();
        int gid = Properties.Settings.Default.id;

        private void musteri_Load(object sender, EventArgs e)
        {
            vericek();
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {

            tblmusteri m = new tblmusteri();
            if (maditb.Text.ToString() == "" || madrestb.Text.ToString() == "" || msaditb.Text.ToString() == "" || mtctb.Text.ToString() == "")
                MessageBox.Show("Boş Alan Bırakmayınız.");
            else
            {
                string tc = mtctb.Text.ToString();
                if (tc.Length == 11)
                {
                    var request = db.tblmusteri.Where(z => z.kullanici_id == gid).Where(z => z.musteri_tc == mtctb.Text.ToString()).FirstOrDefault();
                    if (request == null)
                    {
                        m.kullanici_id = gid;
                        m.musteri_ad = maditb.Text.ToString();
                        m.musteri_adres = madrestb.Text.ToString();
                        m.musteri_soyad = msaditb.Text.ToString();
                        m.musteri_tc = mtctb.Text.ToString();
                        db.tblmusteri.Add(m);
                        db.SaveChanges();
                        MessageBox.Show("Müşteri Ekleme İşlemi Başarılı.");
                        vericek();
                    }
                    else
                        MessageBox.Show("Bu TC Numarası Bu Kullanıcı İçin Kullanılmış.");
                }
                else
                    MessageBox.Show("TC Numarası 11 Haneli Olmalıdır.");
            }
        }

        private void duzenlebtn_Click(object sender, EventArgs e)
        {

            tblmusteri m = new tblmusteri();
            if (maditb.Text.ToString() == "" || madrestb.Text.ToString() == "" || msaditb.Text.ToString() == "" || mtctb.Text.ToString() == "")
                MessageBox.Show("Boş Bırakılamaz.");
            else
            {
                string tc = mtctb.Text.ToString();
                if (tc.Length == 11)
                {
                    int musid = int.Parse(musteriid.Text);

                    var request = db.tblmusteri.Where(z => z.kullanici_id == gid && (z.musteri_tc == mtctb.Text.ToString() && z.musteri_id != musid)).FirstOrDefault();//
                    var rq = db.tblmusteri.Where(z => z.kullanici_id == gid && z.musteri_tc != mtctb.Text.ToString() && z.musteri_id == musid).FirstOrDefault();
                    
                    if (request==null||rq==null)
                    {

                        var gnc = db.tblmusteri.Find(int.Parse(musteriid.Text));
                        gnc.kullanici_id = gid;
                        gnc.musteri_ad = maditb.Text;
                        gnc.musteri_adres = madrestb.Text;
                        gnc.musteri_soyad = msaditb.Text;
                        gnc.musteri_tc = mtctb.Text;
                        db.SaveChanges();
                        MessageBox.Show("Bilgiler Güncellendi.");
                        vericek();
                    }
                    else
                        MessageBox.Show("Hata");
                }
                else
                    MessageBox.Show("TC Numarası 11 Haneli Olmalıdır.");

            }
        }
        public void vericek()
        {
            var request = db.tblmusteri.Where(z => z.kullanici_id == gid).ToList();
            var query = from item in request
                        select new
                        {
                            item.musteri_id,
                            item.musteri_tc,
                            item.musteri_ad,
                            item.musteri_soyad,
                            item.musteri_adres,

                        };
            dataGridView1.DataSource = query.ToList();

        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            
            var x = db.tblmusteri.Find(int.Parse(musteriid.Text));
            db.tblmusteri.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Müşteri Silindi.");
            vericek();
        }

        private void anabtn_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Hide();
        }

        private void ürünbtn_Click(object sender, EventArgs e)
        {
            urunler u = new urunler();
            u.Show();
            this.Hide();

        }

        private void alimbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void tcaratb_TextChanged(object sender, EventArgs e)
        {
            string aranan = tcaratb.Text;
            var x = from item in db.tblmusteri where item.musteri_tc.Contains(aranan)&&item.kullanici_id==gid select item;
            var query = from item in x
                        select new
                        {
                            item.musteri_id,
                            item.musteri_tc,
                            item.musteri_ad,
                            item.musteri_soyad,
                            item.musteri_adres,

                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void mtctb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tcaratb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int mid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["musteri_id"].FormattedValue.ToString());
            maditb.Text = dataGridView1.Rows[e.RowIndex].Cells["musteri_ad"].FormattedValue.ToString();
            msaditb.Text = dataGridView1.Rows[e.RowIndex].Cells["musteri_soyad"].FormattedValue.ToString();
            madrestb.Text = dataGridView1.Rows[e.RowIndex].Cells["musteri_adres"].FormattedValue.ToString();
            mtctb.Text = dataGridView1.Rows[e.RowIndex].Cells["musteri_tc"].FormattedValue.ToString();
            //mtctb.Text = dataGridView1.Rows[e.RowIndex].Cells["tcdg"].FormattedValue.ToString();
            musteriid.Text = mid.ToString();



        }




    }
}
