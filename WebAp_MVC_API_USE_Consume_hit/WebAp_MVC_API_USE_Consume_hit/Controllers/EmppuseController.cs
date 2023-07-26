using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebAp_MVC_API_USE_Consume_hit.Models;

namespace WebAp_MVC_API_USE_Consume_hit.Controllers
{
    public class EmppuseController : Controller
    {
      
        // show -get ke liye
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost] // submit
        public ActionResult Create(tblEmployee _emp)
        {
            HttpClient _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:44388/api/Employee/empinsert");
            string data = JsonConvert.SerializeObject(_emp);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            _client.PostAsync(_client.BaseAddress, content);
            return View(); ;
        }

        //page load method
        public ActionResult Show()
        {
            HttpClient _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:44388/api/Employee/empget");
            List<tblEmployee> lstemp = new List<tblEmployee>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress).Result;
            var abc = response.Content.ReadAsStringAsync().Result;
            var jabc = JsonConvert.DeserializeObject(abc).ToString();
            lstemp = JsonConvert.DeserializeObject<List<tblEmployee>>(jabc);
            return View(lstemp);
        }



    }
}