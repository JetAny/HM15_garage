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
        public event LogEvents? AddedLog;
        public string GetParts(int index)
        {
          
           EnumElectricParts namePart = (EnumElectricParts)index;
            partName= namePart.ToString();
            if (AddedLog != null)
                AddedLog($"На склад гаража добавленна электрическая запчасть{partName}");
            return partName.ToString();
        }
        public override string ToString()
        {
            return $"Электрика: {partName}";
        }

    }
}
