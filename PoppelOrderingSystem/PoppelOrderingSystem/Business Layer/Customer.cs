using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelOrderingSystem.Business_Layer
{
    public class Customer: Person
    {
        #region Data Members
        private string CustomerNo;
        private string phoneNumber;
        private string CreditStatus;
        private float creditBalance;
        #endregion

        #region Properties (Getters and setters)
        public string customerNumber
        {
            get { return CustomerNo; }
            set { CustomerNo = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public double CreditBalance
        {
            get { return creditBalance; }
            set { creditBalance = (float)value; }
        }
        #endregion

        /*  #region Enumeration
          public enum CreditStatus { 
              onHold = 0,
              Released = 1,
              };
          #endregion */

        public string creditStatus {
            get { return CreditStatus; }
            set { CreditStatus = value; }
        }

        #region Constructor

        public Customer() :base()
            {
            CustomerNo = "";
            phoneNumber = "";
            }

        public Customer(string pID, string pName, string pAddress, string pEmail, string cNo,string pNo): base(pID, pName, pAddress, pEmail)
            {
            
            CustomerNo = cNo;
            phoneNumber = pNo;
            }

        #endregion
    }
}
