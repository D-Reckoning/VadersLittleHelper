using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VadersLittleHelper.BackEnd.ObjectTypes
{
    [Serializable]
    public class Squadron : ISquadron
    {
        public string Id { get; }
        public string Name { get; }
        public Faction Faction { get; }

        private readonly List<ISquadronMember> _pilotIds;

        public Squadron(string name, Faction faction)
        {
            Name = name;
            faction = Faction;
            _pilotIds = new List<ISquadronMember>();
        }

        public List<ISquadronMember> GetPilots()
        {
            return _pilotIds;
        }

        public void AddPilot(ISquadronMember pilot)
        {
            _pilotIds.Add(pilot);
        }

        public void RemovePilot(ISquadronMember pilot)
        {
            _pilotIds.Remove(pilot);
        }
    }
}
