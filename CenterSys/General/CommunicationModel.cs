using System;
using DevExpress.Xpo;

namespace CenterSys
{

    public class CommunicationModel 
    {
        public string DatabaseName { get; set; }
        public string ServerName { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Port { get; set; }
        public string dbString { get {
                if (UserName == "" && Password == "")
                    return $"Server={ServerName}{Port};Database={DatabaseName};Trusted_Connection=true;";
                else
                    return $"Server={ServerName}{Port};Database={DatabaseName};User Id = {UserName}; Password = {Password};";
            } }

        public CommunicationModel() 
        {
            ServerName = "localhost";
            DatabaseName = "CenterLabDB";
            UserName = "";
            Password = "";
            Port = "";

        }



     
    }

}