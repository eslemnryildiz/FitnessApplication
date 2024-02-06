using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApplication
{
    public class Sporcu
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        
        public DateTime DoğumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public DateTime KayıtTarihi { get; set; }
        public string Gorsel { get; set; }

        public Sporcu(string ad, string soyad, DateTime doğumTarihi, string cinsiyet, string telefon, string mail, DateTime kayıtTarihi,string gorsel)
        {
            
            Ad = ad;
            Soyad = soyad;
            DoğumTarihi = doğumTarihi;
            Cinsiyet = cinsiyet;
            Telefon = telefon;
            Mail = mail;
            KayıtTarihi = kayıtTarihi;
            Gorsel = gorsel;
        }

        public void VerileriGetir(DataGridView myDataGridView)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
            MySqlDataAdapter adapter;
            DataTable dt;
            dt = new DataTable();
            connection.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM sporcular", connection);
            adapter.Fill(dt);
            myDataGridView.DataSource = dt; 
            connection.Close();
        }



        public void verileriSil(int SporcuId)
        {
            string connectionString = "server=localhost;user id=eslem;password=eslem;database=fitnesstracking;";

            // Silmek istediğiniz sporcu ID
            // Bu değeri kendi gereksinimlerinize göre değiştirin

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand deleteSporcuCommand = new MySqlCommand("DELETE FROM sporcular WHERE SporcuId = @sporcuId", connection))
                    {
                        deleteSporcuCommand.Parameters.AddWithValue("@sporcuId", SporcuId);
                        deleteSporcuCommand.ExecuteNonQuery();

                        // Sporcu silindi, şimdi diğer tablolardan ilgili verileri sil
                        using (MySqlCommand deleteOlcuCommand = new MySqlCommand("DELETE FROM vucutOlcu WHERE SporcuId = @sporcuId", connection))
                        {
                            deleteOlcuCommand.Parameters.AddWithValue("@sporcuId", SporcuId);
                            deleteOlcuCommand.ExecuteNonQuery();
                        }

                        using (MySqlCommand deleteOdemeCommand = new MySqlCommand("DELETE FROM odemeler WHERE SporcuId = @sporcuId", connection))
                        {
                            deleteOdemeCommand.Parameters.AddWithValue("@sporcuId", SporcuId);
                            deleteOdemeCommand.ExecuteNonQuery();
                        }

                        // Diğer tablolar için gerekli DELETE komutlarını ekleyebilirsiniz.
                    }

                    MessageBox.Show("Sporcu ve ilgili veriler başarıyla silindi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        
    }



        public void ara(DataGridView myDataGridView, TextBox txtAd)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");

            try
            {
                connection.Open();

                string arananAd = txtAd.Text.Trim();

                if (string.IsNullOrEmpty(arananAd))
                {
                    VerileriGetir(myDataGridView);
                    // Tüm veriyi göster
                }
                else
                {
                    string query = "SELECT * FROM sporcular WHERE Ad LIKE @arananAd";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@arananAd", "%" + arananAd + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            myDataGridView.DataSource = dt; // Filtrelenmiş veriyi göster
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }


        



    }
    
}