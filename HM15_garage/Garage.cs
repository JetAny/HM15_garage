namespace HM15_garage
{
    delegate void AddPartDelegate(int tape, int index);
    //delegate void LogEvents(string log);


    delegate void SendTransOnFlight(int load);
    delegate void RemovePartDelegate();
    internal class Garage
    {
        //public event LogEvents? AddedLog;

        public List<ITransport> transportOnGarage = new List<ITransport>();
        public List<ITransport> transOnFlight = new List<ITransport>();
        public List<IAddParts> _parts = new List<IAddParts>();



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
        public void PrintGarageParts()
        {
            Console.WriteLine(new string('=', 140));

            foreach (var part in _parts)
            {
                Console.WriteLine(part);
            }
            Console.WriteLine(new string('=', 140));
        }
        public void SendTransOnFlight(int load)
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
        public void AddPart(int tape, int index)
        {

            IAddParts part = new Parts();
            if (tape > 1)
            {
                Console.WriteLine("Неверно введен тип запчасти, надо ввести 0 или 1");
            }
            if (tape == 0)
            {
                part.AddParts(new ElectricParts(), index);
                _parts.Add(part);
                //if (AddedLog != null)
                //    AddedLog($"На склад гаража добавленна электрическая запчасть{part}");

            }
            if (tape == 1)
            {
                part.AddParts(new MechanicalParts(), index);
                _parts.Add(part);
            }



        }
        public static void Display(string massage)
        {
            Console.WriteLine(massage);
        }

        public override string ToString()
        {
            return $"В гараже числится{transportOnGarage.Count} автомобилей";
        }



    }


}
