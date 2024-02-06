using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace FitnessApplication
{
    internal class VeriYonetimiGunler
    {
        public void VerileriGetir(DataGridView myDataGridView)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
            MySqlDataAdapter adapter;
            DataTable dt;
            dt = new DataTable();
            connection.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM gunler", connection);
            adapter.Fill(dt);
            myDataGridView.DataSource = dt;
            connection.Close();
        }

        public void verileriEkle( int sporcuID, string pazartesi, string sali, string carsamba, string persembe, string cuma, string cumartesi, string pazar)
        {

            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
                MySqlCommand command;

                string query = "INSERT INTO `gunler` ( `SporcuId`,`pazartesi`, `sali`, `carsamba`, `persembe`, `cuma`, `cumartesi`, `pazar`) " +
                               "VALUES (@SporcuID,@pazartesi, @sali, @carsamba, @persembe, @cuma, @cumartesi, @pazar);";
                command = new MySqlCommand(query, connection);
                
                command.Parameters.AddWithValue("@SporcuId", sporcuID);
                command.Parameters.AddWithValue("@pazartesi", pazartesi);
                command.Parameters.AddWithValue("@sali", sali);
                command.Parameters.AddWithValue("@carsamba", carsamba);
                command.Parameters.AddWithValue("@persembe", persembe);
                command.Parameters.AddWithValue("@cuma", cuma);
                command.Parameters.AddWithValue("@cumartesi", cumartesi);
                command.Parameters.AddWithValue("@pazar", pazar);

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

        public void VerileriGuncelle(int id,int sporcuID, string pazartesi, string sali, string carsamba, string persembe, string cuma, string cumartesi, string pazar)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
                MySqlCommand command;

                string query = "UPDATE gunler SET id = @id,SporcuId = @SporcuId, pazartesi = @pazartesi, sali = @sali, carsamba = @carsamba, " +
                               "persembe = @persembe, cuma = @cuma, cumartesi = @cumartesi, pazar = @pazar " +
                               "WHERE SporcuId = @SporcuId";  // Burada WHERE koşulu SporcuId'ye göre güncelleme yapılıyor. Siz gerekli alanı belirtmelisiniz.

                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@SporcuId", sporcuID);
                command.Parameters.AddWithValue("@pazartesi", pazartesi);
                command.Parameters.AddWithValue("@sali", sali);
                command.Parameters.AddWithValue("@carsamba", carsamba);
                command.Parameters.AddWithValue("@persembe", persembe);
                command.Parameters.AddWithValue("@cuma", cuma);
                command.Parameters.AddWithValue("@cumartesi", cumartesi);
                command.Parameters.AddWithValue("@pazar", pazar);

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
        public void GunSil(int id)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
                MySqlCommand command;

                string query = "DELETE FROM `gunler` WHERE `id` = @id;";
                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", id);

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


        public void Ara(DataGridView myDataGridView, string sporcuId)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");

            try
            {
                connection.Open();

                if (string.IsNullOrEmpty(sporcuId))
                {
                    VerileriGetir(myDataGridView);
                    // Tüm veriyi göster
                }
                else
                {
                    string query = "SELECT * FROM gunler WHERE sporcuId = @SporcuId";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SporcuId", sporcuId);

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
    }
}
