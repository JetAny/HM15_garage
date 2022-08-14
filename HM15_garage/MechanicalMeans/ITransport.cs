using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM15_garage
{
    public interface ITransport:IComparable<ITransport>, ICloneable
    {
        const int minSpeed = 0;     
        static int maxSpeed { get; set; }
        string fuelType { get; set; }
        double fuelQuantity { get; set; }
        string brand { get; set; }
        void Move(); //двигаться
        void DoJob(); //выполнять работу
        void HelpHeadlights();
    }
}
