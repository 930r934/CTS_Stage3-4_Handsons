using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using PracticeCheckForCoreApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracticeCheckForCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AdminController : ControllerBase
    {
        // GET: api/<AdminController>

        [HttpGet("getallitems")]
        public ActionResult<IEnumerable<MenuItem>> Get()
        {
            var currentuser = HttpContext.User;
            foreach (var claim in currentuser.Claims)
            {
                Debug.WriteLine("" + claim.Type + "  " + claim.Value);
            }
            if (currentuser.HasClaim(claim => claim.Type == "UserId"))
            {
                Debug.WriteLine("claims exist");
                var userid = currentuser.Claims.FirstOrDefault(claim => claim.Type == "UserId").Value;
                if (userid == "1")
                    return MenuItemOperation.getallitems();
                else if (userid == "-1")
                    return new BadRequestObjectResult("you are neither a customer nor an admin");
                else
                    return new BadRequestObjectResult("customers dont have access to all the items");
            }
            else return new BadRequestObjectResult("the claim was not present!");

        }

        // POST api/<AdminController>
        [HttpPost("changeitem/{id}")]
        public ActionResult<string> Post(int id,[FromBody] MenuItem value)
        {
            //JObject json = JObject.Parse(value);

            Debug.WriteLine(""+value);
            var currentuser = HttpContext.User;
            if (currentuser.HasClaim(claim => claim.Type == "UserId"))
            {
                Debug.WriteLine("claims exist");
                var userid = currentuser.Claims.FirstOrDefault(claim => claim.Type == "UserId").Value;
                if (userid == "1")
                {
                    MenuItemOperation y = new MenuItemOperation();
                    y.Editwithid(id, value);
                    return "done";
                }
                else
                    return "not an admin";
            }
            else return "not authorized";
                    
           
        }
    }
}
