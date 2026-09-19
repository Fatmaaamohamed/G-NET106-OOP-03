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

        #region Question03

        public override decimal EstimatedCost
        {
            get => base.EstimatedCost + CustomsFee;

        }

        #endregion


        #region Question02
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) :
            base(trackingCode, description, weight, deliveryFee, destination)
        {

            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;

        }
        #endregion

        #region Question04
        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment\n");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Customs Fee         : {CustomsFee} EGP");
            Console.WriteLine($"Estimated Cost      : {EstimatedCost} EGP");
        }

        #endregion
    }
}
