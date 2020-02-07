using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Auto.ServiceReference1;
using System.ServiceModel;
using System.ServiceModel.Description;


namespace Autokauppa.view
{
    public partial class MainMenu : Form
    {
       
        //KaupanLogiikka registerHandler;
        Service1Client obj = new Service1Client();

        public MainMenu()
        {
            //registerHandler = new KaupanLogiikka();
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Autokauppa;User ID=LAPTOP-Q131GA2D\ruots;Trusted_Connection=yes;");
            conn.Open();
            SqlCommand sc = new SqlCommand("select ID,Merkki from AutonMerkki", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dk = new DataTable();
            dk.Columns.Add("ID", typeof(int));
            dk.Columns.Add("Merkki", typeof(string));
            dk.Load(reader);

            Merkki.ValueMember = "ID";
            Merkki.DisplayMember = "Merkki";
            Merkki.DataSource = dk;

            SqlDataAdapter adapt;
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from auto", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
           

            conn.Close();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void testaaTietokantayhteyttäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KaupanLogiikka k = new KaupanLogiikka();

            if (k.TestDatabaseConnection())
            {
                MessageBox.Show("Yhdistetty");
            }
            else
            {
                MessageBox.Show("Ei Yhteyttä");
            }
        }
        private void Malli_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Autokauppa;User ID=LAPTOP-Q131GA2D\ruots;Trusted_Connection=yes;");
            con.Open();
            SqlCommand sc = new SqlCommand("select ID,AutonMerkkiID,Auton_mallin_nimi from AutonMallit WHERE AutonMerkkiID =" + Merkki.SelectedValue, con);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Auton_mallin_nimi", typeof(string));
            dt.Load(reader);

            Malli.ValueMember = "ID";
            Malli.DisplayMember = "Auton_mallin_nimi";
            Malli.DataSource = dt;
            con.Close();
        }

        private void Polttoaine_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Autokauppa;User ID=LAPTOP-Q131GA2D\ruots;Trusted_Connection=yes;");
            conn.Open();
            SqlCommand sc = new SqlCommand("select * from Polttoaine", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Polttoaineen_nimi", typeof(string));
            dt.Columns.Add("ID", typeof(int));
            dt.Load(reader);

            Polttoaine.ValueMember = "ID";
            Polttoaine.DisplayMember = "Polttoaineen_nimi";
            Polttoaine.DataSource = dt;

            conn.Close();
        }

