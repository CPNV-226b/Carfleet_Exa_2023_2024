using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Carfleet
{
    public class Enterprise
    {
        #region private attributes
        private string _name;
        private string _street;
        private string _city;
        private string _phonenumber;
        private string _emailaddress;
        private List<Vehicle> _vehicles = new List<Vehicle>();
        private List<Driver> _drivers = new List<Driver>();
        #endregion private attributes

        #region public methods
        public Enterprise(string name, string street, string city, string phonenumber, string emailaddress)
        {
            _name = name;
            _street = street;
            _city = city;
            _phonenumber = phonenumber;
            _emailaddress = emailaddress;
        }

        public void Add(Vehicle vehicleToAdd)
        {
            _vehicles.Add(vehicleToAdd);
        }

        public void Add(Driver driver)
        {
            _drivers.Add(driver);
        }

        public Vehicle GetVehicleByChassisNumber(string chassisNumber)
        {
            foreach (Vehicle vehicle in _vehicles)
            {
                if (vehicle.ChassisNumber == chassisNumber)
                {
                    return vehicle;
                }
            }
            throw new VehicleNotFoundException();
        }

        public Driver GetDriverByEmailaddress(string driverEmailaddress)
        {
            foreach (Driver driver in _drivers)
            {
                if (driver.Emailaddress == driverEmailaddress)
                {
                    return driver;
                }
            }
            throw new DriverNotFoundException();
        }

        public void AssignVehicleToDriver(string chassisNumber, string driverEmailaddress)
        {
            Driver driver = this.GetDriverByEmailaddress(driverEmailaddress);
            Vehicle vehicle = this.GetVehicleByChassisNumber(chassisNumber);
            driver.TakeAVehicle(vehicle);
        }

        public void ReleaseVehicleFromDriver(string driverEmailaddress)
        {
            throw new NotImplementedException();
        }
        #endregion public methods

        #region Nesteded class
        public class EnterpriseException : Exception { }
        public class VehicleNotFoundException : EnterpriseException { }
        public class DriverNotFoundException : EnterpriseException { }
        #endregion
    }
}
