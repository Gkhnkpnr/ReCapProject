﻿// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

Car car = new Car();
car.CarId = 6;
car.BrandId = 3;
car.ColorId = 1;
car.ModelYear = 2020;
car.DailyPrice = 550;
car.CarDescription = "Audi R6";
carManager.Add(car);


