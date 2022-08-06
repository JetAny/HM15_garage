using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM15_garage
{
    delegate void LogEvents(string log);
    
    internal interface IParts
    {
        public event LogEvents? AddedLog;
        string GetParts(int index);
    }
}
