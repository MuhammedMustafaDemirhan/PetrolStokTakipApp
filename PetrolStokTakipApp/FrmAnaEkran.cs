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

namespace PetrolStokTakipApp
{
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }

        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-CJ1512V;Initial Catalog=DbPetrolTakipSistemi;Integrated Security=True");
        public void BenzinBilgiGetir()
        {
            #region Kurşunsuz95
            bgl.Open();
            SqlCommand BenzinBilgiKursunsuz95 = new SqlCommand("Select * From TBLBenzin Where PETROLTUR=@p1", bgl);
            BenzinBilgiKursunsuz95.Parameters.AddWithValue("@p1", "Kurşunsuz95");
            SqlDataReader dr1 = BenzinBilgiKursunsuz95.ExecuteReader();
            while (dr1.Read())
            {
                LBLStokKursunsuz95.Text = dr1[4].ToString();
                circularProgressBar1.Value = int.Parse(dr1[4].ToString());
                LBLKursunsuz95.Text = dr1[3].ToString();
            }
            bgl.Close();
            #endregion

            #region MaxDizel
            bgl.Open();
            SqlCommand BenzinBilgiMaxDizel = new SqlCommand("Select * From TBLBenzin Where PETROLTUR=@p1", bgl);
            BenzinBilgiMaxDizel.Parameters.AddWithValue("@p1", "MaxDizel");
            SqlDataReader dr2 = BenzinBilgiMaxDizel.ExecuteReader();
            while (dr2.Read())
            {
                LBLStokMaxDizel.Text = dr2[4].ToString();
                circularProgressBar2.Value = int.Parse(dr2[4].ToString());
                LBLMaxDizel.Text = dr2[3].ToString();
            }
            bgl.Close();
            #endregion

            #region ProDizel
            bgl.Open();
            SqlCommand BenzinBilgiProDizel = new SqlCommand("Select * From TBLBenzin Where PETROLTUR=@p1", bgl);
            BenzinBilgiProDizel.Parameters.AddWithValue("@p1", "ProDizel");
            SqlDataReader dr3 = BenzinBilgiProDizel.ExecuteReader();
            while (dr3.Read())
            {
                LBLStokProDizel.Text = dr3[4].ToString();
                circularProgressBar3.Value = int.Parse(dr3[4].ToString());
                LBLProDizel.Text = dr3[3].ToString();
            }
            bgl.Close();
            #endregion

            #region Gaz
            bgl.Open();
            SqlCommand BenzinBilgiGaz = new SqlCommand("Select * From TBLBenzin Where PETROLTUR=@p1", bgl);
            BenzinBilgiGaz.Parameters.AddWithValue("@p1", "Gaz");
            SqlDataReader dr4 = BenzinBilgiGaz.ExecuteReader();
            while (dr4.Read())
            {
                LBLStokGaz.Text = dr4[4].ToString();
                circularProgressBar6.Value = int.Parse(dr4[4].ToString());
                LBLGaz.Text = dr4[3].ToString();
            }
            bgl.Close();
            #endregion

            #region Kasa
            bgl.Open();
            SqlCommand Kasa = new SqlCommand("Select * From TBLKasa", bgl);
            SqlDataReader dr = Kasa.ExecuteReader();
            while(dr.Read())
            {
                LBLKasa.Text = dr[0].ToString();
            }
            bgl.Close();
            #endregion
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BenzinBilgiGetir();

            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLBenzin", bgl);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                CBXBenzinler.Items.Add(dr["PETROLTUR"]);
                CBXBenzinler.SelectedIndex = 0;
            }
            bgl.Close();
        }

        private void BTNDepoDoldur_Click(object sender, EventArgs e)
        {
            if(TXTPlaka.Text == "")
            {
                MessageBox.Show("Plaka Bölümü Boş Geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(NMRLitre.Value == 0)
            {
                MessageBox.Show("Litre Seçimi Yapınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Hareket Tablosuna Ekleme İşlemi
                bgl.Open();
                SqlCommand DepoDolum = new SqlCommand("Insert into TBLHareket(PLAKA,BENZINTURU,LITRE,FIYAT) Values(@p1,@p2,@p3,@p4)", bgl);
                DepoDolum.Parameters.AddWithValue("@p1", TXTPlaka.Text);
                DepoDolum.Parameters.AddWithValue("@p2", CBXBenzinler.Text);
                DepoDolum.Parameters.AddWithValue("@p3", int.Parse(NMRLitre.Text));
                DepoDolum.Parameters.AddWithValue("@p4", Convert.ToDouble(TXTTutar.Text));
                DepoDolum.ExecuteNonQuery();
                bgl.Close();

                //Kasaya Para Ekleme
                bgl.Open();
                SqlCommand Kasa = new SqlCommand("Update TBLKasa set KASA = KASA+@p1", bgl);
                Kasa.Parameters.AddWithValue("@p1", Convert.ToDouble(TXTTutar.Text));
                Kasa.ExecuteNonQuery();
                bgl.Close();

                //Depodan Düşüm
                bgl.Open();
                SqlCommand StokEksiltme = new SqlCommand("Update TBLBenzin set STOK=STOK-@p1 Where PETROLTUR=@p2", bgl);
                StokEksiltme.Parameters.AddWithValue("@p1", int.Parse(NMRLitre.Value.ToString()));
                StokEksiltme.Parameters.AddWithValue("@p2", CBXBenzinler.Text);
                StokEksiltme.ExecuteNonQuery();
                bgl.Close();
                MessageBox.Show("Depo Dolum İşlemi Tamamlandı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BenzinBilgiGetir();
            }
        }

        private void NMRLitre_ValueChanged(object sender, EventArgs e)
        {
            if(CBXBenzinler.Text == "Kurşunsuz95")
            {
                TXTTutar.Text = (Convert.ToDouble(NMRLitre.Value) * Convert.ToDouble(LBLKursunsuz95.Text)).ToString();
            }
            else if(CBXBenzinler.Text == "MaxDizel")
            {
                TXTTutar.Text = (Convert.ToDouble(NMRLitre.Value) * Convert.ToDouble(LBLMaxDizel.Text)).ToString();
            }
            else if(CBXBenzinler.Text == "ProDizel")
            {
                TXTTutar.Text = (Convert.ToDouble(NMRLitre.Value) * Convert.ToDouble(LBLProDizel.Text)).ToString();
            }
            else if(CBXBenzinler.Text == "Gaz")
            {
                TXTTutar.Text = (Convert.ToDouble(NMRLitre.Value) * Convert.ToDouble(LBLGaz.Text)).ToString();
            }
        }

        private void CBXBenzinler_SelectedIndexChanged(object sender, EventArgs e)
        {
            NMRLitre.Value = 0;
            TXTTutar.Text = "0";
        }

        private void LLBLBenzinAl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmYakitIkmali frm = new FrmYakitIkmali();
            frm.Show();
            this.Hide();
        }
    }
}