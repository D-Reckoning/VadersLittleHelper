using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VadersLittleHelper.BackEnd.ObjectTypes
{
    public interface IUpgrade : ICard
    {
        bool Limited { get; }
        UpgradeType Type { get; }
    }
}
