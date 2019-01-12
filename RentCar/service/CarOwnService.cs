using RentCar.dao;
using RentCar.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.service
{
    class CarOwnService
    {
        private CarOwnDao subjectDao;

        public CarOwnService()
        {
            this.subjectDao = new CarOwnDao();
        }

        public bool CreateSubject(string dateOfStart, string dateOfEnd, int price, bool closed, Car car, User owner)
        {
            CarOwn carOwn = new CarOwn();

            carOwn.dateOfStart = dateOfStart;
            carOwn.dateOfEnd = dateOfEnd;
            carOwn.price = price;
            carOwn.closed = closed;
            carOwn.car = car;
            carOwn.owner = owner;

            subjectDao.CreateSubject(carOwn);

            return true;
        }

        public void DeleteSubjectById(int id)
        {
            subjectDao.DeleteSubjectById(id);
        }

        public List<CarOwn> GetSubjects()
        {
            List<CarOwn> carOwns = new List<CarOwn>();

            carOwns = subjectDao.GetSubjects();

            return carOwns;
        }
    }
}
