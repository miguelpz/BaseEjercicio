using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Music.Enterprise.Data
{
    public  interface IRepositorioBase<Entidad>
    {
        IConnection Connection { get; }
        IEnumerable<Entidad> ObtenerTodas();
        IEnumerable<Entidad> Buscar(Func<Entidad, bool> predicado);
    }
}
