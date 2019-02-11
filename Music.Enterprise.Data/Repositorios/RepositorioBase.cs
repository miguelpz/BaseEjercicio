using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Music.Enterprise.Data.Repositorios
{
    public abstract class RepositorioBase<Entidad> : IRepositorioBase<Entidad> where Entidad : class
    {
        protected Connection _connection;

        public IConnection Connection { get { return _connection; } }

        public RepositorioBase()
        {
            _connection = ObtenerConexionConcreta();
        }

        public abstract Connection ObtenerConexionConcreta();
        
        public IEnumerable<Entidad> ObtenerTodas()
        {
            try
            {
                return JsonConvert.DeserializeObject<IEnumerable<Entidad>>(_connection.gedData());

            }
            catch

            {
                throw new Exception("Error en la desserializacion de datos");
            }
        }

        public IEnumerable<Entidad> Buscar(Func<Entidad, bool> predicado)
        {
            var entidades = JsonConvert.DeserializeObject<IEnumerable<Entidad>>(_connection.gedData());

            return entidades.ToList().Where(predicado);
        }       
    }
}
