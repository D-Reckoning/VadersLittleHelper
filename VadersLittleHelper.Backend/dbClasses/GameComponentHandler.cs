using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VadersLittleHelper.BackEnd.ObjectTypes;

namespace VadersLittleHelper.Backend.dbClasses
{
    public class GameComponentHandler
    {
        private const string dataSource = @"..\..\..\VadersLittleHelper.Backend\db\ComponentDB.xlsx";

        public IList<IPilot> Pilots { get; }
        public IList<IUpgrade> Upgrades { get; }
        public IList<IGameComponent> Ships { get; }

        private readonly IDataReader _dataReader;

        public GameComponentHandler()
        {
            _dataReader = new ExcelReader(dataSource);
        
            Pilots = LoadPilots();
            Upgrades = LoadUpgradeCards();
            Ships = LoadShips();
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

        private IList<IUpgrade> LoadUpgradeCards()
        {
            IList<IUpgrade> upgradeList = new List<IUpgrade>();

            foreach (object[] upgradeData in _dataReader.GetTableContent("CardDB"))
            {
                upgradeList.Add(new UpgradeCard(upgradeData));
            }
            return upgradeList;
        }

        private IList<IGameComponent> LoadShips()
        {
            IList<IGameComponent> shipList = new List<IGameComponent>();

            foreach (object[] shipData in _dataReader.GetTableContent("ShipDB"))
            {
                shipList.Add(new Ship(shipData));
            }
            return shipList;
        }

    } 
}
