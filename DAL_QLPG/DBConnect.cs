using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL_QLPG
{
    public class DBConnect
    {
        //Tao chuoi ket noi co so du lieu
        private string conStr = "Data Source=NHUNGVO;Initial Catalog=QlGym;Integrated Security=True";  
        public SqlConnection conn; 

        //Phuong thuc khoi tao
        public DBConnect()
        {
            conn = new SqlConnection(conStr);
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(conStr);
        }


        //Lay du lieu ve, Phuong thuc su dung voi cau lenh Select
        public DataTable GetDataTable(string strSql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
            conn.Open();
            da.Fill(dt); //do du lieu len
            conn.Close();
            return dt;
        }

        //Overloading: Lay du lieu su dung stored procedure
        public DataTable GetDataTable(string procName, SqlParameter[] para)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            if (para != null)
                cmd.Parameters.AddRange(para);
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        //Phuong thuc thuc thi cac cau lenh Update, Insert, Delete
        public int ExecuteSQL(string strSql)
        {
            SqlCommand cmd = new SqlCommand(strSql, conn);
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            return row;
        }

        //Overloading: 
        public int ExecuteSQL(string procName, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            if (para != null)
                cmd.Parameters.AddRange(para);
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            return row;
        }
    }
}
