using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy
{
   public class Global
    {
        public  static List<T> LoadData<T>(T model, string url)
        {

            using (WebClient wc = new WebClient())
            {
                try
                {

                    var json =  wc.DownloadString(url);

                    var data = JsonConvert.DeserializeObject<List<T>>(json);

                    return  data;

                }
                catch (Exception ex)
                {
                    return null;
                  
                }
            }
        }
        public static double FormatCurrency(string input)
        {
            string b = "";
            for (int i = 0; i < input.Length - 6; i++)
            {
                if (input[i] != ',')
                    b += input[i];

            }
            return double.Parse(b);
        }
    }
}
