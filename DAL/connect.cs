using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class connect
    {
        public static SqlConnection getconnection()
        {

            // string sqlcon = aps.GetValue("myConnection", typeof(System.String)).ToString();
            //string sqlcon = "Data Source=192.168.5.10,1433;Initial Catalog =POS2; User ID = subek; Password=subek1;"; //Capital Grill
            // string sqlcon = "Data Source=192.168.1.196,1433;Initial Catalog =POS2; User ID = Imperial; Password=Imperial1;"; //Imperial

            //string sqlcon = "Data Source=.;Initial Catalog=bugtracker;Integrated Security=True"; //ai la

             // string sqlcon = (@"Data Source =.\SQLEXPRESS; Initial Catalog = POS2; Integrated Security = True;");//sqlexpress
             // string sqlcon = (@"Data Source =LocalHost; Initial Catalog =bugtracker; Integrated Security = True;"); //localhost
                                                                // string sqlcon = (@"Data Source =TX-PC\FUNKEY; Initial Catalog = POS2; Integrated Security = True;");//funkey
              string sqlcon = (@"Data Source =DESKTOP-8FML2MF\SQLEXPRESS; Initial Catalog = bugtracker; Integrated Security = True;");//LocalsqlExpress

            SqlConnection scon = new SqlConnection(sqlcon);
            if (scon.State != ConnectionState.Open)
            {

                scon.Open();
                SqlCommand sqlcmd = new SqlCommand();

            }
            return scon;

        }
        
        public static int IDU(string sql, SqlParameter[] parm)
        {

            using (SqlConnection scon = getconnection())
            {
                SqlCommand scmd = new SqlCommand(sql, scon);
                scmd.CommandTimeout = 200;
                if (parm == null)
                {
                    scmd.Parameters.Add(new SqlParameter("@0", DBNull.Value));
                }
                else if (parm != null)
                {
                    scmd.Parameters.AddRange(parm);
                }
                try
                {

                    return scmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }
        public static int IUD_SP(string sql, CommandType cmdtype, SqlParameter[] param)
        {


            using (SqlConnection con = getconnection())
            {

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = cmdtype;
                cmd.CommandTimeout = 200;
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                try
                {

                    return cmd.ExecuteNonQuery();//insert delete update
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public static DataTable getuser(string sql, SqlParameter[] parm)
        {

            using (SqlConnection scon = getconnection())
            {
                SqlCommand scmd = new SqlCommand(sql, scon);
                scmd.CommandTimeout = 200;
                if (parm != null)
                {
                    scmd.Parameters.AddRange(parm);
                }

                SqlDataAdapter sda = new SqlDataAdapter(scmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;


            }

        }
    }
}

