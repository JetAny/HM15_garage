using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM15_garage
{
    
    internal class Parts : IAddParts
    {
        private IParts? namePart;
        
        public void AddParts(IParts namePart,int index)
        {
            this.namePart = namePart;
            namePart.GetParts( index);
        }
        
        //AddPartDelegate? _deleg;
        //public void RegisterState(AddPartDelegate del)
        //{
        //    _deleg += del;
        //}

        public override string ToString()
        {
            return $"В гараже есть запчасть: {namePart}";
        }
    }
}
