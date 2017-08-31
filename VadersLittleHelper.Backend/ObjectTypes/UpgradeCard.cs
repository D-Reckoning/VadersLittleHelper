using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VadersLittleHelper.Backend.dbClasses;

namespace VadersLittleHelper.BackEnd.ObjectTypes
{
    public class UpgradeCard : IUpgrade
    {
        public string Id { get; }
        public string Name { get; }
        public string Text { get; }
        public int Pts { get; }
        public bool Unique { get; }
        public bool Limited { get; }
        public UpgradeType Type { get; }

        public int QuantityOwned { get; }

        public UpgradeCard(object[] cardData)
        {
            try
            {
                Id =            (string)cardData[0];
                Text =          (string)cardData[2];
                Pts =           (int)((double)cardData[3]);
                Unique =        DataHelper.StringToBool((string)cardData[4]);
                Limited =       DataHelper.StringToBool((string)cardData[5]);
                Type =          DataHelper.StringToUpgradeType((string)cardData[6]);

                Name = Unique ? $"•{cardData[1]}" : (string)cardData[1];

                QuantityOwned = (int)((double)cardData[7]);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unable to parse cardData: {e.GetType().ToString()}");
                throw;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
