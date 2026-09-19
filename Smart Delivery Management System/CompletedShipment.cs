using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System
{
    internal sealed class CompletedShipment : Shipment
    {
        #region Question07
        public CompletedShipment(string trackingCode)
            : base(trackingCode)
        {
        }

        public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
        #endregion
    }
}
