using PoppelOrderingSystem.Database_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelOrderingSystem.Business_Layer
{
    public class CustomerController
    {
        #region Data Members
        private CustomerDB customerDB;
        private Collection<Customer> customers;
        private Customer cust;
        private bool found;
        #endregion

        #region Properties
        public Collection<Customer> AllCustomers
        {
            get
            {
                return customers;
            }
        }

        public bool Found { 

            get => found; 
            set => found = value; 
        }
        #endregion

        #region Constructor
        public CustomerController()
        {
            customerDB = new CustomerDB();
            customers = customerDB.AllCustomers;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(Customer aCustomer, DBClass.DBOperation operation)
        {
            int index = 0;
            customerDB.DataSetChange(aCustomer, operation);
            switch (operation)
            {
                case DBClass.DBOperation.Add:
                    customers.Add(aCustomer);
                    break;
                case DBClass.DBOperation.Edit:
                    index = FindIndex(aCustomer);
                    customers[index] = aCustomer;  // replace Customer at this index with the updated Customer
                    break;
                case DBClass.DBOperation.Delete:
                    customers.Remove(aCustomer);
                    break;
            }
        }

        public bool FinalizeChanges(Customer customer)
        {
            return customerDB.UpdateDataSource(customer);

        }
        #endregion

        #region Search Methods
        public Customer Find(string ID)
        {
            int index = 0;
            Found = (customers[index].Id == ID);  //check if it is the first record
            int count = customers.Count;
            while (!(Found) && (index < customers.Count - 1))  //if not "this" record and you are not at the end of the list 
            {
                index = index + 1;
                Found = (customers[index].Id == ID);   // this will be True if found
            }
            return customers[index];  //customer found
        }

        public int FindIndex(Customer aCustomer)
        {
            int counter = 0;
            found = false;
            found = (aCustomer.Id == customers[counter].Id);   //using a Boolean Expression to initialise found
            while (!(found) & counter < customers.Count - 1)
            {
                counter += 1;
                found = (aCustomer.Id == customers[counter].Id);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }
        #endregion


    }
}

