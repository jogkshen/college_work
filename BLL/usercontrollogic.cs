using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
   public class usercontrollogic
    {
        public DataTable getdatafromuser(string username, string password)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@username",username),
                new SqlParameter("@password",password)
            };
            return connect.getuser("select * from tbl_user where username=@username and password=@password", par);
        }

        //method to search bugs

        public DataTable SearchBug(string bugname) {

            SqlParameter[] parameter = new SqlParameter[] {

                new SqlParameter ("@bugname",bugname)
            };return connect.getuser("select * from tbl_bug where Class=@bugname",parameter);
        }



        public int inputdatauser(string username, string password, string usertype)
        {
            SqlParameter[] par = new SqlParameter[]
            {
              
                new SqlParameter("@username",username),
                 new SqlParameter("@password",password),
                   new SqlParameter("@usertype",usertype),
                 
            };
            return connect.IDU("insert into tbl_user values (@username,@password,@usertype)", par);

        }

        public int inputdataresult(string Class, string term, string name, string roll, string english, string PRenglish , string nepali, string math, string science, string PRscience, string social, string PRsocial, string optenglish, string occupation, string PRoccupation, string moral, string PRmoral, string computer, string PRcomputer, string health, string PRhealth, string OptMathOrEco, string account, string PRaccount)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@Class",Class),
                 new SqlParameter("@term",term),
                  new SqlParameter("@name",name),
                   new SqlParameter("@roll",roll),
                    new SqlParameter("@english",english),
                     new SqlParameter("@PRenglish",PRenglish),
                      new SqlParameter("@nepali",nepali),
                       new SqlParameter("@math",math),
                        new SqlParameter("@science",science),
                 new SqlParameter("@PRscience",PRscience),
                  new SqlParameter("@social",social),
                   new SqlParameter("@optenglish",optenglish),
                    new SqlParameter("@occupation",occupation),
                     new SqlParameter("@PRoccupation",PRoccupation),
                      new SqlParameter("@moral",moral),
                       new SqlParameter("@PRmoral",PRmoral),
                        new SqlParameter("@computer",computer),
                 new SqlParameter("@PRcomputer",PRcomputer),
                  new SqlParameter("@health",health),
                   new SqlParameter("@PRhealth",PRhealth),
                    new SqlParameter("@OptMathOrEco",OptMathOrEco),
                     new SqlParameter("@account",account),
                      new SqlParameter("@PRaccount",PRaccount)


            };
            return connect.IDU("insert into Table values (@Class,@term,@name,@roll,@english,@PRenglish,@nepali,@math,@science,@PRscience,@social,@PRsocial,@Optenglish,@occupation,@PRoccupation,@moral,@Prmoral,@computer,@PRcomputer,@health,@PRhealth,@OptMathOrEco,@acount,@PRaccount)", par);

        }

        public int inputtest(string input, string expected_output, string output, string bug_id, string date, string nepali)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@input",input),
                 new SqlParameter("@expected_output",expected_output),
                  new SqlParameter("@output",output),
                   new SqlParameter("@bug_id",bug_id),
                    new SqlParameter("@date",date),
                     new SqlParameter("@nepali",nepali),
                 


            };
            return connect.IDU("insert into tbl_test values (@input,@expected_output,@output,@bug_id,@ate,@status,@code)", par);

        }

        //g
        public int getupdate(String id, string status) {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@id",id),
                new SqlParameter("@status",status)
            };
            return connect.IDU("update tbl_bug set status=@status where bug_id=@id", para);
        }

        public int updateuser(String username, string password, string usertype, int user_id)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@username",username),
                new SqlParameter("@password",password),
                new SqlParameter("@usertype",usertype),
               
                new SqlParameter("@user_id",user_id)

            };
            return connect.IDU("update tbl_user set username=@username, password=@password, usertype=@usertype where user_id=@user_id", para);
        }

        public int deleteuser(int user_id)
        {
            SqlParameter[] par = new SqlParameter[]
            {

               new SqlParameter("@user_id",user_id)

            };
            int i = 0;
            i = connect.IDU("delete from tbl_user where user_id=@user_id", par);
            return i;
        }



        public DataTable getuser()
        {
            DataTable dt = new DataTable();
            dt = connect.getuser("select * from tbl_user", null);
            return dt;
        }

        public DataTable getdata()
        {
            DataTable dt = new DataTable();
            dt = connect.getuser("select * from tbl_bug", null);
            return dt;
        }
    }
}
