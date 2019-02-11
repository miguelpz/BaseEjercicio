using Music.Enterprise.Data.Conexiones.Factorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Enterprise.Data.Conexiones.Factorias
{
    public static class ConnectionFactory
    {
        const string POSTS_URI = "http://jsonplaceholder.typicode.com/posts";
        const string USERS_URI = "http://jsonplaceholder.typicode.com/users";

        public enum ConnectionEnum
        {
            POSTS,USERS
        }

        public static Connection getConnection(ConnectionEnum connectionEnum, IConnectionMethod connectionMethod)
        {
            Connection _connection = new Connection();
            _connection.setConnectionMethod(connectionMethod);

            switch (connectionEnum.ToString())
            {
                case "POSTS":
                    _connection.URI = POSTS_URI;
                    break;

                case "USERS":
                    _connection.URI = USERS_URI;
                    break;
                    
                default:
                    break;
            }

            return _connection;

        }

       
        
    }
}
