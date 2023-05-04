using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_C_.Exercise_Day4;

namespace C_LearningGit.Assignment_5
{
    internal class CreateAndStore
    {
        public void CreateAndStoreExcelData()
        {
            using (OleDbConnection conn = new OleDbConnection())
            {
                string sheetName = "Employee";
                var dataTable =  new ReadExcel().ReadExcelData("Select * from [" + sheetName + "$]");
                Dictionary<string, Dictionary<string, string>> employeeData = new Dictionary<string, Dictionary<string, string>>();
                foreach (DataRow row in dataTable.Rows)
                {
                    Dictionary<string, string> rowData = new Dictionary<string, string>();
                    var key = string.Empty;
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        rowData[dataTable.Columns[i].ColumnName] = row[i].ToString();
                        if (dataTable.Columns[i].ColumnName == "EmpId")
                            key = row[i].ToString();
                    }

                    employeeData[key] = rowData; //Print the disctionary data
                }
            }

        }
    }
}