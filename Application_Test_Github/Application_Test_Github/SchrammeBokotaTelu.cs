using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Application_Test_Github
{
     public class SchrammeBokotaTelu
     {
         public SqlConnection cont = new SqlConnection();
         public SqlCommand cmd = new SqlCommand();
         public SqlDataReader dr;
         public DataTable dt = new DataTable();
         public DataSet ds = new DataSet();
         //public SqlCommandBuilder bc;
         public void connecter()
         {
             if (cont.State == ConnectionState.Closed || cont.State == ConnectionState.Broken)
             {
                 cont.ConnectionString = " ";
                 cont.Open();
             }
         }
         //declaration de la methode deconnecter
         public void deconnecter()
         {
             cont.Close();
         }
     }

}
