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

            if (zwierzeDoEdycji != null)
            {
                label1.Text = "Edytuj zwierze:";
                nazwaTextBox.Text = zwierzeDoEdycji.Nazwa.ToString();
                gatunekListBox.Text = zwierzeDoEdycji.Gatunek.ToString();
                dataOstWizytyTextBox.Text = zwierzeDoEdycji.DataOstatniejWizyty.ToString();
                wlascicielTextBox.Text = zwierzeDoEdycji.IdWlasciciel.ToString();
            }


        }

        private void ZaladujGatunek()
        {
            using var con = new SqlConnection(Constants.ConnectionString);
            var com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "SELECT DISTINCT Gatunek FROM Zwierzeta";

            con.Open();
            SqlDataReader dr = com.ExecuteReader();

            var listaGatunkow = new List<String>();
            while (dr.Read() == true)
            {
                string gatunek = dr["Gatunek"].ToString();
                listaGatunkow.Add(gatunek);
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
            com.CommandText = "Insert into Zwierzeta(Nazwa,Gatunek,DataOstWizyty,IdWlasciciel) VALUES (@Nazwa, @Gatunek, @DataOstWizyty, @IdWlasciciel)";


            //string idWlascicielaString = Convert.ToInt32(wlascicielTextBox.Text);
            string idWlascicielaString = wlascicielTextBox.Text;
            

            if (int.TryParse(idWlascicielaString, out int idWlasciciela))
            {

            }
            else
            {
                MessageBox.Show("Podano nieprawidłowy numer id właściciela.");
                return;
            }

            string inputDateString = dataOstWizytyTextBox.Text;
            DateTime dDate;
            
            if (DateTime.TryParse(inputDateString, out dDate))
            {
                String.Format("{0:d/MM/yyyy}", dDate);
            }
            else
            {
                MessageBox.Show("Podano nieprawidłowy format daty. Proszę podać datę: DD.MM.YYYY");
                return;
            }


            com.Parameters.AddWithValue("@Nazwa", nazwaTextBox.Text);
            com.Parameters.AddWithValue("@Gatunek", gatunekListBox.Text);
            com.Parameters.AddWithValue("@DataOstWizyty", dDate);
            com.Parameters.AddWithValue("@IdWlasciciel", idWlasciciela);

            con.Open();
            com.ExecuteNonQuery();
            Close();
            

        }

    }
}
