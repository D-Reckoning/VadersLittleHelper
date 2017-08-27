using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VadersLittleHelper.ObjectTypes;

namespace VadersLittleHelper.dbClasses
{
    public static class DataHelper
    {
        public static Faction StringToFaction(string stringValue)
        {
            try
            {
                return (Faction)Enum.Parse(typeof(Faction), stringValue);
            }
            catch (Exception e) when (e is ArgumentNullException || e is ArgumentException || e is OverflowException)
            {
                throw new ArgumentException($"Unable to process string to Faction: string '{stringValue}' has illegal value");
            }
        }

        public static UpgradeType StringToUpgradeType(string stringValue)
        {
            stringValue = stringValue.Replace(" ", "_");

            try
            {
                return (UpgradeType)Enum.Parse(typeof(UpgradeType), stringValue);
            }
            catch (Exception e) when (e is ArgumentNullException || e is ArgumentException || e is OverflowException)
            {
                throw new ArgumentException($"Unable to process string to Upgrade Type: string '{stringValue}' has illegal value");
            }
        }

        public static bool StringToBool(string stringValue)
        {
            switch (stringValue.ToLowerInvariant())
            {
                case "true":
                case "yes":
                case "y":
                    {
                        return true;
                    }
                case "false":
                case "no":
                case "n":
                    {
                        return false;
                    }
                default:
                    {
                        throw new ArgumentException($"Unable to process string to bool: string '{stringValue}' has illegal value");
                    }
            }
        }
    }
}
