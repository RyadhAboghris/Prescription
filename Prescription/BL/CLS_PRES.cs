using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Prescription.BL
{
    internal class CLS_PRES
    {
        //instance from dal
        DAL.DAL DAL = new DAL.DAL();

        // insert data treatments
        public void Insert_Pat_Info(string PAT_NAME, int PAT_AGE, string PAT_TYPE)
        {
            SqlParameter[] pr = new SqlParameter[3];
            pr[0] = new SqlParameter("PAT_NAME", PAT_NAME);
            pr[1] = new SqlParameter("PAT_AGE", PAT_AGE);
            pr[2] = new SqlParameter("PAT_TYPE", PAT_TYPE);
            DAL.conopen();
            DAL.Excute("SP_INSERTPATINFO", pr);
            DAL.conclose();
        }

        // load data
        public DataTable loadTreat()
        {
            SqlParameter[] pr = null;
            return DAL.read("SP_LOADPATFORTRAET", pr);
        }

          // insert data treatments
        public void Insert_Treat_Info(int PATTENTS_ID, string TREAT_NAME, string TREAT_ALL, string TREAT_DUR, string TREAT_TIME)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("PATTENTS_ID", PATTENTS_ID);
            pr[1] = new SqlParameter("TREAT_NAME", TREAT_NAME);
            pr[2] = new SqlParameter("TREAT_ALL", TREAT_ALL);
            pr[3] = new SqlParameter("TREAT_DUR", TREAT_DUR);
            pr[4] = new SqlParameter("TREAT_TIME", TREAT_TIME);
            DAL.conopen();
            DAL.Excute("SP_INSERTTREATFORPAT", pr);
            DAL.conclose();
        }
    }
}
