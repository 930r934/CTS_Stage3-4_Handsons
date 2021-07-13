using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PracticeCheckForCoreApi.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracticeCheckForCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomerController : ControllerBase
    {

        static List<MenuItem> cart = new List<MenuItem>();
        // GET api/<CustomerController>/5
        [HttpGet]
        public ActionResult<List<MenuItem>> GetItemsFromCart()
        {
            if (iscustomer())
                return cart;
            else
                return new BadRequestObjectResult("access denied");
        }

        // POST api/<CustomerController>
        [HttpPost("additemtocart/{nameofitem}")]
        public ActionResult<MenuItem> Post(string nameofitem)
        {
            if (iscustomer())
            {
                List<MenuItem> allitems = MenuItemOperation.getallitems();
                MenuItem item = allitems.FirstOrDefault(item => item.Name == nameofitem);
                cart.Add(item);
                return item;
            }
            else
                return new BadRequestObjectResult("access denied");
        }


        // DELETE api/<CustomerController>/5
        [HttpDelete("deletefromcart/{name}")]
        public ActionResult<MenuItem> DeleteFromCart(string name)
        {
            if (iscustomer())
            {
                List<MenuItem> allitems = MenuItemOperation.getallitems();
                var item = allitems.FirstOrDefault(item => item.Name == name);
                cart.Remove(item);
                return item;
            }
            else
                return new BadRequestObjectResult("access denied");
        }

        Boolean iscustomer()
        {
            var currentuser = HttpContext.User;
            if (currentuser.HasClaim(claim => claim.Type == "UserId"))
            {
                var userid = currentuser.Claims.FirstOrDefault(claim => claim.Type == "UserId").Value;
                if ((userid != "1") && (userid != "-1"))
                    return true;
                else
                    return false;
            }
            else return false;
        }
    }
}
