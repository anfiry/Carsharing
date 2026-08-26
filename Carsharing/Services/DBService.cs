using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing.Services
{
    public class DBService : IDisposable
    {
        private readonly string _connectionString;
        private NpgsqlConnection _connection;

        public DBService()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public void Open()
        {
            if (_connection == null || _connection.State == ConnectionState.Closed)
            {
                _connection = new NpgsqlConnection(_connectionString);
                _connection.Open();
            }
        }

        public void Close()
        {
            _connection?.Close();
        }

        public ConnectionState GetState()
        {
            return _connection?.State ?? ConnectionState.Closed;
        }

        public DataTable ExecuteQuery(string sql, params NpgsqlParameter[] parameters)
        {
            Open();
            using (var cmd = new NpgsqlCommand(sql, _connection))
            {
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                var dt = new DataTable();
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                return dt;
            }
        }

        public int ExecuteNonQuery(string sql, params NpgsqlParameter[] parameters)
        {
            Open();
            using (var cmd = new NpgsqlCommand(sql, _connection))
            {
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteNonQuery();
            }
        }

        public object ExecuteScalar(string sql, params NpgsqlParameter[] parameters)
        {
            Open();
            using (var cmd = new NpgsqlCommand(sql, _connection))
            {
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteScalar();
            }
        }

        public object ExecuteFunction(string functionName, params NpgsqlParameter[] parameters)
        {
            Open();
            string paramPlaceholders = parameters != null && parameters.Length > 0
                ? string.Join(", ", parameters.Select(p => $"@{p.ParameterName}"))
                : "";

            using (var cmd = new NpgsqlCommand($"SELECT {functionName}({paramPlaceholders})", _connection))
            {
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteScalar();
            }
        }


        public void Dispose()
        {
            Close();
            _connection?.Dispose();
        }
    }
}
