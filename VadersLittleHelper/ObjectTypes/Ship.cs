using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VadersLittleHelper.ObjectTypes
{
    public class Ship : IGameComponent
    {
        public string Id { get; }
        public string Name { get; }
        public int QuantityOwned { get; }

        public Ship(object[] shipData)
        {
            try
            {
                Id =            (string)shipData[0];
                Name =          (string)shipData[1];
                QuantityOwned = (int)((double)shipData[2]);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unable to parse cardData: {e.GetType().ToString()}");
                throw;
            }
        }
    }
}
