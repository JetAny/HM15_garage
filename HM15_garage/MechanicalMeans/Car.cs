namespace HM15_garage
{
    internal class Car : MechanicalMeans, ILoading
    {
        private int _maxPassengers;      
        public int _totalLoad { get ; set ; }
        public Car(string fuelType, double fuelQuantity, string Name, int maxSpeed, int maxPassenger) :
            base(fuelType, fuelQuantity, Name, maxSpeed)
        {
            _maxPassengers = maxPassenger;
        }
        public override void DoJob()
        {
            Console.WriteLine($"Машина перевозит пассажиров");
        }
        public override void Move()
        {
            Console.WriteLine($"Машина едет по дороге");
        }
        public override void HelpHeadlights()
        {
            Console.WriteLine($"Поморгала фарами\n");
        }
        void ILoading.Load(int totalLoad)
        {
            Console.WriteLine($"В машину загрузилось {_maxPassengers} пассажиров");
        }
        public override string ToString()
        {
            return $"{base.ToString()}\t" +
                $"Максимальное количество пассажиров: {_maxPassengers}\n";
        }
    }
}
