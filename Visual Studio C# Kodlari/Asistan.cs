// Asistan.cs

using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace VTYSProje
{
    public partial class Asistan : Form
    {
        private string connectionString = "Data Source=TOSHIBA;Initial Catalog=VTYSProje;Integrated Security=True";
        private object cagriListesiGorTableAdapter;



        public object VTYSProjeDataSet { get; private set; }

        public Asistan()
        {
            InitializeComponent();
        }

        public void SetWelcomeMessage(string adSoyad, string personelID)
        {
            labAsistan.Text = "Hoşgeldiniz " + adSoyad;
            AsistanID.Text = personelID;
        }

        private void Asistan_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'vTYSProjeDataSet5.AylikPrimListesi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.aylikPrimListesiTableAdapter1.Fill(this.vTYSProjeDataSet5.AylikPrimListesi);
            
            btnYeniCagri.Visible = false;
            cagriListesi.Visible = false;
            labBanaGelenCagrilar.Visible = false;
            primItirazlari.Visible = false;
            btnItirazEkle.Visible = false;
            aylikPrimListesi.Visible=false;

            
        }

        private void müşteriÇağrıListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(cagriListesi);
            form2.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CagriListesiMenusu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM cagriListesiGor ORDER BY GorusmeTarihi DESC, BaslamaSaati DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        cagriListesi.DataSource = dataTable;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

            btnYeniCagri.Visible = true;
            cagriListesi.Visible = true;
            labBanaGelenCagrilar.Visible = true;
            primItirazlari.Visible = false;
            btnItirazEkle.Visible = false;
            aylikPrimListesi.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAsistanExit_Click(object sender, EventArgs e)
        {
            // Asistanın oturumunu kapat ve kaydını sil
            string personelID = AsistanID.Text;
            RemoveFromActiveUsers(personelID);

            // Formu kapat
            this.Close();
        }

        private void RemoveFromActiveUsers(string personelID)
        {
            string query = "DELETE FROM OturumAcmisKullanicilar WHERE PersonelID = @personelID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@personelID", personelID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void cagriListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void primItirazlari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void PrimItirazlariMenusu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM Itirazlarim";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Assuming you have a DataGridView named 'cagriListesi' to display the data
                        primItirazlari.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

            // Make necessary UI elements visible/invisible
            btnYeniCagri.Visible = false; // Assuming you want to hide the 'Yeni Çağrı' button
            cagriListesi.Visible = false;
            labBanaGelenCagrilar.Visible = false;
            primItirazlari.Visible = true;
            btnItirazEkle.Visible = false;
            aylikPrimListesi.Visible = false;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            btnItirazEkle.Enabled = false;         
        }

        private void aylikPrimListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool CheckCurrentMonth(DateTime date)
        {
            // Güncel tarihi al
            DateTime currentDate = DateTime.Now;

            // Parametre olarak gelen tarihin ayını al
            int dateMonth = date.Month;

            // Güncel tarihin ayını al
            int currentMonth = currentDate.Month;

            // Tarih ayı ile güncel ayı karşılaştır ve sonucu döndür
            if (dateMonth == currentMonth)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void AylikPrimleriMenusu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT Tarih FROM Itirazlarim";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Itirazlar tablosundan tarih sütununu al
                        foreach (DataRow row in dataTable.Rows)
                        {
                            DateTime itirazDate = Convert.ToDateTime(row["Tarih"]);

                            // Tarihin ayını kontrol et
                            bool isCurrentMonth = CheckCurrentMonth(itirazDate);

                            // Eğer tarih bu ay ise işlem yap
                            if (isCurrentMonth)
                            {
                                btnItirazEkle.Enabled = false;
                            }
                            else
                            {
                                btnItirazEkle.Enabled = true;
                            }
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

            // Make necessary UI elements visible/invisible
            btnYeniCagri.Visible = false; // Assuming you want to hide the 'Yeni Çağrı' button
            cagriListesi.Visible = false;
            labBanaGelenCagrilar.Visible = false;
            primItirazlari.Visible = false;           
            aylikPrimListesi.Visible = true;
            btnItirazEkle.Visible = true;
        }

        private void aylikPrimListesi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }
    }
}
        
    
