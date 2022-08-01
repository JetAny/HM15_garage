
using HM15_garage;

Garage garage1=new Garage();
ITransport car1 = new Car("Бензин", 55, "Шкода", 180, 4);
ITransport car2 = new Car("Дизель",65,"БМВ",230,6);
garage1.AddMechanicalMeans(car1);
garage1.AddMechanicalMeans(car2);

Bus bus1 = new Bus("Дизель", 450, "Neoplan", 120, 56);
Bus bus2 = new Bus("Дизель", 450, "Neoplan", 120, 56);
garage1.AddMechanicalMeans(bus1);
garage1.AddMechanicalMeans(bus2);

Truck truck1 = new Truck("Дизель", 450, "Mersedes", 100, 25);
Truck truck2 = new Truck("Дизель", 450, "Man", 100, 25);
garage1.AddMechanicalMeans(truck1);
garage1.AddMechanicalMeans(truck2);

var z = garage1.GetIndex(bus2);
var bus3 = (ITransport)bus2.Clone();

garage1.AddMechanicalMeans(bus3);
garage1.PrintGarage();

garage1.SendTransOnFlight(20);
garage1.SendTransOnFlight(10);
garage1.SendTransOnFlight(5);
garage1.SendTransOnFlight(60);
garage1.ReturnFromFlight();
garage1.ReturnFromFlight();
garage1.ReturnFromFlight();
garage1.ReturnFromFlight();
garage1.ReturnFromFlight();
garage1.ReturnFromFlight();

