using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VadersLittleHelper.BackEnd.ObjectTypes;

namespace VadersLittleHelper.Test.Stubs
{
    class UpgradeCardStub : IUpgrade
    {
        public string Name => throw new NotImplementedException();
        public bool Limited => throw new NotImplementedException();
        public UpgradeType Type => throw new NotImplementedException();
        public string Text => throw new NotImplementedException();
        public int Pts => throw new NotImplementedException();
        public bool Unique => throw new NotImplementedException();
        public int QuantityOwned => throw new NotImplementedException();

        public string Id { get; }

        public UpgradeCardStub(string id)
        {
            Id = id;
        }

    }
}
