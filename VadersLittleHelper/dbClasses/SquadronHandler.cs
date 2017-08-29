using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VadersLittleHelper.ObjectTypes;

namespace VadersLittleHelper.dbClasses
{
    class SquadronHandler
    {
        private const string dataSource = @"..\..\db\SquadronDB.bin";

        public IList<ISquadron> Squadrons { get; }

        public SquadronHandler()
        {
            Squadrons = LoadSquadrons();
        }

        private IList<ISquadron> LoadSquadrons()
        {
            return (IList<ISquadron>)BinaryReader.ReadFromFile(dataSource);
        }
    }
}
