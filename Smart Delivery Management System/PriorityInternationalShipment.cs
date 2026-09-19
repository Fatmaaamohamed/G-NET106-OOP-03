using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System
{
    internal class PriorityInternationalShipment : InternationalShipment
    {


        #region Question08
        public PriorityInternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee)
        {
        }

        // Sealed method: overrides base implementation and prevents further overriding in derived classes
        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine($"[PRIORITY] Express Customs Clearance Report for {DestinationCountry}: Fee = {CustomsFee} EGP");
        }



        #endregion
    }
}
