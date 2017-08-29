using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VadersLittleHelper.BackEnd.ObjectTypes
{
    public interface ICard : IGameComponent
    {
        string Text { get; }
        int Pts { get; }
        bool Unique { get; }
    }
}
