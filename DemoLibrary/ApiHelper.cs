using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ApiHelper
    {
        public static HttpClient ApiClient { get; set; } = new HttpClient();
    }
}
