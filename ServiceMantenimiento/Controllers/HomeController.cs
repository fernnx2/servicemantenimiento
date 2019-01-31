using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ServiceMantenimiento.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace ServiceMantenimiento.Controllers
{
    public class HomeController : Controller
    {

        String baseUrl = "http://servicemantenimiento-dev.us-west-2.elasticbeanstalk.com/";
       // String baseUrl = "http://localhost:50720/";
        public async  Task<ActionResult> Index()
        {
            List<Marca> marcas = new List<Marca>();
            
            ViewBag.Title = "Home Page";
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage r = await  client.GetAsync("api/marca");
                if (r.IsSuccessStatusCode)
                {
                    var response = r.Content.ReadAsStringAsync().Result;
                    marcas = JsonConvert.DeserializeObject<List<Marca>>(response);
                }
            }
            return View(marcas);
        }
    }
}