        private void Väri_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Autokauppa;User ID=LAPTOP-Q131GA2D\ruots;Trusted_Connection=yes;");
            conn.Open();
            SqlCommand sc = new SqlCommand("select * from Varit", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Varin_nimi", typeof(string));
            dt.Columns.Add("ID", typeof(int));
            dt.Load(reader);

            Väri.ValueMember = "ID";
            Väri.DisplayMember = "Varin_nimi";
            Väri.DataSource = dt;

            conn.Close();
        }
        //Poisto
        private void button3_Click(object sender, EventArgs e)
        {
            Malli.ResetText();
            Merkki.ResetText();
            Polttoaine.ResetText();
            Väri.ResetText();
            Mittarilukema.ResetText();
            Tilavuus.ResetText();
            Hinta.ResetText();
        }
        string connectionString = GetConnectionString();
        static private string GetConnectionString()
        {
            return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = Autokauppa;User ID=LAPTOP-Q131GA2D\ruots;Trusted_Connection=yes;";
        } 
        //Tallennus
        private void button2_Click(object sender, EventArgs e)
        {
            int Mittari = Convert.ToInt32(Mittarilukema.Text);
            decimal Tila = Convert.ToDecimal(Tilavuus.Text);
            decimal Value = Convert.ToDecimal(Hinta.Text);
            int MerkkiId = Convert.ToInt32(Merkki.SelectedValue);
            int MalliId = Convert.ToInt32(Malli.SelectedValue);
            int VariId = Convert.ToInt32(Väri.SelectedValue);
            int PolttoId = Convert.ToInt32(Polttoaine.SelectedValue);
            DateTime Rekisteripmv = Convert.ToDateTime(dateTimePicker1.Text);

            Autodata objuserdetail = new Autodata();
            objuserdetail.Mittarilukema = Mittari;
            objuserdetail.Moottorin_tilavuus = Tila;
            objuserdetail.Hinta = Value;
            objuserdetail.AutonMerkkiID = MerkkiId;
            objuserdetail.AutonMalliID = MalliId;
            objuserdetail.VaritID = VariId;
            objuserdetail.Rekisteri_paivamaara = Rekisteripmv;
            objuserdetail.PolttoaineID = PolttoId;
            obj.InsertUserDetails(objuserdetail);
            MessageBox.Show("Nimi Lisätty!");

            //string querystring = "INSERT INTO auto (Mittarilukema,Moottorin_tilavuus,Hinta,AutonMerkkiID,Rekisteri_paivamaara) VALUES (@Mittarilukema, @Moottorin_tilavuus, @Hinta, @AutonMerkkiID, @Rekisteri_paivamaara)";
            /*string querystring = "INSERT INTO auto (Mittarilukema,Moottorin_tilavuus,Hinta,AutonMerkkiID,AutonMalliID,VaritID,PolttoaineID,Rekisteri_paivamaara) VALUES (@Mittarilukema, @Moottorin_tilavuus, @Hinta, @AutonMerkkiID, @AutonMalliID, @VaritID, @PolttoaineID, @Rekisteri_paivamaara)";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(querystring, sqlConnection))*/
            // SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Autokauppa;User ID=LAPTOP-Q131GA2D\ruots;Trusted_Connection=yes;");
            //SqlCommand cm = new SqlCommand("INSERT INTO auto (Mittarilukema,Moottorin_tilavuus,Hinta,AutonMerkkiID,AutonMalliID,VaritID,PolttoaineID,Rekisteri_paivamaara) VALUES (@Mittarilukema, @Moottorin_tilavuus, @Hinta, @AutonMerkkiID, @AutonMalliID, @VaritID, @PolttoaineID, @Rekisteri_paivamaara)", cnn);
            {
                // try
                //  {
                    //int MerkkiId = Convert.ToInt32(Merkki.SelectedValue);
                    //int MalliId = Convert.ToInt32(Malli.SelectedValue);
                    //int VariId = Convert.ToInt32(Väri.SelectedValue);
                    //int PolttoaineId = Convert.ToInt32(Polttoaine.SelectedValue);
                  /*  sqlCommand.Parameters.Add("@Mittarilukema", SqlDbType.Int).Value = int.Parse(Mittarilukema.Text);
                    sqlCommand.Parameters.Add("@Moottorin_tilavuus", SqlDbType.Decimal).Value = decimal.Parse(Tilavuus.Text);
                    sqlCommand.Parameters.Add("@Hinta", SqlDbType.Decimal).Value = decimal.Parse(Hinta.Text);
                    sqlCommand.Parameters.Add("@AutonMerkkiID", SqlDbType.Int).Value = MerkkiId;
                    sqlCommand.Parameters.Add("@AutonMalliID", SqlDbType.Int).Value = MalliId;
                    sqlCommand.Parameters.Add("@VaritID", SqlDbType.Int).Value = VariId;
                    sqlCommand.Parameters.Add("@PolttoaineID", SqlDbType.Int).Value = PolttoaineId;
                    sqlCommand.Parameters.Add("@Rekisteri_paivamaara", SqlDbType.DateTime).Value = dateTimePicker1.Text;

                    sqlCommand.CommandType = CommandType.Text;
                    sqlConnection.Open();
                    int i = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    if (i != 0)
                    {

                        MessageBox.Show("Nimi Lisätty!");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    */
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
        }

        private void Paivita_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Autokauppa;User ID=LAPTOP-Q131GA2D\ruots;Trusted_Connection=yes;");
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            SqlDataAdapter adapt;
            adapt = new SqlDataAdapter("select * from auto", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}