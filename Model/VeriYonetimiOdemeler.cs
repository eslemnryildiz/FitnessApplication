using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace FitnessApplication
{
    internal class VeriYonetimiOdemeler
    {
        public void VerileriGetir(DataGridView myDataGridView)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
            MySqlDataAdapter adapter;
            DataTable dt;
            dt = new DataTable();
            connection.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM odemeler", connection);
            adapter.Fill(dt);
            myDataGridView.DataSource = dt;
            connection.Close();
        }


        public void verileriEkle(int sporcuID,string ad, DateTime tarih,int miktar,string aciklama)
        {

            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
                MySqlCommand command;

                string query = "INSERT INTO `Odemeler` (`SporcuID`, `Ad`,`Tarih`, `Miktar`, `Aciklama`) " +
                               "VALUES (@SporcuID,@Ad, @Tarih, @miktar, @Aciklama);";
                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@SporcuID", sporcuID);
                command.Parameters.AddWithValue("@Ad", ad);
                command.Parameters.AddWithValue("@Tarih", tarih);
                command.Parameters.AddWithValue("@Miktar", miktar);
                command.Parameters.AddWithValue("@Aciklama", aciklama);
                
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



        public void verileriSil(int odemeId)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
                MySqlCommand command;

                string query = "DELETE FROM `odemeler` WHERE `OdemeId` = @OdemeId;";
                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@OdemeId", odemeId);

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

        public void verileriGuncelle(int odemeId,int sporcuID,string ad, DateTime tarih, int miktar, string aciklama)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
                MySqlCommand command;

                string query = "UPDATE odemeler SET odemeID = @odemeID,sporcuID = @sporcuID,ad = @ad, tarih=@tarih, miktar=@miktar, aciklama=@aciklama " +
               "WHERE SporcuID = @SporcuID";

                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@OdemeID", odemeId);
                command.Parameters.AddWithValue("@SporcuID", sporcuID);
                command.Parameters.AddWithValue("@ad", ad);
                command.Parameters.AddWithValue("@Tarih", tarih);
                command.Parameters.AddWithValue("@Miktar", miktar);
                command.Parameters.AddWithValue("@Aciklama", aciklama);

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

        public void Ara(DataGridView myDataGridView, string sporcuAd)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");

            try
            {
                connection.Open();

                if (string.IsNullOrEmpty(sporcuAd))
                {
                    VerileriGetir(myDataGridView);
                    // Tüm veriyi göster
                }
                else
                {
                    string query = "SELECT * FROM odemeler WHERE Ad = @Ad";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Ad", sporcuAd);

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
