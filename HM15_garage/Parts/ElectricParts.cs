using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM15_garage
{
    internal class ElectricParts : IParts
    {
        string? partName;
       public ElectricParts? namePart { get; set; }
       
        public string GetParts(int index)
        {
          
           EnumElectricParts namePart = (EnumElectricParts)index;
            partName= namePart.ToString();
            
            return partName.ToString();
        }
        public override string ToString()
        {
            return $"Электрика: {partName}";
        }

    }
}
