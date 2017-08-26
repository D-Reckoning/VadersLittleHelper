using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VadersLittleHelper.dbClasses
{
    public interface IDataReader
    {
        IEnumerable<object[]> GetTableContent(string tableName);
    }
}
