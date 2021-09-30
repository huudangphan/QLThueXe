using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadData();
        }
        private JArray GetRESTData(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<JArray>(s);
        }
        public void loadData()
        {
            string baseURL = "https://localhost:44302/api/Test/Test";
            try
            {
                dataGridView1.DataSource = GetRESTData(baseURL);
            }
            catch (WebException webex)
            {
                MessageBox.Show("Es gab so ein Schlamassel! ({0})", webex.Message);
            }
        }

    }
}
