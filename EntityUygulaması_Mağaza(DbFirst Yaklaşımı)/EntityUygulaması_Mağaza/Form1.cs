using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityUygulaması_Mağaza
{
    public partial class Form_Kategori : Form
    {
        public Form_Kategori()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities1 db = new DbEntityUrunEntities1();
        private void BtnListele_Click(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = (from x in db.TBLKATEGORI 
                                        select new
                                       {
                                         x.ID,
                                         x.AD
                                        }).ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLKATEGORI tk = new TBLKATEGORI();
            tk.AD = textBox2.Text;
            db.TBLKATEGORI.Add(tk);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarıyla Gerçekleşti.");
        }

        private void BtnSıl_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                var secilen = db.TBLKATEGORI.Find(x);
                db.TBLKATEGORI.Remove(secilen);
                db.SaveChanges();
                MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti");
            }
            catch 
            {
                MessageBox.Show("Bilgi Hatası Bulunmaktadır");
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var secilen = db.TBLKATEGORI.Find(x);
            secilen.AD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleştirildi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text=dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
