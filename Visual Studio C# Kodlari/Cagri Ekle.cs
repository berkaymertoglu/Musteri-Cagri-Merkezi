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

namespace VTYSProje
{
    public partial class Form2 : Form
    {
        private string connectionString = "Data Source=TOSHIBA;Initial Catalog=VTYSProje;Integrated Security=True";

        private DataGridView cagriListesi;
        public Form2(DataGridView cagriListesi)
        {
            InitializeComponent();
            this.cagriListesi = cagriListesi;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxDurum.Items.Add("Tamamlandı");
            comboBoxDurum.Items.Add("Takip Ediliyor");
            comboBoxDurum.Items.Add("Sorun Çözülemedi");
            comboBoxKonu.Items.Add("Arıza");
            comboBoxKonu.Items.Add("Talep");
            comboBoxKonu.Items.Add("Bilgi");
            this.Text = "Çağrı Ekle";
        }

        private DateTime ParseDateString(string dateString)
        {
            DateTime parsedDate;
            if (DateTime.TryParse(dateString, out parsedDate))
            {
                return parsedDate;
            }
            else
            {
                // Dönüşüm başarısız olduysa varsayılan değeri döndür veya hata yönetimi yap
                MessageBox.Show("Tarih formatı hatalı!");
                return DateTime.MinValue; // Veya başka bir değer dönülebilir
            }
        }

        private TimeSpan ParseTimeString(string timeString)
        {
            TimeSpan parsedTime;
            if (TimeSpan.TryParse(timeString, out parsedTime))
            {
                return parsedTime;
            }
            else
            {
                // Dönüşüm başarısız olduysa varsayılan değeri döndür veya hata yönetimi yap
                MessageBox.Show("Saat formatı hatalı!");
                return TimeSpan.MinValue; // Veya başka bir değer dönülebilir
            }
        }

        private void btnCagriEkle_Click(object sender, EventArgs e)
        {
            
            string musteriID = txtMusteriID.Text;
            string cagriTarihiStr = txtCagriTarihi.Text;
            DateTime cagriTarihi = ParseDateString(cagriTarihiStr);
            string baslamaSaatiStr = txtBaslamaSaati.Text;
            TimeSpan baslamaSaati = ParseTimeString(baslamaSaatiStr);
            string bitisSaatiStr = txtBitisSaati.Text;
            TimeSpan bitisSaati = ParseTimeString(bitisSaatiStr);

            // ComboBox'tan seçili durumu al
            int durum;
            switch (comboBoxDurum.SelectedItem.ToString())
            {
                case "Tamamlandı":
                    durum = 1;
                    break;
                case "Takip Ediliyor":
                    durum = 2;
                    break;
                case "Sorun Çözülemedi":
                    durum = 3;
                    break;
                default:
                    durum = 0; // Varsayılan durum
                    break;
            }

            // ComboBox'tan seçili konuyu al
            int konu;
            switch (comboBoxKonu.SelectedItem.ToString())
            {
                case "Arıza":
                    konu = 1;
                    break;
                case "Talep":
                    konu = 2;
                    break;
                case "Bilgi":
                    konu = 3;
                    break;
                default:
                    konu = 0; // Varsayılan konu
                    break;
            }

            // Bağlantı oluştur
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Komut oluştur
                using (SqlCommand command = new SqlCommand("sp_CagriEkle", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("MusteriID", musteriID);
                    command.Parameters.AddWithValue("gorusmeTarihi", cagriTarihi);
                    command.Parameters.AddWithValue("BaslamaSaati", baslamaSaati);
                    command.Parameters.AddWithValue("BitisSaati", bitisSaati);
                    command.Parameters.AddWithValue("Durum", durum); 
                    command.Parameters.AddWithValue("Konu", konu); 

                    // Bağlantıyı aç ve komutu çalıştır
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Çağrı ekleme işlemi başarılı");

                        ReloadPage();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void ReloadPage()
        {
            // Verileri yeniden yükle
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM cagriListesiGor ORDER BY GorusmeTarihi DESC, BaslamaSaati DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }

            // DataGridView nesnesini yeniden yükle
            cagriListesi.DataSource = dt;
        }
    }    
}
