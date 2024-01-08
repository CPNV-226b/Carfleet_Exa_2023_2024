using System;
using System.Runtime.CompilerServices;

namespace Carfleet{
    public class Truck:Vehicle
    {
        #region private attributes
        private Boolean _isCarryingGoods = false;
        private Boolean _isOnDelivery = false;
        #endregion private attributes

        #region public methods
        public Truck(string registration, string brand, string model, string chassisNumber)
                    :base(registration, brand, model, chassisNumber){}

        public Boolean IsCarryingGoods
        {
            get
            {
                return _isCarryingGoods;
            }
            set
            {
                _isCarryingGoods = value;
            }
        }

        public Boolean IsOnDelivery
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            //TODO help : use the private methods above
            string result = base.ToString();

            return base.ToString() + " - " + this.IsCarringyGoodsToString() + " - " + this.IsOnDeliveryToString();
        }
        #endregion public methods

        #region private methods
        private string IsCarringyGoodsToString()
        {
            throw new NotImplementedException();
        }

        private string IsOnDeliveryToString()
        {
            throw new NotImplementedException();
        }
        #endregion private methods
    }
}
