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
    
    }
}
