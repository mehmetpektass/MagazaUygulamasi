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
    public partial class FormAnaMenu : Form
    {
        public FormAnaMenu()
        {
            InitializeComponent();
        }

        private void BtnKategori_Click(object sender, EventArgs e)
        {
            Form_Kategori form1 = new Form_Kategori();
            form1.Show();
        }

        private void BtnÜrünler_Click(object sender, EventArgs e)
        {
            FormUrunler frm = new FormUrunler();
            frm.Show();
        }

        private void Btnİstatistikler_Click(object sender, EventArgs e)
        {
            Form_Istatistikler frm = new Form_Istatistikler();
            frm.Show();
        }
    }
}
