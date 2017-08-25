using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VadersLittleHelper.ObjectTypes
{
    public interface ICard
    {
        string Name { get; }
        string Text { get; }
        int Pts { get; }
        bool Unique { get; }
    }
}
