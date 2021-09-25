using ExcelDataReader;
using LinkedInTesting_Selenium.Operations;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInTesting_Selenium.Email
{
    public class ExcelOperationForEmail
    {
        public static DataTable ExcelDataTable(string Filename)
        {
            //Opening the existing file for reading
            FileStream stream = File.Open(Filename, FileMode.Open, FileAccess.Read);
            Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            DataSet resultSet = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });
            DataTableCollection table = resultSet.Tables;
            DataTable resultTable = table["Sheet1"];
            return resultTable;
        }
        //creating list
        static List<DataCollection> dataCol = new List<DataCollection>();
        //Accessing the datas from the file
        public  void PopulateInCollection(string filename)
        {
            //creating instance of datatable
            DataTable table = ExcelDataTable(filename);
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    DataCollection dtTable = new DataCollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };
                    //adding the values into the list
                    dataCol.Add(dtTable);
                }
            }
        }
        //method to read data from the file
        public  string ReadData(int rowNumber, string columnName)
        {
            try
            {
                string data = (from colData in dataCol where colData.colName == columnName && colData.rowNumber == rowNumber select colData.colValue).SingleOrDefault();
                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
