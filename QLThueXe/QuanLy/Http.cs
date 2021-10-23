using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy
{
    public class Http
    {
        public static string POST(string urlbase)
        {
            try
            {
                var result = "";
                string strUrl = String.Format(urlbase);
                WebRequest request = WebRequest.Create(strUrl);
                request.Method = "POST";
                request.ContentType = "application/json";
                
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    var response = request.GetResponse();
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                         result = streamReader.ReadToEnd();
                        var data = JsonConvert.DeserializeObject<List<dynamic>>(result);
                       
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public static string PUT(string urlbase)
        {
            try
            {
                var result = "";
                string strUrl = String.Format(urlbase);
                WebRequest request = WebRequest.Create(strUrl);
                request.Method = "PUT";
                request.ContentType = "application/json";                
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    var response = request.GetResponse();
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                         result = streamReader.ReadToEnd();
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public static string DELETE(string urlbase)
        {
            try
            {
                var result = "";
                string strUrl = String.Format(urlbase);
                WebRequest request = WebRequest.Create(strUrl);
                request.Method = "DELETE";
                request.ContentType = "application/json";
               
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    var response = request.GetResponse();
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                         result = streamReader.ReadToEnd();
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }


        public static string GET(string urlbase, string token)
        {
            
            
            string jsonString = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlbase);
            request.Method = "GET";
            request.Headers.Add("Authorization", "Bearer " + token);
            request.Credentials = CredentialCache.DefaultCredentials;
            ((HttpWebRequest)request).UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 7.1; Trident/5.0)";
            request.Accept = "/";
            request.UseDefaultCredentials = true;
            request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            request.ContentType = "application/x-www-form-urlencoded";

            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            jsonString = sr.ReadToEnd();
            sr.Close();
            return jsonString;
        }

    }
}
