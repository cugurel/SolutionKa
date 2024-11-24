using Class;

Car firstCar = new Car();
firstCar.Id = 1;
firstCar.Brand = "Mercedes";
firstCar.Model = "AMG";
firstCar.Price = "2.500.000";
firstCar.Currency = "TL";

Car secondCar = new Car();
secondCar.Id = 2;
secondCar.Brand = "Opel";
secondCar.Model = "Astra";
secondCar.Price = "500.000";
secondCar.Currency = "TL";

Car thirdCar = new Car();
thirdCar.Id = 3;
thirdCar.Brand = "Volvo";
thirdCar.Model = "S90";
thirdCar.Price = "3.500.000";
thirdCar.Currency = "TL";

List<Car> cars = new List<Car>();
cars.Add(firstCar);
cars.Add(secondCar);
cars.Add(thirdCar);

//foreach (var car in cars)
//{
//    Console.WriteLine(car.Id);
//    Console.WriteLine(car.Brand);
//    Console.WriteLine(car.Model);
//    Console.WriteLine(car.Price);
//    Console.WriteLine(car.Currency);
//    Console.WriteLine("-----------------------------------------------");
//}

for (int i = 0; i < cars.Count; i++)
{
    Console.WriteLine(cars[i].Id);
    Console.WriteLine(cars[i].Brand);
    Console.WriteLine(cars[i].Model);
    Console.WriteLine(cars[i].Price);
    Console.WriteLine(cars[i].Currency);
    Console.WriteLine("-----------------------------------------------");
}