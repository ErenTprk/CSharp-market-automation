using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Windows.Input;


namespace ornekproje
{
    public partial class urunler : Form
    {
        public urunler()
        {
            InitializeComponent();
        }
        Db_projeEntities0 db = new Db_projeEntities0();
        int gid = Properties.Settings.Default.id;


        private void urunler_Load(object sender, EventArgs e)
        {
            vericek();
            katcek();
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            tblurun u = new tblurun();
                u.kullanici_id = gid;
                u.urun_ad = urunadtb.Text.ToString();
                u.urun_miktar = eklemiktartb.Text.ToString();
                u.urun_kategori = eklekategoricb.Text.ToString();
                u.urun_fiyat = fiyattb.Text.ToString();
                u.kategori_id = Convert.ToInt32(eklekategoricb.SelectedValue);
                if (ekleadetrb.Checked)
                    u.urun_tur = "adet";
                else
                    u.urun_tur = "kg";

                db.tblurun.Add(u);
                db.SaveChanges();
                MessageBox.Show("Urun Ekleme İşlemi Başarılı.");
                vericek();
        
        }

        private void duzeltbtn_Click(object sender, EventArgs e)
        {
            int uid = int.Parse(urunid.Text);
            var request = db.tblurun.Where(z => z.kullanici_id == gid && (z.urun_ad == urunadtb.Text.ToString() && z.urun_id != uid)).FirstOrDefault();
            if (request == null)
            {
                var gnc = db.tblurun.Find(int.Parse(urunid.Text));
                gnc.kullanici_id = gid;
                gnc.urun_ad = dadtb.Text;
                gnc.urun_miktar = dmiktartb.Text;
                gnc.urun_kategori = dkategoricb.SelectedItem.ToString();
                gnc.urun_fiyat = fiyattb.Text.ToString();
                if (dadetrb.Checked)
                    gnc.urun_tur = "adet";
                else if (dkgrb.Checked)
                    gnc.urun_tur = "kg";
                else
                    MessageBox.Show("Bu Alan Boş Geçilemez.");
                db.SaveChanges();
                MessageBox.Show("Bilgiler Güncellendi.");
                vericek();
            }
            else
                MessageBox.Show("Hata");
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            var x = db.tblurun.Find(int.Parse(urunid.Text));
            db.tblurun.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi.");
            vericek();
        }

        private void anabtn_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Hide();
        }

        private void gecmisbtn_Click(object sender, EventArgs e)
        {
            gecmis m = new gecmis();
            m.Show();
            this.Hide();
        }
        public void vericek()
        {
            var request = db.tblurun.Where(z => z.kullanici_id == gid).ToList();
            var query = from item in request
                        select new
                        {
                            item.urun_id,
                            item.urun_ad,
                            item.urun_miktar,
                            item.urun_tur,
                            item.urun_kategori,
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int uid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["urun_id"].FormattedValue.ToString());
            dadtb.Text = dataGridView1.Rows[e.RowIndex].Cells["urun_ad"].FormattedValue.ToString();
            dmiktartb.Text = dataGridView1.Rows[e.RowIndex].Cells["urun_miktar"].FormattedValue.ToString();
            urunid.Text = uid.ToString();
        }

        private void aratb_TextChanged(object sender, EventArgs e)
        {
            string aranan = aratb.Text;
            var x = from item in db.tblurun where item.urun_ad.Contains(aranan) && item.kullanici_id == gid select item;
            var query = from item in x
                        select new
                        {
                            item.urun_id,
                            item.urun_ad,
                            item.urun_miktar,
                            item.urun_tur,
                            item.urun_kategori,
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string kategori = Interaction.InputBox("Bilgi Girişi", "Eklemek İstediğiniz Kategoriyi Giriniz.", "Örn: Meyve", 0, 0);
            tblkategori k = new tblkategori();
            var request = db.tblkategori.Where(z => z.kullanici_id == gid).FirstOrDefault();
            if (request != null)
            {
                k.kullanici_id = gid;
                k.kategori_ad = kategori;
            db.tblkategori.Add(k);
            db.SaveChanges();

            }
            katcek();



        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //sıkıntı
            
            var x = db.tblkategori.Find(int.Parse(katid.Text));
            db.tblkategori.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi.");
            katcek();
        }
        public void katcek()
        {
            var request = db.tblkategori.Where(z => z.kullanici_id == gid).ToList();
            if (request != null)
            {
                eklekategoricb.DataSource = request;
                eklekategoricb.DisplayMember = "kategori_ad";
                eklekategoricb.ValueMember = "kategori_id";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void eklekategoricb_SelectedIndexChanged(object sender, EventArgs e)
        {
            katid.Text = eklekategoricb.SelectedValue.ToString();
        }




    }
}
