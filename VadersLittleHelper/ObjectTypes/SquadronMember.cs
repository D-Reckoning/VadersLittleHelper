using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VadersLittleHelper.ObjectTypes
{
    class SquadronMember : ISquadronMember
    {
        public string PilotId { get; }
        private readonly List<string> _upgradeIds;

        public SquadronMember(IPilot pilot)
        {
            PilotId = pilot.Id;
            _upgradeIds = new List<string>();
        }

        public void AddUpgrade(IUpgrade upgrade)
        {
            _upgradeIds.Add(upgrade.Id);
        }

        public void RemoveUpgrade(IUpgrade upgrade)
        {
            _upgradeIds.Remove(upgrade.Id);
        }

        public List<string> UpgradeIds()
        {
            return _upgradeIds;
        }
    }
}
