using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using WindowsFormHealthDocBasic.model;

namespace WindowsFormHealthDocBasic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //client.DefaultRequestHeaders.Add("Authorization", "Basic TUNTRTpNQ1MhZTIwMTc=");
            //client.DefaultRequestHeaders.Add("ClientURL", "http://123.com");
            var response = client.GetAsync("api/location/").Result;
            Location[] obj = await response.Content.ReadAsAsync<Location[]>();
        }
    }
}
