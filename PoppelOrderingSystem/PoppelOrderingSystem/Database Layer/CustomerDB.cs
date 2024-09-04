using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoppelOrderingSystem.Business_Layer;

namespace PoppelOrderingSystem.Database_Layer
{
    public class CustomerDB : DBClass
    {
        #region  Data members 
        private string table1 = "Customer";
        private string sqlLocal1 = "SELECT * FROM Customer";
        
        private Collection<Customer> customers;
        #endregion

        #region Property Method: Collection
        public Collection<Customer> AllCustomers
        {
            get
            {
                return customers;
            }
        }
        #endregion

        #region Constructor
        public CustomerDB() : base()
        {
            customers = new Collection<Customer>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
        }
        #endregion

        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }
        private void Add2Collection(string table)
        {
            DataRow myRow = null;
            Customer aCustomer;

            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Customer object
                    aCustomer = new Customer();

                    //Obtain each employee attribute from the specific field in the row in the table
                    aCustomer.customerNumber = Convert.ToString(myRow["CustomerNo"]).TrimEnd();
                    aCustomer.Id = Convert.ToString(myRow["ID"]).TrimEnd();
                    aCustomer.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                    aCustomer.Email = Convert.ToString(myRow["email"]).TrimEnd();
                    aCustomer.PhoneNumber = Convert.ToString(myRow["phoneNumber"]).TrimEnd();
                    aCustomer.Address = Convert.ToString(myRow["Address"]).TrimEnd();
                    aCustomer.creditStatus = Convert.ToString(myRow["creditStatus"]).TrimEnd();
                   // aCustomer.CreditBalance = myRow["creditBalance"];

                    customers.Add(aCustomer);
                }
            }
        }
        private void FillRow(DataRow aRow, Customer aCustomer, DBClass.DBOperation operation)
        {

            if (operation == DBClass.DBOperation.Add)
            {
                aRow["CustomerNo"] = aCustomer.customerNumber;
                aRow["ID"] = aCustomer.Id;

                aRow["Name"] = aCustomer.Name;
                aRow["email"] = aCustomer.Email;
                aRow["phoneNumber"] = aCustomer.PhoneNumber;
                aRow["Address"] = aCustomer.Address;
                aRow["creditStatus"] = aCustomer.creditStatus;
                aRow["creditBalance"] = aCustomer.CreditBalance;
            }

        }
        private int FindRow(Customer aCustomer, string tblCustomer)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[tblCustomer].Rows)
            {
                myRow = myRow_loopVariable;
                //Ignore rows marked as deleted in dataset

                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    if (aCustomer.customerNumber == Convert.ToString(dsMain.Tables[tblCustomer].Rows[rowIndex]["CustomerNo"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Customer aCustomer, DBClass.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;
          
            switch (operation)
            {
                case DBClass.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, aCustomer, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;

                case DBClass.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aCustomer, dataTable)];
                    FillRow(aRow, aCustomer, operation);
                    break;

                case DBClass.DBOperation.Delete:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aCustomer, dataTable)];
                    aRow.Delete();

                    break;
            }
        }
        #endregion

       
        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Customer aCustomer)
        {
            //Create Parameters to communicate with SQL INSERT
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@CustomerNo", SqlDbType.NVarChar, 10, "CustomerNo");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@ID", SqlDbType.NVarChar, 13, "ID");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@email", SqlDbType.NVarChar, 50, "email");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@phoneNumber", SqlDbType.NVarChar, 10, "phoneNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 50, "Address");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@creditStatus", SqlDbType.NVarChar, 50, "creditStatus");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@creditBalance", SqlDbType.NVarChar, 50, "creditBalance");
            daMain.InsertCommand.Parameters.Add(param);
        }
            //***https://msdn.microsoft.com/en-za/library/ms179882.aspx
        
        private void Build_UPDATE_Parameters(Customer aCustomer)
        {
            //Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            //testing the Customer Number of record that needs to change with the original Customer Number of the record
            param = new SqlParameter("@Original_CustomerNo", SqlDbType.NVarChar, 10, "CustomerNo");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
            //testing the Customer Number of record that needs to change with the original Customer Number of the record
            param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 10, "ID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@email", SqlDbType.NVarChar, 50, "email");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@phoneNumber", SqlDbType.NVarChar, 15, "phoneNumber");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 50, "Address");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@creditStatus", SqlDbType.NVarChar, 50, "creditStatus");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@creditBalance", SqlDbType.NVarChar, 50, "creditBalance");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);


        }
        private void Create_INSERT_Command(Customer aCustomer)
        {
            //Create the command that must be used to insert values into the table
            daMain.InsertCommand = new SqlCommand("INSERT into Customer (CustomerNo, ID, Name, email, phoneNumber, Address, creditStatus, creditBalance) VALUES (@CustomerNo, @ID, @Name, @email, @phoneNumber, @Address, @creditStatus, @creditBalance)", cnMain);
                  
            Build_INSERT_Parameters(aCustomer);
        }
        private void Create_UPDATE_Command(Customer aCustomer)
        {
            //Assumption is that the ID and CustomerNo cannot be changed
            daMain.UpdateCommand = new SqlCommand("UPDATE Customer SET Name =@Name, phoneNumber =@phoneNumber, email =@email, Address =@Address, creditStatus =@creditStatus, creditBalance " + "WHERE CustomerNo = @Original_CustomerNo", cnMain); 
            Build_UPDATE_Parameters(aCustomer);
        }
        public bool UpdateDataSource(Customer aCustomer)
        {
            bool success = true;
            Create_INSERT_Command(aCustomer);
            Create_UPDATE_Command(aCustomer);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }

        #endregion

    }
}


