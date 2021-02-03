using DataAccess.Abstract;
using Entities.Concerte;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concerte.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> cars;
        //1-Beyaz,2-Kırmızı,3-Siyah

        public InMemoryCarDal()
        {
            cars = new List<Car>
            {
                new Car{BrandId=1,ColorId=1,DailyPrice=400,Description="Volkswagen Golf",Id=1,ModelYear="2017"},
                new Car{BrandId=2,ColorId=3,DailyPrice=1000,Description="Mercesdes C63",Id=2,ModelYear="2016"},
                new Car{BrandId=3,ColorId=2,DailyPrice=200,Description="BMW E36",Id=3,ModelYear="1998"},
                new Car{BrandId=4,ColorId=3,DailyPrice=400,Description="Ford Ranger",Id=4,ModelYear="2018"},
                new Car{BrandId=5,ColorId=1,DailyPrice=450,Description="Honda Civic Rs",Id=5,ModelYear="2019"},
                new Car{BrandId=6,ColorId=3,DailyPrice=100,Description="Fiat Doblo",Id=6,ModelYear="2016"},
            };
        }

        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = cars.SingleOrDefault(c => c.Id == car.Id);
            cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public void GetById(Car car)
        {
            Car selectedCar = cars.SingleOrDefault(c => c.Id == car.Id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;


        }
    }
}
