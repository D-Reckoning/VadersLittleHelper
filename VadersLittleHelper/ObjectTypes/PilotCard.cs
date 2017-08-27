using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VadersLittleHelper.dbClasses;

namespace VadersLittleHelper.ObjectTypes
{
    public class PilotCard : IPilot
    {
        public string Id { get; }
        public string Name { get; }
        public string Text { get; }
        public int Pts { get; }
        public bool Unique { get; }
        public string Ship { get; }
        public Faction Faction { get; }

        public int PilotSkill { get; }
        public int FirePower { get; }
        public int Agility { get; }
        public int Hull { get; }
        public int Shields { get; }

        public int QuantityOwned { get; }


        public PilotCard(object[] cardData)
        {
            try
            {
                Id =            (string)cardData[0];
                Name =          (string)cardData[1];
                Text =          (string)cardData[2];
                Pts =           (int)((double)cardData[3]);
                Unique =        DataHelper.StringToBool((string)cardData[4]);
                Ship =          (string)cardData[5];
                Faction =       DataHelper.StringToFaction((string)cardData[6]);

                PilotSkill =    (int)((double)cardData[7]);
                FirePower =     (int)((double)cardData[8]);
                Agility =       (int)((double)cardData[9]);
                Hull =          (int)((double)cardData[10]);
                Shields =       (int)((double)cardData[11]);

                QuantityOwned = (int)((double)cardData[12]);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unable to parse cardData: {e.GetType().ToString()}");
                throw;
            }
        }
    }
}
