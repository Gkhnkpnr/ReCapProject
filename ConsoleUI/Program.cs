// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new InMemoryCarDal());

Car car = new Car();
car.Id = 6;
car.BrandId = 3;
car.ColorId = 1;
car.ModelYear = 2020;
car.DailyPrice = 550;
car.Description = "Audi R6";
carManager.Add(car);

foreach (var item in carManager.GetAll())
{
    Console.WriteLine("Id: "+item.Id+"\nBrand Id: "+item.BrandId+"\nColor Id: "+item.ColorId+"\nModel Year: "+item.ModelYear+"\nDaily Price: "+item.DailyPrice+"\nDescription: "+item.Description);
    Console.WriteLine("****************************");
}
