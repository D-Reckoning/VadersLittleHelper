using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VadersLittleHelper.ObjectTypes
{
    public class UpgradeCard : IUpgrade
    {
        public string Name { get; }
        public string Text { get; }
        public int Pts { get; }
        public bool Unique { get; }

        public UpgradeType Type { get; }
        public bool Limited { get; }
    }
}
