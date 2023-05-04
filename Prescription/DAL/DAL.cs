using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Prescription.DAL
{
    
    internal class DAL
    {
        SqlConnection con;
        public DAL()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBPRSCRIPTION.mdf;Integrated Security=True");
        }
        // open con
        public void conopen()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }


        // close con
        public void conclose()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        // fun load to data
        public DataTable read(string store, SqlParameter[] parm)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = store;
            if(parm != null)
            {
                cmd.Parameters.AddRange(parm);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        // void for insert , delete , update
        public void Excute(string store, SqlParameter[] parm)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = store;
            if (parm != null)
            {
                cmd.Parameters.AddRange(parm);
            }
           cmd.ExecuteNonQuery();
        }

    }
}
