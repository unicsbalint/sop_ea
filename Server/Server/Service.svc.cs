using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data.MySqlClient;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        private const string connectionString = "server=127.0.0.1;port=3306;user id=root; password=; database=szop_ea; SslMode=none";
        private MySqlConnection connection = new MySqlConnection(connectionString);
        public static string currectUser = "";

        public bool Login(string username, string password)
        {
            connection.Open();
            MySqlCommand cmd_database = new MySqlCommand(String.Format("SELECT * FROM USERS WHERE USERNAME=\"{0}\" AND PASSWORD=\"{1}\"", username, password), connection);
            MySqlDataReader dr = cmd_database.ExecuteReader();
            if (dr.HasRows)
            {
                currectUser = username;
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }
        public string loggedUser()
        {
            return currectUser;
        }
        public bool Register(string username, string password)
        {
            connection.Open();
            MySqlCommand cmd_database = new MySqlCommand(String.Format("INSERT INTO USERS (username, password, isAdmin) VALUES (\"{0}\",\"{1}\",\"{2}\")", username, password, "0"), connection);
            MySqlDataReader dr = cmd_database.ExecuteReader();
            connection.Close();
            return Login(username, password);
        }

        public void Logout()
        {
            currectUser = "";
        }
        public List<string> getUsers()
        {
            if (currectUser == "")
            {
                return new List<string>();
            }
            connection.Open();
            MySqlCommand cmd_database = new MySqlCommand(String.Format("SELECT * FROM USERS"), connection);
            MySqlDataReader dr = cmd_database.ExecuteReader();
            List<string> users = new List<string>();
            users.Add("Felhasználóink:");
            while (dr.Read())
            {
                users.Add(string.Format("{0}", dr["USERNAME"].ToString()));
            }
            connection.Close();
            return users;
        }
        public List<string> getCars()
        {
            if (currectUser == "")
            {
                return new List<string>();
            }
            connection.Open();
            MySqlCommand cmd_database = new MySqlCommand(String.Format("SELECT * FROM CARS WHERE isAvailable = \"1\""), connection);
            MySqlDataReader dr = cmd_database.ExecuteReader();
            List<string> cars = new List<string>();
            cars.Add("RENDSZÁM | TÍPUS | ÁR");
            while (dr.Read())
            {
                cars.Add(string.Format("{0}| {1} | {2} ", dr["license_plate"].ToString(), dr["TYPE"].ToString(), dr["COST"].ToString()));
            }
            connection.Close();
            return cars;
        }

        public void addCar(string platenumber, string type, string cost)
        {
            if (currectUser != "")
            {
                connection.Open();
                MySqlCommand cmd_database = new MySqlCommand(String.Format("INSERT INTO CARS VALUES(\"{0}\",\"{1}\",{2},\"{3}\")", platenumber, type, cost, "1"), connection);
                try
                {
                    MySqlDataReader dr = cmd_database.ExecuteReader();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                }

                connection.Close();
            }



        }
        public void modifyCar(string platenumber, string type, string cost)
        {

            if (currectUser != "")
            {
                connection.Open();
                MySqlCommand cmd_database = new MySqlCommand(String.Format("UPDATE CARS SET license_plate=\"{0}\", type=\"{1}\",cost={2} WHERE license_plate=\"{3}\"", platenumber, type, cost, platenumber), connection);
                try
                {
                    MySqlDataReader dr = cmd_database.ExecuteReader();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                }
                connection.Close();
            }

        }
        public void deleteCar(string platenumber)
        {
            if (currectUser != "")
            {
                connection.Open();
                MySqlCommand cmd_database = new MySqlCommand(String.Format("DELETE FROM CARS WHERE license_plate=\"{0}\"", platenumber), connection);
                try
                {
                    MySqlDataReader dr = cmd_database.ExecuteReader();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                }
                connection.Close();
            }


        }
        public List<string> getBorrows()
        {
            if (currectUser == "")
            {
                return new List<string>();
            }
            connection.Open();
            MySqlCommand cmd_database = new MySqlCommand(String.Format("SELECT * FROM BORROWED"), connection);
            MySqlDataReader dr = cmd_database.ExecuteReader();
            List<string> borrowed = new List<string>();
            borrowed.Add("ID | Melyik felhasználó | Melyik autót?");
            while (dr.Read())
            {
                borrowed.Add(string.Format("{0}| {1} | {2} ", dr["borrow_id"].ToString(), dr["username"].ToString(), dr["license_plate"].ToString()));
            }
            connection.Close();
            return borrowed;
        }

        public List<string> getUserCars()
        {
            if (currectUser == "")
            {
                return new List<string>();
            }
            connection.Open();
            List<string> userCars = new List<string>();
            MySqlCommand cmd_database = new MySqlCommand(String.Format("SELECT DISTINCT borrow_id ,borrowed.username, borrowed.license_plate, cars.type FROM borrowed, users, cars WHERE borrowed.license_plate = cars.license_plate AND  borrowed.username = \"{0}\"", currectUser), connection);
            MySqlDataReader dr = cmd_database.ExecuteReader();
            userCars.Add("BorrowID | User | Plate | Type | ");
            while (dr.Read())
            {
                userCars.Add(string.Format("{0}| {1} | {2} | {3} ",dr["borrow_id"].ToString(), dr["username"].ToString(), dr["license_plate"].ToString(), dr["type"].ToString()));
            }
            connection.Close();
            return userCars;
        }

        public void borrowCar(string platenumber)
        {
            if (currectUser != "")
            {
                connection.Open();
                MySqlCommand cmd_database = new MySqlCommand(String.Format("INSERT INTO borrowed(username, license_plate) VALUES (\"{0}\",\"{1}\")",currectUser,platenumber), connection);
                try
                {
                    MySqlDataReader dr = cmd_database.ExecuteReader();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {

                }
                connection.Close();
                changeAvailableStatus(platenumber,"0");

            }
        }
        public void changeAvailableStatus(string platenumber, string toWhat)
        {
            connection.Open();
            MySqlCommand cmd_database = new MySqlCommand(String.Format("UPDATE cars SET isAvailable=\"{0}\" WHERE license_plate=\"{1}\"",toWhat,platenumber), connection);
            try
            {
                MySqlDataReader dr = cmd_database.ExecuteReader();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {

            }
            connection.Close();
        }
        public string getRendszamFromBorrowID(string id)
        {
            string rendszam = "";
            connection.Open();
            MySqlCommand cmd_database = new MySqlCommand(String.Format("SELECT * FROM BORROWED WHERE BORROW_ID=\"{0}\"",id), connection);         
            MySqlDataReader dr = cmd_database.ExecuteReader();
            dr.Read();
            rendszam = dr["license_plate"].ToString();


            connection.Close();
            return rendszam;
        }
        public void giveBackCar(string id)
        {
            string platenumber = getRendszamFromBorrowID(id);
            changeAvailableStatus(platenumber, "1");
            connection.Open();
            MySqlCommand cmd_database = new MySqlCommand(String.Format("DELETE FROM borrowed WHERE borrow_id = \"{0}\"",id), connection);
            try
            {
                MySqlDataReader dr = cmd_database.ExecuteReader();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {

            }
            connection.Close();
            
        }
        public string userPayment()
        {
            connection.Open();
            MySqlCommand cmd_database = new MySqlCommand(String.Format("SELECT sum(cost) FROM cars,borrowed WHERE borrowed.license_plate = cars.license_plate and borrowed.username=\"{0}\"",currectUser), connection);
            MySqlDataReader dr = cmd_database.ExecuteReader();
            dr.Read();
            string payings = dr["sum(cost)"].ToString();
            connection.Close();
            return payings;
        }
    }
}
