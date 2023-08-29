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
    public partial class TabelaZDanymi : Form
    {
        private string zalogowany;

        public TabelaZDanymi(string text)
        {
            InitializeComponent();
            PobierzDaneZwierzat();
            loginLabel.Text = text;
        }
        public TabelaZDanymi()
        {
            InitializeComponent();
            loginLabel.Text = "Niezautoryzowane logowanie";
        }

        public void PobierzDaneZwierzat()
        {
            using SqlConnection con = new SqlConnection(Constants.ConnectionString);
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "Select * from Zwierze";

            con.Open();
            SqlDataReader dr = com.ExecuteReader();

            var zwierzeta = new List<Zwierze>();
            while (dr.Read() == true)
            {
                int idZwierze = (int)dr["IdZwierze"];
                string nazwa = dr["Nazwa"].ToString();
                string gatunek = dr["Gatunek"].ToString();
                string dataOstatniejWizyty = dr["DataOstWizyty"].ToString();
                int idWlasciciel = (int)dr["IdWlasciciel"];

                var z = new Zwierze();
                z.IdZwierze = idZwierze;
                z.Nazwa = nazwa;
                z.Gatunek = gatunek;
                z.DataOstatniejWizyty = dataOstatniejWizyty;
                z.IdWlasciciel = idWlasciciel;
                zwierzeta.Add(z);

            }
            dataGridView.DataSource = zwierzeta;

        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TabelaZDanymi_Load(object sender, EventArgs e)
        {

        }

        private void usunButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Proszę wybrać zwierzę do usunięcia");
                return;
            }

            Zwierze zwierzeWybrane = dataGridView.SelectedRows[0].DataBoundItem as Zwierze;

            using SqlConnection con = new SqlConnection(Constants.ConnectionString);
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "DELETE FROM ZWIERZE WHERE IdZwierze=@IdZwierze;";

            com.Parameters.AddWithValue("@IdZwierze", zwierzeWybrane.IdZwierze);
            con.Open();
            com.ExecuteNonQuery();
            MessageBox.Show("Zwierze nazwane " + zwierzeWybrane.Nazwa + " zostało usunięte ");
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            var dodajEdytujOkienko = new DodajEdytujZwierze();
            dodajEdytujOkienko.Show();
            PobierzDaneZwierzat();
        }

        private void edytujButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Proszę wybrać zwierzę do edycji");
                return;
            }
            Zwierze zwierzeWybrane = dataGridView.SelectedRows[0].DataBoundItem as Zwierze;

            var edytujOkienko = new DodajEdytujZwierze();
            edytujOkienko.Show();
        }
    }
}
