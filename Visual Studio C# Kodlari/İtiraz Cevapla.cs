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
using System.Net;
using System.Net.Mail;

namespace VTYSProje
{
    public partial class Form3 : Form
    {
        private string connectionString = "Data Source=TOSHIBA;Initial Catalog=VTYSProje;Integrated Security=True";
        private DataGridView asistanlariminItirazlari;
        private int ItirazID;


        private string aciklama;
        public Form3(int ItirazID, DataGridView asistanlariminItirazlari)
        {
            InitializeComponent();
            this.ItirazID = ItirazID;
            this.asistanlariminItirazlari = asistanlariminItirazlari;
        }
    

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            int durum = 2; // Onay durumu

            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spo_itirazaCevap", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Stored Procedure parametrelerini ayarlayın
                    cmd.Parameters.AddWithValue("@ItirazID", ItirazID);
                    cmd.Parameters.AddWithValue("@Aciklama", aciklama); 
                    cmd.Parameters.AddWithValue("@ItirazinDurumu", durum);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("İtiraz onaylandı.");

                         string grupYoneticisiMail = GetGrupYoneticisiMail();

                        // E-posta gönderme işlemi
                         SendEmail("testveritabani@gmail.com", "tfdg jgui urla raig", grupYoneticisiMail, "Çağrı Onayı", aciklama);

                         ReloadPage();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            int durum = 3; // Reddetme durumu

            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spo_itirazaCevap", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Stored Procedure parametrelerini ayarlayın
                    cmd.Parameters.AddWithValue("@ItirazID", ItirazID);
                    cmd.Parameters.AddWithValue("@Aciklama", aciklama); 
                    cmd.Parameters.AddWithValue("@ItirazinDurumu", durum);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("İtiraz reddedildi.");

                        string grupYoneticisiMail = GetGrupYoneticisiMail();

                        // E-posta gönderme işlemi
                        SendEmail("testveritabani@gmail.com", "tfdg jgui urla raig", grupYoneticisiMail, "Çağrı Reddi", aciklama);

                        ReloadPage();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void txtItirazAciklamasi_TextChanged(object sender, EventArgs e)
        {
            aciklama = txtItirazAciklamasi.Text;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "İtiraz Cevapla";
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
                string query = @"SELECT dbo.f_ilgiliGrupYoneticisiMaili() AS Email";

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

        private void ReloadPage()
        {
            // Verileri yeniden yükle
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM AsistanlariminItirazlari"; // Tablo adınızı buraya girin

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
            asistanlariminItirazlari.DataSource = dt;
        }
    }
}
