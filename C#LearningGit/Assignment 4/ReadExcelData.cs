

using System.Data;
using System.Data.OleDb;
using System.Security.Policy;

namespace Training_C_.Exercise_Day4
{


    public class ReadExcel
    {
        public void ReadExcelData()
        {
            using (OleDbConnection conn = new OleDbConnection())
            {
                DataTable dt = new DataTable();
                string Import_FileName = @"C:\Users\Ajinkya.Patil\source\TestWorkBook.xlsx";
                string sheetName = "Employee";
                string fileExtension = Path.GetExtension(Import_FileName);
                if (fileExtension == ".xls")
                    conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
                if (fileExtension == ".xlsx")
                    conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                using (OleDbCommand comm = new OleDbCommand())
                {
                    comm.CommandText = "Select * from [" + sheetName + "$]";

                    comm.Connection = conn;

                    using (OleDbDataAdapter da = new OleDbDataAdapter())
                    {
                        da.SelectCommand = comm;
                        da.Fill(dt);
                        Console.WriteLine("EmpId, \t\t FirstName, \t\t LastName, \t\t Email, \t\t PhoneNo, \t\t Salary");
                        foreach (DataRow row in dt.Rows)
                        {
                            Console.WriteLine($"{row["EmpId"]}, \t\t {row["FirstName"]}, \t\t {row["LastName"]}, \t\t {row["Email"]}, \t\t {row["PhoneNo"]}, \t\t {row["Salary"]}");
                        }
                    }

                }
            }

        }
        public DataTable ReadExcelData(string sqlQuery)
        {
            using (OleDbConnection conn = new OleDbConnection())
            {
                DataTable dt = new DataTable();
                string Import_FileName = @"C:\Users\Ajinkya.Patil\source\TestWorkBook.xlsx";
                string sheetName = "Employee";
                string fileExtension = Path.GetExtension(Import_FileName);
                if (fileExtension == ".xls")
                    conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
                if (fileExtension == ".xlsx")
                    conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                using (OleDbCommand comm = new OleDbCommand())
                {
                    comm.CommandText = sqlQuery;

                    comm.Connection = conn;

                    using (OleDbDataAdapter da = new OleDbDataAdapter())
                    {
                        da.SelectCommand = comm;
                        da.Fill(dt);
                        return dt;
                    }

                }
            }

        }

    }

}

