using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_C_.Exercise_Day4;

namespace C_LearningGit.Assignment_5
{
    internal class ReadAndStore
    {
        public void ReadAndStoreAssign() 
        {
            string sheetName = "Employee";
            var data = new ReadExcel().ReadExcelData($"Select  TOP 5 * from [{sheetName}$]");
            string source = "Data Source=localhost\\SQLEXPRESS02;Database=master;" + "Integrated Security=True;" + "TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(source))
            {
                conn.Open();
                var sql = "INSERT INTO EMPLOYEE (";
                var valueSQL = " VALUES(";
                int i = 1;
                foreach(var row in data.Columns)
                {
                    if (i != 1)
                        sql = sql + ",";
                    sql = sql + row.ToString();
                    if (i != 1)
                        valueSQL = valueSQL + ",";
                    valueSQL +=  $" @Value{i} ";
                    i= i + 1;
                }
                sql = sql + " ) ";
                valueSQL = valueSQL + " ) ";
                sql = sql + valueSQL;
                SqlCommand command = new SqlCommand(sql, conn);
                i = 1;
                foreach (var row in data.Columns)
                {
                    command.Parameters.AddWithValue($"@Value{i}", "");
                    i++;

                }
             
                // Iterate through the rows in the DataTable and add each row to the SqlCommand object
                foreach (DataRow row in data.Rows) 
                { 
                    command.Parameters["@Value1"].Value = row["EmpId"]; 
                    command.Parameters["@Value2"].Value = row["FirstName"]; 
                    command.Parameters["@Value3"].Value = row["LastName"];
                    command.Parameters["@Value4"].Value = row["Email"];
                    command.Parameters["@Value5"].Value = row["PhoneNo"];
                    command.Parameters["@Value6"].Value = row["Salary"];
                    command.ExecuteNonQuery(); 
                }
                conn.Close();

            }

        }
    }
}
