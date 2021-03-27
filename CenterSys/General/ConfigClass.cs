
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterSys
{
  public static class ConfigClass
    {
        //Database connections
      
       
        public static CommunicationModel communication = new CommunicationModel();
        /// <summary>
        /// Initialize the requsted Connection 
        /// </summary>
        /// <param name="db"> Database type</param>
        public static void InitializeConnection()
        {
            //Create database conneciton  
          
            //  log.Info("Set connection to SQL-Server.");
       

        }
   
        public static string Get_ConnectionString()
        {
            RegistryControl RegControl = new RegistryControl();
            communication = RegControl.get_setting();
            return communication.dbString;
        }

      
        /// <summary>
        /// Check if the SQL server is reachable
        /// </summary>
        /// <param name="server"></param>
        /// <param name="User"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public static bool IsServerConnected()
        {

        
            using (SqlConnection connection = new SqlConnection(communication.dbString))
            {
                try
                {
                    connection.Open();

            
                    return true;
                }
                catch (SqlException ex)
                {
                    //ConfigClass.log.Error("Error on Connection settings: " + ex.Message);
                    return false;
                }
            }
        }



    }
}
