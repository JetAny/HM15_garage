namespace HM15_garage
{
    internal class Garage
    {
        public List<ITransport> transportOnGarage = new List<ITransport>();
        public List<ITransport> transOnFlight = new List<ITransport>();


        public void AddMechanicalMeans(ITransport mechanicalMeans)
        {
            transportOnGarage.Add(mechanicalMeans);
            transportOnGarage.Sort();
        }
        public int GetIndex<T>(T myTransport)
        {
            if (myTransport == null)
            {
                return 0;
            }
            ITransport _myTransport = (ITransport)myTransport;

            return transportOnGarage.BinarySearch(_myTransport);
        }
        public void PrintGarage()
        {
            Console.WriteLine(new string('=', 140));
            Console.WriteLine($"В гараже находятся:\n");
            foreach (var trans in transportOnGarage)
            {
                Console.WriteLine(trans);
            }
            Console.WriteLine(new string('=', 140));
        }
        public ITransport SendTransOnFlight(int load)
        {
            Random R = new Random();
            int someRandomTransport = R.Next(0, transportOnGarage.Count());
            ITransport sendTrans = transportOnGarage.ElementAt(someRandomTransport);
            Console.WriteLine($"\nВ рейс отправился: {sendTrans}\n");
            transportOnGarage.Remove(sendTrans);
            transOnFlight.Add(sendTrans);
            ILoading loadTrans = (ILoading)sendTrans;
            loadTrans.Load(load);
            sendTrans.Move();
            PrintGarage();
            return sendTrans;
        }
        public void ReturnFromFlight()
        {
            if (transOnFlight.Count == 0)
            {
                Console.WriteLine($"\nВесь транспорт находится в гараже \n");
            }
            else
            {
                Random R = new Random();
                int someRandomTransport = R.Next(0, transOnFlight.Count());
                ITransport sendTrans = transOnFlight.ElementAt(someRandomTransport);
                transportOnGarage.Add(sendTrans);
                transOnFlight.Remove(sendTrans);
                Console.WriteLine($"\nИз рейса вернулся: {sendTrans}\n");
                sendTrans.HelpHeadlights();
                PrintGarage();               
            }
        }

        public override string ToString()
        {
            return $"В гараже числится{transportOnGarage.Count} автомобилей";
        }


    }
}
