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
namespace proje_hastane
{
    public partial class frmhastadetay: Form
    {
        public frmhastadetay()
        {
            InitializeComponent();
        }
        public string TC;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmhastadetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = TC;
            SqlCommand komut = new SqlCommand("select hastaad,hastasoyad from Tbl_Hastalar where hastatc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where HastaTc=" + TC, bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            //Branşları Çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select DoktorAd,DoktorSoyad from " +
                "Tbl_doktorlar where Doktorbrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);

            }
            bgl.baglanti().Close();

        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where RandevuBrans='" + cmbBrans.Text + "'" + "and RandevuDoktor='" + cmbDoktor.Text + "'and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
        }

        private void lnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           FrmBilgiDüzenle fr = new FrmBilgiDüzenle();
            fr.TCNo = lblTc.Text;
            fr.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Başlık satırına tıklamayı engeller
            {
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells["Randevuİd"].Value.ToString();
            }
        }
        

        private void btnRandevual_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_Randevular set RandevuDurum=1,HastaTc=@p1,HastaSikayet=@p2 where Randevuİd=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            komut.Parameters.AddWithValue("@p2", rchSikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

    

