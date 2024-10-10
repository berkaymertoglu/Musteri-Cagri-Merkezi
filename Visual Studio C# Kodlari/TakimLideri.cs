// TakimLideri.cs

using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VTYSProje
{
    public partial class TakimLideri : Form
    {
        private string connectionString = "Data Source=TOSHIBA;Initial Catalog=VTYSProje;Integrated Security=True";
        public int ItirazID;
        public TakimLideri()
        {
            InitializeComponent();
        }



        public void SetWelcomeMessage(string adSoyad, string personelID)
        {
            labTakimLideri.Text = "Hoşgeldiniz " + adSoyad;
            TakimLideriID.Text = personelID;
        }

        private void TakimLideri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'vTYSProjeDataSet3.AsistanlariminItirazlari' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.asistanlariminItirazlariTableAdapter2.Fill(this.vTYSProjeDataSet3.AsistanlariminItirazlari);


            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "İşlem";
            btnColumn.Text = "İtiraz Cevapla";
            btnColumn.UseColumnTextForButtonValue = true;
            asistanlariminItirazları.Columns.Add(btnColumn);
            asistanlariminItirazları.Visible = false;
            this.Text = "Takım Lideri";
            

        }


        private void btnTakimLideriExit_Click(object sender, EventArgs e)
        {
            // Takım liderinin oturumunu kapat ve kaydını sil
            string personelID = TakimLideriID.Text;
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

        private void iTİRAZLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // DataGridView'i görünür yap
            asistanlariminItirazları.Visible = true;
            
        }

        

        private void asistanlariminİtirazlari_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        

        private void asistanlariminItirazları_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Seçilen satırın 5. sütununun değerini al
            object value = asistanlariminItirazları.Rows[e.RowIndex].Cells[5].Value;

            // Eğer değer null veya DBNull.Value ise
            if (value == null || value == DBNull.Value)
            {
                ItirazID = Convert.ToInt32(asistanlariminItirazları.Rows[e.RowIndex].Cells[6].Value);
                // Form3'ü gösterme işlemi
                Form3 form3 = new Form3(ItirazID, asistanlariminItirazları);
                form3.Show();
            }
            else
            {
                // Değer null değilse, kullanıcıya bir hata mesajı göster
                MessageBox.Show("Zaten cevap girilmiş.");
            }
        }
    }
}
    

