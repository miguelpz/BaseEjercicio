using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Music.Enterprise.Data
{
    public class HttpMethod:IConnectionMethod
    {
        public string connectTo(string uri)
        {
            string json;

            HttpWebRequest RateRequest = (HttpWebRequest)WebRequest.Create(@uri);
            
                using (HttpWebResponse response = (HttpWebResponse)RateRequest.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    json = reader.ReadToEnd();
                }

                return json;
            
        }
    }
}
