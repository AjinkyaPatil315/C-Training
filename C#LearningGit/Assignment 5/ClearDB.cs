using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LearningGit.Assignment_5
{
    internal class ClearDB
    {
        public void ClearDBData() 
        {


            string source = "Data Source=localhost\\SQLEXPRESS02;Database=master;" + "Integrated Security=True;" + "TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(source))
            {
                conn.Open();
                var command = new SqlCommand("DELETE FROM EMPLOYEE", conn);
                command.ExecuteNonQuery();
                var command1 = new SqlCommand("DROP TABLE EMPLOYEE", conn);
                command1.ExecuteNonQuery();
                conn.Close();
            }


        }
    }
}
