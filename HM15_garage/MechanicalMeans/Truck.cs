namespace HM15_garage
{
    [Serializable]
    public class Truck : MechanicalMeans, ILoading
    {
        public double _maxLoad;
        
        public int _totalLoad { get; set; }
        public Truck() { }
        
        
        public Truck(string fuelType, double fuelQuantity, string Name, int maxSpeed, double maxLoad) :
            base(fuelType, fuelQuantity, Name, maxSpeed)
        {
            _maxLoad = maxLoad;
        }
        public override void DoJob()
        {
            Console.WriteLine($"Грузовик перевозит груз");
        }
        public override void Move()
        {
            Console.WriteLine($"Грузовик едет по дороге");
        }

        void ILoading.Load(int totalLoad)
        {
            _totalLoad = totalLoad;
            double underLoad = totalLoad;
            if (underLoad >= 0) { Console.WriteLine($"В грузовик загрузили {_totalLoad} тон груза"); }
            else { Console.WriteLine($"Не весь груз смогли загрузить," +
                $" осталось перевезти еще {underLoad*-1} тон груза"); }
        }
        public override string ToString()
        {
            return $"{base.ToString()}\t" +
                $"Максимальная грузоподъёмность: {_maxLoad}\n";
        }

        
    }
}
