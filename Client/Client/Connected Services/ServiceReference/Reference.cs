﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Login", ReplyAction="http://tempuri.org/IService/LoginResponse")]
        bool Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Login", ReplyAction="http://tempuri.org/IService/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Register", ReplyAction="http://tempuri.org/IService/RegisterResponse")]
        bool Register(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Register", ReplyAction="http://tempuri.org/IService/RegisterResponse")]
        System.Threading.Tasks.Task<bool> RegisterAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getUsers", ReplyAction="http://tempuri.org/IService/getUsersResponse")]
        string[] getUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getUsers", ReplyAction="http://tempuri.org/IService/getUsersResponse")]
        System.Threading.Tasks.Task<string[]> getUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getCars", ReplyAction="http://tempuri.org/IService/getCarsResponse")]
        string[] getCars();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getCars", ReplyAction="http://tempuri.org/IService/getCarsResponse")]
        System.Threading.Tasks.Task<string[]> getCarsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getBorrows", ReplyAction="http://tempuri.org/IService/getBorrowsResponse")]
        string[] getBorrows();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getBorrows", ReplyAction="http://tempuri.org/IService/getBorrowsResponse")]
        System.Threading.Tasks.Task<string[]> getBorrowsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/addCar", ReplyAction="http://tempuri.org/IService/addCarResponse")]
        void addCar(string platenumber, string type, string cost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/addCar", ReplyAction="http://tempuri.org/IService/addCarResponse")]
        System.Threading.Tasks.Task addCarAsync(string platenumber, string type, string cost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/modifyCar", ReplyAction="http://tempuri.org/IService/modifyCarResponse")]
        void modifyCar(string platenumber, string type, string cost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/modifyCar", ReplyAction="http://tempuri.org/IService/modifyCarResponse")]
        System.Threading.Tasks.Task modifyCarAsync(string platenumber, string type, string cost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/deleteCar", ReplyAction="http://tempuri.org/IService/deleteCarResponse")]
        void deleteCar(string platenumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/deleteCar", ReplyAction="http://tempuri.org/IService/deleteCarResponse")]
        System.Threading.Tasks.Task deleteCarAsync(string platenumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/loggedUser", ReplyAction="http://tempuri.org/IService/loggedUserResponse")]
        string loggedUser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/loggedUser", ReplyAction="http://tempuri.org/IService/loggedUserResponse")]
        System.Threading.Tasks.Task<string> loggedUserAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Logout", ReplyAction="http://tempuri.org/IService/LogoutResponse")]
        void Logout();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Logout", ReplyAction="http://tempuri.org/IService/LogoutResponse")]
        System.Threading.Tasks.Task LogoutAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getUserCars", ReplyAction="http://tempuri.org/IService/getUserCarsResponse")]
        string[] getUserCars();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getUserCars", ReplyAction="http://tempuri.org/IService/getUserCarsResponse")]
        System.Threading.Tasks.Task<string[]> getUserCarsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/borrowCar", ReplyAction="http://tempuri.org/IService/borrowCarResponse")]
        void borrowCar(string platenumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/borrowCar", ReplyAction="http://tempuri.org/IService/borrowCarResponse")]
        System.Threading.Tasks.Task borrowCarAsync(string platenumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/giveBackCar", ReplyAction="http://tempuri.org/IService/giveBackCarResponse")]
        void giveBackCar(string borrowid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/giveBackCar", ReplyAction="http://tempuri.org/IService/giveBackCarResponse")]
        System.Threading.Tasks.Task giveBackCarAsync(string borrowid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/userPayment", ReplyAction="http://tempuri.org/IService/userPaymentResponse")]
        string userPayment();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/userPayment", ReplyAction="http://tempuri.org/IService/userPaymentResponse")]
        System.Threading.Tasks.Task<string> userPaymentAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Client.ServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Client.ServiceReference.IService>, Client.ServiceReference.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public bool Register(string username, string password) {
            return base.Channel.Register(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterAsync(string username, string password) {
            return base.Channel.RegisterAsync(username, password);
        }
        
        public string[] getUsers() {
            return base.Channel.getUsers();
        }
        
        public System.Threading.Tasks.Task<string[]> getUsersAsync() {
            return base.Channel.getUsersAsync();
        }
        
        public string[] getCars() {
            return base.Channel.getCars();
        }
        
        public System.Threading.Tasks.Task<string[]> getCarsAsync() {
            return base.Channel.getCarsAsync();
        }
        
        public string[] getBorrows() {
            return base.Channel.getBorrows();
        }
        
        public System.Threading.Tasks.Task<string[]> getBorrowsAsync() {
            return base.Channel.getBorrowsAsync();
        }
        
        public void addCar(string platenumber, string type, string cost) {
            base.Channel.addCar(platenumber, type, cost);
        }
        
        public System.Threading.Tasks.Task addCarAsync(string platenumber, string type, string cost) {
            return base.Channel.addCarAsync(platenumber, type, cost);
        }
        
        public void modifyCar(string platenumber, string type, string cost) {
            base.Channel.modifyCar(platenumber, type, cost);
        }
        
        public System.Threading.Tasks.Task modifyCarAsync(string platenumber, string type, string cost) {
            return base.Channel.modifyCarAsync(platenumber, type, cost);
        }
        
        public void deleteCar(string platenumber) {
            base.Channel.deleteCar(platenumber);
        }
        
        public System.Threading.Tasks.Task deleteCarAsync(string platenumber) {
            return base.Channel.deleteCarAsync(platenumber);
        }
        
        public string loggedUser() {
            return base.Channel.loggedUser();
        }
        
        public System.Threading.Tasks.Task<string> loggedUserAsync() {
            return base.Channel.loggedUserAsync();
        }
        
        public void Logout() {
            base.Channel.Logout();
        }
        
        public System.Threading.Tasks.Task LogoutAsync() {
            return base.Channel.LogoutAsync();
        }
        
        public string[] getUserCars() {
            return base.Channel.getUserCars();
        }
        
        public System.Threading.Tasks.Task<string[]> getUserCarsAsync() {
            return base.Channel.getUserCarsAsync();
        }
        
        public void borrowCar(string platenumber) {
            base.Channel.borrowCar(platenumber);
        }
        
        public System.Threading.Tasks.Task borrowCarAsync(string platenumber) {
            return base.Channel.borrowCarAsync(platenumber);
        }
        
        public void giveBackCar(string borrowid) {
            base.Channel.giveBackCar(borrowid);
        }
        
        public System.Threading.Tasks.Task giveBackCarAsync(string borrowid) {
            return base.Channel.giveBackCarAsync(borrowid);
        }
        
        public string userPayment() {
            return base.Channel.userPayment();
        }
        
        public System.Threading.Tasks.Task<string> userPaymentAsync() {
            return base.Channel.userPaymentAsync();
        }
    }
}
