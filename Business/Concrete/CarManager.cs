using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstrack;
using DataAccess.Abstrack;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        
       

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            //işkodları
           
            return _carDal.GetAll();
        }
    }
}
