using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EntityUygulaması_Mağaza
{
    public partial class FormUrunler : Form
    {
        public FormUrunler()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities1 db = new DbEntityUrunEntities1();

        private void FormUrunler_Load(object sender, EventArgs e)
        {
            var secilen = (from x in db.TBLKATEGORI
                           select new
                           {
                               x.ID,
                               x.AD
                           }
                           ).ToList();
            ComboboxKategori.ValueMember = "ID";
            ComboboxKategori.DisplayMember = "AD";
            ComboboxKategori.DataSource = secilen;
        }


        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FİYAT,
                                            x.DURUM,
                                            x.TBLKATEGORI.AD 
                                        }).ToList();
                                         
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = TxtAd.Text;
            t.MARKA = TxtMarka.Text;
            t.STOK = short.Parse(Txtstok.Text);
            t.FİYAT = decimal.Parse(TxtFiyat.Text);
            t.DURUM = true;
            t.KATEGORİ = int.Parse(ComboboxKategori.SelectedValue.ToString());
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ekleme Başarıyla Gerçekleşti");

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var secilen = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(secilen);
            db.SaveChanges();
            MessageBox.Show("Silme Başarıyla Gerçekleşti");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var secilen = db.TBLURUN.Find(x);
            secilen.URUNAD = TxtAd.Text;
            secilen.MARKA= TxtMarka.Text;
            secilen.STOK= short.Parse(Txtstok.Text);
            secilen.FİYAT=decimal.Parse(TxtFiyat.Text);
            secilen.DURUM = bool.Parse(TxtDurum.Text);
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarıyla Gerçekleşti");
        }

        private void Btntemizle_Click(object sender, EventArgs e)
        {
            TxtID.Clear();
            TxtAd.Clear();
            TxtMarka.Clear();
            Txtstok.Clear();
            TxtFiyat.Clear();
            TxtDurum.Clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtMarka.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            Txtstok.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtFiyat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtDurum.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}
