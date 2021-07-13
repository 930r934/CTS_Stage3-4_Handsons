using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticeCheckForCoreApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracticeCheckForCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnonymousUserController : ControllerBase
    {
        DbContext db;
        // GET: api/<CustomerController>
        [HttpGet("getallmenuitems")]
        public IEnumerable<MenuItem> Get()
        {
            return MenuItemOperation.getallitems();
        }


    }
}
