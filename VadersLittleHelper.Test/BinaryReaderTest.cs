using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VadersLittleHelper.BackEnd.ObjectTypes;
using VadersLittleHelper.Test.Stubs;
using VadersLittleHelper.Backend.dbClasses;

namespace VadersLittleHelper.Test
{
    [TestFixture]
    class BinaryReaderTest
    {
        [Test]
        public void BinaryReaderSaveAndLoadSquadrons()
        {
            const string dataPath = @"..\..\test\SquadronDB.bin";
            IList<ISquadron> sqdListOut = new List<ISquadron>();
            IList<ISquadron> sqdListIn;
            sqdListOut.Add(PopulateSquadron("Able Squadron"));
            sqdListOut.Add(PopulateSquadron("Baker Squadron"));

            try
            {
                BinaryReader.WriteToFile(dataPath, sqdListOut);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unable to write squadrons to file: {e.GetType().ToString()}");
                throw;
            }

            try
            {
                sqdListIn = (IList<ISquadron>)BinaryReader.ReadFromFile(dataPath);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unable to read squadrons from file: {e.GetType().ToString()}");
                throw;
            }

            //Assert each list contains the same number of Squadrons
            Assert.AreEqual(sqdListOut.Count, sqdListIn.Count);

            // Assert that each 
            for (int i = 0; i < sqdListIn.Count; i++)
            {
                for (int j = 0; j < sqdListIn[i].Pilots.Count; j++)
                {
                    Assert.AreEqual(sqdListIn[i].Pilots[j].PilotId, sqdListOut[i].Pilots[j].PilotId);

                    for (int k = 0; k < sqdListIn[i].Pilots[j].UpgradeIds().Count; k++)
                    {
                        Assert.AreEqual(sqdListIn[i].Pilots[j].UpgradeIds().ElementAt(k),
                            sqdListOut[i].Pilots[j].UpgradeIds().ElementAt(k));
                    }
                }
            }
        }

        public Squadron PopulateSquadron(string name)
        {
            Squadron s = new Squadron(name);

            SquadronMember sm_1 = new SquadronMember(new PilotCardStub("P0001"));
            sm_1.AddUpgrade(new UpgradeCardStub("U0001"));
            sm_1.AddUpgrade(new UpgradeCardStub("U0002"));
            s.Pilots.Add(sm_1);

            SquadronMember sm_2 = new SquadronMember(new PilotCardStub("P0002"));
            sm_2.AddUpgrade(new UpgradeCardStub("U0003"));
            s.Pilots.Add(sm_2);

            return s;
        }
    }
}
