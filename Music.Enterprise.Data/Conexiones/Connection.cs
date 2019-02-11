using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Enterprise.Data
{
    public class Connection:IConnection
    {
        protected string cache;  // Por si la conexión falla
        static string dataTemp;
        private IConnectionMethod _connectionMethod;


        #region CONFIGURACION DE CONEXION     

        public void setConnectionMethod(IConnectionMethod connectionMethod)
        {
            _connectionMethod = connectionMethod;
        }

        public string URI { get; set; }

        #endregion


        public string gedData()
        {
            try
            {
                dataTemp = _connectionMethod.connectTo(URI);
                cache = dataTemp; //Guardamos datos en cache en la primera conexión por si falla api en un futuro.
            }
            catch 
            {
                if (cache == null)
                {
                    throw new Exception("No se ha podido conectar a la api, tampoco existen datos cacheados");
                }

                dataTemp = cache; //Si falla intentamos recuperar de la cache.              
            }

            return dataTemp;
        }

    }
}
