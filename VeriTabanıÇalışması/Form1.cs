using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace VeriTabanıÇalışması
{
    public partial class Form1 : Form
    {

        


        OleDbConnection _connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data source=VizeDeneme.accdb"); //veritabanı ile bağlantımızı oluşturudk

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Doldurma1();
            textBox_tc_kimlik.MaxLength = 11;
        }


        public void Doldurma1()
        {
            ConnectionOpen();

            OleDbCommand command = new OleDbCommand("SELECT * FROM Tablo1", _connection); // veri tabanı içinden Tablo1 i istedik



            OleDbDataReader reader = command.ExecuteReader(); // verileri satır satır okuması için command e ilişkilendirdiğimiz tabloyu okuması için reader a veriyoruz.

            //OleDbDataAdapter tüm tabloyu komple alır

            //verileri doldurmak için bir datatable oluşturuyoruz

            DataTable data = new DataTable();



            data.Load(reader);

            grid_veri.DataSource = data;
            ConnectionClose();
        }

        private void ConnectionClose()
        {
            if (ConnectionState.Open == _connection.State) //bağlantının durumu açıksa kapatalım
            {
                _connection.Close();
            }
        }

        private void ConnectionOpen()
        {
            if (ConnectionState.Closed == _connection.State) //bağlantının durumu kapalıysa açalım
            {
                _connection.Open();
            }
        }

        public void Add()
        {
            ConnectionOpen();

            OleDbCommand command = new OleDbCommand("insert into Tablo1 ([ad_soyad],[tc_kimlik],[password]) values(@ad_soyad,@tc_kimlik,@password)", _connection);

            command.Parameters.AddWithValue("@ad_soyad", textBox_ad_soyad.Text );
            command.Parameters.AddWithValue("@tc_kimlik", textBox_tc_kimlik.Text);
            command.Parameters.AddWithValue("@password",textBox_password.Text);




            int deger = -1;

            deger =command.ExecuteNonQuery();

            if (deger > 0)
            {
                MessageBox.Show("Kullanıcı Kaydedildi! ");


            }
            else
            {
                MessageBox.Show("Kullanıcı Kaydedilemedi!");
            }

            ConnectionClose();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add();
            Doldurma1();
            Sifirla();
        }

        public void Sifirla()
        {
            textBox_ad_soyad.Text = "";
            textBox_password.Text = "";
            textBox_tc_kimlik.Text = "";
            textBox_tc_kimlik_update.Text = "";
            textBox_ad_soyad_update.Text = "";
            textBox_password_update.Text = "";
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            Update();
            Doldurma1();
            Sifirla();
        }

        public void Update()
        {
            
            ConnectionOpen();

            OleDbCommand komut = new OleDbCommand("update Tablo1 set [password]='"+textBox_password_update.Text+"' where ad_soyad='"+textBox_ad_soyad_update.Text+"' and tc_kimlik='"+textBox_tc_kimlik_update.Text+"'", _connection);

            komut.ExecuteNonQuery();

            MessageBox.Show("Kullancı şifresi güncellendi!");


            ConnectionClose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete();
            Doldurma1();
            textBox_sil.Text = "";
        }

        public void Delete()
        {
            ConnectionOpen();

            var dialogResult = MessageBox.Show("Bu kayit kalıcı olarak silinecektir. Silmek istiyormusunuz?", "Silme işlemi", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                string komut = $"Delete from Tablo1 where Id={textBox_sil.Text}";

                OleDbCommand oleDbCommand = new OleDbCommand(komut, _connection);

                oleDbCommand.ExecuteNonQuery();

                MessageBox.Show("Kullanıcı Silindi!");
            }



            ConnectionClose();
        }
    }
}
