using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VadersLittleHelper.ObjectTypes;

namespace VadersLittleHelper.dbClasses
{
    class SquadronHandler
    {
        private const string dataSource = @"..\..\db\SquadronDB.xlsx";

        public IList<ISquadron> Squadrons { get; }

        private readonly IDataReader _dataReader;

        public SquadronHandler()
        {
            _dataReader = new ExcelReader(dataSource);

            Squadrons = LoadSquadrons();
        }

        private IList<ISquadron> LoadSquadrons()
        {
            IList<ISquadron> squadronList = new List<ISquadron>();

            foreach (DataTable squadron in _dataReader.GetTables())
            {
                foreach(object[] pilot in _dataReader.GetTableContent(squadron))
                {
                    //TODO
                }
            }

            return squadronList;
        }
    }
}
