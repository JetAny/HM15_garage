using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM15_garage
{
    internal class Harvester : MechanicalMeans
    {
        public Harvester(string fuelType, double fuelQuantity, string Name, int maxSpeed) :
            base(fuelType, fuelQuantity, Name, maxSpeed)
        {
        }
        public override void DoJob()
        {
            Console.WriteLine($"Комбаин косит пшеницу");
        }
        public override void Move()
        {
            Console.WriteLine($"Комбаин едет по полю");
        }
        public override void HelpHeadlights()
        {
            Console.WriteLine($"Поморгал фарами\n");
        }
    }
}
