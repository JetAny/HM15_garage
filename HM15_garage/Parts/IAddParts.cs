using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM15_garage
{
    delegate void LogEvents(string log);
    internal interface IAddParts
    {
        public event LogEvents? AddedLog;
        void AddParts( IParts namePart,int index);
        void RemoveParts(IParts namePart, int index);
    }
}
