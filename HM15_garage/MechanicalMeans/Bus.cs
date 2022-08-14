namespace HM15_garage
{
    [Serializable]
    internal class Bus : MechanicalMeans, ILoading
    {
        public int _maxPassengers;
        public int _totalPassengers;
        public int _totalLoad { get; set; }
        public Bus() { }
       


        public Bus(string fuelType, double fuelQuantity, string Name, int maxSpeed, int maxPassengers) :
            base(fuelType, fuelQuantity, Name, maxSpeed)
        {
            _maxPassengers = maxPassengers;
        }
        public object Clone()
        {
            

            return MemberwiseClone();
        }
        public override void DoJob()
        {
            Console.WriteLine($"Автобус перевозит много пассажиров");
        }
        public override void Move()
        {
            Console.WriteLine($"Автобус едет по дороге");
        }        
        void ILoading.Load(int totalLoad)
        {
            _totalPassengers = totalLoad;
            int passengersLeft = _maxPassengers - _totalPassengers;
            if (passengersLeft >= 0) { Console.WriteLine($"В автобус загрузилось {_totalPassengers} пассажиров"); }
            else { Console.WriteLine($"Не все пссажиры смогли уехать на этом автобусе," +
                $" осталось перевезти еще {passengersLeft*-1} пассажиров"); }
        }
        public override string ToString()
        {
            return $"{base.ToString()}\t" +
                $"Максимальное количество пассажиров: {_maxPassengers}\n";
        }
    }
}
