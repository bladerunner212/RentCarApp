using RentCar.entity;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.dao
{
    class CarDao
    {
        private NpgsqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public CarDao()
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
        public void CreateSubject(Car car)
        {

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                NpgsqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Insert into public.cars(brand, model, power, maxspeed, transmission, year, type, color, country) values(@brand, @model, @power, @maxspeed, @transmission, @year, @type, @color, @country) ";
                cmd.Parameters.AddWithValue("@brand", car.brand);
                cmd.Parameters.AddWithValue("@model", car.model);
                cmd.Parameters.AddWithValue("@power", car.power);
                cmd.Parameters.AddWithValue("@maxspeed", car.maxSpeed);
                cmd.Parameters.AddWithValue("@transmission", car.transmission);
                cmd.Parameters.AddWithValue("@year", car.year);
                cmd.Parameters.AddWithValue("@type", car.type);
                cmd.Parameters.AddWithValue("@color", car.color);
                cmd.Parameters.AddWithValue("@country", car.country);
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }


        //Delete statement
        public void DeleteSubjectById(int id)
        {

            string query = "DELETE FROM cars WHERE id=" + id + ";";

            if (this.OpenConnection() == true)
            {
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public List<Car> GetSubjects()
        {
            string query = "SELECT * FROM cars";
            List<Car> cars = new List<Car>();

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
                    Car car = new Car();
                    string iduser = (dataReader["id"] + "");
                    car.id = int.Parse(iduser);
                    car.brand = (string)dataReader["brand"];
                    car.color = (string)dataReader["color"];
                    car.country = (string)dataReader["country"];
                    car.maxSpeed = (int)dataReader["maxspeed"];
                    car.model = (string)dataReader["model"];
                    car.power = (int)dataReader["power"];
                    car.transmission = (string)dataReader["transmission"];
                    car.type = (string)dataReader["type"];
                    car.year = (int)dataReader["year"];
                    cars.Add(car);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return cars;
            }
            else
            {
                return cars;
            }

        }
    }
}
