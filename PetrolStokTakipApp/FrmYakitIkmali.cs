using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolStokTakipApp
{
    public partial class FrmYakitIkmali : Form
    {
        public FrmYakitIkmali()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-CJ1512V;Initial Catalog=DbPetrolTakipSistemi;Integrated Security=True");
        int giris = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmAnaEkran frm = new FrmAnaEkran();
            frm.Show();
            this.Hide();
        }

        private void FrmYakitIkmali_Load(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLBenzin", bgl);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CBXBenzinler.Items.Add(dr["PETROLTUR"]);
                CBXBenzinler.SelectedIndex = 0;
            }
            bgl.Close();
        }

        private void BTNDepoDoldur_Click(object sender, EventArgs e)
        {
            if(CBXBenzinler.Text == "")
            {
                MessageBox.Show("Benzin Türü Alanı Boş Geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(NMRLitre.Value == 0)
            {
                MessageBox.Show("Litre Seçimi Yapınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Stok Durumu Sorgulama
                bgl.Open();
                SqlCommand stoksorgu = new SqlCommand("Select STOK From TBLBenzin Where PETROLTUR=@p1", bgl);
                stoksorgu.Parameters.AddWithValue("@p1", CBXBenzinler.Text);
                SqlDataReader dr = stoksorgu.ExecuteReader();
                while(dr.Read())
                {
                    if (int.Parse(dr[0].ToString()) + NMRLitre.Value <= 10000)
                    {
                        giris++;
                    }
                    else
                    {
                        MessageBox.Show("Petrol Deponuz 10.000 Litreden Fazla Alamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                bgl.Close();

                //Kasa Durumu ile Tutarı Karşılaştırma
                bgl.Open();
                SqlCommand kasasorgu = new SqlCommand("Select KASA From TBLKasa", bgl);
                SqlDataReader dr1 = kasasorgu.ExecuteReader();
                while(dr1.Read())
                {
                    if (Convert.ToDouble(dr1[0]) < Convert.ToDouble(LBLTutar.Text))
                    {
                        MessageBox.Show("Kasada Bulunan Para İkmal İçin Yetersiz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        giris++;
                    }
                }
                bgl.Close();

                //İkmal Yapma
                if(giris > 0)
                {
                    //Benzin Eklemesi
                    bgl.Open();
                    SqlCommand ikmalyap = new SqlCommand("Update TBLBenzin set STOK=STOK+@p1 Where PETROLTUR=@p2", bgl);
                    ikmalyap.Parameters.AddWithValue("@p1", int.Parse(NMRLitre.Value.ToString()));
                    ikmalyap.Parameters.AddWithValue("@p2", CBXBenzinler.Text);
                    ikmalyap.ExecuteNonQuery();
                    bgl.Close();

                    //Kasadan Düşme İşlemi
                    bgl.Open();
                    SqlCommand kasadandus = new SqlCommand("Update TBLKasa set KASA=KASA-@p1", bgl);
                    kasadandus.Parameters.AddWithValue("@p1", Convert.ToDouble(LBLTutar.Text));
                    kasadandus.ExecuteNonQuery();
                    bgl.Close();

                    MessageBox.Show("Yakıt İkmali Tamamlanmıştır!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void NMRLitre_ValueChanged(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand alisfiyat = new SqlCommand("Select ALISFIYAT From TBLBenzin Where PETROLTUR=@p1", bgl);
            alisfiyat.Parameters.AddWithValue("@p1", CBXBenzinler.Text);
            SqlDataReader dr = alisfiyat.ExecuteReader();   
            while(dr.Read())
            {
                LBLTutar.Text = (Convert.ToDouble(NMRLitre.Value.ToString()) * Convert.ToDouble(dr[0])).ToString();
            }
            bgl.Close();
        }

        private void CBXBenzinler_SelectedIndexChanged(object sender, EventArgs e)
        {
            NMRLitre.Value = 0;
            LBLTutar.Text = "00,00";
        }
    }
}
