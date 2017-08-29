using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VadersLittleHelper.ObjectTypes
{
    [Serializable]
    class Squadron : ISquadron
    {
        public string Id { get; }
        public string Name { get; }
        public List<ISquadronMember> Pilots { get; }

        public Squadron(string name)
        {
            Name = name;
            Pilots = new List<ISquadronMember>();
        }
    }
}
