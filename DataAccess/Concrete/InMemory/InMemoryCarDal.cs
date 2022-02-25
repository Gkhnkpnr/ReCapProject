﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id = 1,BrandId = 1,ColorId = 1,DailyPrice = 300,Description = "Otomatik Dizel",ModelYear = 2000},
                new Car { Id = 2, BrandId = 1, ColorId = 2, DailyPrice = 250, Description = "Otomatik Benzin", ModelYear = 2005 },
                new Car { Id = 3, BrandId = 2, ColorId = 3, DailyPrice = 350, Description = "Manuel Dizel", ModelYear = 2010 },
                new Car { Id = 4, BrandId = 2, ColorId = 2, DailyPrice = 400, Description = "Manuel Benzin", ModelYear = 2018 },
                new Car { Id = 5, BrandId = 2, ColorId = 3, DailyPrice = 450, Description = "Otomatik Hybrid", ModelYear = 2019 }
            };
            
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }
    }
}
