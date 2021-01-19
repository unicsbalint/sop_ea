using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        bool Login(string username, string password);

        [OperationContract]
        bool Register(string username, string password);
        [OperationContract]
        List<string> getUsers();
        [OperationContract]
        List<string> getCars();
        [OperationContract]
        List<string> getBorrows();
        [OperationContract]
        void addCar(string platenumber, string type, string cost);
        [OperationContract]
        void modifyCar(string platenumber, string type, string cost);
        [OperationContract]
        void deleteCar(string platenumber);
        [OperationContract]
        string loggedUser();
        [OperationContract]
        void Logout();
        [OperationContract]
        List<string> getUserCars();
        [OperationContract]
        void borrowCar(string platenumber);
        [OperationContract]
        void giveBackCar(string borrowid);
        [OperationContract]
        string userPayment();
    }
    
}
