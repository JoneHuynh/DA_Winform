using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Thư viện Connect dữ liệu
using System.Data.SqlClient;
using System.Data;

namespace _21_4_qlbandienthoai
{
    internal class qlbandienthoai
    {
        SqlConnection con = new SqlConnection();
        void ketNoi()
        {
            con.ConnectionString = @"Data source=DESKTOP-7ODDOG3\SQLEXPRESS;Initial Catalog=bandienthoai;integrated Security=true";
            if(con.State== ConnectionState.Closed)
            {
                con.Open();
            }
        }
        void dongKetNoi()
        {
            con.Close();
        }
        public qlbandienthoai()
        {
            ketNoi();
        }

        public DataSet SelectData(string sql)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            da.Fill(ds);//load dữ liệu
            return ds;
        }

        public int UpdateData(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            return cmd.ExecuteNonQuery();
        }

    }
}
