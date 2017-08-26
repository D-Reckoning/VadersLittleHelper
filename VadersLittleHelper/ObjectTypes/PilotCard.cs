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


        public PilotCard(object[] cardData)
        {
            try
            {
                Name = (string)cardData[0];
                Text = (string)cardData[1];
                Pts = (int)((double)cardData[2]);
                Unique = DataHelper.StringToBool((string)cardData[3]);
                Ship = (string)cardData[4];
                Faction = DataHelper.StringToFaction((string)cardData[5]);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Unable to parse cardData: {e.GetType().ToString()}");
                throw;
            }
        }
    }
}
