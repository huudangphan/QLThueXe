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
        public static string tenkh { get; set; }
        public static DateTime ngay_thue { get; set; }
        public static string bien_so { get; set; }
        public static string ten_xe { get; set; }
        public static double gia_thue { get; set; }
        public static string cmnd { get; set; }
        public static string dia_chi { get; set; }
        public static string sdt { get; set; }
        public static DateTime ngay_sinh { get; set; }
        public static int id_hop_dong { get; set; }
    }
}
