using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace handsonsforCoreApi.Filters
{
    public class CustomAuthFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            var x = filterContext.HttpContext.Request.Headers.ContainsKey("cookie");
            var y = new Microsoft.Extensions.Primitives.StringValues();
            String j;
            var i = filterContext.HttpContext.Request.Headers.TryGetValue("cookie", out y);
            Debug.WriteLine($"values are {x} \n {y}");
            if(!x)
            {
                 filterContext.Result = new BadRequestObjectResult("Invalid request - No Auth token");
            }
        }
    }
}
