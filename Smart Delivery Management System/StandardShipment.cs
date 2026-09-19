using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System
{
    internal class StandardShipment : Shipment
    {
        #region Question02
        public StandardShipment(string trackingCode)
            : base(trackingCode)
        {
        }

        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) :
            base(trackingCode, description, weight, deliveryFee, destination)
        {


        }


        

        #endregion
    


    }
}
