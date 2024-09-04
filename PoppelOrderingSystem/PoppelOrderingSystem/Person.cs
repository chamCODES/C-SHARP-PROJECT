using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelOrderingSystem
{
    public class Person
    {
        #region Data members 
        private string ID;
        private string name;
        private string address;
        private string email;
        #endregion

        #region Properties (Getters and setters)
        public string Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        #endregion

        #region Constructor
        public Person()
        {
            ID = "";
            name = "";
            address = "";
            email = "";       
        }
        public Person(string pID, string pName, string pAddress,string pEmail)
        {
            ID = pID;
            name = pName;
            address = pAddress;
            email = pEmail;
        }
        #endregion

        #region ToStringMethod
        public override string ToString()
        {
            return name + '\n' + email;
        }

        #endregion



    }
}
