using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public class SQLHelper
    {
        /*public SQLHelper()
        {
            try
            {
                GetConnection().Open();
                GetConnection().Close();
            }
            catch
            {
                throw new Exception("SQL Sunucusuna Bağlanılamadı!");
            }
        }*/

        private SqlConnection GetConnection()
        {
            return new SqlConnection(DataConnections.Get_MsSQLConnectionString);
        }

        private SqlCommand GetCommand()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = GetConnection();

            return cmd;
        }

        public int ExecuteNonQuery(string commandText, CommandType type, SqlParameter[] parameters)
        {
            SqlCommand cmd = GetCommand();
            cmd.CommandText = commandText;
            cmd.CommandType = type;

            if(parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            GetConnection().Open();
            int rows = cmd.ExecuteNonQuery();
            GetConnection().Close();

            return rows;
        }

        public int ExecuteNonQuery(string commandText)
        {
            SqlCommand cmd = GetCommand();
            cmd.CommandText = commandText;
            
            GetConnection().Open();
            int rows = cmd.ExecuteNonQuery();
            GetConnection().Close();

            return rows;
        }

        public object ExecuteScalar(string commandText, CommandType type, SqlParameter[] parameters)
        {
            SqlCommand cmd = GetCommand();
            cmd.CommandText = commandText;
            cmd.CommandType = type;

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            GetConnection().Open();
            object result = cmd.ExecuteScalar();
            GetConnection().Close();

            return result;
        }

        public object ExecuteScalar(string commandText)
        {
            SqlCommand cmd = GetCommand();
            cmd.CommandText = commandText;

            GetConnection().Open();
            object result = cmd.ExecuteScalar();
            GetConnection().Close();

            return result;
        }

        public SqlDataReader ExecuteReader(string commandText, CommandType type, SqlParameter[] parameters)
        {
            SqlCommand cmd = GetCommand();
            cmd.CommandText = commandText;
            cmd.CommandType = type;

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            GetConnection().Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GetConnection().Close();

            return reader;
        }

        public SqlDataReader ExecuteReader(string commandText)
        {
            SqlCommand cmd = GetCommand();
            cmd.CommandText = commandText;

            GetConnection().Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GetConnection().Close();

            return reader;
        }

        public DataTable GetDataTable(string commandText, CommandType type, SqlParameter[] parameters)
        {
            SqlCommand cmd = GetCommand();
            cmd.CommandText = commandText;
            cmd.CommandText = commandText;
            cmd.CommandType = type;

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            GetConnection().Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GetConnection().Close();

            DataTable returnTable = new DataTable();
            returnTable.Load(reader);

            return returnTable;
        }

        public DataTable GetDataTable(string commandText)
        {
            SqlCommand cmd = GetCommand();
            cmd.CommandText = commandText;

            GetConnection().Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GetConnection().Close();

            DataTable returnTable = new DataTable();
            returnTable.Load(reader);

            return returnTable;
        }

    }
}
