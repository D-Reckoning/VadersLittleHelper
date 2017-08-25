using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VadersLittleHelper.ObjectTypes
{
    public interface IListEntry
    {
        IPilot Pilot { get; }
        IList<IUpgrade> Upgrades { get; }
    }
}
