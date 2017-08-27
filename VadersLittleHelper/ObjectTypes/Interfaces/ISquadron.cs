﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VadersLittleHelper.ObjectTypes
{
    interface ISquadron
    {
        string Id { get; }
        string Name { get; }
        Dictionary<IPilot, IList<IUpgrade>> Pilots { get; }
    }
}
