using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstrack;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int CarId { get; set; }
        public int CategoryId { get; set; }
        public int Brandld { get; set; }
        public int Colorld { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

    }
}
