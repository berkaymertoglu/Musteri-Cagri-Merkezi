using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYSProje
{
    public partial class Form4 : Form
    {
        private string connectionString = "Data Source=TOSHIBA;Initial Catalog=VTYSProje;Integrated Security=True";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "İtiraz Ekle";
        }

        

        private void btnGonder_Click(object sender, EventArgs e)
        {
            // Veritabanına göndermek istediğiniz metni TextBox'tan alın
            string metin = txtItirazAciklamasi.Text;

            // Bağlantı nesnesini oluşturun
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Veritabanına gönderilecek olan metni parametre olarak belirtin
                SqlCommand cmd = new SqlCommand("sp_itirazEkle", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Aciklama", metin);

                try
                {
                    // Bağlantıyı açın ve komutu çalıştırın
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("İtiraz ekleme işlemi başarılı.");

                    string grupYoneticisiMail = GetGrupYoneticisiMail();
                    SendEmail("testveritabani@gmail.com", "tfdg jgui urla raig", grupYoneticisiMail, "İtiraz İşlemi", metin);
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SendEmail(string fromEmail, string password, string toEmail, string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpserver = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(fromEmail);
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = body;

                smtpserver.Port = 587;
                smtpserver.Credentials = new System.Net.NetworkCredential(fromEmail, password);
                smtpserver.EnableSsl = true;

                smtpserver.Send(mail);

                MessageBox.Show("Mail gönderme işlemi başarılı.");

                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Mail gönderilemedi." + ex.Message);
            }
        }

        private string GetGrupYoneticisiMail()
        {
            string grupYoneticisiMail = "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT dbo.f_AsistanIcinGYMaili() AS Email";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            grupYoneticisiMail = result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }

            return grupYoneticisiMail;
        }
    }
}
