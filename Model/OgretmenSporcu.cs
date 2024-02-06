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
    public class OgretmenSporcu:Sporcu
    {
        public string Brans { get; set; }
        public DateTime MezuniyetTarihi { get; set; }

        public OgretmenSporcu( string ad, string soyad, DateTime doğumTarihi, string cinsiyet, string telefon, string mail, DateTime kayıtTarihi, string brans, DateTime mezuniyetTarihi,string gorsel)
            : base( ad, soyad, doğumTarihi, cinsiyet, telefon, mail, kayıtTarihi,gorsel)
        {
            Brans = brans;
            MezuniyetTarihi = mezuniyetTarihi;
        }
        public void VerileriGetir(DataGridView myDataGridView)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
            MySqlDataAdapter adapter;
            DataTable dt;
            dt = new DataTable();
            connection.Open();
            adapter = new MySqlDataAdapter("SELECT SporcuId, SporcuTuru, Ad, Soyad, DoğumTarihi, Cinsiyet, Telefon, Mail, KayıtTarihi, Brans, MezuniyetTarihi,Gorsel FROM sporcular WHERE SporcuTuru = 'Öğretmen'", connection);
            adapter.Fill(dt);
            myDataGridView.DataSource = dt;
            connection.Close();
        }



        public void verileriEkle(string sporcuTuru, string ad, string soyad, DateTime dogumTarihi, string cinsiyet, string telefon, string mail, DateTime kayitTarihi, string brans,DateTime mezuniyetTarihi, string gorsel)
        {

            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
                MySqlCommand command;

                string query = "INSERT INTO `sporcular` (`SporcuTuru` ,`Ad`, `SOYAD`, `DoğumTarihi`, `Cinsiyet`, `Telefon`, `Mail`, `KayıtTarihi`, `Brans`, `MezuniyetTarihi`, `Gorsel`) " +
                               "VALUES (@SporcuTuru,@Ad, @Soyad, @DoğumTarihi, @Cinsiyet, @Telefon, @Mail, @KayıtTarihi, @Brans, @MezuniyetTarihi, @Gorsel);";
                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@SporcuTuru", "Öğretmen");
                command.Parameters.AddWithValue("@Ad", ad);
                command.Parameters.AddWithValue("@Soyad", soyad);
                command.Parameters.AddWithValue("@DoğumTarihi", dogumTarihi);
                command.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                command.Parameters.AddWithValue("@Telefon", telefon);
                command.Parameters.AddWithValue("@Mail", mail);
                command.Parameters.AddWithValue("@KayıtTarihi", kayitTarihi);
                command.Parameters.AddWithValue("@Brans", brans);
                command.Parameters.AddWithValue("@MezuniyetTarihi", mezuniyetTarihi);
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




        public void verileriGuncelle(string Id, string ad, string soyad, DateTime dogumTarihi, string cinsiyet, string telefon, string mail, DateTime kayitTarihi, string brans, DateTime mezuniyetTarihi,string gorsel)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;user id=eslem;password=eslem;database=fitnesstracking;");
                MySqlCommand command;

                string query = "UPDATE sporcular SET Ad = @Ad, SOYAD=@Soyad, DoğumTarihi=@DoğumTarihi, Cinsiyet=@Cinsiyet, Telefon=@Telefon, Mail=@Mail, KayıtTarihi=@KayıtTarihi, Brans=@Brans, MezuniyetTarihi=@MezuniyetTarihi, Gorsel=@Gorsel " +
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
                command.Parameters.AddWithValue("@Brans", brans);
                command.Parameters.AddWithValue("@MezuniyetTarihi", mezuniyetTarihi);
                command.Parameters.AddWithValue("@Gorsel", gorsel);


                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Öğretmen başarıyla güncellendi");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }



       
    }
}
