using Music.Enterprise.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Enterprise.Pruebas
{
    public class FackDataHttpMethodcs:IConnectionMethod
    {
        public string connectTo(string uri)
        {
            DirectoryInfo path = new DirectoryInfo(Directory.GetCurrentDirectory());

            string anterior = path.Parent.Parent.FullName;
            string DIRECTORY_PATH = anterior + "\\DataFiles";
            string FileDirectory = DIRECTORY_PATH + "\\datosjson.json";
            string resultado;

            try
            {
                using (StreamReader reader = File.OpenText(@FileDirectory))
                {
                    resultado = reader.ReadToEnd();
                }
            }
            catch 
            {

                throw new Exception("Error al leer el json");
            }

            return resultado;
        }    
    }
}
