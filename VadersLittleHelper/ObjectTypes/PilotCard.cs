using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VadersLittleHelper.ObjectTypes
{
    public class PilotCard : IPilot
    {
        public string Name { get; }
        public string Text { get; }
        public int Pts { get; }
        public bool Unique { get; }

        public int PilotSkill { get; }
        public int FirePower { get; }
        public int Agility { get; }
        public int Hull { get; }
        public int Shields { get; }

        public Ship Ship { get; }
        public Faction Faction { get; }
    }
}
