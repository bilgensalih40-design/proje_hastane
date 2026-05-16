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
    public partial class FrmHastaGiris: Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void lnkuyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Frmhastakayıt fr = new Frmhastakayıt();
            fr.Show();
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmhastadetay fr = new frmhastadetay();
                fr.TC = mskTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre");

            }
            bgl.baglanti().Close();

        }
    }
}
