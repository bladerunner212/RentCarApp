using RentCar.entity;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.dao
{
    class CarOwnDao
    {
        private NpgsqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public CarOwnDao()
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
        public void CreateSubject(CarOwn carOwn)
        {

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                NpgsqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Insert into public.carowns(dateofstart, dateofend, price, closed) values(@dateofstart, @dateofend, @price, @closed) ";
                cmd.Parameters.AddWithValue("@dateofstart", carOwn.dateOfStart);
                cmd.Parameters.AddWithValue("@dateofend", carOwn.dateOfEnd);
                cmd.Parameters.AddWithValue("@price", carOwn.price);
                cmd.Parameters.AddWithValue("@closed", carOwn.closed);
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }


        //Delete statement
        public void DeleteSubjectById(int id)
        {

            string query = "DELETE FROM carowns WHERE id=" + id + ";";

            if (this.OpenConnection() == true)
            {
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public List<CarOwn> GetSubjects()
        {
            string query = "SELECT * FROM carowns";
            List<CarOwn> carOwns = new List<CarOwn>();

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
                    CarOwn carOwn = new CarOwn();
                    string iduser = (dataReader["id"] + "");
                    carOwn.id = int.Parse(iduser);
                    carOwn.dateOfStart = (string)dataReader["dateofstart"];
                    carOwn.dateOfEnd = (string)dataReader["dateofend"];
                    carOwn.price = (int)dataReader["price"];
                    carOwn.closed = (bool)dataReader["closed"];
                    carOwns.Add(carOwn);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return carOwns;
            }
            else
            {
                return carOwns;
            }

        }
    }
}
