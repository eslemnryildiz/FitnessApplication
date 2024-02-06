using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace FitnessApplication
{
    internal class VeriYonetimiEgzersiz
    {
        public void VerileriGetir(DataGridView myDataGridView)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
            MySqlDataAdapter adapter;
            DataTable dt;
            dt = new DataTable();
            connection.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM egzersiz_aletleri", connection);
            adapter.Fill(dt);
            myDataGridView.DataSource = dt;
            connection.Close();
        }


        public void verileriEkle( string ad, string islev, string gorsel)
        {

            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
                MySqlCommand command;


                string query = "INSERT INTO `egzersiz_aletleri` ( `Ad`,`Islev`, `Gorsel`) " +
                               "VALUES (@Ad, @Islev, @Gorsel);";
                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@Ad", ad);
                command.Parameters.AddWithValue("@Islev", islev);
                command.Parameters.AddWithValue("@Gorsel", gorsel);

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



        public void verileriSil(int id)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
                MySqlCommand command;

                string query = "DELETE FROM `egzersiz_aletleri` WHERE `Id` = @Id;";
                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", id);

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

        public void verileriGuncelle( int id,string ad, string islev, string gorsel)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
                MySqlCommand command;

                string query = "UPDATE egzersiz_aletleri SET  Id=@Id ,Ad=@Ad, Islev=@Islev, Gorsel=@Gorsel " +
               "WHERE Id = @Id";

                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Ad", ad);
                command.Parameters.AddWithValue("@Islev", islev);
                command.Parameters.AddWithValue("@Gorsel", gorsel);

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
                    string query = "SELECT * FROM egzersiz_aletleri WHERE Ad LIKE @Ad";
                    ad = "%" + ad + "%"; // Kısmi eşleşmeler için % joker karakterini ekleyin

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Ad", ad);

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
                                MessageBox.Show("Egzersiz bulunamadı.");
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


