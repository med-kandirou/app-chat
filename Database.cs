using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace app_chat
{
     static class Database
    {
        public static MySqlConnection cnx = new MySqlConnection();
        public static MySqlCommand cmd = new MySqlCommand();
  
        public static MySqlDataReader rd;
        public static DataTable dt = new DataTable();

        public static MySqlDataAdapter da = new MySqlDataAdapter();
        

        public static void Connecter() 
        {
            //"server=sql4.freesqldatabase.com;uid=root;pwd=b2h6hRdesc;database=sql4455877"
            string nomserver = "sql4.freesqldatabase.com";
            string psw = "b2h6hRdesc";
            string db = "sql4455877";
            if (cnx.State == ConnectionState.Closed || cnx.State == ConnectionState.Broken)
            {
                cnx.ConnectionString = "server=sql4.freesqldatabase.com;uid=sql4455877;pwd=b2h6hRdesc;database=sql4455877";
                //"server="+nomserver+";uid="+db+";pwd="+psw+";database="+db+"";
                cnx.Open();
            }

        }
        public static void deconnecter()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }


    }
}
