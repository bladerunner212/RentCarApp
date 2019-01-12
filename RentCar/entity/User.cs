using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.entity
{
    class User : AbstractEntity
    {
        public string nickName { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public string phoneNumber { get; set; }
        public ICollection<CarOwn> listOfOwnedCars { get; set; }
        //public List<Permission> permissions { get; set; }
    }
}
