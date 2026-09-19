using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System
{
    internal class InternationalShipment : Shipment
    {
        string destinationCountry;


        Decimal customsFee;


        public string DestinationCountry
        {
            get => destinationCountry;


            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
            }

        }


        public decimal CustomsFee
        {
            get => customsFee;


            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
            }

        }


      

        #region Question02
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) :
            base(trackingCode, description, weight, deliveryFee, destination)
        {

            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;

        }
        #endregion 




    }
}
