using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_C_.Exercise_Day4;

namespace C_LearningGit.Assignment_4
{
    internal class UpdateExcelData
    {
        public void UpdateExcelDataAssign()
        {
            using (OleDbConnection conn = new OleDbConnection())
            {
                string sheetName = "Employee";

                var oldValue = new ReadExcel().ReadExcelData("Select FirstName from [" + sheetName + "$] where EmpId=2");
                Console.WriteLine("---------------------------------------OldValue------------------------------");    
                foreach (DataRow row in oldValue.Rows)
                {
                    Console.WriteLine($"{row["FirstName"]}");
                }
                DataTable dt = new DataTable();
                string Import_FileName = @"C:\Users\Ajinkya.Patil\source\TestWorkBook.xlsx";
                string fileExtension = Path.GetExtension(Import_FileName);
                if (fileExtension == ".xls")
                    conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
                if (fileExtension == ".xlsx")
                    conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                using (OleDbCommand comm = new OleDbCommand())
                {
                    comm.CommandText = "UPDATE [" + sheetName + "$] set FirstName = 'Ajinkya' where EmpId = 2";

                    comm.Connection = conn;
                    conn.Open();
                    comm.ExecuteNonQuery();

                }
                var newValue = new ReadExcel().ReadExcelData("Select FirstName from [" + sheetName + "$] where EmpId=2");
                Console.WriteLine("---------------------------------------NewValue------------------------------");
                foreach (DataRow row in newValue.Rows)
                {
                    Console.WriteLine($"{row["FirstName"]}");
                }

            }

        }
    }
}
