using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VadersLittleHelper.BackEnd.ObjectTypes
{
    public interface IGameComponent
    {
        string Id { get; }
        string Name { get; }
        int QuantityOwned { get; }
    }
}
