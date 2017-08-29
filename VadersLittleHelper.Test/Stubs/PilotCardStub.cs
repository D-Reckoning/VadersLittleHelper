using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VadersLittleHelper.BackEnd.ObjectTypes;

namespace VadersLittleHelper.Test.Stubs
{
    class PilotCardStub : IPilot
    {
        public int PilotSkill => throw new NotImplementedException();
        public int FirePower => throw new NotImplementedException();
        public int Agility => throw new NotImplementedException();
        public int Hull => throw new NotImplementedException();
        public int Shields => throw new NotImplementedException();
        public string Ship => throw new NotImplementedException();
        public Faction Faction => throw new NotImplementedException();
        public string Text => throw new NotImplementedException();
        public int Pts => throw new NotImplementedException();
        public bool Unique => throw new NotImplementedException();
        public string Name => throw new NotImplementedException();
        public int QuantityOwned => throw new NotImplementedException();

        public string Id { get; }

        public PilotCardStub(string id)
        {
            Id = id;
        }
    }
}
