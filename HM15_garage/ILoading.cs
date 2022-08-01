using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM15_garage
{
    public interface ILoading
    {
        int totalLoad { get; set; }
        void Load(int totalLoad);
    }
}
