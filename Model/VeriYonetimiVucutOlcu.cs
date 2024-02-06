using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace FitnessApplication
{
    internal class VeriYonetimiVucutOlcu
    {
        public void VerileriGetir(DataGridView myDataGridView)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
            MySqlDataAdapter adapter;
            DataTable dt;
            dt = new DataTable();
            connection.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM vucutolcu", connection);
            adapter.Fill(dt);
            myDataGridView.DataSource = dt;
            connection.Close();
        }


        public void verileriEkle(int sporcuID, string ad, int kilo, int boy, int gogusCevresi, int belCevresi, int kalcaCevresi, DateTime olcuTarihi)
        {

            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
                MySqlCommand command;

                string query = "INSERT INTO `vucutolcu` (`SporcuID`, `Ad`,`Kilo`, `Boy`, `GogusCevresi`, `BelCevresi`, `KalcaCevresi`, `OlcuTarihi`) " +
                               "VALUES (@SporcuID,@Ad, @Kilo, @Boy, @GogusCevresi,@BelCevresi, @KalcaCevresi, @OlcuTarihi);";
                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@SporcuID", sporcuID);
                command.Parameters.AddWithValue("@Ad", ad);
                command.Parameters.AddWithValue("@Kilo", kilo);
                command.Parameters.AddWithValue("@Boy", boy);
                command.Parameters.AddWithValue("@GogusCevresi", gogusCevresi);
                command.Parameters.AddWithValue("@BelCevresi", belCevresi);
                command.Parameters.AddWithValue("@KalcaCevresi", kalcaCevresi);
                command.Parameters.AddWithValue("@OlcuTarihi", olcuTarihi);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Veri başarıyla eklendi.");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }



        public void verileriSil(int SporcuId)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
                MySqlCommand command;

                string query = "DELETE FROM `vucutolcu` WHERE `SporcuId` = @SporcuId;";
                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@SporcuId", SporcuId);

                connection.Open();
                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Veri başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Silinecek veri bulunamadı.");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        public void verileriGuncelle(int sporcuID, int kilo, int boy, int gogusCevresi, int belCevresi, int kalcaCevresi, DateTime olcuTarihi)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
                MySqlCommand command;
                
                string query = "UPDATE vucutolcu SET sporcuID = @sporcuID, Kilo=@Kilo, Boy=@Boy, GogusCevresi=@GogusCevresi, BelCevresi=@BelCevresi, KalcaCevresi=@KalcaCevresi, OlcuTarihi=@OlcuTarihi " +
               "WHERE SporcuId = @SporcuId";

                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@SporcuID", sporcuID);
                command.Parameters.AddWithValue("@Kilo", kilo);
                command.Parameters.AddWithValue("@Boy", boy);
                command.Parameters.AddWithValue("@GogusCevresi", gogusCevresi);
                command.Parameters.AddWithValue("@BelCevresi", belCevresi);
                command.Parameters.AddWithValue("@KalcaCevresi", kalcaCevresi);
                command.Parameters.AddWithValue("@OlcuTarihi", olcuTarihi);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Veri başarıyla güncellendi");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
       
          
        }

        public void Ara(DataGridView myDataGridView, string ad)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");

            try
            {
                connection.Open();

                if (string.IsNullOrEmpty(ad))
                {
                    VerileriGetir(myDataGridView);
                    // Tüm veriyi göster
                }
                else
                {
                    string query = "SELECT * FROM vucutolcu WHERE Ad = @Ad";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ad", ad);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                myDataGridView.DataSource = dt; // Filtrelenmiş veriyi göster
                            }
                            else
                            {
                                MessageBox.Show("Sporcu bulunamadı.");
                            }
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



        public string AdBilgisiniGetir(int sporcuId)
        {
            string ad = "";

            MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
            MySqlCommand command;
            connection.Open();

            string query = $"SELECT Ad FROM Sporcular WHERE SporcuID = {sporcuId}";
            command = new MySqlCommand(query, connection);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                ad = reader["Ad"].ToString();
            }

            connection.Close();

            return ad;
        }
    }
}
