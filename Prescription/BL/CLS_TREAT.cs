using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Prescription.BL
{
    internal class CLS_TREAT
    {
        //instance from dal
        DAL.DAL DAL = new DAL.DAL();
        // load data
        public DataTable loadTreat()
        {
            SqlParameter[] pr = null;
            return DAL.read("SP_LOADTREAT", pr);
        }

        // insert data treatments
        public void Insert_Treat(string Treat_Name)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("TREAT_NAME",Treat_Name);
            DAL.conopen();
            DAL.Excute("SP_INSERTTREAT",pr);
            DAL.conclose();
        }

        // delete data treatments
        public void Delete_Treat(int TREAT_ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("TREAT_ID", TREAT_ID);
            DAL.conopen();
            DAL.Excute("SP_DELETETREAT", pr);
            DAL.conclose();
        }

        // update data treatments
        public void Update_Treat(int TREAT_ID,string TREAT_NAME)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("TREAT_ID", TREAT_ID);
            pr[1] = new SqlParameter("TREAT_NAME", TREAT_NAME);
            DAL.conopen();
            DAL.Excute("SP_UPDATETREAT", pr);
            DAL.conclose();
        }


        // search data
        public DataTable SearchTreat(string TREAT_NAME)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("TREAT_NAME", TREAT_NAME);
            return DAL.read("SP_SEARCHTREAT", pr);
        }


        // start method of patients
        // load data
        public DataTable loadPat()
        {
            SqlParameter[] pr = null;
            return DAL.read("SP_LOADPAT", pr);
        }// delete data treatments
        public void Delete_Pat(int PATIENTS_ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("PATIENTS_ID", PATIENTS_ID);
            DAL.conopen();
            DAL.Excute("SP_DELETEPAT", pr);
            DAL.conclose();
        }

        // search data
        public DataTable SearchPat(string PAT_SEARCH)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("PAT_SEARCH", PAT_SEARCH);
            return DAL.read("SP_SEARCHPAT", pr);
        }

        // load data threat for patients
        public DataTable loadTreatPat(int PATIENTS_ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("PATIENTS_ID", PATIENTS_ID);
            return DAL.read("SP_LOADPATTREAT", pr);
        }

        // start method of user
        // load data user
        public DataTable loadUsers()
        {
            SqlParameter[] pr = null;
            return DAL.read("SP_LOADUSER", pr);
        }


        // insert data USERS
        public void Insert_Users(string NAME, string USER_NAME, string PASSWORD, string USER_ROLL, string USER_STATE)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("NAME", NAME);
            pr[1] = new SqlParameter("USER_NAME", USER_NAME);
            pr[2] = new SqlParameter("PASSWORD", PASSWORD);
            pr[3] = new SqlParameter("USER_ROLL", USER_ROLL);
            pr[4] = new SqlParameter("USER_STATE", USER_STATE);
            DAL.conopen();
            DAL.Excute("SP_INSERTUSERS", pr);
            DAL.conclose();
        }


        // insert data update
        public void Edit_Users(int USER_ID,string NAME, string USER_NAME, string PASSWORD, string USER_ROLL)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("USER_ID", USER_ID);
            pr[1] = new SqlParameter("NAME", NAME);
            pr[2] = new SqlParameter("USER_NAME", USER_NAME);
            pr[3] = new SqlParameter("PASSWORD", PASSWORD);
            pr[4] = new SqlParameter("USER_ROLL", USER_ROLL);
            DAL.conopen();
            DAL.Excute("SP_UPDATEUSERS", pr);
            DAL.conclose();
        }
        // delete data USER
        public void Delete_User(int @USER_ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@USER_ID", @USER_ID);
            DAL.conopen();
            DAL.Excute("SP_DELETEUSER", pr);
            DAL.conclose();
        }
    }
}
