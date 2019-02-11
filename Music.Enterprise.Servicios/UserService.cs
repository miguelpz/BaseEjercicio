using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music.Enterprise.Data.Models;
using Music.Enterprise.Data.Repositorios;

namespace Music.Enterprise.Servicios
{
    public class UserService:IUserService
    {
        private IUserRepositorio _userRepositorio;

        public UserService(IUserRepositorio userRepositorio)
        {
            _userRepositorio = userRepositorio;
        }
      
        public IEnumerable<User> ObtenerTodos()
        {
            return _userRepositorio.ObtenerTodas();
        }

        public IEnumerable<User> BuscarPorID(int id)
        {
            return _userRepositorio.Buscar(u => u.id.Equals(id));
        }       
    }
}
