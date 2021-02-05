using System.Collections.Generic;
using DataAccess.Abstrack;
using Entities.Concrete;

namespace Business.Concrete
{
    public class InmemoryCarDal : ICarDal
    {
        public void Add(Car car)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Car car)
        {
            throw new System.NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<Car> GetAllByCategory(int categoryId)
        {
            throw new System.NotImplementedException();
        }

        public void GetById(Car car)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new System.NotImplementedException();
        }
    }
}