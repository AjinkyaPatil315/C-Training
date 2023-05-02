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
            string source = "Server=localhost\\SQLEXPRESS02;Database=master;Trusted_Connection=True;" + "integrated security=SSPI;";
            string select = "SELECT FirstName,Salary FROM Employee";
            using (SqlConnection conn = new SqlConnection(source))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(select, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("name: {0} : salary: {1}",
                    reader[0], reader[1]);
                }
                //close data reader
                reader.Close();

                //close connection
                conn.Close();
            }


        }
    }
}
