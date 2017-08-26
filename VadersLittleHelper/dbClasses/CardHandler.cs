using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VadersLittleHelper.ObjectTypes;

namespace VadersLittleHelper.dbClasses
{
    class CardHandler
    {
        private const string dataSource = @"..\..\db\ComponentDB.xlsx";

        public IList<IPilot> Pilots { get; }
        public IList<IUpgrade> Upgrades { get; }
        public IList<Ship> Ships { get; }

        private readonly IDataReader _dataReader;

        public CardHandler()
        {
            _dataReader = new ExcelReader(dataSource);
        
            Pilots = LoadPilots();
            //Upgrades = LoadUpgradeCards();
            //Ships = LoadShips();
        }

        private IList<IPilot> LoadPilots()
        {
            IList<IPilot> pilotList = new List<IPilot>();

            foreach (object[] pilotData in _dataReader.GetTableContent("PilotDB"))
            {
                pilotList.Add(new PilotCard(pilotData));
            }

            return pilotList;
        }

        //private IList<IUpgrade> LoadUpgradeCards()
        //{
        //    return new Dictionary<IUpgrade, int>();
        //}

        //private IList<Ship> LoadShips()
        //{
        //    return new Dictionary<Ship, int>();
        //}
        //private IList<ISquadron> LoadSquadrons()
        //{
        //    return new List<ISquadron>();
        //}
    } 
}
