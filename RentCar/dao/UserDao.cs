using RentCar.entity;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.dao
{
    class UserDao
    {
        private NpgsqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public UserDao()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "postgres";
            uid = "postgres";
            password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new NpgsqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (NpgsqlException ex)
            {

                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (NpgsqlException ex)
            {

                return false;
            }

        }

        //Insert statement
        public void CreateSubject(User user)
        {

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                NpgsqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Insert into public.users(nickName, emailAddress, firstName, lastName, password, phoneNumber) values(@nickName, @emailAddress, @firstName, @lastName, @password, @phoneNumber) ";
                cmd.Parameters.AddWithValue("@nickName", user.nickName);
                cmd.Parameters.AddWithValue("@emailAddress", user.emailAddress);
                cmd.Parameters.AddWithValue("@firstName", user.firstName);
                cmd.Parameters.AddWithValue("@lastName", user.lastName);
                cmd.Parameters.AddWithValue("@password", user.password);
                cmd.Parameters.AddWithValue("@phoneNumber", user.phoneNumber);
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }


        //Delete statement
        public void DeleteSubjectById(int id)
        {
   
            string query = "DELETE FROM users WHERE id=" + id + ";";

            if (this.OpenConnection() == true)
            {
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public List<User> GetSubjects()
        {
            string query = "SELECT * FROM users";
            List<User> users = new List<User>();

            if (this.OpenConnection() == true)
            {
                //Create Command
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                //Create a data reader and Execute the command
                NpgsqlDataReader dataReader = cmd.ExecuteReader();

                string idteacher = string.Empty;
                string login = string.Empty;
                string password = string.Empty;

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    User user = new User();
                    string iduser = (dataReader["id"] + "");
                    user.id = int.Parse(iduser);
                    user.nickName = (string)dataReader["nickname"];
                    user.firstName = (string)dataReader["firstname"];
                    user.lastName = (string)dataReader["lastname"];
                    user.password = (string)dataReader["password"];
                    user.phoneNumber = (string)dataReader["phonenumber"];

                    users.Add(user);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return users;
            }
            else
            {
                return users;
            }

        }
    }
}
