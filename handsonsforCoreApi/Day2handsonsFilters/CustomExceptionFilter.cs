using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace handsonsforCoreApi.Filters
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {

       
        public override void OnException(ExceptionContext context)
        {

            context.ExceptionHandled = true;


            

            context.Result = new BadRequestObjectResult("testing custom exception");


        }
    }
}
