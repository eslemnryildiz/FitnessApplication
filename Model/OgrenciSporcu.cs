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
    public class OgrenciSporcu: Sporcu
    {
        
        public string Sinif { get; set; }
        public string Bolum { get; set; }

        public OgrenciSporcu(string ad, string soyad, DateTime doğumTarihi, string cinsiyet, string telefon, string mail, DateTime kayıtTarihi, string sinif, string bolum,string gorsel)
            : base(ad, soyad, doğumTarihi, cinsiyet, telefon, mail, kayıtTarihi,gorsel)
        {
            
            Sinif = sinif;
            Bolum = bolum;
        }


        public void VerileriGetir(DataGridView myDataGridView)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
            MySqlDataAdapter adapter;//verileri çekmek için
            DataTable dt;//geçici tablo
            dt = new DataTable();
            connection.Open();
            adapter = new MySqlDataAdapter("SELECT SporcuId, SporcuTuru, Ad, Soyad, DoğumTarihi, Cinsiyet, Telefon, Mail, KayıtTarihi, Sinif,Bolum,Gorsel FROM sporcular WHERE SporcuTuru = 'Öğrenci'", connection);
            adapter.Fill(dt);
            myDataGridView.DataSource = dt;
            connection.Close();
        }


        public void verileriEkle(string sporcuTuru,string ad, string soyad, DateTime dogumTarihi, string cinsiyet, string telefon, string mail, DateTime kayitTarihi, string sinif, string bolum,string gorsel)
        {

            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
                MySqlCommand command;//gönderilecek sorgu

                string query = "INSERT INTO `sporcular` (`SporcuTuru` ,`Ad`, `SOYAD`, `DoğumTarihi`, `Cinsiyet`, `Telefon`, `Mail`, `KayıtTarihi`, `Sinif`, `Bolum`, `Gorsel`) " +
                               "VALUES (@SporcuTuru,@Ad, @Soyad, @DoğumTarihi, @Cinsiyet, @Telefon, @Mail, @KayıtTarihi, @Sinif, @Bolum, @Gorsel);";
                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@SporcuTuru", "Öğrenci");
                command.Parameters.AddWithValue("@Ad", ad);
                command.Parameters.AddWithValue("@Soyad", soyad);
                command.Parameters.AddWithValue("@DoğumTarihi", dogumTarihi);
                command.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                command.Parameters.AddWithValue("@Telefon", telefon);
                command.Parameters.AddWithValue("@Mail", mail);
                command.Parameters.AddWithValue("@KayıtTarihi", kayitTarihi);
                command.Parameters.AddWithValue("@Sinif", sinif);
                command.Parameters.AddWithValue("@Bolum", bolum);
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

        public void verileriGuncelle(string Id, string ad, string soyad, DateTime dogumTarihi, string cinsiyet, string telefon, string mail, DateTime kayitTarihi, string sinif, string bolum, string gorsel)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
                MySqlCommand command;

                string query = "UPDATE sporcular SET Ad = @Ad, SOYAD=@Soyad, DoğumTarihi=@DoğumTarihi, Cinsiyet=@Cinsiyet, Telefon=@Telefon, Mail=@Mail, KayıtTarihi=@KayıtTarihi, Sinif=@Sinif, Bolum=@Bolum , Gorsel=@Gorsel" +
               "WHERE SporcuId = @SporcuId";

                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@SporcuId", Id);
                command.Parameters.AddWithValue("@Ad", ad);
                command.Parameters.AddWithValue("@Soyad", soyad);
                command.Parameters.AddWithValue("@DoğumTarihi", dogumTarihi);
                command.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                command.Parameters.AddWithValue("@Telefon", telefon);
                command.Parameters.AddWithValue("@Mail", mail);
                command.Parameters.AddWithValue("@KayıtTarihi", kayitTarihi);
                command.Parameters.AddWithValue("@Sinif", sinif);
                command.Parameters.AddWithValue("@Bolum", bolum);
                command.Parameters.AddWithValue("@Gorsel", gorsel);


                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Öğrenci başarıyla güncellendi");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

    



      

    }
}
