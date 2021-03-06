using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId = 1,BrandId = 1,ColorId = 1,DailyPrice = 300,CarDescription = "Otomatik Dizel",ModelYear = 2000},
                new Car { CarId = 2, BrandId = 1, ColorId = 2, DailyPrice = 250, CarDescription = "Otomatik Benzin", ModelYear = 2005 },
                new Car { CarId = 3, BrandId = 2, ColorId = 3, DailyPrice = 350, CarDescription = "Manuel Dizel", ModelYear = 2010 },
                new Car { CarId = 4, BrandId = 2, ColorId = 2, DailyPrice = 400, CarDescription = "Manuel Benzin", ModelYear = 2018 },
                new Car { CarId = 5, BrandId = 2, ColorId = 3, DailyPrice = 450, CarDescription = "Otomatik Hybrid", ModelYear = 2019 }
            };
            
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.CarDescription = car.CarDescription;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
        }
    }
}
