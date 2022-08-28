using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM15_garage
{
    internal class MechanicalParts : IParts
    {
        string? partName;
        
        public string GetParts(int index)
        {

            EnumMechanicalParts namePart = (EnumMechanicalParts)index;
            partName = namePart.ToString();
            return partName;
        }
        public override string ToString()
        {
            return $"Механика: {partName}";
        }
    }
}
