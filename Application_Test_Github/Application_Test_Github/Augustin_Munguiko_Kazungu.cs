using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//j'importer cet espqce de nom
using System.Data;//j'importer cet espqce de nom

namespace Application_Test_Github
{
    class Augustin_Munguiko_Kazungu
    {
        private SqlConnection con = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        //je cree la methode connecter
        public void connecter(string requetSql)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = requetSql;
                con.Open();
            }
        }
        private void deconnecter()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
