using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WindowsFormHealthDocBasic.model;

namespace WindowsFormHealthDocBasic.service
{
    class LocationService
    {
        public void getLocations()
        {
            // Create a request using a URL that can receive a post.
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/api/location/");
            string html = string.Empty;
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                html = reader.ReadToEnd();
            }

            Console.WriteLine(html);
        }
    }
}
