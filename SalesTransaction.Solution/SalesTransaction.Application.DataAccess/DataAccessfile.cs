using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.Json.Serialization;

namespace SalesTransaction.Application.DataAccess
{
    public class DataAccessfile
    {
        private SqlConnection connection;
        private string connectedString;

        public DataAccessfile(string connectionString)
        {
            connectedString = connectionString;
        }
        //Syntax Of Sql server Connection String
        //for windows auth,
        //@"Data Source = (MachineName)\(InstanceName); Initial Catalog=(DBName);User ID =(USERName); Password = (Password);"
        public SqlConnection GetConnection()
        {
            try
            {
                SetConnection();
                return connection;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public void SetConnection()
        {
            connection = new SqlConnection(connectedString);
            if (connection.State == ConnectionState.Closed )
            {
                connection.Open();
            }
            else
            {
                connection.Close();
                connection.Open();
            }
        }

        public dynamic GetJson(SqlDataReader reader)
        {
            var dataTable = new DataTable();
            dataTable.Load(reader);

            if (dataTable.Rows[0] != null && dataTable.Rows[0]["Json"].ToString() != "" )
            {
                return JsonConverter.DeserializeObject(dataTable.Rows[0]["Json"].ToString());

            }
            else
            {
                return null;
            }
         }
    }
 }
