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
    public static class SQLHelper
    {
        private static SqlConnection GetConnection()
        {
            return new SqlConnection(DataConnections.Get_MsSQLConnectionString);
        }

        private static SqlCommand GetCommand()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = GetConnection();

            return cmd;
        }

        public static int ExecuteNonQuery(string commandText, CommandType type, SqlParameter[] parameters)
        {
            SqlCommand cmd = GetCommand();
            cmd.CommandText = commandText;
            cmd.CommandType = type;

            if(parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            return rows;
        }

        public static int ExecuteNonQuery(string commandText, SqlParameter[] parameters)
        {
            SqlCommand cmd = GetCommand();
            cmd.CommandText = commandText;

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            return rows;
        }

        public static int ExecuteNonQuery(string commandText)
        {
            SqlCommand cmd = GetCommand();
            cmd.CommandText = commandText;

            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            return rows;
        }

        public static object ExecuteScalar(string commandText, CommandType type, SqlParameter[] parameters)
        {
            SqlCommand cmd = GetCommand();
            cmd.CommandText = commandText;
            cmd.CommandType = type;

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            cmd.Connection.Open();
            object result = cmd.ExecuteScalar();
            cmd.Connection.Close();

            return result;
        }

        public static object ExecuteScalar(string commandText, SqlParameter[] parameters)
        {
            SqlCommand cmd = GetCommand();
            cmd.CommandText = commandText;

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            cmd.Connection.Open();
            object result = cmd.ExecuteScalar();
            cmd.Connection.Close();

            return result;
        }

        public static object ExecuteScalar(string commandText)
        {
            SqlCommand cmd = GetCommand();
            cmd.CommandText = commandText;

            cmd.Connection.Open();
            object result = cmd.ExecuteScalar();
            cmd.Connection.Close();

            return result;
        }

        public static SqlDataReader ExecuteReader(string commandText, CommandType type, SqlParameter[] parameters)
        {
            SqlCommand cmd = GetCommand();
            cmd.CommandText = commandText;
            cmd.CommandType = type;

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            cmd.Connection.Close();

            return reader;
        }

        public static SqlDataReader ExecuteReader(string commandText, SqlParameter[] parameters)
        {
            SqlCommand cmd = GetCommand();
            cmd.CommandText = commandText;

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            cmd.Connection.Close();

            return reader;
        }

        public static SqlDataReader ExecuteReader(string commandText)
        {
            SqlCommand cmd = GetCommand();
            cmd.CommandText = commandText;

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            cmd.Connection.Open();
            return reader;
        }

        public static DataTable GetDataTable(string commandText, CommandType type, SqlParameter[] parameters)
        {
            SqlCommand cmd = GetCommand();
            cmd.CommandText = commandText;
            cmd.CommandText = commandText;
            cmd.CommandType = type;

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            cmd.Connection.Close();

            DataTable returnTable = new DataTable();
            returnTable.Load(reader);

            return returnTable;
        }

        public static DataTable GetDataTable(string commandText, SqlParameter[] parameters)
        {
            SqlCommand cmd = GetCommand();
            cmd.CommandText = commandText;

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            cmd.Connection.Close();

            DataTable returnTable = new DataTable();
            returnTable.Load(reader);

            return returnTable;
        }

        public static DataTable GetDataTable(string commandText)
        {
            SqlCommand cmd = GetCommand();
            cmd.CommandText = commandText;

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable returnTable = new DataTable();
            returnTable.Load(reader);
            reader.Close();

            cmd.Connection.Close();
            return returnTable;
        }
    }
}
