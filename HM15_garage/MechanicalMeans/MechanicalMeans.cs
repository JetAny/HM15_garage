using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM15_garage
{
    internal abstract class MechanicalMeans : ITransport
    {
        public string fuelType { get ; set; }
        public double fuelQuantity { get ; set ; }
        public string brand { get ; set ; }
        public int maxSpeed { get ; set ; }
        public int namber { get ; set ; }
        public  MechanicalMeans(string fuelType, double fuelQuantity, string brand, int maxSpeed)
        {
            this.fuelType = fuelType;
            this.fuelQuantity = fuelQuantity;
            this.brand = brand;
            this.maxSpeed = maxSpeed;
            namber = namberRandom();
        }
        abstract public void DoJob();
        abstract public void Move();
        public virtual void HelpHeadlights()
        {
            Console.WriteLine($"Поморгал фарами\n");
        }
        public object Clone()
        {
            return MemberwiseClone();            
        }
        public int CompareTo(ITransport? other)
        {
            if (other == null)
            {
                return 0;
            }
            int result = string.Compare(this.brand, other.brand);
            return result;
        }
        public static int namberRandom()
        {
            Random rnd = new Random();
            return rnd.Next(1000, 9999);
        }
        public override string ToString()
        {
            return $"Марка: {brand}\t" +
                $"Номерной знак: {namber}\t" +
                $"Вид топлива: {fuelType}\n" +
                $"Количество топлива в баке: {fuelQuantity}\t" +
                $"Максимальная скорость передвижения: {maxSpeed}";
        }       
    }
}
