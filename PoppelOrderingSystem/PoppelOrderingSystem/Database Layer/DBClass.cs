using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using PoppelOrderingSystem.Properties;

namespace PoppelOrderingSystem.Database_Layer
{
    public class DBClass
    {
        #region Variable Declaration
        private string strConn = Settings.Default.PoppelDatabaseConnectionString;
        protected SqlConnection cnMain;
        protected DataSet dsMain;
        protected SqlDataAdapter daMain;
        #endregion

        #region CRUD Enumeration
        public enum DBOperation
        {
            Add = 0,
            Edit = 1,
            Delete = 2
        }
        #endregion

        #region Constructor

        public DBClass()
        {
            try
            {
                cnMain = new SqlConnection(strConn);
                dsMain = new DataSet();
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return;
            }
        }
        #endregion

        #region Fills dataset fresh from the DB for a specific table and with a specific Query        
        public void FillDataSet(string aSQLstring, string aTable)
        {
            try
            {
                daMain = new SqlDataAdapter(aSQLstring, cnMain);
                cnMain.Open();
                daMain.Fill(dsMain, aTable);
                cnMain.Close();
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
            }
        }
        #endregion


        #region Update the data source 

        protected bool UpdateDataSource(string sqlLocal, string table)
        { 
            bool success;
            try
            {

                cnMain.Open();   

                #region Update the database table via the data adapter
                daMain.Update(dsMain, table);

                #endregion

                cnMain.Close(); 

                #region  Fill the dataset with the SQL statement sqlLocal and the specific table table
                FillDataSet(sqlLocal, table); 
                #endregion

                success = true;
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                success = false;
            }
            finally
            {
            }
            return success;
        }
        #endregion

        public string getConncectionString() {
            return strConn;
        }

        internal static object getConnectionString()
        {
            throw new NotImplementedException();
        }
    }
}


    


