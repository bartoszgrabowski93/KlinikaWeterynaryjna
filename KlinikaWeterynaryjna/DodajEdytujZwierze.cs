using KlinikaWeterynaryjna.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikaWeterynaryjna
{
    public partial class DodajEdytujZwierze : Form
    {
        public DodajEdytujZwierze(Zwierze zwierzeDoEdycji = null)
        {
            InitializeComponent();
            ZaladujGatunek();


        }

        private void ZaladujGatunek()
        {
            using var con = new SqlConnection(Constants.ConnectionString);
            var com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "SELECT DISTINCT Gatunek FROM ZWIERZE";

            con.Open();
            SqlDataReader dr = com.ExecuteReader();

            var listaGatunkow = new List<Zwierze>();
            while (dr.Read() == true)
            {
                string gatunek = dr["Gatunek"].ToString();
                var gatunekZwierzecia = new Zwierze();
                gatunekZwierzecia.Gatunek = gatunek;
                listaGatunkow.Add(gatunekZwierzecia);
            }
            gatunekListBox.DataSource = listaGatunkow;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void anulujButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void zaakceptujButton_Click(object sender, EventArgs e)
        {
            if (nazwaTextBox.Text == "")
            {
                MessageBox.Show("Podano nieprawidłowe dane");
                return;
            }

            using var con = new SqlConnection(Constants.ConnectionString);
            var com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "Insert into Zwierze(Nazwa,Gatunek,DataOstWizyty,IdWlasciciela) VALUES (@Nazwa, @Gatunek, @DataOstWizyty, @IdWlasciciela";

            
            int idWlasciciela = Int32.Parse(wlascicielTextBox.Text);
            var dateTime = DateTime.Parse(dataOstWizytyTextBox.Text);

            com.Parameters.AddWithValue("@Nazwa", nazwaTextBox.Text);
            com.Parameters.AddWithValue("@Gatunek", gatunekListBox.Text);
            com.Parameters.AddWithValue("@DataOstWizyty", dateTime);
            com.Parameters.AddWithValue("@IdWlasciciela", idWlasciciela);

            con.Open();
            com.ExecuteNonQuery();
            Close();

        }

    }
}
