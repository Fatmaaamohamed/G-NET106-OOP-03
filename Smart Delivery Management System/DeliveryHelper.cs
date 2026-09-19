using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System
{
    internal class DeliveryHelper
    {

        #region Question06

        public static void PrintShipmentDetails(Shipment shipment)
        {
            if (shipment != null)
            {
               
                shipment.PrintShipment();
            }
        }

        #endregion
    }
}
