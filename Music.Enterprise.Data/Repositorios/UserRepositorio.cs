using Music.Enterprise.Data.Conexiones.Factorias;
using Music.Enterprise.Data.Models;
using Music.Enterprise.Data.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Enterprise.Data
{
    public class UserRepositorio:RepositorioBase<User>,IUserRepositorio
    {
        public UserRepositorio()
        {
           _connection = ObtenerConexionConcreta();
        }

        public override Connection ObtenerConexionConcreta()
        {
            return ConnectionFactory.getConnection(ConnectionFactory.ConnectionEnum.USERS, new HttpMethod());
        }
    }
}
