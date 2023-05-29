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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbEntityUrunEntities1 db = new DbEntityUrunEntities1();
            var sorgu = from x in db.TblAdmin where x.Kullanici == textBox1.Text && x.Sifre == textBox2.Text select x;
            if (sorgu.Any())
            {
                FormAnaMenu frm = new FormAnaMenu();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi girdiniz");
            }
        }
    }
}
