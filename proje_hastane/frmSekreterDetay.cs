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
    public partial class frmSekreterDetay : Form
    {
        public frmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCNumara;
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void frmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCNumara;
            
            //AD SOYAD
            SqlCommand komut1 = new SqlCommand("select SekreterAdSoyad from Tbl_Sekreter where SekreterTc=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblAdSOYAD.Text = dr1[0].ToString();

            }
            bgl.baglanti().Close();

            //Branşları datagride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları listeye aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (DoktorAd+' '+DoktorSoyad) as 'Doktorlar',DoktorBrans from Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşı comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBRANS.Items.Add(dr2[0]);

            }
            bgl.baglanti().Close();



        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", MskTarıh.Text);
            komutkaydet.Parameters.AddWithValue("@r2", mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbBRANS.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu..");

        }

        private void cmbBRANS_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("select doktorad,doktorsoyad from tbl_doktorlar where doktorbrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbBRANS.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0] + " " + dr[1]);

            }
            bgl.baglanti().Close();

        }

        private void btnOLustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_Duyurular (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu!");
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            frmDoktorlarPaneli drp = new frmDoktorlarPaneli();
            drp.Show();

        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            frmBrans frb = new frmBrans();
            frb.Show();
        }

        private void btnRandevuListesi_Click(object sender, EventArgs e)
        {

            FrmRandevuListesi frm = new FrmRandevuListesi();
            frm.Show();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDuyurular frm = new frmDuyurular();
            frm.Show();

        }
    }
    }
    

    
