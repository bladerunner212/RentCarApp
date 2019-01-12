using RentCar.dao;
using RentCar.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.service
{
    class CarService
    {
        private CarDao subjectDao;

        public CarService()
        {
            this.subjectDao = new CarDao();
        }

        public bool CreateSubject(string brand, string model, int power, int maxSpeed, string transmission, int year, string type, string color, string country, bool owned)
        {
            Car car = new Car();

            car.brand = brand;
            car.model = model;
            car.power = power;
            car.maxSpeed = maxSpeed;
            car.transmission = transmission;
            car.year = year;
            car.type = type;
            car.color = color;
            car.country = country;
            car.owned = owned;

            subjectDao.CreateSubject(car);

            return true;
        }

        public void DeleteSubjectById(int id)
        {
            subjectDao.DeleteSubjectById(id);
        }

        public List<Car> GetSubjects()
        {
            List<Car> cars = new List<Car>();

            cars = subjectDao.GetSubjects();

            return cars;
        }
    }
}
