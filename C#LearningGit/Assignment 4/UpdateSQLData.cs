using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LearningGit.Assignment_4
{
    internal class UpdateSQLData
    {
        public void UpdateSQLData1() 
        {
            var salary = 105;
            var empId = 1;
            var read = new ReadSQlData();
            var oldvalue = read.ReadSQlDataAssign("Salary", "SELECT TOP 1 * FROM Employee Where EmpId = " + empId);
            string source = "Data Source=localhost\\SQLEXPRESS02;Database=master;" + "Integrated Security=True;" + "TrustServerCertificate=True;";
            string select = "UPDATE Employee SET Salary = " + salary + " Where EmpId = " + empId;
            using (SqlConnection conn = new SqlConnection(source))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(select, conn);
                int rowsCount = cmd.ExecuteNonQuery();
                Console.WriteLine("the no of rows updated is {0}", rowsCount);
                conn.Close();
            }
            var newvalue = read.ReadSQlDataAssign("Salary", "SELECT TOP 1 * FROM Employee Where EmpId = " + empId);
            Console.WriteLine($"Old Value {oldvalue}, New Value {newvalue}");
        }
    }
}
