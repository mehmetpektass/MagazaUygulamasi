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
    public partial class Form_Istatistikler : Form
    {
        public Form_Istatistikler()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities1 db = new DbEntityUrunEntities1();
        private void Form_Istatistikler_Load(object sender, EventArgs e)
        {
            LblToplamKategori.Text = db.TBLKATEGORI.Count().ToString();
            LblToplamUrun.Text = db.TBLURUN.Count().ToString();
            LblAktifMusteri.Text=db.TBLMUSTERI.Count(x=>x.DURUM==true).ToString();
            LblPasifMusteri.Text = db.TBLMUSTERI.Count(x => x.DURUM == false).ToString();
            LblToplamStok.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
            LblKasadakiTutar.Text = db.TBLSATIS.Sum(x => x.FIYAT).ToString() + "TL";
            LblMaxFiyatUrun.Text=(from x in db.TBLURUN orderby x.FİYAT descending select x.URUNAD).FirstOrDefault();
            LblMinFiyatUrun.Text=(from x in db.TBLURUN orderby x.FİYAT ascending select x.URUNAD ).FirstOrDefault();
            LblBeyazEsya.Text=db.TBLURUN.Count(x=>x.KATEGORİ==1).ToString();
            LblToplamBuzdolabı.Text=db.TBLURUN.Count(x=>x.URUNAD=="Buzdolabı").ToString();
            LblSehirSayısı.Text = (from x in db.TBLMUSTERI select x.SEHIR).Distinct().Count().ToString();
            LblMaxUrunMarka.Text = db.MaxMarka().FirstOrDefault();
        }

   
    }
}
