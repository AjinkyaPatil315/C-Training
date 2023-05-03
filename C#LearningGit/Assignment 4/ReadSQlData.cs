using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace C_LearningGit.Assignment_4
{
    internal class ReadSQlData
    {
        public void ReadSQlDataAssign()
        {
            string source = "Data Source=localhost\\SQLEXPRESS02;Database=master;" + "Integrated Security=True;" + "TrustServerCertificate=True;";
            string select = "SELECT TOP 1 * FROM Employee";
            using (SqlConnection conn = new SqlConnection(source))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(select, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    for (i = 0; i < reader.FieldCount; i++)
                    {
                        var columnName = reader.GetName(i);
                        var value = reader[i];
                        Console.WriteLine("ColumnName: {0} : Value: {1}",
                        columnName, value);
                    }
                }
                //close data reader
                reader.Close();

                //close connection
                conn.Close();
            }
        }

        public string ReadSQlDataAssign(string columnname, string query)
        {
            string source = "Data Source=localhost\\SQLEXPRESS02;Database=master;" + "Integrated Security=True;" + "TrustServerCertificate=True;";
            string select = query;
            using (SqlConnection conn = new SqlConnection(source))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(select, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    for (i = 0; i < reader.FieldCount; i++)
                    {
                        var columnName = reader.GetName(i);
                        if (columnName == columnname)
                            return reader[i].ToString();
                    }
                }
                //close data reader
                reader.Close();

                //close connection
                conn.Close();
                return string.Empty;
            }
        }
    }
}
