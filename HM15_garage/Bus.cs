namespace HM15_garage
{
    internal class Bus : MechanicalMeans, ILoading
    {
        private int _maxPassengers;
        private int _totalPassengers;
        public int totalLoad { get; set; }

        public Bus(string fuelType, double fuelQuantity, string Name, int maxSpeed, int maxPassengers) :
            base(fuelType, fuelQuantity, Name, maxSpeed)
        {
            _maxPassengers = maxPassengers;

        }

        public override void DoJob()
        {
            Console.WriteLine($"Автобус перевозит много пассажиров");
        }

        public override void Move()
        {
            Console.WriteLine($"Автобус едет по дороге");
        }
        
        public void Load(int totalLoad)
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
