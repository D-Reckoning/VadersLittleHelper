using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VadersLittleHelper.BackEnd.ObjectTypes
{
    public interface ISquadron
    {
        string Id { get; }
        string Name { get; }
        Faction Faction { get; }
        List<ISquadronMember> GetPilots();
        void AddPilot(ISquadronMember pilot);
        void RemovePilot(ISquadronMember pilot);
    }
}
