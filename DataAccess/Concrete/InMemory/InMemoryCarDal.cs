using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstrack;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        //Bu projeyi başlatınca bellekte ürün listesi olusturur.
        //constructor:Bellekte referans aldığı zaman çalısacak olan blog
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car{CarId=1,CategoryId=1,Brandld=1,Colorld=1,ModelYear=2020,DailyPrice=90000,Description="Opel"},
            new Car{CarId=2,CategoryId=1,Brandld=1,Colorld=3,ModelYear=2019,DailyPrice=80000,Description="Ford"},
            new Car{CarId=3,CategoryId=2,Brandld=2,Colorld=5,ModelYear=2018,DailyPrice=70000,Description="Fiat"},
            new Car{CarId=4,CategoryId=2,Brandld=2,Colorld=7,ModelYear=2017,DailyPrice=60000,Description="Skoda"},
            new Car{CarId=5,CategoryId=3,Brandld=3,Colorld=9,ModelYear=2016,DailyPrice=50000,Description="Kia"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            foreach (var c in _cars)
            {
                if (car.CarId ==c.CarId)
                {
                    carToDelete = c;
                }
            }

            carToDelete = _cars.SingleOrDefault(Car => car.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        

       

        public void Update(Car car)
        {
            //Gönderdiğim ürüne ait ürün id sini bul 
            Car carToUpdate = _cars.SingleOrDefault(Car => car.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.CategoryId = car.CategoryId;
            carToUpdate.Brandld = car.Brandld;
            carToUpdate.Colorld = car.Colorld;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;


        }

        public List<Car> GetAllByCategory(int categoryId)
        {
            return _cars.Where(c =>c.CategoryId == categoryId).ToList();
        }
    }
}