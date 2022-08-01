namespace HM15_garage
{
    internal class Truck : MechanicalMeans, ILoading
    {
        private int _maxLoad;
        private int _totalLoad;
        public int totalLoad { get; set; }
        public Truck(string fuelType, double fuelQuantity, string Name, int maxSpeed, int maxLoad) :
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
       
        public void Load(int totalLoad)
        {
            _totalLoad = totalLoad;
            int underLoad = _maxLoad - _totalLoad;
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
