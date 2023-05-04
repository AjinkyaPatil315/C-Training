using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_C_.Exercise_Day4;

namespace C_LearningGit.Assignment_5
{
    internal class PrintRelEmpDet
    {
        public void PrintRelEmpDetAssign()
        {
            Dictionary<string, Dictionary<string, string>> employeeData = new Dictionary<string, Dictionary<string, string>>();
            using (OleDbConnection conn = new OleDbConnection())
            {
                string sheetName = "Employee";
                var dataTable = new ReadExcel().ReadExcelData("Select * from [" + sheetName + "$]");
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

                    employeeData[key] = rowData;
                }
            }
            var input = Console.ReadLine();
            if (Int32.TryParse(input, out var empId))
            {
                if (employeeData.ContainsKey(empId.ToString()))
                {
                    var data = employeeData[empId.ToString()];
                    foreach (var i in data)
                    Console.WriteLine($"ColumnName {i.Key} value {i.Value}");
                    return;

                }
            }
            foreach(var data in employeeData.Values )
            {
                if (data.ContainsKey("FirstName"))
                {
                    if (data["FirstName"]== input)
                    {
                        foreach (var i in data)
                            Console.WriteLine($"ColumnName {i.Key} value {i.Value}");
                        return;
                    }
                }
            }
            Console.WriteLine("Data Not Found");

        }
    }
}
