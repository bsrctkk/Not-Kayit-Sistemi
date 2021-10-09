using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Not_Kayıt_Sistemi
{
    public partial class FrmÖğretmenDetay : Form
    //Data Source=.\SQLEXPRESS;Initial Catalog=NotKayıt;Integrated Security=True
    {
        public FrmÖğretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NotKayıt;Integrated Security=True");
        private void FrmÖğretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'notKayıtDataSet.TblDers' table. You can move, or remove it, as needed.
            this.tblDersTableAdapter.Fill(this.notKayıtDataSet.TblDers);

        }

        private void btnÖğrenciKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TblDers (OgrNumara,OgrAd,OgrSoyad) values (@P1,@P2,@P3)", baglanti);
            komut.Parameters.AddWithValue("@P1", masktxtNumara.Text);
            komut.Parameters.AddWithValue("@P2", txtAd.Text);
            komut.Parameters.AddWithValue("@P3", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi");
            this.tblDersTableAdapter.Fill(this.notKayıtDataSet.TblDers);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            masktxtNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSınav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSınav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtSınav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            String durum;

            s1 = Convert.ToDouble(txtSınav1.Text);
            s2 = Convert.ToDouble(txtSınav2.Text);
            s3 = Convert.ToDouble(txtSınav3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            lblOrtalamaSnv.Text = ortalama.ToString();

            if(ortalama>=50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TblDers set OgrS1=@P1,OgrS2=@P2,OgrS3=@P3,Ortalama=@P4,Durum=@P5 where OgrNumara=@P6",baglanti);
            komut.Parameters.AddWithValue("@P1", txtSınav1.Text);
            komut.Parameters.AddWithValue("@P2", txtSınav2.Text);
            komut.Parameters.AddWithValue("@P3", txtSınav3.Text);
            komut.Parameters.AddWithValue("@P4", decimal.Parse(lblOrtalamaSnv.Text));
            komut.Parameters.AddWithValue("@P5", durum);
            komut.Parameters.AddWithValue("@P6", masktxtNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi");
            this.tblDersTableAdapter.Fill(this.notKayıtDataSet.TblDers);
        }
    }
}
