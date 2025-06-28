using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;


namespace DataAccess.DataAccessLayer
{
    public class SQLHelper
    {
        private readonly string _connectionString;

        public SQLHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string ExecuteNonQueryAsync(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    return "Hello";
                }
            }
        }

        public string ExecuteQuerySP(string query, SqlParameter[] para)
        {
            string msg = string.Empty;
            DataSet ds = new DataSet();
            SqlDataReader dr = null;
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                SqlCommand cmd = new SqlCommand(query, con);
                if (query.StartsWith("insert") || query.StartsWith("INSERT"))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                }
                else
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                }
                for (int i = 0; i < para.Length; i++)
                {
                    cmd.Parameters.Add(para[i]);
                }
                con.Open();

                cmd.ExecuteNonQuery();
                msg = cmd.Parameters["@P_OUT"].Value.ToString();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }

            return msg;
        }

        public string ExecuteNonQuerySP(string query, SqlParameter[] para)
        {
            string msg = string.Empty;
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                SqlCommand cmd = new SqlCommand(query, con);


                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                for (int i = 0; i < para.Length; i++)
                {
                    cmd.Parameters.Add(para[i]);
                }
                con.Open();
                msg = (cmd.ExecuteNonQuery()).ToString();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

    }
}
