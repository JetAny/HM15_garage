
using HM15_garage;

Garage garage1 = new Garage();
ITransport car1 = new Car("Бензин", 55, "Шкода", 180, 4);
ITransport car2 = new Car("Дизель", 65, "БМВ", 230, 6);
garage1.AddMechanicalMeans(car1);
garage1.AddMechanicalMeans(car2);

ITransport bus1 = new Bus("Дизель", 450, "Neoplan", 120, 56);
ITransport bus2 = new Bus("Дизель", 450, "Neoplan", 120, 56);
garage1.AddMechanicalMeans(bus1);
garage1.AddMechanicalMeans(bus2);

ITransport truck1 = new Truck("Дизель", 450, "Mersedes", 100, 25);
ITransport truck2 = new Truck("Дизель", 450, "Man", 100, 25);
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

garage1.AddPart(0, 1);
garage1.AddPart(1, 2);
garage1.AddPart(1, 3);
garage1.AddPart(1, 4);
garage1.AddPart(0, 1);
garage1.PrintGarageParts();



Console.WriteLine($"{new string('=', 50)}ДЗ 16{new string('=', 50)}");


AddPartDelegate partsDelegate = garage1.AddPart;
partsDelegate(0, 1);
SendTransOnFlight SendTransDelegate = garage1.SendTransOnFlight;
SendTransDelegate(32);
RemovePartDelegate RemoveTransDelegate = garage1.ReturnFromFlight;
RemoveTransDelegate();

var addEvent = new Parts();
addEvent.AddedLog += Servise.Display;
addEvent.AddParts(new ElectricParts(), 1);
addEvent.AddParts(new ElectricParts(), 2);
addEvent.AddParts(new ElectricParts(), 3);
addEvent.AddParts(new MechanicalParts(), 1);
addEvent.AddParts(new MechanicalParts(), 2);

addEvent.RemoveParts(new MechanicalParts(), 2);
Console.WriteLine($"{new string('=', 50)}");

//garage1.PrintGarageLog();

