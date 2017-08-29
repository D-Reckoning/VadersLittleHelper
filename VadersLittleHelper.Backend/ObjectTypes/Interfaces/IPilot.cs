using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VadersLittleHelper.BackEnd.ObjectTypes
{
    public interface IPilot : ICard
    {
        int PilotSkill { get; }
        int FirePower { get; }
        int Agility { get; }
        int Hull { get; }
        int Shields { get; }

        string Ship { get; }
        Faction Faction { get; }
    }
}
