using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelOrderingSystem.Business_Layer
{
    public class Order
    {
        #region Data Members
        private string OrderID;
        public string CustomerNo;
        public string StaffNumber;
        public string dateOdered;
        public string dateShipped;
        public string deliveryAddress;
        private double totalPrice;
        #endregion

        #region Properties (Getters and setters)
        public void setTotalPrice(double total)
            {
            totalPrice = total;
            }
        public double getTotalPrice()
            { 
            return totalPrice;
            }
        #region Constructor

        public Order(string oID,Staff staff,Customer customer, string dateO, string dateS, string deliveryAdd, double tPrice)
            {
            OrderID = oID;
            CustomerNo = customer.CustomerNo;
            StaffNumber = staff.StaffNumber;
            string dateOdered = dateO;
            dateShipped = dateS;
            deliveryAddress = deliveryAdd;
            totalPrice = tPrice;
            }

        #endregion
    }
}
