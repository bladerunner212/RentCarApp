using RentCar.dao;
using RentCar.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.service
{
    class UserService
    {
        private UserDao subjectDao;

        public UserService()
        {
            this.subjectDao = new UserDao();
        }

        public bool CreateSubject(string nickName, string emailAdress, string firstName, string lastName, string password, string phoneNumber)
        {
            User user = new User();

            user.nickName = nickName;
            user.emailAddress = emailAdress;
            user.firstName = firstName;
            user.lastName = lastName;
            user.password = password;
            user.phoneNumber = phoneNumber;

            subjectDao.CreateSubject(user);

            return true;
        }


        public void DeleteSubjectById(int id)
        {
            subjectDao.DeleteSubjectById(id);
        }


        public List<User> GetSubjects()
        {
            List<User> users = new List<User>();

            users = subjectDao.GetSubjects();

            return users;
        }
    }
}
