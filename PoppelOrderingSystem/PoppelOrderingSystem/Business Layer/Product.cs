using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelOrderingSystem.Business_Layer
{
    public class Product
    {
        #region Data Members
        private int ProductID;
        private string category;
        private string name;
        private string productDescription;
        #endregion

        #region Properties (Getters and setters)
        public void getProductID()
        {
            Random rd = new Random();
            ProductID = rd.Next(100000,999999);
        }
        #endregion

        #region Enumeration

        #endregion

        #region Constructor
        public Product(string cgr, string Name, string description)
            { 
            ProductID = getProductID();
           category = cgr;
            name = Name;
            productDescription = description;
            }
        
        #endregion
    }
}

