using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM15_garage
{
    [Serializable]
    internal class Parts : IAddParts
    {
        private IParts? namePart;
        public event LogEvents? AddedLog;
        public void AddParts(IParts namePart,int index)
        {
            this.namePart = namePart;            
            namePart.GetParts( index);
            if (AddedLog != null)
                AddedLog($"На склад гаража добавленна запчасть: {namePart}");
        }
        public void RemoveParts(IParts namePart, int index)
        {
            this.namePart = namePart;
            namePart.GetParts(index);
            if (AddedLog != null)
                AddedLog($"Со склада гаража выдана запчасть: {namePart}");
        }

        public override string ToString()
        {
            return $"В гараже есть запчасть: {namePart}";
        }
    }
}
