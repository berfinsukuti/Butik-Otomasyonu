using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace Proje
{
    class VeriTabani
    {

        private OleDbConnection connection;
        private OleDbDataAdapter adapter;
        private OleDbCommand command = new OleDbCommand();
        private OleDbDataReader reader;
        private DataTable table;

        public VeriTabani() {
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=sirket.accdb");
            adapter = new OleDbDataAdapter(command);
            command.Connection = connection;
            table = new DataTable();

        }


        public void Listele(string sqlKomut,DataGridView view){

            connection.Open();
            command.CommandText = sqlKomut;
            table.Clear();
           
            adapter.Fill(table);
           
            view.DataSource = table;
           
            connection.Close();

        }

        public bool KayitEkle(string sqlKomut)
        {

            connection.Open();
            try
            {
                command.CommandText = sqlKomut;
                command.ExecuteNonQuery();

            }
            catch (OleDbException ex)
            {
                
                return false;
                
            }
            finally
            {
                connection.Close();
            }


            return true;

        }


        public void ComboBoxDoldur(string sqlKomut,string kolon,ComboBox combo)
        {

            connection.Open();
            command.CommandText = sqlKomut;

            reader = command.ExecuteReader();
            combo.Items.Clear();
            while (reader.Read())
            {
                combo.Items.Add(reader[kolon]);
            }
            
            reader.Close();
            connection.Close();

        }

        public void KayitSil(string sqlKomut) {

            connection.Open();
         command.CommandText = sqlKomut;
         command.ExecuteNonQuery();
            connection.Close();

           
        }

       public void ListViewDoldur(string sqlKomut,string colon,ListView list)
        {
            connection.Open();
            command.CommandText = sqlKomut;
            reader = command.ExecuteReader();
            list.Items.Clear();
            while (reader.Read())
            {

                list.Items.Add(reader[colon].ToString());

            }

            reader.Close();
            connection.Close();
        }

        public string DegerOku(string sqlKomut,string kolon)
        {
            connection.Open();
            command.CommandText = sqlKomut;
            reader = command.ExecuteReader();
            reader.Read();

            string deger = reader[kolon].ToString();
            reader.Close();
            connection.Close();
            return deger;


        }


        public bool GirisYap(string sqlKomut)
        {
            connection.Open();
            command.CommandText = sqlKomut;

            reader = command.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                connection.Close();
                return true;

            }
            reader.Close();
            connection.Close();
            return false;

        }


        public void KayitGüncelle(string sqlKomutu)
        {

            connection.Open();
            command.CommandText = sqlKomutu;
            reader = command.ExecuteReader();
            reader.Close();
            connection.Close();


        }

    }
}
