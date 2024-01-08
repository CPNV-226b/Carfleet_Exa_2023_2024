using System;

namespace Carfleet{
    public class Vehicle
    {
        #region private attributes
        private readonly string _chassisNumber;
        private string _registration;
        private string _brand;
        private string _model;
        #endregion private attributes

        #region public methods
        public Vehicle(string registration, string brand, string model, string chassisNumber)
        {
            _registration = registration;
            _brand = brand;
            _model = model;
            _chassisNumber = chassisNumber;
        }

        public string ChassisNumber => _chassisNumber;

        public string Registration { get => _registration; }
        public string Brand { get => _brand; }
        public string Model { get => _model; }

        public override string ToString()
        {
            return this.Registration + " - " + this.Brand + " - " + this.Model + " - " + this.ChassisNumber;
        }
        #endregion public methods
    }
}
