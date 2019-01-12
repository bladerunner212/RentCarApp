using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.entity
{
    class CarOwn : AbstractEntity
    {
        public string dateOfStart { get; set; }
        public string dateOfEnd { get; set; }
        public int price { get; set; }
        public bool closed { get; set; }
        public Car car { get; set; }
        public User owner { get; set; }
    }
}
