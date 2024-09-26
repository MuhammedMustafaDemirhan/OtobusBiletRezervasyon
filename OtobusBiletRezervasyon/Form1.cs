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

namespace OtobusBiletRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-CJ1512V;Initial Catalog=DbOtobusRezervasyon;Integrated Security=True");
        int giris = 0;
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLSeferBilgi", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void SeferNo()
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Select SEFERNO From TBLSeferBilgi", bgl);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            bgl.Close();
        }
        void KoltukRenklendir(string btn)
        {
            if(btn == "K1 ")
            {
                K1.BackColor = Color.DarkRed;
                K1.ForeColor = Color.White;
                K1.Enabled = false;
            }
            if (btn == "K2 ")
            {
                K2.BackColor = Color.DarkRed;
                K2.ForeColor = Color.White;
                K2.Enabled = false;
            }
            if (btn == "K3 ")
            {
                K3.BackColor = Color.DarkRed;
                K3.ForeColor = Color.White;
                K3.Enabled = false;
            }
            if (btn == "K4 ")
            {
                K4.BackColor = Color.DarkRed;
                K4.ForeColor = Color.White;
                K4.Enabled = false;
            }
            if (btn == "K5 ")
            {
                K5.BackColor = Color.DarkRed;
                K5.ForeColor = Color.White;
                K5.Enabled = false;
            }
            if (btn == "K6 ")
            {
                K6.BackColor = Color.DarkRed;
                K6.ForeColor = Color.White;
                K6.Enabled = false;
            }
            if (btn == "K7 ")
            {
                K7.BackColor = Color.DarkRed;
                K7.ForeColor = Color.White;
                K7.Enabled = false;
            }
            if (btn == "K8 ")
            {
                K8.BackColor = Color.DarkRed;
                K8.ForeColor = Color.White;
                K8.Enabled = false;
            }
            if (btn == "K9 ")
            {
                K9.BackColor = Color.DarkRed;
                K9.ForeColor = Color.White;
                K9.Enabled = false;
            }
            if (btn == "K10")
            {
                K10.BackColor = Color.DarkRed;
                K10.ForeColor = Color.White;
                K10.Enabled = false;
            }
            if (btn == "K11")
            {
                K11.BackColor = Color.DarkRed;
                K11.ForeColor = Color.White;
                K11.Enabled = false;
            }
            if (btn == "K12")
            {
                K12.BackColor = Color.DarkRed;
                K12.ForeColor = Color.White;
                K12.Enabled = false;
            }
        }
        void KoltukTemizle()
        {
            K1.BackColor = Color.White;
            K1.ForeColor = SystemColors.ControlText;
            K1.Enabled = true;
            K2.BackColor = Color.White;
            K2.ForeColor = SystemColors.ControlText;
            K2.Enabled = true;
            K3.BackColor = Color.White;
            K3.ForeColor = SystemColors.ControlText;
            K3.Enabled = true;
            K4.BackColor = Color.White;
            K4.ForeColor = SystemColors.ControlText;
            K4.Enabled = true;
            K5.BackColor = Color.White;
            K5.ForeColor = SystemColors.ControlText;
            K5.Enabled = true;
            K6.BackColor = Color.White;
            K6.ForeColor = SystemColors.ControlText;
            K6.Enabled = true;
            K7.BackColor = Color.White;
            K7.ForeColor = SystemColors.ControlText;
            K7.Enabled = true;
            K8.BackColor = Color.White;
            K8.ForeColor = SystemColors.ControlText;
            K8.Enabled = true;
            K9.BackColor = Color.White;
            K9.ForeColor = SystemColors.ControlText;
            K9.Enabled = true;
            K10.BackColor = Color.White;
            K10.ForeColor = SystemColors.ControlText;
            K10.Enabled = true;
            K11.BackColor = Color.White;
            K11.ForeColor = SystemColors.ControlText;
            K11.Enabled = true;
            K12.BackColor = Color.White;
            K12.ForeColor = SystemColors.ControlText;
            K12.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
            SeferNo();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komutekle = new SqlCommand("Insert into TBLKaptan(KAPTANNO,ADSOYAD,TELEFON) Values(@p1,@p2,@p3)",bgl);
            komutekle.Parameters.AddWithValue("@p1", TXTKaptanNo.Text);
            komutekle.Parameters.AddWithValue("@p2", TXTAdSoyad.Text);
            komutekle.Parameters.AddWithValue("@p3", TXTTelefon.Text);
            komutekle.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Şöför Kaydı Sisteme Eklenmiştir!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komutekle = new SqlCommand("Insert into TBLYolcuBilgi(AD,SOYAD,TELEFON,TC,CINSIYET,MAIL) Values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl);
            komutekle.Parameters.AddWithValue("@p1", TXTAd.Text);
            komutekle.Parameters.AddWithValue("@p2", TXTSoyad.Text);
            komutekle.Parameters.AddWithValue("@p3", TXTTelefonYolcu.Text);
            komutekle.Parameters.AddWithValue("@p4", TXTTc.Text);
            komutekle.Parameters.AddWithValue("@p5", CBXCinsiyet.Text);
            komutekle.Parameters.AddWithValue("@p6", TXTMail.Text);
            komutekle.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Yolcu Kaydı Sisteme Eklenmiştir!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLSeferBilgi(KALKIS,VARIS,TARIH,SAAT,KAPTAN,FIYAT) Values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl);
            komut.Parameters.AddWithValue("@p1", TXTKalkis.Text);
            komut.Parameters.AddWithValue("@p2", TXTVaris.Text);
            komut.Parameters.AddWithValue("@p3", TXTTarih.Text);
            komut.Parameters.AddWithValue("@p4", TXTSaat.Text);
            komut.Parameters.AddWithValue("@p5", TXTKaptan.Text);
            komut.Parameters.AddWithValue("@p6", TXTFiyat.Text);
            komut.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Sefer Kaydı Oluşturuldu!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            SeferNo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CBXKoltuk.Text = "K1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CBXKoltuk.Text = "K2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CBXKoltuk.Text = "K3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CBXKoltuk.Text = "K4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CBXKoltuk.Text = "K5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CBXKoltuk.Text = "K6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CBXKoltuk   .Text = "K7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CBXKoltuk.Text = "K8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CBXKoltuk.Text = "K9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CBXKoltuk.Text = "K10";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            CBXKoltuk.Text = "K11";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            CBXKoltuk.Text = "K12";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLSeferDetay Where SEFERNO=@p1 and KOLTUK=@p2 and DURUM=0", bgl);
            komut.Parameters.AddWithValue("@p1", TXTRezervSefer.Text);
            komut.Parameters.AddWithValue("@p2", CBXKoltuk.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                giris = 1;
                bgl.Close();
            }
            else
            {
                MessageBox.Show("Dolu Koltuk Seçimi Yapıldı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.Close();
            }
            if(giris==1)
            {
                bgl.Open();
                SqlCommand komutekle = new SqlCommand("Update TBLSeferDetay set YOLCUTC=@P1, DURUM=@p2 Where SEFERNO=@P3 and KOLTUK=@p4", bgl);
                komutekle.Parameters.AddWithValue("@p1", TXTRezervTC.Text);
                komutekle.Parameters.AddWithValue("@p2", 1);
                komutekle.Parameters.AddWithValue("@p3", TXTRezervSefer.Text);
                komutekle.Parameters.AddWithValue("@p4", CBXKoltuk.Text);
                komutekle.ExecuteNonQuery();
                bgl.Close();
                MessageBox.Show("Rezervasyon Yapılmıştır!\nİyi Yolculuklar Dileriz...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.Close();
            }
            giris = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLSeferBilgi Where KALKIS=@p1 and VARIS = @p2 and TARIH=@p3", bgl);
            komut.Parameters.AddWithValue("@p1", AraKalkıs.Text);
            komut.Parameters.AddWithValue("@p2", AraVarıs.Text);
            komut.Parameters.AddWithValue("@p3", AraTarıh.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                giris = 1;
            }
            bgl.Close();
            if(giris==1)
            {
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            giris = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            KoltukTemizle();
            int seferno = Convert.ToInt32(comboBox1.Text);
            List<string> list = new List<string>();

            bgl.Open();
            SqlCommand koltuksorgu = new SqlCommand("Select KOLTUK From TBLSeferDetay Where DURUM=1 and SEFERNO=@p1", bgl);
            koltuksorgu.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr = koltuksorgu.ExecuteReader();
            while (dr.Read())
            {
                list.Add(dr[0].ToString());
            }
            foreach(string s in list)
            {
                string[] butonisim = { "K1 ", "K2 ", "K3 ", "K4 ", "K5 ", "K6 ", "K7 ", "K8 ", "K9 ", "K10", "K11", "K12" };
                foreach(string btn in butonisim)
                {
                    if (s==btn)
                    {
                        KoltukRenklendir(s);
                    }
                }
            }
            bgl.Close();
        }
    }
}