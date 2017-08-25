using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VadersLittleHelper.ObjectTypes;

namespace VadersLittleHelper.dbClasses
{
    class DataHandler
    {
        private Dictionary<IPilot, int> _pilots;
        private Dictionary<IUpgrade, int> _upgrades;
        private Dictionary<Ship, int> _ships;

        private List<ISquadron> _squadrons;

        private IDataReader dataReader;

        public DataHandler()
        {

        }

        public void Init()
        {
            _pilots = LoadPilots();
            _upgrades = LoadUpgradeCards();
            _ships = LoadShips();
            _squadrons = LoadSquadrons();
        }

        private Dictionary<IPilot, int> LoadPilots()
        {
            return new Dictionary<IPilot, int>();
        }

        private Dictionary<IUpgrade, int> LoadUpgradeCards()
        {
            return new Dictionary<IUpgrade, int>();
        }

        private Dictionary<Ship, int> LoadShips()
        {
            return new Dictionary<Ship, int>();
        }
        private List<ISquadron> LoadSquadrons()
        {
            return new List<ISquadron>();
        }
    } 
}
