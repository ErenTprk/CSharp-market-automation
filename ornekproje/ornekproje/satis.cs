using Newtonsoft.Json;
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
    public partial class satis : Form
    {
        public satis()
        {
            InitializeComponent();
        }
        Db_projeEntities0 db = new Db_projeEntities0();
        int gid = Properties.Settings.Default.id;
        int tutar = 0;
        int miktar = 0;
        string temp;
        string temp2;


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (evetrb.Checked)
            {
                hatirlatb.Enabled = true;
            }
            else
            {
                hatirlatb.Enabled = false;
                hatirlatb.Text = "";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void satis_Load(object sender, EventArgs e)
        {
            if (evetrb.Checked)
            {
                hatirlatb.Enabled = true;
            }
            else
            {
                hatirlatb.Enabled = false;
                hatirlatb.Text = "";
            }
            muscek();
            katcek();
            uruncek();
        }
        public void muscek()
        {
            var list = db.tblmusteri.Where(z => z.kullanici_id == gid).Select(x => new
            {
                x.musteri_id,
                x.musteri_tc,
                musad = x.musteri_ad + " " + x.musteri_soyad,
            }).ToList();
            if (list != null)
            {
                comboBox1.DataSource = list;
                comboBox1.ValueMember = "musteri_tc";
                comboBox1.DisplayMember = "musad";
            }
        }
        public void katcek()
        {
            var list = db.tblkategori.Where(z => z.kullanici_id == gid).Select(x => new
            {
                x.kategori_id,
                katad = x.kategori_ad,
            }).ToList();
            if (list != null)
            {
                kategoricb.DataSource = list;
                kategoricb.ValueMember = "kategori_id";
                kategoricb.DisplayMember = "katad";
            }
        }
        public void uruncek()
        {
            int katId = Convert.ToInt32(kategoricb.SelectedValue);
            var list = db.tblurun.Where(z => z.kategori_id == katId).Select(x => new
            {
                x.urun_id,
                urun_ad = x.urun_ad,
            }).ToList();
            if (list != null)
            {
                urunseccb.DataSource = list;
                urunseccb.ValueMember = "urun_id";
                urunseccb.DisplayMember = "urun_ad";
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            mustctb.Text = comboBox1.SelectedValue.ToString();

        }

        private void sepeteklebtn_Click(object sender, EventArgs e)
        {

            string mikek = Convert.ToString(miktartb.Text);
            int urun_id = int.Parse(urunseccb.SelectedValue.ToString());
            Urun urn = new Urun();
            urn.setter(urun_id);
            listBox1.Items.Add(urn.urun_ad + " " + mikek);
            sepethidden.Items.Add(int.Parse(urn.urun_fiyat) * int.Parse(mikek));
            tutarHesapla();
            temp = urunseccb.Text.ToString();
            temp2 = mikek;



        }
        public void stok(string urunad,string umiktar)
        {


        }

        public void tutarHesapla()
        {
            tutar = 0;
            foreach (var listBoxItem in sepethidden.Items)
            {
                tutar += int.Parse(listBoxItem.ToString());
            }
            label7.Text = tutar.ToString();
        }

        private void sepetcikar_Click(object sender, EventArgs e)
        {
            tblurun u = new tblurun();
            sepethidden.SelectedIndex = listBox1.SelectedIndex;
            sepethidden.Items.Remove(sepethidden.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem); 
            tutarHesapla();
            //var request = db.tblurun.Where(z => z.urun_ad == label16.Text.ToString()).FirstOrDefault();
            //if (request != null)
            //{
                
            //}
        }


        private void urunseccb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SayiMi(urunseccb.SelectedValue.ToString()))
            {
                int urun_id = int.Parse(urunseccb.SelectedValue.ToString());
                Urun urn = new Urun();
                urn.setter(urun_id);
                label8.Text = urn.urun_miktar;
                label5.Text = urn.urun_fiyat;
            }

        }

        bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {

                string tut = listBox1.SelectedItem.ToString();
                string tut2 = "";
                string tut3 = "";
                for (int i = 0; i < tut.Length; i++)
                {
                    if (tut[i] == ' ')
                    {
                        i++;
                        for (; i < tut.Length; i++)
                        {
                            tut3 += tut[i];
                        }
                        break;
                    }
                    tut2 += tut[i];
                }
                label16.Text = tut2;
                label17.Text = tut3;
            }
        }

        private void alimbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
