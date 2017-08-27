using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VadersLittleHelper.ObjectTypes
{
    class XWingSquadron : ISquadron
    {
        public string Id { get; }
        public string Name { get; }
        public Dictionary<IPilot, IList<IUpgrade>> Pilots { get; }
    }
}
