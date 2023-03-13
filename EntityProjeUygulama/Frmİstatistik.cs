using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.TBLKATEGORİ.Count().ToString();
            label3.Text = db.TBLURUN.Count().ToString();
            label13.Text = db.TBLURUN.Sum(y => y.STOK).ToString();
            label19.Text=db.TBLSATIS.Sum(z => z.FIYAT).ToString() + "TL";
            label11.Text=(from x in db.TBLURUN orderby x.FİYAT descending select x.URUNAD).FirstOrDefault().ToString();
            label9.Text=(from x in db.TBLURUN orderby x.FİYAT ascending select x.URUNAD).FirstOrDefault().ToString();
            label15.Text=db.TBLURUN.Count(x => x.KATEGORİ == 1).ToString();
            label25.Text=db.TBLURUN.Count(x => x.URUNAD=="ÇAMAŞIR MAKİNESİ ").ToString();
            label17.Text=(from x in db.TBLMUSTERI select x.SEHIR).Distinct().Count().ToString();
            
        }
    }
}
