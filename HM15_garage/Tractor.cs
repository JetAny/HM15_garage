using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM15_garage
{
    internal class Tractor : MechanicalMeans
    {
        public Tractor(string fuelType, double fuelQuantity, string Name, int maxSpeed) :
            base(fuelType, fuelQuantity, Name, maxSpeed)
        {
        }
        public override void DoJob()
        {
            Console.WriteLine($"Трактор пашет поле");
        }

        public override void Move()
        {
            Console.WriteLine($"Трактор едет по проселочной  дороге");
        }
        public override void HelpHeadlights()
        {
            Console.WriteLine($"Поморгал фарами\n");
        }
    }
}
