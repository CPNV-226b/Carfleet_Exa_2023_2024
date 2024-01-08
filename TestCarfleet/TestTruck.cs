using NUnit.Framework;

namespace Carfleet
{
    public class TestTruck
    {
        #region private attributes
        private string _registration = "VD 123 567";
        private string _brand = "Volvo";
        private string _model = "FH16";
        private string _chassisNumber = "VOL45-0157966";
        private bool _isCarryingGoods = false;
        private bool _isOnDelivery = false;
        Truck _truck;
        #endregion private attributes


        [SetUp]
        public void Setup()
        {
            _truck = new Truck(_registration, _brand, _model, _chassisNumber);
        }

        [Test]
        public void AllProperties_AfterInstantiation_GetCorrectValues()
        {
            //given

            //when
            
            //then
            Assert.AreEqual(_registration, _truck.Registration);
            Assert.AreEqual(_brand, _truck.Brand);
            Assert.AreEqual(_model, _truck.Model);
            Assert.AreEqual(_chassisNumber, _truck.ChassisNumber);
            Assert.AreEqual(_isCarryingGoods, _truck.IsCarryingGoods);
            Assert.AreEqual(_isOnDelivery, _truck.IsOnDelivery);
        }

        [Test]
        public void ToString_AllPropertiesDefaultValue_GetFullString()
        {
            //given
            string expectedString = "VD 123 567 - Volvo - FH16 - VOL45-0157966 - No goods - Not on delivery";

            //when

            //then
            Assert.AreEqual(expectedString, _truck.ToString());
        }

        [Test]
        public void ToString_CustomValuesForGoodsAndDelivery_GetFullString()
        {
            //given
            _truck.IsCarryingGoods = true;
            _truck.IsOnDelivery = true;
            string expectedString = "VD 123 567 - Volvo - FH16 - VOL45-0157966 - Goods detected - Currently on delivery";

            //when

            //then
            Assert.AreEqual(expectedString, _truck.ToString());
        }

        [Test]
        public void ToString_CustomValuesForGoods_GetFullString()
        {
            //given
            _truck.IsCarryingGoods = true;
            string expectedString = "VD 123 567 - Volvo - FH16 - VOL45-0157966 - Goods detected - Not on delivery";

            //when

            //then
            Assert.AreEqual(expectedString, _truck.ToString());
        }

        [Test]
        public void ToString_CustomValuesForDevilery_GetFullString()
        {
            //given
            _truck.IsOnDelivery = true;
            string expectedString = "VD 123 567 - Volvo - FH16 - VOL45-0157966 - No goods - Currently on delivery";

            //when

            //then
            Assert.AreEqual(expectedString, _truck.ToString());
        }

        [Test]
        public void IsCarryingGoods_DefaultValue_GetDefaultValue()
        {
            //given

            //when

            //then
            Assert.IsFalse(_truck.IsCarryingGoods);
        }

        [Test]
        public void IsCarryingGoods_SetToTrue_GetTrue()
        {
            //given

            //when
            _truck.IsCarryingGoods = true;

            //then
            Assert.IsTrue(_truck.IsCarryingGoods);
        }
    }
}