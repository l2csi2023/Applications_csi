using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Application_Test_Github
{
    class Salomon_Tchimanga_osee
    {
        public SqlCommand cmd = new SqlCommand();
        public SqlConnection conx = new SqlConnection();
        public DataSet dts = new DataSet();
        public DataTable dttb = new DataTable();
        public int numLigne = 0;
        public int nombreInfo;
        public SqlDataAdapter dta = new SqlDataAdapter();
        // charge la table et la source de données

        public void ChargementTable(string nomTable)
        {
            dts.Clear();
            cmd.CommandText = "select * from " + nomTable;
            cmd.Connection = conx;
            SqlDataAdapter dta = new SqlDataAdapter(cmd.CommandText, conx);
            //SqlDataAdapter dta = new SqlDataAdapter(cmd.CommandText, conx);

            conx.Open();
            cmd.ExecuteNonQuery();
            dta.Fill(dts, nomTable);
            conx.Close();
            dttb = dts.Tables[nomTable];
            nombreInfo = dttb.Rows.Count;// compte le nombre de ligne de la table ou source de données 
        }
    }
}
