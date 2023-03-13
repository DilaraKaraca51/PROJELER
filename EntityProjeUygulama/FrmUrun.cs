using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void BTNLİSTELE_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=(from x in db.TBLURUN
                                      select new
                                      {
                                          x.URUNID,
                                          x.URUNAD,
                                          x.MARKA,
                                          x.STOK,
                                          x.FİYAT,
                                          x.TBLKATEGORİ.AD,
                                          x.DURUM
                                      }).ToList();
        }

        private void BTNEKLE_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD =TXTURUNADI.Text;
            t.MARKA =TXTMARKA.Text;
            t.STOK=short. Parse(TXTSTOK.Text);
            t.KATEGORİ=int.Parse(comboBox1.SelectedValue.ToString());
            t.FİYAT=decimal.Parse(TXTFIYAT.Text);
            t.DURUM=true;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Sisteme Kaydedildi");

        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TXTID.Text);
            var urun = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi");
        }

        private void BTNGUNCELLE_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TXTID.Text);
            var urun = db.TBLURUN.Find(x);
            urun.URUNAD=TXTURUNADI.Text ;
            urun.STOK=short.Parse(TXTSTOK.Text);
            urun.MARKA=TXTMARKA.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");

        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBLKATEGORİ
                               select new
                               {
                                   x.ID,
                                   x.AD
                               }
                               ).ToList();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "AD";
            comboBox1.DataSource = kategoriler;
        }

        private void BTNTEMIZLE_Click(object sender, EventArgs e)
        {
            TXTURUNADI.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
