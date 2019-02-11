using Music.Enterprise.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Enterprise.Servicios
{
    public interface IUserService
    {
        IEnumerable<User> ObtenerTodos();
        IEnumerable<User> BuscarPorID(int id);

    }
}
