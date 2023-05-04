using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prescription.BL
{
    internal class CLS_UESRS
    {   //instance from dal
        DAL.DAL DAL = new DAL.DAL();
        // load data
        public DataTable loadLogin(string USER_NAME,string USER_PASSWORD)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("USER_NAME", USER_NAME);
            pr[1] = new SqlParameter("USER_PASSWORD", USER_PASSWORD);
            return DAL.read("SP_LOGIN", pr);
        }

        public void Edit_state(int USER_ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("USER_ID", USER_ID);

            DAL.conopen();
            DAL.Excute("SP_UPDATELOGIN", pr);
            DAL.conclose();
        }

        public void logout()
        {
            SqlParameter[] pr = null;


            DAL.conopen();
            DAL.Excute("SP_LOGOUT", pr);
            DAL.conclose();
        }


        public DataTable load_start()
        {
            SqlParameter[] pr = null;
            return DAL.read("SP_START", pr);
        }

    }
}
