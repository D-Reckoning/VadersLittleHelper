using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VadersLittleHelper.ObjectTypes
{
    public interface ISquadronMember
    {
        string PilotId { get; }
        List<string> UpgradeIds();
        void AddUpgrade(IUpgrade upgrade);
        void RemoveUpgrade(IUpgrade upgrade);
    }
}
