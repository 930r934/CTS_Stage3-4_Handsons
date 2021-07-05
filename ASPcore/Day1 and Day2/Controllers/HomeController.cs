using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using ASPcoreHANDSON.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ASPcoreHANDSON.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Employeedeets> listofe = new List<Employeedeets>();
            var jObject = ReadJSONData("JsonData/Employee-detailsjson.json");
            for (int i = 0; i < jObject["employeedeets"].Count(); i++)
            {
                listofe.Add(new Employeedeets()
                {
                    Id = (int)jObject["employeedeets"][i]["id"],
                    Name = (string)jObject["employeedeets"][i]["name"],
                    Salary = (int)jObject["employeedeets"][i]["salary"],
                    Permanent = (bool)jObject["employeedeets"][i]["permanent"]
                });
            }
            
            return View(listofe);
        }

        public IActionResult Privacy()
        {
            
            return View();
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JObject ReadJSONData(string jsonFilename)
        {
            try
            {
                JObject jObject;
                // Read JSON directly from a file    
                using (StreamReader file = System.IO.File.OpenText(jsonFilename))
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    jObject = (JObject)JToken.ReadFrom(reader);
                }
                return jObject;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occurred : " + ex.Message);
                return null;
            }
        }

    }
}
