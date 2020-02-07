using System.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Autokauppa.view
{
    public class DatabaseHallinta
    {
        string yhteysTiedot;
        SqlConnection dbYhteys = new SqlConnection();
        public DatabaseHallinta()
        {
           yhteysTiedot = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Autokauppa;User ID=LAPTOP-Q131GA2D\ruots;Trusted_Connection=yes;");
        }

        public bool connectDatabase()
        {
            dbYhteys.ConnectionString = yhteysTiedot;
            
            try
            { 
                dbYhteys.Open();
                return true;
            }
            catch(Exception e)
            { 
                Console.WriteLine("Virheilmoitukset:" + e);
                dbYhteys.Close();
                return false;

            }
            
        }

        public void disconnectDatabase()
        {
            dbYhteys.Close();
        }

        public bool saveAutoIntoDatabase(Auto newAuto)
        {
            bool palaute = false;
            return palaute;

            
        }

        public  List<string> getAllAutoMakersFromDatabase()
        {
            List<string> palaute = null;
            return palaute;

        }

        public  List<int> getAutoModelsByMakerId(int makerId) 
             
        {
            List<int> palaute = null;
            return palaute;
        }
    }
}