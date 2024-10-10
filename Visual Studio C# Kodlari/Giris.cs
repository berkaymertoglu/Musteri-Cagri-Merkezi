// LoginForm.cs

using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VTYSProje
{
    public partial  class LoginForm : Form
    {
        private string connectionString = "Data Source=TOSHIBA;Initial Catalog=VTYSProje;Integrated Security=True";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            string password = tbPass.Text;

            // Kullanıcının pozisyonunu ve PersonelID'sini al
            Tuple<int, string> userData = GetUserData(email, password);
            int position = userData.Item1;
            string personelID = userData.Item2;

            if (position == 1 || position == 2) // Asistan ya da Takım Lideri ise
            {
                // Oturum açmış kullanıcının bilgilerini OturumAcmisKullanicilar tablosuna ekle
                AddToActiveUsers(personelID);

                // Formları aç ve gizle
                if (position == 1)
                {
                    string adSoyad = GetUserName(email);
                    Asistan asistanForm = new Asistan();
                    asistanForm.SetWelcomeMessage(adSoyad, personelID);
                    asistanForm.Show();
                    this.Hide();
                }
                else if (position == 2)
                {
                    string adSoyad = GetUserName(email);
                    TakimLideri takimLideriForm = new TakimLideri();
                    takimLideriForm.SetWelcomeMessage(adSoyad, personelID);
                    takimLideriForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Hatalı Giriş", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEmail.Clear();
                tbPass.Clear();
                tbEmail.Focus();
            }
        }

        // Oturum açmış kullanıcıyı OturumAcmisKullanicilar tablosuna ekleyen metod
        private void AddToActiveUsers(string personelID)
        {
            string query = "INSERT INTO OturumAcmisKullanicilar (PersonelID, OturumBaslangicZamani) VALUES (@personelID, @baslangicZamani)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@personelID", personelID);
                    cmd.Parameters.AddWithValue("@baslangicZamani", DateTime.Now); // Oturum başlangıç zamanı

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private Tuple<int, string> GetUserData(string email, string password)
        {
            string query = "SELECT Pozisyon, PersonelID FROM SistemKullanicilari WHERE Eposta = @username AND Sifre = @password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int position = reader.GetInt32(0);
                        string personelID = reader.GetString(1);
                        return Tuple.Create(position, personelID);
                    }
                    else
                    {
                        // Kullanıcı bulunamadıysa varsayılan değerler döndür
                        return Tuple.Create(-1, "");
                    }
                }
            }
        }

        private string GetUserName(string email)
        {
            string query = "SELECT CONCAT(PersonelAdi, ' ', PersonelSoyadi) FROM SistemKullanicilari WHERE Eposta = @username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", email);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    return result != DBNull.Value ? result.ToString() : "";
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
