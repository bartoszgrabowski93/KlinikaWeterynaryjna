using System.Data.SqlClient;

namespace KlinikaWeterynaryjna
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void zalogujButton_Click(object sender, EventArgs e)
        {

            if (loginTextBox.Text == "" || hasloTextBox.Text == "")
            {
                MessageBox.Show("Wprowadz login i haslo");
                return;
            }

            using SqlConnection con = new SqlConnection(Constants.ConnectionString);

            string sql = "Select * from Uzytkownicy where login=@login and haslo=@haslo";

            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = sql;
            com.Parameters.AddWithValue("@login", loginTextBox.Text);
            com.Parameters.AddWithValue("@haslo", hasloTextBox.Text);

            con.Open();

            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read() == true)
            {
                MessageBox.Show("Zalogowano");
                var glowneOkno = new TabelaZDanymi(loginTextBox.Text);
                glowneOkno.Show();
                var oknoLogowania = new LoginScreen();
                oknoLogowania.Close();

            }
            else
            {
                MessageBox.Show("Niepoprawny login i/lub haslo");

            }


        }

        private void anulujButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}