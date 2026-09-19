using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System
{
    internal class ExpressShipment : Shipment
    {
        

        decimal extraFee;


        public decimal ExtraFee
        {
            get => extraFee;

            set
            {
                if (value >= 0)
                {
                    extraFee = value;
                }
            }
        }


        #region Question02
        public override decimal EstimatedCost
        {
            get => base.EstimatedCost + ExtraFee;
        }

        #endregion

        #region Question02



        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee) :
            base(trackingCode, description, weight, deliveryFee, destination)
        {

            ExtraFee = extraFee;

        }




        #endregion

        #region Question04

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment\n");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }



        #endregion

    }
}
