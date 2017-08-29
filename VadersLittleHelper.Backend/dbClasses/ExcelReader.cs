using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VadersLittleHelper.Backend.dbClasses
{
    class ExcelReader : IDataReader
    {
        private readonly DataSet _fileContents;

        public ExcelReader(string filePath)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string filename = Path.GetFullPath(Path.Combine(basePath, filePath));

            FileStream stream = File.Open(filename, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            _fileContents = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });

            excelReader.Close();
        }

        public IEnumerable<object[]> GetTableContent(string tableName)
        {

            DataTable tableContent = _fileContents.Tables[tableName];

            foreach (DataRow item in tableContent.Rows)
            {
                yield return item.ItemArray;
            }
        }

        public IEnumerable<object[]> GetTableContent(DataTable table)
        {
            foreach (DataRow item in table.Rows)
            {
                yield return item.ItemArray;
            }
        }

        public IEnumerable<DataTable> GetTables()
        {
            foreach (DataTable table in _fileContents.Tables)
            {
                yield return table;
            }
        }
    }
}
